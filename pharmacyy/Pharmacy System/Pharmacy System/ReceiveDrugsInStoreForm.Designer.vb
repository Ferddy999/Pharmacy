<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiveDrugsInStoreForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DrugComboBox = New System.Windows.Forms.ComboBox()
        Me.BatchNoTextBox = New System.Windows.Forms.TextBox()
        Me.ExpiryDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(562, 262)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DRUG CODE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(585, 615)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "QUANTITY"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.ForeColor = System.Drawing.Color.Lime
        Me.StatusLabel.Location = New System.Drawing.Point(1314, 326)
        Me.StatusLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 40)
        Me.StatusLabel.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(575, 498)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 40)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "EXPIRY DATE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(558, 380)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(317, 40)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "BATCH NUMBER"
        '
        'DrugComboBox
        '
        Me.DrugComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrugComboBox.FormattingEnabled = True
        Me.DrugComboBox.Location = New System.Drawing.Point(888, 270)
        Me.DrugComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DrugComboBox.Name = "DrugComboBox"
        Me.DrugComboBox.Size = New System.Drawing.Size(422, 48)
        Me.DrugComboBox.TabIndex = 5
        '
        'BatchNoTextBox
        '
        Me.BatchNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchNoTextBox.Location = New System.Drawing.Point(896, 388)
        Me.BatchNoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BatchNoTextBox.Name = "BatchNoTextBox"
        Me.BatchNoTextBox.Size = New System.Drawing.Size(422, 48)
        Me.BatchNoTextBox.TabIndex = 6
        '
        'ExpiryDatePicker
        '
        Me.ExpiryDatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpiryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ExpiryDatePicker.Location = New System.Drawing.Point(913, 508)
        Me.ExpiryDatePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ExpiryDatePicker.Name = "ExpiryDatePicker"
        Me.ExpiryDatePicker.Size = New System.Drawing.Size(298, 48)
        Me.ExpiryDatePicker.TabIndex = 7
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(909, 624)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(241, 48)
        Me.QuantityTextBox.TabIndex = 8
        '
        'SubmitButton
        '
        Me.SubmitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitButton.Location = New System.Drawing.Point(1165, 861)
        Me.SubmitButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(285, 108)
        Me.SubmitButton.TabIndex = 9
        Me.SubmitButton.Text = "SUBMIT"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(526, 125)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(636, 40)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "RECEIVE DRUGS IN STORE FORM"
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(768, 765)
        Me.Back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(285, 108)
        Me.Back.TabIndex = 11
        Me.Back.Text = "BACK"
        Me.Back.UseVisualStyleBackColor = True
        '
        'ReceiveDrugsInStoreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1798, 1050)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.ExpiryDatePicker)
        Me.Controls.Add(Me.BatchNoTextBox)
        Me.Controls.Add(Me.DrugComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ReceiveDrugsInStoreForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECEIVEDRUGSINSTOREFORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DrugComboBox As ComboBox
    Friend WithEvents BatchNoTextBox As TextBox
    Friend WithEvents ExpiryDatePicker As DateTimePicker
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Back As Button
End Class
