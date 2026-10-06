Imports System.Data.SqlClient
Imports System.Configuration

Public Class ReceiveDrugsInStoreForm
    Private Sub ReceiveDrugsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT DrugID, DrugCode FROM Drugs"
                Using command As New SqlCommand(query, connection)
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        DrugComboBox.Items.Add(New With {.DrugID = reader("DrugID"), .DrugCode = reader("DrugCode").ToString()})
                    End While
                End Using
                DrugComboBox.DisplayMember = "DrugCode"
                DrugComboBox.ValueMember = "DrugID"
            Catch ex As Exception
                StatusLabel.Text = "Error loading drugs: " & ex.Message
            End Try
        End Using
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If DrugComboBox.SelectedItem Is Nothing OrElse String.IsNullOrEmpty(BatchNoTextBox.Text) OrElse String.IsNullOrEmpty(QuantityTextBox.Text) Then
            StatusLabel.Text = "Please fill all fields."
            Return
        End If

        Dim drugID As Integer = DirectCast(DrugComboBox.SelectedItem, Object).DrugID
        Dim batchNo As String = BatchNoTextBox.Text
        Dim expiryDate As Date = ExpiryDatePicker.Value
        Dim quantity As Integer
        If Not Integer.TryParse(QuantityTextBox.Text, quantity) OrElse quantity <= 0 Then
            StatusLabel.Text = "Invalid quantity."
            Return
        End If

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim batchQuery As String = "INSERT INTO Batches (DrugID, BatchNo, ExpiryDate, StoreQuantity, DispensingQuantity) OUTPUT INSERTED.BatchID VALUES (@DrugID, @BatchNo, @ExpiryDate, @Quantity, 0)"
                Using batchCommand As New SqlCommand(batchQuery, connection)
                    batchCommand.Parameters.AddWithValue("@DrugID", drugID)
                    batchCommand.Parameters.AddWithValue("@BatchNo", batchNo)
                    batchCommand.Parameters.AddWithValue("@ExpiryDate", expiryDate)
                    batchCommand.Parameters.AddWithValue("@Quantity", quantity)
                    Dim batchID As Integer = Convert.ToInt32(batchCommand.ExecuteScalar())

                    Dim receiptQuery As String = "INSERT INTO Receipts (BatchID, Quantity, ReceiptDate) VALUES (@BatchID, @Quantity, @ReceiptDate)"
                    Using receiptCommand As New SqlCommand(receiptQuery, connection)
                        receiptCommand.Parameters.AddWithValue("@BatchID", batchID)
                        receiptCommand.Parameters.AddWithValue("@Quantity", quantity)
                        receiptCommand.Parameters.AddWithValue("@ReceiptDate", DateTime.Now)
                        receiptCommand.ExecuteNonQuery()
                    End Using
                End Using
                StatusLabel.Text = "Drug received successfully."
                BatchNoTextBox.Text = ""
                QuantityTextBox.Text = ""
            Catch ex As Exception
                StatusLabel.Text = "Error: " & ex.Message
            End Try
        End Using
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim MainMenuForm As New MainMenuForm()
        MainMenuForm.Show()
        Me.Close()
    End Sub
End Class