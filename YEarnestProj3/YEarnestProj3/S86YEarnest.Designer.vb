<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S86YEarnest
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
        Me.S86txtLoanAmt = New System.Windows.Forms.TextBox()
        Me.S86txtIntRate = New System.Windows.Forms.TextBox()
        Me.S86txtDurationMths = New System.Windows.Forms.TextBox()
        Me.S86btn = New System.Windows.Forms.Button()
        Me.S86txtMthlyPmt = New System.Windows.Forms.TextBox()
        Me.S86txtTotal = New System.Windows.Forms.TextBox()
        Me.S86lbl1 = New System.Windows.Forms.Label()
        Me.S86lbl2 = New System.Windows.Forms.Label()
        Me.S86lbl3 = New System.Windows.Forms.Label()
        Me.S86lbl4 = New System.Windows.Forms.Label()
        Me.S86lbl5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'S86txtLoanAmt
        '
        Me.S86txtLoanAmt.Location = New System.Drawing.Point(167, 50)
        Me.S86txtLoanAmt.Name = "S86txtLoanAmt"
        Me.S86txtLoanAmt.Size = New System.Drawing.Size(126, 20)
        Me.S86txtLoanAmt.TabIndex = 0
        Me.S86txtLoanAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86txtIntRate
        '
        Me.S86txtIntRate.Location = New System.Drawing.Point(167, 91)
        Me.S86txtIntRate.Name = "S86txtIntRate"
        Me.S86txtIntRate.Size = New System.Drawing.Size(126, 20)
        Me.S86txtIntRate.TabIndex = 1
        Me.S86txtIntRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86txtDurationMths
        '
        Me.S86txtDurationMths.Location = New System.Drawing.Point(167, 127)
        Me.S86txtDurationMths.Name = "S86txtDurationMths"
        Me.S86txtDurationMths.Size = New System.Drawing.Size(126, 20)
        Me.S86txtDurationMths.TabIndex = 2
        Me.S86txtDurationMths.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86btn
        '
        Me.S86btn.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.S86btn.Location = New System.Drawing.Point(70, 175)
        Me.S86btn.Name = "S86btn"
        Me.S86btn.Size = New System.Drawing.Size(223, 40)
        Me.S86btn.TabIndex = 3
        Me.S86btn.Text = "Analyze"
        Me.S86btn.UseVisualStyleBackColor = False
        '
        'S86txtMthlyPmt
        '
        Me.S86txtMthlyPmt.Location = New System.Drawing.Point(167, 240)
        Me.S86txtMthlyPmt.Name = "S86txtMthlyPmt"
        Me.S86txtMthlyPmt.Size = New System.Drawing.Size(126, 20)
        Me.S86txtMthlyPmt.TabIndex = 4
        Me.S86txtMthlyPmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86txtTotal
        '
        Me.S86txtTotal.Location = New System.Drawing.Point(167, 285)
        Me.S86txtTotal.Name = "S86txtTotal"
        Me.S86txtTotal.Size = New System.Drawing.Size(126, 20)
        Me.S86txtTotal.TabIndex = 5
        Me.S86txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86lbl1
        '
        Me.S86lbl1.AutoSize = True
        Me.S86lbl1.Location = New System.Drawing.Point(63, 53)
        Me.S86lbl1.Name = "S86lbl1"
        Me.S86lbl1.Size = New System.Drawing.Size(85, 13)
        Me.S86lbl1.TabIndex = 6
        Me.S86lbl1.Text = "Amount of Loan:"
        '
        'S86lbl2
        '
        Me.S86lbl2.AutoSize = True
        Me.S86lbl2.Location = New System.Drawing.Point(74, 91)
        Me.S86lbl2.Name = "S86lbl2"
        Me.S86lbl2.Size = New System.Drawing.Size(74, 39)
        Me.S86lbl2.TabIndex = 7
        Me.S86lbl2.Text = "Interest rate:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(such as 5.25)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'S86lbl3
        '
        Me.S86lbl3.AutoSize = True
        Me.S86lbl3.Location = New System.Drawing.Point(63, 130)
        Me.S86lbl3.Name = "S86lbl3"
        Me.S86lbl3.Size = New System.Drawing.Size(98, 13)
        Me.S86lbl3.TabIndex = 8
        Me.S86lbl3.Text = "Duration in months:"
        '
        'S86lbl4
        '
        Me.S86lbl4.AutoSize = True
        Me.S86lbl4.Location = New System.Drawing.Point(67, 243)
        Me.S86lbl4.Name = "S86lbl4"
        Me.S86lbl4.Size = New System.Drawing.Size(91, 13)
        Me.S86lbl4.TabIndex = 9
        Me.S86lbl4.Text = "Monthly Payment:"
        '
        'S86lbl5
        '
        Me.S86lbl5.AutoSize = True
        Me.S86lbl5.Location = New System.Drawing.Point(64, 292)
        Me.S86lbl5.Name = "S86lbl5"
        Me.S86lbl5.Size = New System.Drawing.Size(94, 13)
        Me.S86lbl5.TabIndex = 10
        Me.S86lbl5.Text = "Total interest paid:"
        '
        'S86YEarnest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 398)
        Me.Controls.Add(Me.S86lbl5)
        Me.Controls.Add(Me.S86lbl4)
        Me.Controls.Add(Me.S86lbl3)
        Me.Controls.Add(Me.S86lbl2)
        Me.Controls.Add(Me.S86lbl1)
        Me.Controls.Add(Me.S86txtTotal)
        Me.Controls.Add(Me.S86txtMthlyPmt)
        Me.Controls.Add(Me.S86btn)
        Me.Controls.Add(Me.S86txtDurationMths)
        Me.Controls.Add(Me.S86txtIntRate)
        Me.Controls.Add(Me.S86txtLoanAmt)
        Me.Name = "S86YEarnest"
        Me.Text = "Car Loan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents S86txtLoanAmt As System.Windows.Forms.TextBox
    Friend WithEvents S86txtIntRate As System.Windows.Forms.TextBox
    Friend WithEvents S86txtDurationMths As System.Windows.Forms.TextBox
    Friend WithEvents S86btn As System.Windows.Forms.Button
    Friend WithEvents S86txtMthlyPmt As System.Windows.Forms.TextBox
    Friend WithEvents S86txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents S86lbl1 As System.Windows.Forms.Label
    Friend WithEvents S86lbl2 As System.Windows.Forms.Label
    Friend WithEvents S86lbl3 As System.Windows.Forms.Label
    Friend WithEvents S86lbl4 As System.Windows.Forms.Label
    Friend WithEvents S86lbl5 As System.Windows.Forms.Label

End Class
