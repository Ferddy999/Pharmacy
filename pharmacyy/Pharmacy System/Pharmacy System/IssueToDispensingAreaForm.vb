Imports System.Configuration
Imports System.Data.SqlClient

Public Class IssueToDispensingAreaForm
    Private Sub IssueToDispensingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT b.BatchID, d.DrugCode + ' - ' + b.BatchNo AS DisplayText FROM Batches b JOIN Drugs d ON b.DrugID = d.DrugID WHERE b.StoreQuantity > 0"
                Using command As New SqlCommand(query, connection)
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        BatchComboBox.Items.Add(New With {.BatchID = reader("BatchID"), .DisplayText = reader("DisplayText").ToString()})
                    End While
                End Using
                BatchComboBox.DisplayMember = "DisplayText"
                BatchComboBox.ValueMember = "BatchID"
            Catch ex As Exception
                StatusLabel.Text = "Error loading batches: " & ex.Message
            End Try
        End Using
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If BatchComboBox.SelectedItem Is Nothing OrElse String.IsNullOrEmpty(QuantityTextBox.Text) Then
            StatusLabel.Text = "Please fill all fields."
            Return
        End If

        Dim batchID As Integer = DirectCast(BatchComboBox.SelectedItem, Object).BatchID
        Dim quantity As Integer
        If Not Integer.TryParse(QuantityTextBox.Text, quantity) OrElse quantity <= 0 Then
            StatusLabel.Text = "Invalid quantity."
            Return
        End If

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim updateQuery As String = "UPDATE Batches SET StoreQuantity = StoreQuantity - @Quantity, DispensingQuantity = DispensingQuantity + @Quantity WHERE BatchID = @BatchID AND StoreQuantity >= @Quantity"
                Using updateCommand As New SqlCommand(updateQuery, connection)
                    updateCommand.Parameters.AddWithValue("@Quantity", quantity)
                    updateCommand.Parameters.AddWithValue("@BatchID", batchID)
                    Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        StatusLabel.Text = "Insufficient stock in store."
                        Return
                    End If

                    Dim issueQuery As String = "INSERT INTO IssuesToDispensing (BatchID, Quantity, IssueDate) VALUES (@BatchID, @Quantity, @IssueDate)"
                    Using issueCommand As New SqlCommand(issueQuery, connection)
                        issueCommand.Parameters.AddWithValue("@BatchID", batchID)
                        issueCommand.Parameters.AddWithValue("@Quantity", quantity)
                        issueCommand.Parameters.AddWithValue("@IssueDate", DateTime.Now)
                        issueCommand.ExecuteNonQuery()
                    End Using
                End Using
                StatusLabel.Text = "Drugs issued to dispensing area successfully."
                QuantityTextBox.Text = ""
            Catch ex As Exception
                StatusLabel.Text = "Error: " & ex.Message
            End Try
        End Using
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim MainMenuForm As New MainMenuForm()
        MainMenuForm.Show()
        Me.Close()
    End Sub
End Class