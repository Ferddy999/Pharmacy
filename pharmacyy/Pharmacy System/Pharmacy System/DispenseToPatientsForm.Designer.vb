<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DispenseToPatientsForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.PatientComboBox = New System.Windows.Forms.ComboBox()
        Me.BatchComboBox = New System.Windows.Forms.ComboBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(523, 142)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(584, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DISPENSE TO PATIENTS FORM"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.ForeColor = System.Drawing.Color.Lime
        Me.StatusLabel.Location = New System.Drawing.Point(1316, 300)
        Me.StatusLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 40)
        Me.StatusLabel.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(596, 393)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "BATCH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(637, 618)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 40)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PRICE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(608, 495)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 40)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "QUANTITY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(579, 286)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 40)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "PATIENT"
        '
        'SubmitButton
        '
        Me.SubmitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitButton.Location = New System.Drawing.Point(750, 767)
        Me.SubmitButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(238, 72)
        Me.SubmitButton.TabIndex = 6
        Me.SubmitButton.Text = "SUBMIT"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'PatientComboBox
        '
        Me.PatientComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientComboBox.FormattingEnabled = True
        Me.PatientComboBox.Location = New System.Drawing.Point(843, 291)
        Me.PatientComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PatientComboBox.Name = "PatientComboBox"
        Me.PatientComboBox.Size = New System.Drawing.Size(409, 48)
        Me.PatientComboBox.TabIndex = 7
        '
        'BatchComboBox
        '
        Me.BatchComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchComboBox.FormattingEnabled = True
        Me.BatchComboBox.Location = New System.Drawing.Point(857, 399)
        Me.BatchComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BatchComboBox.Name = "BatchComboBox"
        Me.BatchComboBox.Size = New System.Drawing.Size(409, 48)
        Me.BatchComboBox.TabIndex = 8
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTextBox.Location = New System.Drawing.Point(873, 623)
        Me.PriceTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(148, 48)
        Me.PriceTextBox.TabIndex = 9
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(874, 508)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(180, 48)
        Me.QuantityTextBox.TabIndex = 10
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(1311, 793)
        Me.Back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(238, 72)
        Me.Back.TabIndex = 11
        Me.Back.Text = "BACK"
        Me.Back.UseVisualStyleBackColor = True
        '
        'DispenseToPatientsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.BatchComboBox)
        Me.Controls.Add(Me.PatientComboBox)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "DispenseToPatientsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DispenseToPatientsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SubmitButton As Button
    Friend WithEvents PatientComboBox As ComboBox
    Friend WithEvents BatchComboBox As ComboBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Back As Button
End Class
