Imports System.Configuration
Imports System.Data.SqlClient

Public Class SalesReportForm
    Private Sub SalesReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportTypeComboBox.Items.AddRange({"Daily", "Weekly", "Monthly"})
        ReportTypeComboBox.SelectedIndex = 0
        EndDatePicker.Visible = False
        EndDateLabel.Visible = False
    End Sub

    Private Sub ReportTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ReportTypeComboBox.SelectedIndexChanged
        EndDatePicker.Visible = ReportTypeComboBox.SelectedItem.ToString() <> "Daily"
        EndDateLabel.Visible = EndDatePicker.Visible
    End Sub

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        Dim startDate As Date = StartDatePicker.Value
        Dim endDate As Date = If(ReportTypeComboBox.SelectedItem.ToString() = "Daily", startDate, EndDatePicker.Value)
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT s.SaleID, p.Name AS PatientName, d.Name AS DrugName, b.BatchNo, s.Quantity, s.Price, s.SaleDate " &
                                      "FROM Sales s JOIN Patients p ON s.PatientID = p.PatientID " &
                                      "JOIN Batches b ON s.BatchID = b.BatchID " &
                                      "JOIN Drugs d ON b.DrugID = d.DrugID " &
                                      "WHERE s.SaleDate BETWEEN @StartDate AND @EndDate"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@StartDate", startDate)
                    command.Parameters.AddWithValue("@EndDate", endDate.AddDays(1).AddSeconds(-1)) ' End of day
                    Using adapter As New SqlDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        SalesGridView.DataSource = table
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error generating report: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim MainMenuForm As New MainMenuForm()
        MainMenuForm.Show()
        Me.Close()
    End Sub
End Class

' log, main, receive, issu,, ine,, sales