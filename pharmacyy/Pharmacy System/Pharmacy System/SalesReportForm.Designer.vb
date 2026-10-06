<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesReportForm
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
        Me.EndDateLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ReportTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.EndDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.SalesGridView = New System.Windows.Forms.DataGridView()
        Me.Back = New System.Windows.Forms.Button()
        CType(Me.SalesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(479, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SALES REPORT FORM"
        '
        'EndDateLabel
        '
        Me.EndDateLabel.AutoSize = True
        Me.EndDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDateLabel.Location = New System.Drawing.Point(432, 500)
        Me.EndDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EndDateLabel.Name = "EndDateLabel"
        Me.EndDateLabel.Size = New System.Drawing.Size(207, 40)
        Me.EndDateLabel.TabIndex = 2
        Me.EndDateLabel.Text = "END DATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(432, 379)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 40)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "START DATE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(432, 259)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(281, 40)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "REPORT TYPE"
        '
        'ReportTypeComboBox
        '
        Me.ReportTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportTypeComboBox.FormattingEnabled = True
        Me.ReportTypeComboBox.Location = New System.Drawing.Point(771, 261)
        Me.ReportTypeComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReportTypeComboBox.Name = "ReportTypeComboBox"
        Me.ReportTypeComboBox.Size = New System.Drawing.Size(360, 48)
        Me.ReportTypeComboBox.TabIndex = 5
        '
        'StartDatePicker
        '
        Me.StartDatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StartDatePicker.Location = New System.Drawing.Point(771, 379)
        Me.StartDatePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.Size = New System.Drawing.Size(298, 48)
        Me.StartDatePicker.TabIndex = 6
        '
        'EndDatePicker
        '
        Me.EndDatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EndDatePicker.Location = New System.Drawing.Point(771, 506)
        Me.EndDatePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.Size = New System.Drawing.Size(298, 48)
        Me.EndDatePicker.TabIndex = 7
        '
        'GenerateButton
        '
        Me.GenerateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateButton.Location = New System.Drawing.Point(771, 997)
        Me.GenerateButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(285, 108)
        Me.GenerateButton.TabIndex = 8
        Me.GenerateButton.Text = "GENERATE"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'SalesGridView
        '
        Me.SalesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesGridView.Location = New System.Drawing.Point(1600, 223)
        Me.SalesGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SalesGridView.Name = "SalesGridView"
        Me.SalesGridView.RowHeadersWidth = 62
        Me.SalesGridView.Size = New System.Drawing.Size(1098, 1023)
        Me.SalesGridView.TabIndex = 9
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(477, 997)
        Me.Back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(285, 108)
        Me.Back.TabIndex = 10
        Me.Back.Text = "BACK"
        Me.Back.UseVisualStyleBackColor = True
        '
        'SalesReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.SalesGridView)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.EndDatePicker)
        Me.Controls.Add(Me.StartDatePicker)
        Me.Controls.Add(Me.ReportTypeComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.EndDateLabel)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SalesReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalesReportForm"
        CType(Me.SalesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents EndDateLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ReportTypeComboBox As ComboBox
    Friend WithEvents StartDatePicker As DateTimePicker
    Friend WithEvents EndDatePicker As DateTimePicker
    Friend WithEvents GenerateButton As Button
    Friend WithEvents SalesGridView As DataGridView
    Friend WithEvents Back As Button
End Class
