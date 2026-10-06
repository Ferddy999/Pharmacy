Imports System.Data.SqlClient
Imports System.Configuration

Public Class MainMenuForm
    Private userID As Integer
    Private role As String

    Public Sub New(userID As Integer, role As String)
        InitializeComponent()
        Me.userID = userID
        Me.role = role
        WelcomeLabel.Text = "Welcome, " & GetUsername(userID)
        ConfigureAccess()
    End Sub

    Public Sub New()
    End Sub

    Private Sub ConfigureAccess()
        Select Case role
            Case "Admin"
                ' Enable all buttons
                DispenseToPatientsButton.Enabled = True
                InventoryReportButton.Enabled = True
                SalesReportButton.Enabled = True
                ReceiveDrugsButton.Enabled = True
                ManageRecordsButton.Enabled = True
                IssueToDispensingButton.Enabled = True
            Case "StoreManager"
                DispenseToPatientsButton.Enabled = False
                InventoryReportButton.Enabled = True
                SalesReportButton.Enabled = True
                ReceiveDrugsButton.Enabled = True
                ManageRecordsButton.Enabled = True
                IssueToDispensingButton.Enabled = True
            Case "Dispenser"
                DispenseToPatientsButton.Enabled = True
                InventoryReportButton.Enabled = False
                SalesReportButton.Enabled = False
                ReceiveDrugsButton.Enabled = False
                ManageRecordsButton.Enabled = False
                IssueToDispensingButton.Enabled = True
            Case Else
                ' Disable all buttons for unknown roles
                DispenseToPatientsButton.Enabled = False
                InventoryReportButton.Enabled = False
                SalesReportButton.Enabled = False
                ReceiveDrugsButton.Enabled = False
                ManageRecordsButton.Enabled = False
                IssueToDispensingButton.Enabled = False
        End Select
    End Sub

    Private Function GetUsername(userID As Integer) As String
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2")?.ConnectionString
        If String.IsNullOrEmpty(connectionString) Then
            Return "Unknown"
        End If

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT Username FROM Users WHERE UserID = @userID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@userID", userID)
                    Dim result As Object = command.ExecuteScalar()
                    Return If(result IsNot Nothing, result.ToString(), "Unknown")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching username: " & ex.Message)
                Return "Unknown"
            End Try
        End Using
    End Function

    Private Sub DispenseToPatientsButton_Click(sender As Object, e As EventArgs) Handles DispenseToPatientsButton.Click
        Dim form As New DispenseToPatientsForm()
        form.ShowDialog()
    End Sub

    Private Sub IssueToDispensingButton_Click(sender As Object, e As EventArgs) Handles IssueToDispensingButton.Click
        Dim form As New DispenseToPatientsForm()
        form.ShowDialog()
    End Sub

    Private Sub InventoryReportButton_Click(sender As Object, e As EventArgs) Handles InventoryReportButton.Click
        Dim form As New InventoryReportForm()
        form.ShowDialog()
    End Sub

    Private Sub SalesReportButton_Click(sender As Object, e As EventArgs) Handles SalesReportButton.Click
        Dim form As New SalesReportForm()
        form.ShowDialog()
    End Sub

    Private Sub ReceiveDrugsButton_Click(sender As Object, e As EventArgs) Handles ReceiveDrugsButton.Click
        Dim form As New ReceiveDrugsInStoreForm()
        form.ShowDialog()
    End Sub

    Private Sub ManageRecordsButton_Click(sender As Object, e As EventArgs) Handles ManageRecordsButton.Click
        Dim form As New ManageRecordsForm()
        form.ShowDialog()
    End Sub

    Private Sub MainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: Add initialization code here if needed
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim LoginForm As New LoginForm()
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class