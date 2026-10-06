Imports System.Configuration
Imports System.Data.SqlClient

Public Class InventoryReportForm
    Private Sub InventoryReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventory()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        LoadInventory()
    End Sub

    Private Sub LoadInventory()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT d.DrugCode, d.Name, b.BatchNo, b.ExpiryDate, b.StoreQuantity, b.DispensingQuantity " &
                                      "FROM Batches b JOIN Drugs d ON b.DrugID = d.DrugID"
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    InventoryGridView.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading inventory: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim MainMenuForm As New MainMenuForm()
        MainMenuForm.Show()
        Me.Close()
    End Sub
End Class