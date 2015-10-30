<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Demonstration
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
        Me.txtFirst_TextChanged = New System.Windows.Forms.TextBox()
        Me.txtFirst_Leave = New System.Windows.Forms.TextBox()
        Me.btnRed_Click = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirst_TextChanged
        '
        Me.txtFirst_TextChanged.Location = New System.Drawing.Point(65, 50)
        Me.txtFirst_TextChanged.Name = "txtFirst_TextChanged"
        Me.txtFirst_TextChanged.Size = New System.Drawing.Size(148, 20)
        Me.txtFirst_TextChanged.TabIndex = 0
        '
        'txtFirst_Leave
        '
        Me.txtFirst_Leave.Location = New System.Drawing.Point(65, 96)
        Me.txtFirst_Leave.Name = "txtFirst_Leave"
        Me.txtFirst_Leave.Size = New System.Drawing.Size(148, 20)
        Me.txtFirst_Leave.TabIndex = 1
        '
        'btnRed_Click
        '
        Me.btnRed_Click.Location = New System.Drawing.Point(65, 141)
        Me.btnRed_Click.Name = "btnRed_Click"
        Me.btnRed_Click.Size = New System.Drawing.Size(148, 23)
        Me.btnRed_Click.TabIndex = 2
        Me.btnRed_Click.Text = "Change Color to Red"
        Me.btnRed_Click.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 196)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'Demonstration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 479)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnRed_Click)
        Me.Controls.Add(Me.txtFirst_Leave)
        Me.Controls.Add(Me.txtFirst_TextChanged)
        Me.Name = "Demonstration"
        Me.Text = "  "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirst_TextChanged As System.Windows.Forms.TextBox
    Friend WithEvents txtFirst_Leave As System.Windows.Forms.TextBox
    Friend WithEvents btnRed_Click As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
