Imports System.Data.SqlClient
Imports System.Configuration

Public Class LoginForm
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        ErrorLabel.Text = ""
        If String.IsNullOrEmpty(UsernameTextBox.Text) OrElse String.IsNullOrEmpty(PasswordTextBox.Text) Then
            ErrorLabel.Text = "Please enter username and password."
            Return
        End If

        Dim username As String = UsernameTextBox.Text.Trim()
        Dim password As String = PasswordTextBox.Text ' Use plaintext password
        MessageBox.Show("Username: " & username & vbCrLf & "Password: " & password) ' Debug input

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2")?.ConnectionString
        If String.IsNullOrEmpty(connectionString) Then
            ErrorLabel.Text = "Connection string 'PharmacySystem2' not found."
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                ErrorLabel.Text = "Connected to database successfully." ' Debug connection
                Dim query As String = "SELECT UserID, Role FROM Users WHERE UPPER(Username) = UPPER(@username) AND Password = @password"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password) ' Compare plaintext password
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                Dim userID As Integer = reader.GetInt32(0) ' UserID
                                Dim role As String = reader.GetString(1)   ' Role
                                Dim mainForm As New MainMenuForm(userID, role)
                                mainForm.Show()
                                Me.Hide()
                                Return
                            End While
                        Else
                            ErrorLabel.Text = "Invalid credentials or no matching records."
                        End If
                    End Using
                End Using
            Catch ex As Exception
                ErrorLabel.Text = "Error: " & ex.Message
            End Try
        End Using
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class