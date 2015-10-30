<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemo
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
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(87, 43)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(201, 20)
        Me.txtFirst.TabIndex = 0
        '
        'txtSecond
        '
        Me.txtSecond.Location = New System.Drawing.Point(87, 97)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(201, 20)
        Me.txtSecond.TabIndex = 1
        '
        'btnRed
        '
        Me.btnRed.Location = New System.Drawing.Point(87, 159)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(209, 23)
        Me.btnRed.TabIndex = 2
        Me.btnRed.Text = "Change Color to Red"
        Me.btnRed.UseVisualStyleBackColor = True
        '
        'frmDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 318)
        Me.Controls.Add(Me.btnRed)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.txtFirst)
        Me.Name = "frmDemo"
        Me.Text = "Demostration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtSecond As System.Windows.Forms.TextBox
    Friend WithEvents btnRed As System.Windows.Forms.Button

End Class
