<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageRecordsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EditPatientButton = New System.Windows.Forms.Button()
        Me.DeletePatientButton = New System.Windows.Forms.Button()
        Me.AddPatientButton = New System.Windows.Forms.Button()
        Me.ContactInfoTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PatientsGridView = New System.Windows.Forms.DataGridView()
        Me.EditDrugButton = New System.Windows.Forms.Button()
        Me.DeleteDrugButton = New System.Windows.Forms.Button()
        Me.AddDrugButton = New System.Windows.Forms.Button()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.DrugCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DrugsGridView = New System.Windows.Forms.DataGridView()
        Me.Back = New System.Windows.Forms.Button()
        CType(Me.PatientsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(501, 59)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(498, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MANAGE RECORDS FORM"
        '
        'EditPatientButton
        '
        Me.EditPatientButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditPatientButton.Location = New System.Drawing.Point(2412, 1034)
        Me.EditPatientButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EditPatientButton.Name = "EditPatientButton"
        Me.EditPatientButton.Size = New System.Drawing.Size(312, 80)
        Me.EditPatientButton.TabIndex = 46
        Me.EditPatientButton.Text = "EDIT PATIENT"
        Me.EditPatientButton.UseVisualStyleBackColor = True
        '
        'DeletePatientButton
        '
        Me.DeletePatientButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeletePatientButton.Location = New System.Drawing.Point(2252, 1175)
        Me.DeletePatientButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeletePatientButton.Name = "DeletePatientButton"
        Me.DeletePatientButton.Size = New System.Drawing.Size(423, 83)
        Me.DeletePatientButton.TabIndex = 45
        Me.DeletePatientButton.Text = "DELETE PATIENT"
        Me.DeletePatientButton.UseVisualStyleBackColor = True
        '
        'AddPatientButton
        '
        Me.AddPatientButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddPatientButton.Location = New System.Drawing.Point(2409, 908)
        Me.AddPatientButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddPatientButton.Name = "AddPatientButton"
        Me.AddPatientButton.Size = New System.Drawing.Size(315, 86)
        Me.AddPatientButton.TabIndex = 44
        Me.AddPatientButton.Text = "ADD PATIENT"
        Me.AddPatientButton.UseVisualStyleBackColor = True
        '
        'ContactInfoTextBox
        '
        Me.ContactInfoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactInfoTextBox.Location = New System.Drawing.Point(2103, 1003)
        Me.ContactInfoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ContactInfoTextBox.Name = "ContactInfoTextBox"
        Me.ContactInfoTextBox.Size = New System.Drawing.Size(282, 48)
        Me.ContactInfoTextBox.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1740, 1008)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(298, 40)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "CONTACT INFO"
        '
        'NameTextBox1
        '
        Me.NameTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox1.Location = New System.Drawing.Point(2103, 908)
        Me.NameTextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NameTextBox1.Name = "NameTextBox1"
        Me.NameTextBox1.Size = New System.Drawing.Size(282, 48)
        Me.NameTextBox1.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1740, 917)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 40)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "NAME"
        '
        'PatientsGridView
        '
        Me.PatientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientsGridView.Location = New System.Drawing.Point(1684, 143)
        Me.PatientsGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PatientsGridView.Name = "PatientsGridView"
        Me.PatientsGridView.RowHeadersWidth = 62
        Me.PatientsGridView.Size = New System.Drawing.Size(1012, 634)
        Me.PatientsGridView.TabIndex = 39
        '
        'EditDrugButton
        '
        Me.EditDrugButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditDrugButton.Location = New System.Drawing.Point(834, 989)
        Me.EditDrugButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EditDrugButton.Name = "EditDrugButton"
        Me.EditDrugButton.Size = New System.Drawing.Size(267, 63)
        Me.EditDrugButton.TabIndex = 38
        Me.EditDrugButton.Text = "EDIT DRUG"
        Me.EditDrugButton.UseVisualStyleBackColor = True
        '
        'DeleteDrugButton
        '
        Me.DeleteDrugButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteDrugButton.Location = New System.Drawing.Point(834, 1085)
        Me.DeleteDrugButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteDrugButton.Name = "DeleteDrugButton"
        Me.DeleteDrugButton.Size = New System.Drawing.Size(310, 65)
        Me.DeleteDrugButton.TabIndex = 37
        Me.DeleteDrugButton.Text = "DELETE DRUG"
        Me.DeleteDrugButton.UseVisualStyleBackColor = True
        '
        'AddDrugButton
        '
        Me.AddDrugButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddDrugButton.Location = New System.Drawing.Point(834, 898)
        Me.AddDrugButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddDrugButton.Name = "AddDrugButton"
        Me.AddDrugButton.Size = New System.Drawing.Size(267, 63)
        Me.AddDrugButton.TabIndex = 36
        Me.AddDrugButton.Text = "ADD DRUG"
        Me.AddDrugButton.UseVisualStyleBackColor = True
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(454, 994)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(330, 48)
        Me.NameTextBox.TabIndex = 35
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(454, 1105)
        Me.DescriptionTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(330, 48)
        Me.DescriptionTextBox.TabIndex = 34
        '
        'DrugCodeTextBox
        '
        Me.DrugCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrugCodeTextBox.Location = New System.Drawing.Point(454, 894)
        Me.DrugCodeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DrugCodeTextBox.Name = "DrugCodeTextBox"
        Me.DrugCodeTextBox.Size = New System.Drawing.Size(330, 48)
        Me.DrugCodeTextBox.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(135, 1003)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 40)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(135, 1105)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 40)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "DESCRIPTION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 898)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 40)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "DRUG CODE"
        '
        'DrugsGridView
        '
        Me.DrugsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DrugsGridView.Location = New System.Drawing.Point(190, 143)
        Me.DrugsGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DrugsGridView.Name = "DrugsGridView"
        Me.DrugsGridView.RowHeadersWidth = 62
        Me.DrugsGridView.Size = New System.Drawing.Size(1012, 634)
        Me.DrugsGridView.TabIndex = 29
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(1302, 1151)
        Me.Back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(328, 108)
        Me.Back.TabIndex = 47
        Me.Back.Text = "BACK"
        Me.Back.UseVisualStyleBackColor = True
        '
        'ManageRecordsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1803, 1050)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.EditPatientButton)
        Me.Controls.Add(Me.DeletePatientButton)
        Me.Controls.Add(Me.AddPatientButton)
        Me.Controls.Add(Me.ContactInfoTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NameTextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PatientsGridView)
        Me.Controls.Add(Me.EditDrugButton)
        Me.Controls.Add(Me.DeleteDrugButton)
        Me.Controls.Add(Me.AddDrugButton)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.DrugCodeTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DrugsGridView)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ManageRecordsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageRecordsForm"
        CType(Me.PatientsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents EditPatientButton As Button
    Friend WithEvents DeletePatientButton As Button
    Friend WithEvents AddPatientButton As Button
    Friend WithEvents ContactInfoTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NameTextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PatientsGridView As DataGridView
    Friend WithEvents EditDrugButton As Button
    Friend WithEvents DeleteDrugButton As Button
    Friend WithEvents AddDrugButton As Button
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents DrugCodeTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DrugsGridView As DataGridView

    Private Sub ManageRecordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents Back As Button
End Class
