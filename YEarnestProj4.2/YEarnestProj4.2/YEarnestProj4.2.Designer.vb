<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.S86chkBurgers = New System.Windows.Forms.CheckBox()
        Me.S86chkFries = New System.Windows.Forms.CheckBox()
        Me.S86chkDrinks = New System.Windows.Forms.CheckBox()
        Me.S86grpBurgers = New System.Windows.Forms.GroupBox()
        Me.S86radbacon = New System.Windows.Forms.RadioButton()
        Me.S86radCheese = New System.Windows.Forms.RadioButton()
        Me.S86radBoth = New System.Windows.Forms.RadioButton()
        Me.S86radRegular = New System.Windows.Forms.RadioButton()
        Me.S86grpFries = New System.Windows.Forms.GroupBox()
        Me.S86radMedium = New System.Windows.Forms.RadioButton()
        Me.S86radSmall = New System.Windows.Forms.RadioButton()
        Me.S86radLarge = New System.Windows.Forms.RadioButton()
        Me.S86grpDrinks = New System.Windows.Forms.GroupBox()
        Me.S86radWater = New System.Windows.Forms.RadioButton()
        Me.S86radSoda = New System.Windows.Forms.RadioButton()
        Me.S86btn = New System.Windows.Forms.Button()
        Me.S86lbl = New System.Windows.Forms.Label()
        Me.S86txt = New System.Windows.Forms.TextBox()
        Me.S86grpBurgers.SuspendLayout()
        Me.S86grpFries.SuspendLayout()
        Me.S86grpDrinks.SuspendLayout()
        Me.SuspendLayout()
        '
        'S86chkBurgers
        '
        Me.S86chkBurgers.AutoSize = True
        Me.S86chkBurgers.Location = New System.Drawing.Point(39, 65)
        Me.S86chkBurgers.Name = "S86chkBurgers"
        Me.S86chkBurgers.Size = New System.Drawing.Size(62, 17)
        Me.S86chkBurgers.TabIndex = 0
        Me.S86chkBurgers.Text = "Burgers"
        Me.S86chkBurgers.UseVisualStyleBackColor = True
        '
        'S86chkFries
        '
        Me.S86chkFries.AutoSize = True
        Me.S86chkFries.Location = New System.Drawing.Point(39, 199)
        Me.S86chkFries.Name = "S86chkFries"
        Me.S86chkFries.Size = New System.Drawing.Size(48, 17)
        Me.S86chkFries.TabIndex = 1
        Me.S86chkFries.Text = "Fries"
        Me.S86chkFries.UseVisualStyleBackColor = True
        '
        'S86chkDrinks
        '
        Me.S86chkDrinks.AutoSize = True
        Me.S86chkDrinks.Location = New System.Drawing.Point(39, 353)
        Me.S86chkDrinks.Name = "S86chkDrinks"
        Me.S86chkDrinks.Size = New System.Drawing.Size(56, 17)
        Me.S86chkDrinks.TabIndex = 2
        Me.S86chkDrinks.Text = "Drinks"
        Me.S86chkDrinks.UseVisualStyleBackColor = True
        '
        'S86grpBurgers
        '
        Me.S86grpBurgers.Controls.Add(Me.S86radbacon)
        Me.S86grpBurgers.Controls.Add(Me.S86radCheese)
        Me.S86grpBurgers.Controls.Add(Me.S86radBoth)
        Me.S86grpBurgers.Controls.Add(Me.S86radRegular)
        Me.S86grpBurgers.Location = New System.Drawing.Point(174, 30)
        Me.S86grpBurgers.Name = "S86grpBurgers"
        Me.S86grpBurgers.Size = New System.Drawing.Size(200, 119)
        Me.S86grpBurgers.TabIndex = 3
        Me.S86grpBurgers.TabStop = False
        Me.S86grpBurgers.Text = "Choices for Burgers "
        '
        'S86radbacon
        '
        Me.S86radbacon.AutoSize = True
        Me.S86radbacon.Location = New System.Drawing.Point(23, 68)
        Me.S86radbacon.Name = "S86radbacon"
        Me.S86radbacon.Size = New System.Drawing.Size(101, 17)
        Me.S86radbacon.TabIndex = 2
        Me.S86radbacon.TabStop = True
        Me.S86radbacon.Text = "w/ bacon (4.79)"
        Me.S86radbacon.UseVisualStyleBackColor = True
        '
        'S86radCheese
        '
        Me.S86radCheese.AutoSize = True
        Me.S86radCheese.Location = New System.Drawing.Point(23, 44)
        Me.S86radCheese.Name = "S86radCheese"
        Me.S86radCheese.Size = New System.Drawing.Size(106, 17)
        Me.S86radCheese.TabIndex = 1
        Me.S86radCheese.TabStop = True
        Me.S86radCheese.Text = "w/ cheese (4.79)"
        Me.S86radCheese.UseVisualStyleBackColor = True
        '
        'S86radBoth
        '
        Me.S86radBoth.AutoSize = True
        Me.S86radBoth.Location = New System.Drawing.Point(23, 92)
        Me.S86radBoth.Name = "S86radBoth"
        Me.S86radBoth.Size = New System.Drawing.Size(160, 17)
        Me.S86radBoth.TabIndex = 0
        Me.S86radBoth.TabStop = True
        Me.S86radBoth.Text = "w/ bacon and cheese (5.39)"
        Me.S86radBoth.UseVisualStyleBackColor = True
        '
        'S86radRegular
        '
        Me.S86radRegular.AutoSize = True
        Me.S86radRegular.Location = New System.Drawing.Point(23, 20)
        Me.S86radRegular.Name = "S86radRegular"
        Me.S86radRegular.Size = New System.Drawing.Size(92, 17)
        Me.S86radRegular.TabIndex = 0
        Me.S86radRegular.TabStop = True
        Me.S86radRegular.Text = "Regular (4.19)"
        Me.S86radRegular.UseVisualStyleBackColor = True
        '
        'S86grpFries
        '
        Me.S86grpFries.Controls.Add(Me.S86radMedium)
        Me.S86grpFries.Controls.Add(Me.S86radSmall)
        Me.S86grpFries.Controls.Add(Me.S86radLarge)
        Me.S86grpFries.Location = New System.Drawing.Point(174, 167)
        Me.S86grpFries.Name = "S86grpFries"
        Me.S86grpFries.Size = New System.Drawing.Size(200, 123)
        Me.S86grpFries.TabIndex = 4
        Me.S86grpFries.TabStop = False
        Me.S86grpFries.Text = "Choices for Fries"
        '
        'S86radMedium
        '
        Me.S86radMedium.AutoSize = True
        Me.S86radMedium.Location = New System.Drawing.Point(23, 68)
        Me.S86radMedium.Name = "S86radMedium"
        Me.S86radMedium.Size = New System.Drawing.Size(89, 17)
        Me.S86radMedium.TabIndex = 2
        Me.S86radMedium.TabStop = True
        Me.S86radMedium.Text = "Medium(3.09)"
        Me.S86radMedium.UseVisualStyleBackColor = True
        '
        'S86radSmall
        '
        Me.S86radSmall.AutoSize = True
        Me.S86radSmall.Location = New System.Drawing.Point(23, 44)
        Me.S86radSmall.Name = "S86radSmall"
        Me.S86radSmall.Size = New System.Drawing.Size(77, 17)
        Me.S86radSmall.TabIndex = 1
        Me.S86radSmall.TabStop = True
        Me.S86radSmall.Text = "Small(2.39)"
        Me.S86radSmall.UseVisualStyleBackColor = True
        '
        'S86radLarge
        '
        Me.S86radLarge.AutoSize = True
        Me.S86radLarge.Location = New System.Drawing.Point(23, 91)
        Me.S86radLarge.Name = "S86radLarge"
        Me.S86radLarge.Size = New System.Drawing.Size(79, 17)
        Me.S86radLarge.TabIndex = 0
        Me.S86radLarge.TabStop = True
        Me.S86radLarge.Text = "Large(4.99)"
        Me.S86radLarge.UseVisualStyleBackColor = True
        '
        'S86grpDrinks
        '
        Me.S86grpDrinks.Controls.Add(Me.S86radWater)
        Me.S86grpDrinks.Controls.Add(Me.S86radSoda)
        Me.S86grpDrinks.Location = New System.Drawing.Point(174, 312)
        Me.S86grpDrinks.Name = "S86grpDrinks"
        Me.S86grpDrinks.Size = New System.Drawing.Size(200, 100)
        Me.S86grpDrinks.TabIndex = 5
        Me.S86grpDrinks.TabStop = False
        Me.S86grpDrinks.Text = "Choices for Drinks"
        '
        'S86radWater
        '
        Me.S86radWater.AutoSize = True
        Me.S86radWater.Location = New System.Drawing.Point(23, 54)
        Me.S86radWater.Name = "S86radWater"
        Me.S86radWater.Size = New System.Drawing.Size(114, 17)
        Me.S86radWater.TabIndex = 3
        Me.S86radWater.TabStop = True
        Me.S86radWater.Text = "Bottled water(1.49)"
        Me.S86radWater.UseVisualStyleBackColor = True
        '
        'S86radSoda
        '
        Me.S86radSoda.AutoSize = True
        Me.S86radSoda.Location = New System.Drawing.Point(23, 31)
        Me.S86radSoda.Name = "S86radSoda"
        Me.S86radSoda.Size = New System.Drawing.Size(77, 17)
        Me.S86radSoda.TabIndex = 1
        Me.S86radSoda.TabStop = True
        Me.S86radSoda.Text = "Soda(1.69)"
        Me.S86radSoda.UseVisualStyleBackColor = True
        '
        'S86btn
        '
        Me.S86btn.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.S86btn.Location = New System.Drawing.Point(440, 312)
        Me.S86btn.Name = "S86btn"
        Me.S86btn.Size = New System.Drawing.Size(206, 58)
        Me.S86btn.TabIndex = 3
        Me.S86btn.Text = "Compute Cost of Meal"
        Me.S86btn.UseVisualStyleBackColor = False
        '
        'S86lbl
        '
        Me.S86lbl.AutoSize = True
        Me.S86lbl.Location = New System.Drawing.Point(439, 413)
        Me.S86lbl.Name = "S86lbl"
        Me.S86lbl.Size = New System.Drawing.Size(68, 13)
        Me.S86lbl.TabIndex = 6
        Me.S86lbl.Text = "Cost of meal:"
        '
        'S86txt
        '
        Me.S86txt.Location = New System.Drawing.Point(513, 410)
        Me.S86txt.Name = "S86txt"
        Me.S86txt.Size = New System.Drawing.Size(110, 20)
        Me.S86txt.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 473)
        Me.Controls.Add(Me.S86txt)
        Me.Controls.Add(Me.S86lbl)
        Me.Controls.Add(Me.S86btn)
        Me.Controls.Add(Me.S86grpDrinks)
        Me.Controls.Add(Me.S86grpFries)
        Me.Controls.Add(Me.S86grpBurgers)
        Me.Controls.Add(Me.S86chkDrinks)
        Me.Controls.Add(Me.S86chkFries)
        Me.Controls.Add(Me.S86chkBurgers)
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.S86grpBurgers.ResumeLayout(False)
        Me.S86grpBurgers.PerformLayout()
        Me.S86grpFries.ResumeLayout(False)
        Me.S86grpFries.PerformLayout()
        Me.S86grpDrinks.ResumeLayout(False)
        Me.S86grpDrinks.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents S86chkBurgers As System.Windows.Forms.CheckBox
    Friend WithEvents S86chkFries As System.Windows.Forms.CheckBox
    Friend WithEvents S86chkDrinks As System.Windows.Forms.CheckBox
    Friend WithEvents S86grpBurgers As System.Windows.Forms.GroupBox
    Friend WithEvents S86radbacon As System.Windows.Forms.RadioButton
    Friend WithEvents S86radCheese As System.Windows.Forms.RadioButton
    Friend WithEvents S86radRegular As System.Windows.Forms.RadioButton
    Friend WithEvents S86grpFries As System.Windows.Forms.GroupBox
    Friend WithEvents S86radMedium As System.Windows.Forms.RadioButton
    Friend WithEvents S86radSmall As System.Windows.Forms.RadioButton
    Friend WithEvents S86radBoth As System.Windows.Forms.RadioButton
    Friend WithEvents S86grpDrinks As System.Windows.Forms.GroupBox
    Friend WithEvents S86radSoda As System.Windows.Forms.RadioButton
    Friend WithEvents S86radLarge As System.Windows.Forms.RadioButton
    Friend WithEvents S86btn As System.Windows.Forms.Button
    Friend WithEvents S86lbl As System.Windows.Forms.Label
    Friend WithEvents S86txt As System.Windows.Forms.TextBox
    Friend WithEvents S86radWater As System.Windows.Forms.RadioButton

End Class
