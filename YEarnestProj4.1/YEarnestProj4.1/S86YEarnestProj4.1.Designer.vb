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
        Me.S86btnRate = New System.Windows.Forms.Button()
        Me.S86btn = New System.Windows.Forms.Button()
        Me.S86lblItem = New System.Windows.Forms.Label()
        Me.S86lblDuration = New System.Windows.Forms.Label()
        Me.S86txtItem = New System.Windows.Forms.TextBox()
        Me.S86txtDuration = New System.Windows.Forms.TextBox()
        Me.S86lBox = New System.Windows.Forms.ListBox()
        Me.S86lBox2 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'S86btnRate
        '
        Me.S86btnRate.Location = New System.Drawing.Point(55, 73)
        Me.S86btnRate.Name = "S86btnRate"
        Me.S86btnRate.Size = New System.Drawing.Size(171, 42)
        Me.S86btnRate.TabIndex = 0
        Me.S86btnRate.Text = "Display Rental Rates"
        Me.S86btnRate.UseVisualStyleBackColor = True
        '
        'S86btn
        '
        Me.S86btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.S86btn.Location = New System.Drawing.Point(55, 283)
        Me.S86btn.Name = "S86btn"
        Me.S86btn.Size = New System.Drawing.Size(171, 36)
        Me.S86btn.TabIndex = 1
        Me.S86btn.Text = "Display Customer Bill"
        Me.S86btn.UseVisualStyleBackColor = False
        '
        'S86lblItem
        '
        Me.S86lblItem.AutoSize = True
        Me.S86lblItem.Location = New System.Drawing.Point(12, 161)
        Me.S86lblItem.Name = "S86lblItem"
        Me.S86lblItem.Size = New System.Drawing.Size(119, 13)
        Me.S86lblItem.TabIndex = 2
        Me.S86lblItem.Text = "Select an item(1,2 or 3):"
        '
        'S86lblDuration
        '
        Me.S86lblDuration.AutoSize = True
        Me.S86lblDuration.Location = New System.Drawing.Point(3, 195)
        Me.S86lblDuration.Name = "S86lblDuration"
        Me.S86lblDuration.Size = New System.Drawing.Size(128, 13)
        Me.S86lblDuration.TabIndex = 3
        Me.S86lblDuration.Text = "Select a duration (H or F):"
        '
        'S86txtItem
        '
        Me.S86txtItem.Location = New System.Drawing.Point(137, 158)
        Me.S86txtItem.Name = "S86txtItem"
        Me.S86txtItem.Size = New System.Drawing.Size(66, 20)
        Me.S86txtItem.TabIndex = 4
        Me.S86txtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86txtDuration
        '
        Me.S86txtDuration.Location = New System.Drawing.Point(137, 192)
        Me.S86txtDuration.Name = "S86txtDuration"
        Me.S86txtDuration.Size = New System.Drawing.Size(66, 20)
        Me.S86txtDuration.TabIndex = 5
        Me.S86txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86lBox
        '
        Me.S86lBox.FormattingEnabled = True
        Me.S86lBox.Location = New System.Drawing.Point(246, 52)
        Me.S86lBox.Name = "S86lBox"
        Me.S86lBox.Size = New System.Drawing.Size(342, 95)
        Me.S86lBox.TabIndex = 6
        '
        'S86lBox2
        '
        Me.S86lBox2.FormattingEnabled = True
        Me.S86lBox2.Location = New System.Drawing.Point(246, 204)
        Me.S86lBox2.Name = "S86lBox2"
        Me.S86lBox2.Size = New System.Drawing.Size(342, 173)
        Me.S86lBox2.TabIndex = 7
        '
        'S86Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 451)
        Me.Controls.Add(Me.S86lBox2)
        Me.Controls.Add(Me.S86lBox)
        Me.Controls.Add(Me.S86txtDuration)
        Me.Controls.Add(Me.S86txtItem)
        Me.Controls.Add(Me.S86lblDuration)
        Me.Controls.Add(Me.S86lblItem)
        Me.Controls.Add(Me.S86btn)
        Me.Controls.Add(Me.S86btnRate)
        Me.Name = "S86Frm"
        Me.Text = "Welcome to Eddie's Equipment Rental"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents S86btnRate As System.Windows.Forms.Button
    Friend WithEvents S86btn As System.Windows.Forms.Button
    Friend WithEvents S86lblItem As System.Windows.Forms.Label
    Friend WithEvents S86lblDuration As System.Windows.Forms.Label
    Friend WithEvents S86txtItem As System.Windows.Forms.TextBox
    Friend WithEvents S86txtDuration As System.Windows.Forms.TextBox
    Friend WithEvents S86lBox As System.Windows.Forms.ListBox
    Friend WithEvents S86lBox2 As System.Windows.Forms.ListBox

End Class
