<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S86YEarnestProj5
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
        Me.S86lblSlice = New System.Windows.Forms.Label()
        Me.S86lblFries = New System.Windows.Forms.Label()
        Me.S86lblDrinks = New System.Windows.Forms.Label()
        Me.S86lstBox = New System.Windows.Forms.ListBox()
        Me.S86btnTotal = New System.Windows.Forms.Button()
        Me.S86txtBoxSlices = New System.Windows.Forms.TextBox()
        Me.S86txtBoxFries = New System.Windows.Forms.TextBox()
        Me.S86txtBoxDrinks = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'S86lblSlice
        '
        Me.S86lblSlice.AutoSize = True
        Me.S86lblSlice.Location = New System.Drawing.Point(80, 57)
        Me.S86lblSlice.Name = "S86lblSlice"
        Me.S86lblSlice.Size = New System.Drawing.Size(119, 13)
        Me.S86lblSlice.TabIndex = 0
        Me.S86lblSlice.Text = "How many pizza slices?"
        '
        'S86lblFries
        '
        Me.S86lblFries.AutoSize = True
        Me.S86lblFries.Location = New System.Drawing.Point(80, 102)
        Me.S86lblFries.Name = "S86lblFries"
        Me.S86lblFries.Size = New System.Drawing.Size(85, 13)
        Me.S86lblFries.TabIndex = 1
        Me.S86lblFries.Text = "How many fries?"
        '
        'S86lblDrinks
        '
        Me.S86lblDrinks.AutoSize = True
        Me.S86lblDrinks.Location = New System.Drawing.Point(80, 147)
        Me.S86lblDrinks.Name = "S86lblDrinks"
        Me.S86lblDrinks.Size = New System.Drawing.Size(114, 13)
        Me.S86lblDrinks.TabIndex = 2
        Me.S86lblDrinks.Text = "How many soft drinks?"
        '
        'S86lstBox
        '
        Me.S86lstBox.FormattingEnabled = True
        Me.S86lstBox.Location = New System.Drawing.Point(83, 187)
        Me.S86lstBox.Name = "S86lstBox"
        Me.S86lstBox.Size = New System.Drawing.Size(379, 160)
        Me.S86lstBox.TabIndex = 3
        '
        'S86btnTotal
        '
        Me.S86btnTotal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.S86btnTotal.Location = New System.Drawing.Point(298, 54)
        Me.S86btnTotal.Name = "S86btnTotal"
        Me.S86btnTotal.Size = New System.Drawing.Size(164, 103)
        Me.S86btnTotal.TabIndex = 4
        Me.S86btnTotal.Text = "Compute Total Cost"
        Me.S86btnTotal.UseVisualStyleBackColor = False
        '
        'S86txtBoxSlices
        '
        Me.S86txtBoxSlices.Location = New System.Drawing.Point(205, 54)
        Me.S86txtBoxSlices.Name = "S86txtBoxSlices"
        Me.S86txtBoxSlices.Size = New System.Drawing.Size(64, 20)
        Me.S86txtBoxSlices.TabIndex = 5
        Me.S86txtBoxSlices.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86txtBoxFries
        '
        Me.S86txtBoxFries.Location = New System.Drawing.Point(205, 99)
        Me.S86txtBoxFries.Name = "S86txtBoxFries"
        Me.S86txtBoxFries.Size = New System.Drawing.Size(64, 20)
        Me.S86txtBoxFries.TabIndex = 6
        Me.S86txtBoxFries.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86txtBoxDrinks
        '
        Me.S86txtBoxDrinks.Location = New System.Drawing.Point(205, 144)
        Me.S86txtBoxDrinks.Name = "S86txtBoxDrinks"
        Me.S86txtBoxDrinks.Size = New System.Drawing.Size(64, 20)
        Me.S86txtBoxDrinks.TabIndex = 7
        Me.S86txtBoxDrinks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86YEarnestProj5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 395)
        Me.Controls.Add(Me.S86txtBoxDrinks)
        Me.Controls.Add(Me.S86txtBoxFries)
        Me.Controls.Add(Me.S86txtBoxSlices)
        Me.Controls.Add(Me.S86btnTotal)
        Me.Controls.Add(Me.S86lstBox)
        Me.Controls.Add(Me.S86lblDrinks)
        Me.Controls.Add(Me.S86lblFries)
        Me.Controls.Add(Me.S86lblSlice)
        Me.Name = "S86YEarnestProj5"
        Me.Text = "Restaurant Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents S86lblSlice As System.Windows.Forms.Label
    Friend WithEvents S86lblFries As System.Windows.Forms.Label
    Friend WithEvents S86lblDrinks As System.Windows.Forms.Label
    Friend WithEvents S86lstBox As System.Windows.Forms.ListBox
    Friend WithEvents S86btnTotal As System.Windows.Forms.Button
    Friend WithEvents S86txtBoxSlices As System.Windows.Forms.TextBox
    Friend WithEvents S86txtBoxFries As System.Windows.Forms.TextBox
    Friend WithEvents S86txtBoxDrinks As System.Windows.Forms.TextBox

End Class
