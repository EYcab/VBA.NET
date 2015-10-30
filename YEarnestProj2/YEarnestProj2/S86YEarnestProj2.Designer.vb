<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S86Frm
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
        Me.S86txtbx1 = New System.Windows.Forms.TextBox()
        Me.S86txtBx2 = New System.Windows.Forms.TextBox()
        Me.S86txtBx3 = New System.Windows.Forms.TextBox()
        Me.S86lstBx = New System.Windows.Forms.ListBox()
        Me.S86btn = New System.Windows.Forms.Button()
        Me.S86Lbl1 = New System.Windows.Forms.Label()
        Me.S86Lbl2 = New System.Windows.Forms.Label()
        Me.S86Lbl3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'S86txtbx1
        '
        Me.S86txtbx1.Location = New System.Drawing.Point(112, 81)
        Me.S86txtbx1.Name = "S86txtbx1"
        Me.S86txtbx1.Size = New System.Drawing.Size(300, 20)
        Me.S86txtbx1.TabIndex = 0
        '
        'S86txtBx2
        '
        Me.S86txtBx2.Location = New System.Drawing.Point(152, 130)
        Me.S86txtBx2.Name = "S86txtBx2"
        Me.S86txtBx2.Size = New System.Drawing.Size(100, 20)
        Me.S86txtBx2.TabIndex = 1
        Me.S86txtBx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86txtBx3
        '
        Me.S86txtBx3.Location = New System.Drawing.Point(152, 169)
        Me.S86txtBx3.Name = "S86txtBx3"
        Me.S86txtBx3.Size = New System.Drawing.Size(100, 20)
        Me.S86txtBx3.TabIndex = 2
        Me.S86txtBx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86lstBx
        '
        Me.S86lstBx.FormattingEnabled = True
        Me.S86lstBx.Location = New System.Drawing.Point(112, 238)
        Me.S86lstBx.Name = "S86lstBx"
        Me.S86lstBx.Size = New System.Drawing.Size(300, 95)
        Me.S86lstBx.TabIndex = 3
        '
        'S86btn
        '
        Me.S86btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.S86btn.Location = New System.Drawing.Point(301, 116)
        Me.S86btn.Name = "S86btn"
        Me.S86btn.Size = New System.Drawing.Size(111, 82)
        Me.S86btn.TabIndex = 4
        Me.S86btn.Text = "Display Bill"
        Me.S86btn.UseVisualStyleBackColor = False
        '
        'S86Lbl1
        '
        Me.S86Lbl1.AutoSize = True
        Me.S86Lbl1.Location = New System.Drawing.Point(46, 84)
        Me.S86Lbl1.Name = "S86Lbl1"
        Me.S86Lbl1.Size = New System.Drawing.Size(54, 13)
        Me.S86Lbl1.TabIndex = 5
        Me.S86Lbl1.Text = "Customer:"
        '
        'S86Lbl2
        '
        Me.S86Lbl2.AutoSize = True
        Me.S86Lbl2.Location = New System.Drawing.Point(70, 133)
        Me.S86Lbl2.Name = "S86Lbl2"
        Me.S86Lbl2.Size = New System.Drawing.Size(76, 13)
        Me.S86Lbl2.TabIndex = 6
        Me.S86Lbl2.Text = "Hours of labor:"
        '
        'S86Lbl3
        '
        Me.S86Lbl3.AutoSize = True
        Me.S86Lbl3.Location = New System.Drawing.Point(12, 172)
        Me.S86Lbl3.Name = "S86Lbl3"
        Me.S86Lbl3.Size = New System.Drawing.Size(134, 13)
        Me.S86Lbl3.TabIndex = 7
        Me.S86Lbl3.Text = "Cost of Parts and Supplies:"
        '
        'S86Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 462)
        Me.Controls.Add(Me.S86Lbl3)
        Me.Controls.Add(Me.S86Lbl2)
        Me.Controls.Add(Me.S86Lbl1)
        Me.Controls.Add(Me.S86btn)
        Me.Controls.Add(Me.S86lstBx)
        Me.Controls.Add(Me.S86txtBx3)
        Me.Controls.Add(Me.S86txtBx2)
        Me.Controls.Add(Me.S86txtbx1)
        Me.Name = "S86Frm"
        Me.Text = "Auto Repair"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents S86txtbx1 As System.Windows.Forms.TextBox
    Friend WithEvents S86txtBx2 As System.Windows.Forms.TextBox
    Friend WithEvents S86txtBx3 As System.Windows.Forms.TextBox
    Friend WithEvents S86lstBx As System.Windows.Forms.ListBox
    Friend WithEvents S86btn As System.Windows.Forms.Button
    Friend WithEvents S86Lbl1 As System.Windows.Forms.Label
    Friend WithEvents S86Lbl2 As System.Windows.Forms.Label
    Friend WithEvents S86Lbl3 As System.Windows.Forms.Label

End Class
