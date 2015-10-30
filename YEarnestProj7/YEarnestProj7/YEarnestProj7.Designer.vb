<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YEarnestProj7
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
        Me.S86lBoxUnits = New System.Windows.Forms.ListBox()
        Me.S86txtLength = New System.Windows.Forms.TextBox()
        Me.S86txtOriginal = New System.Windows.Forms.TextBox()
        Me.S86txtDesired = New System.Windows.Forms.TextBox()
        Me.S86btn = New System.Windows.Forms.Button()
        Me.S86txtOutcome = New System.Windows.Forms.TextBox()
        Me.S86lbl1 = New System.Windows.Forms.Label()
        Me.S86lbl2 = New System.Windows.Forms.Label()
        Me.S86lbl3 = New System.Windows.Forms.Label()
        Me.S86lbl4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'S86lBoxUnits
        '
        Me.S86lBoxUnits.FormattingEnabled = True
        Me.S86lBoxUnits.Location = New System.Drawing.Point(21, 47)
        Me.S86lBoxUnits.Name = "S86lBoxUnits"
        Me.S86lBoxUnits.Size = New System.Drawing.Size(164, 355)
        Me.S86lBoxUnits.TabIndex = 0
        '
        'S86txtLength
        '
        Me.S86txtLength.Location = New System.Drawing.Point(380, 56)
        Me.S86txtLength.Name = "S86txtLength"
        Me.S86txtLength.Size = New System.Drawing.Size(61, 20)
        Me.S86txtLength.TabIndex = 1
        Me.S86txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86txtOriginal
        '
        Me.S86txtOriginal.Location = New System.Drawing.Point(380, 110)
        Me.S86txtOriginal.Name = "S86txtOriginal"
        Me.S86txtOriginal.Size = New System.Drawing.Size(39, 20)
        Me.S86txtOriginal.TabIndex = 2
        Me.S86txtOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86txtDesired
        '
        Me.S86txtDesired.Location = New System.Drawing.Point(380, 163)
        Me.S86txtDesired.Name = "S86txtDesired"
        Me.S86txtDesired.Size = New System.Drawing.Size(39, 20)
        Me.S86txtDesired.TabIndex = 3
        Me.S86txtDesired.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86btn
        '
        Me.S86btn.Location = New System.Drawing.Point(222, 211)
        Me.S86btn.Name = "S86btn"
        Me.S86btn.Size = New System.Drawing.Size(248, 77)
        Me.S86btn.TabIndex = 4
        Me.S86btn.Text = "Convert"
        Me.S86btn.UseVisualStyleBackColor = True
        '
        'S86txtOutcome
        '
        Me.S86txtOutcome.Location = New System.Drawing.Point(380, 337)
        Me.S86txtOutcome.Name = "S86txtOutcome"
        Me.S86txtOutcome.Size = New System.Drawing.Size(100, 20)
        Me.S86txtOutcome.TabIndex = 5
        Me.S86txtOutcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86lbl1
        '
        Me.S86lbl1.AutoSize = True
        Me.S86lbl1.Location = New System.Drawing.Point(280, 59)
        Me.S86lbl1.Name = "S86lbl1"
        Me.S86lbl1.Size = New System.Drawing.Size(94, 13)
        Me.S86lbl1.TabIndex = 6
        Me.S86lbl1.Text = "Length to convert:"
        '
        'S86lbl2
        '
        Me.S86lbl2.AutoSize = True
        Me.S86lbl2.Location = New System.Drawing.Point(280, 113)
        Me.S86lbl2.Name = "S86lbl2"
        Me.S86lbl2.Size = New System.Drawing.Size(93, 13)
        Me.S86lbl2.TabIndex = 7
        Me.S86lbl2.Text = "Original Units(1-9):"
        '
        'S86lbl3
        '
        Me.S86lbl3.AutoSize = True
        Me.S86lbl3.Location = New System.Drawing.Point(280, 166)
        Me.S86lbl3.Name = "S86lbl3"
        Me.S86lbl3.Size = New System.Drawing.Size(97, 13)
        Me.S86lbl3.TabIndex = 8
        Me.S86lbl3.Text = "Desired Units (1-9):"
        '
        'S86lbl4
        '
        Me.S86lbl4.AutoSize = True
        Me.S86lbl4.Location = New System.Drawing.Point(292, 340)
        Me.S86lbl4.Name = "S86lbl4"
        Me.S86lbl4.Size = New System.Drawing.Size(82, 13)
        Me.S86lbl4.TabIndex = 9
        Me.S86lbl4.Text = "Desired Length:"
        '
        'YEarnestProj7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 495)
        Me.Controls.Add(Me.S86lbl4)
        Me.Controls.Add(Me.S86lbl3)
        Me.Controls.Add(Me.S86lbl2)
        Me.Controls.Add(Me.S86lbl1)
        Me.Controls.Add(Me.S86txtOutcome)
        Me.Controls.Add(Me.S86btn)
        Me.Controls.Add(Me.S86txtDesired)
        Me.Controls.Add(Me.S86txtOriginal)
        Me.Controls.Add(Me.S86txtLength)
        Me.Controls.Add(Me.S86lBoxUnits)
        Me.Name = "YEarnestProj7"
        Me.Text = "Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents S86lBoxUnits As System.Windows.Forms.ListBox
    Friend WithEvents S86txtLength As System.Windows.Forms.TextBox
    Friend WithEvents S86txtOriginal As System.Windows.Forms.TextBox
    Friend WithEvents S86txtDesired As System.Windows.Forms.TextBox
    Friend WithEvents S86btn As System.Windows.Forms.Button
    Friend WithEvents S86txtOutcome As System.Windows.Forms.TextBox
    Friend WithEvents S86lbl1 As System.Windows.Forms.Label
    Friend WithEvents S86lbl2 As System.Windows.Forms.Label
    Friend WithEvents S86lbl3 As System.Windows.Forms.Label
    Friend WithEvents S86lbl4 As System.Windows.Forms.Label

End Class
