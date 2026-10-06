Imports System.Data.SqlClient
Imports System.Configuration

Public Class ManageRecordsForm
    Inherits System.Windows.Forms.Form

    Public Property PatientNameTextBox As Object

    ' Declare controls (assume these are added in the Form Designer)
    'Private WithEvents DrugsGridView As DataGridView
    'Private WithEvents PatientsGridView As DataGridView
    'Private DrugCodeTextBox As TextBox
    'Private NameTextBox As TextBox
    ' Private DescriptionTextBox As TextBox
    ' Private PatientNameTextBox As TextBox
    ' Private ContactInfoTextBox As TextBox
    ' Private AddDrugButton As Button
    ' Private EditDrugButton As Button
    ' Private DeleteDrugButton As Button
    ' Private AddPatientButton As Button
    ' Private EditPatientButton As Button
    ' Private DeletePatientButton As Button

    Private Sub ManageRecordsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDrugs()
        LoadPatients()
    End Sub

    ' Load drugs into the DataGridView
    Private Sub LoadDrugs()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT DrugID, DrugCode, Name, Description FROM Drugs"
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DrugsGridView.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading drugs: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Load patients into the DataGridView
    Private Sub LoadPatients()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT PatientID, Name, ContactInfo FROM Patients"
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    PatientsGridView.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading patients: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Add a new drug
    Private Sub AddDrugButton_Click(sender As Object, e As EventArgs) Handles AddDrugButton.Click
        If String.IsNullOrEmpty(DrugCodeTextBox.Text) OrElse String.IsNullOrEmpty(NameTextBox.Text) Then
            MessageBox.Show("Please enter Drug Code and Name.")
            Return
        End If

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO Drugs (DrugCode, Name, Description) VALUES (@DrugCode, @Name, @Description)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@DrugCode", DrugCodeTextBox.Text)
                    command.Parameters.AddWithValue("@Name", NameTextBox.Text)
                    command.Parameters.AddWithValue("@Description", DescriptionTextBox.Text)
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Drug added successfully.")
                LoadDrugs()
                DrugCodeTextBox.Text = ""
                NameTextBox.Text = ""
                DescriptionTextBox.Text = ""
            Catch ex As Exception
                MessageBox.Show("Error adding drug: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Edit selected drug
    Private Sub EditDrugButton_Click(sender As Object, e As EventArgs) Handles EditDrugButton.Click
        If DrugsGridView.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a drug to edit.")
            Return
        End If

        Dim drugID As Integer = Convert.ToInt32(DrugsGridView.SelectedRows(0).Cells("DrugID").Value)
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "UPDATE Drugs SET DrugCode = @DrugCode, Name = @Name, Description = @Description WHERE DrugID = @DrugID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@DrugCode", DrugCodeTextBox.Text)
                    command.Parameters.AddWithValue("@Name", NameTextBox.Text)
                    command.Parameters.AddWithValue("@Description", DescriptionTextBox.Text)
                    command.Parameters.AddWithValue("@DrugID", drugID)
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Drug updated successfully.")
                LoadDrugs()
            Catch ex As Exception
                MessageBox.Show("Error updating drug: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Delete selected drug
    Private Sub DeleteDrugButton_Click(sender As Object, e As EventArgs) Handles DeleteDrugButton.Click
        If DrugsGridView.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a drug to delete.")
            Return
        End If

        Dim drugID As Integer = Convert.ToInt32(DrugsGridView.SelectedRows(0).Cells("DrugID").Value)
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "DELETE FROM Drugs WHERE DrugID = @DrugID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@DrugID", drugID)
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Drug deleted successfully.")
                LoadDrugs()
            Catch ex As Exception
                MessageBox.Show("Error deleting drug: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Add a new patient
    Private Sub AddPatientButton_Click(sender As Object, e As EventArgs) Handles AddPatientButton.Click
        If String.IsNullOrEmpty(PatientNameTextBox.Text) Then
            MessageBox.Show("Please enter Patient Name.")
            Return
        End If

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO Patients (Name, ContactInfo) VALUES (@Name, @ContactInfo)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Name", PatientNameTextBox.Text)
                    command.Parameters.AddWithValue("@ContactInfo", ContactInfoTextBox.Text)
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Patient added successfully.")
                LoadPatients()
                PatientNameTextBox.Text = ""
                ContactInfoTextBox.Text = ""
            Catch ex As Exception
                MessageBox.Show("Error adding patient: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Edit selected patient
    Private Sub EditPatientButton_Click(sender As Object, e As EventArgs) Handles EditPatientButton.Click
        If PatientsGridView.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a patient to edit.")
            Return
        End If

        Dim patientID As Integer = Convert.ToInt32(PatientsGridView.SelectedRows(0).Cells("PatientID").Value)
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "UPDATE Patients SET Name = @Name, ContactInfo = @ContactInfo WHERE PatientID = @PatientID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Name", PatientNameTextBox.Text)
                    command.Parameters.AddWithValue("@ContactInfo", ContactInfoTextBox.Text)
                    command.Parameters.AddWithValue("@PatientID", patientID)
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Patient updated successfully.")
                LoadPatients()
            Catch ex As Exception
                MessageBox.Show("Error updating patient: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Delete selected patient
    Private Sub DeletePatientButton_Click(sender As Object, e As EventArgs) Handles DeletePatientButton.Click
        If PatientsGridView.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a patient to delete.")
            Return
        End If

        Dim patientID As Integer = Convert.ToInt32(PatientsGridView.SelectedRows(0).Cells("PatientID").Value)
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("PharmacySystem2").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "DELETE FROM Patients WHERE PatientID = @PatientID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@PatientID", patientID)
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Patient deleted successfully.")
                LoadPatients()
            Catch ex As Exception
                MessageBox.Show("Error deleting patient: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Populate textboxes when a drug row is selected
    Private Sub DrugsGridView_SelectionChanged(sender As Object, e As EventArgs) Handles DrugsGridView.SelectionChanged
        If DrugsGridView.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DrugsGridView.SelectedRows(0)
            DrugCodeTextBox.Text = row.Cells("DrugCode").Value.ToString()
            NameTextBox.Text = row.Cells("Name").Value.ToString()
            DescriptionTextBox.Text = row.Cells("Description").Value.ToString()
        End If
    End Sub

    ' Populate textboxes when a patient row is selected
    Private Sub PatientsGridView_SelectionChanged(sender As Object, e As EventArgs) Handles PatientsGridView.SelectionChanged
        If PatientsGridView.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = PatientsGridView.SelectedRows(0)
            PatientNameTextBox.Text = row.Cells("Name").Value.ToString()
            ContactInfoTextBox.Text = row.Cells("ContactInfo").Value.ToString()
        End If
    End Sub

    Private Sub DescriptionTextBox_TextChanged(sender As Object, e As EventArgs) Handles DescriptionTextBox.TextChanged

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim MainMenuForm As New MainMenuForm()
        MainMenuForm.Show()
        Me.Close()
    End Sub
End Class