Imports System.Data.SqlClient
Imports System.Configuration

Public Class DispenseToPatientsForm
    Inherits System.Windows.Forms.Form

    ' Declare controls (assume these are added in the Form Designer)
    ' Private PatientComboBox As ComboBox
    ' Private BatchComboBox As ComboBox
    ' Private QuantityTextBox As TextBox
    ' Private PriceTextBox As TextBox
    ' Private SubmitButton As Button
    'Private StatusLabel As Label

    Private Sub DispenseToPatientsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatients()
        LoadBatches()
    End Sub

    ' Load patients into ComboBox
    Private Sub LoadPatients()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT PatientID, Name FROM Patients"
                Using command As New SqlCommand(query, connection)
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        PatientComboBox.Items.Add(New With {.PatientID = reader("PatientID"), .Name = reader("Name").ToString()})
                    End While
                End Using
                PatientComboBox.DisplayMember = "Name"
                PatientComboBox.ValueMember = "PatientID"
            Catch ex As Exception
                MessageBox.Show("Error loading patients: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Load batches with DispensingQuantity > 0 into ComboBox
    Private Sub LoadBatches()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT b.BatchID, d.DrugCode + ' - ' + b.BatchNo AS DisplayText " &
                                     "FROM Batches b JOIN Drugs d ON b.DrugID = d.DrugID WHERE b.DispensingQuantity > 0"
                Using command As New SqlCommand(query, connection)
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        BatchComboBox.Items.Add(New With {.BatchID = reader("BatchID"), .DisplayText = reader("DisplayText").ToString()})
                    End While
                End Using
                BatchComboBox.DisplayMember = "DisplayText"
                BatchComboBox.ValueMember = "BatchID"
            Catch ex As Exception
                MessageBox.Show("Error loading batches: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Handle dispensation submission
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If PatientComboBox.SelectedItem Is Nothing OrElse BatchComboBox.SelectedItem Is Nothing OrElse
           String.IsNullOrEmpty(QuantityTextBox.Text) OrElse String.IsNullOrEmpty(PriceTextBox.Text) Then
            StatusLabel.Text = "Please fill all fields."
            Return
        End If

        Dim patientID As Integer = DirectCast(PatientComboBox.SelectedItem, Object).PatientID
        Dim batchID As Integer = DirectCast(BatchComboBox.SelectedItem, Object).BatchID
        Dim quantity As Integer
        Dim price As Decimal

        If Not Integer.TryParse(QuantityTextBox.Text, quantity) OrElse quantity <= 0 Then
            StatusLabel.Text = "Invalid quantity."
            Return
        End If

        If Not Decimal.TryParse(PriceTextBox.Text, price) OrElse price <= 0 Then
            StatusLabel.Text = "Invalid price."
            Return
        End If

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                ' Check available quantity
                Dim checkQuery As String = "SELECT DispensingQuantity FROM Batches WHERE BatchID = @BatchID"
                Dim availableQuantity As Integer
                Using checkCommand As New SqlCommand(checkQuery, connection)
                    checkCommand.Parameters.AddWithValue("@BatchID", batchID)
                    availableQuantity = Convert.ToInt32(checkCommand.ExecuteScalar())
                End Using

                If quantity > availableQuantity Then
                    StatusLabel.Text = "Quantity exceeds available stock."
                    Return
                End If

                ' Begin transaction
                Using transaction As SqlTransaction = connection.BeginTransaction()
                    Try
                        ' Insert into Sales table
                        Dim saleQuery As String = "INSERT INTO Sales (PatientID, BatchID, Quantity, Price, SaleDate) " &
                                                  "VALUES (@PatientID, @BatchID, @Quantity, @Price, @SaleDate)"
                        Using saleCommand As New SqlCommand(saleQuery, connection, transaction)
                            saleCommand.Parameters.AddWithValue("@PatientID", patientID)
                            saleCommand.Parameters.AddWithValue("@BatchID", batchID)
                            saleCommand.Parameters.AddWithValue("@Quantity", quantity)
                            saleCommand.Parameters.AddWithValue("@Price", price)
                            saleCommand.Parameters.AddWithValue("@SaleDate", DateTime.Now)
                            saleCommand.ExecuteNonQuery()
                        End Using

                        ' Update DispensingQuantity in Batches table
                        Dim updateQuery As String = "UPDATE Batches SET DispensingQuantity = DispensingQuantity - @Quantity " &
                                                    "WHERE BatchID = @BatchID"
                        Using updateCommand As New SqlCommand(updateQuery, connection, transaction)
                            updateCommand.Parameters.AddWithValue("@Quantity", quantity)
                            updateCommand.Parameters.AddWithValue("@BatchID", batchID)
                            updateCommand.ExecuteNonQuery()
                        End Using

                        transaction.Commit()
                        StatusLabel.Text = "Drug dispensed successfully."
                        QuantityTextBox.Text = ""
                        PriceTextBox.Text = ""
                        LoadBatches() ' Refresh batches to reflect updated quantities
                    Catch ex As Exception
                        transaction.Rollback()
                        StatusLabel.Text = "Error dispensing drug: " & ex.Message
                    End Try
                End Using
            Catch ex As Exception
                StatusLabel.Text = "Error connecting to database: " & ex.Message
            End Try
        End Using
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles PriceTextBox.TextChanged

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim MainMenuForm As New MainMenuForm()
        MainMenuForm.Show()
        Me.Hide()
    End Sub
End Class