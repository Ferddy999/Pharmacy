<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryReportForm
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
        Me.InventoryGridView = New System.Windows.Forms.DataGridView()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        CType(Me.InventoryGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InventoryGridView
        '
        Me.InventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InventoryGridView.Location = New System.Drawing.Point(334, 197)
        Me.InventoryGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InventoryGridView.Name = "InventoryGridView"
        Me.InventoryGridView.RowHeadersWidth = 62
        Me.InventoryGridView.Size = New System.Drawing.Size(2120, 888)
        Me.InventoryGridView.TabIndex = 0
        '
        'RefreshButton
        '
        Me.RefreshButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.Location = New System.Drawing.Point(1257, 1137)
        Me.RefreshButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(297, 108)
        Me.RefreshButton.TabIndex = 1
        Me.RefreshButton.Text = "REFRESH"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1098, 111)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(522, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INVENTORY REPORT FORM"
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(1718, 1137)
        Me.Back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(285, 108)
        Me.Back.TabIndex = 3
        Me.Back.Text = "BACK"
        Me.Back.UseVisualStyleBackColor = True
        '
        'InventoryReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.InventoryGridView)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "InventoryReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InventoryReportForm"
        CType(Me.InventoryGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InventoryGridView As DataGridView
    Friend WithEvents RefreshButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Back As Button
End Class
