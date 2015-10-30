<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S86YEarnestProj6
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
        Me.S86lBox = New System.Windows.Forms.ListBox()
        Me.S86btnSL = New System.Windows.Forms.Button()
        Me.S86btnDDB = New System.Windows.Forms.Button()
        Me.S86txtItem = New System.Windows.Forms.TextBox()
        Me.S86txtCost = New System.Windows.Forms.TextBox()
        Me.S86txtPurchase = New System.Windows.Forms.TextBox()
        Me.S86txtlife = New System.Windows.Forms.TextBox()
        Me.S86lblItem = New System.Windows.Forms.Label()
        Me.S86lblCost = New System.Windows.Forms.Label()
        Me.S86lblPurchase = New System.Windows.Forms.Label()
        Me.S86lbllife = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'S86lBox
        '
        Me.S86lBox.FormattingEnabled = True
        Me.S86lBox.Location = New System.Drawing.Point(12, 239)
        Me.S86lBox.Name = "S86lBox"
        Me.S86lBox.Size = New System.Drawing.Size(503, 186)
        Me.S86lBox.TabIndex = 0
        '
        'S86btnSL
        '
        Me.S86btnSL.Location = New System.Drawing.Point(49, 115)
        Me.S86btnSL.Name = "S86btnSL"
        Me.S86btnSL.Size = New System.Drawing.Size(418, 37)
        Me.S86btnSL.TabIndex = 1
        Me.S86btnSL.Text = "Straight-Line Method"
        Me.S86btnSL.UseVisualStyleBackColor = True
        '
        'S86btnDDB
        '
        Me.S86btnDDB.Location = New System.Drawing.Point(49, 171)
        Me.S86btnDDB.Name = "S86btnDDB"
        Me.S86btnDDB.Size = New System.Drawing.Size(418, 39)
        Me.S86btnDDB.TabIndex = 2
        Me.S86btnDDB.Text = "Double-Declining-Balance Method"
        Me.S86btnDDB.UseVisualStyleBackColor = True
        '
        'S86txtItem
        '
        Me.S86txtItem.Location = New System.Drawing.Point(130, 31)
        Me.S86txtItem.Name = "S86txtItem"
        Me.S86txtItem.Size = New System.Drawing.Size(86, 20)
        Me.S86txtItem.TabIndex = 3
        '
        'S86txtCost
        '
        Me.S86txtCost.Location = New System.Drawing.Point(326, 31)
        Me.S86txtCost.Name = "S86txtCost"
        Me.S86txtCost.Size = New System.Drawing.Size(100, 20)
        Me.S86txtCost.TabIndex = 4
        Me.S86txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86txtPurchase
        '
        Me.S86txtPurchase.Location = New System.Drawing.Point(143, 76)
        Me.S86txtPurchase.Name = "S86txtPurchase"
        Me.S86txtPurchase.Size = New System.Drawing.Size(86, 20)
        Me.S86txtPurchase.TabIndex = 5
        Me.S86txtPurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86txtlife
        '
        Me.S86txtlife.Location = New System.Drawing.Point(413, 76)
        Me.S86txtlife.Name = "S86txtlife"
        Me.S86txtlife.Size = New System.Drawing.Size(31, 20)
        Me.S86txtlife.TabIndex = 6
        Me.S86txtlife.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86lblItem
        '
        Me.S86lblItem.AutoSize = True
        Me.S86lblItem.Location = New System.Drawing.Point(74, 34)
        Me.S86lblItem.Name = "S86lblItem"
        Me.S86lblItem.Size = New System.Drawing.Size(30, 13)
        Me.S86lblItem.TabIndex = 7
        Me.S86lblItem.Text = "Item:"
        '
        'S86lblCost
        '
        Me.S86lblCost.AutoSize = True
        Me.S86lblCost.Location = New System.Drawing.Point(269, 37)
        Me.S86lblCost.Name = "S86lblCost"
        Me.S86lblCost.Size = New System.Drawing.Size(31, 13)
        Me.S86lblCost.TabIndex = 8
        Me.S86lblCost.Text = "Cost:"
        '
        'S86lblPurchase
        '
        Me.S86lblPurchase.AutoSize = True
        Me.S86lblPurchase.Location = New System.Drawing.Point(46, 80)
        Me.S86lblPurchase.Name = "S86lblPurchase"
        Me.S86lblPurchase.Size = New System.Drawing.Size(91, 13)
        Me.S86lblPurchase.TabIndex = 9
        Me.S86lblPurchase.Text = "Year of purchase:"
        '
        'S86lbllife
        '
        Me.S86lbllife.AutoSize = True
        Me.S86lbllife.Location = New System.Drawing.Point(269, 80)
        Me.S86lbllife.Name = "S86lbllife"
        Me.S86lbllife.Size = New System.Drawing.Size(141, 13)
        Me.S86lbllife.TabIndex = 10
        Me.S86lbllife.Text = "Estimated life of Item (years):"
        '
        'S86YEarnestProj6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 437)
        Me.Controls.Add(Me.S86lbllife)
        Me.Controls.Add(Me.S86lblPurchase)
        Me.Controls.Add(Me.S86lblCost)
        Me.Controls.Add(Me.S86lblItem)
        Me.Controls.Add(Me.S86txtlife)
        Me.Controls.Add(Me.S86txtPurchase)
        Me.Controls.Add(Me.S86txtCost)
        Me.Controls.Add(Me.S86txtItem)
        Me.Controls.Add(Me.S86btnDDB)
        Me.Controls.Add(Me.S86btnSL)
        Me.Controls.Add(Me.S86lBox)
        Me.Name = "S86YEarnestProj6"
        Me.Text = "Depreciation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents S86lBox As System.Windows.Forms.ListBox
    Friend WithEvents S86btnSL As System.Windows.Forms.Button
    Friend WithEvents S86btnDDB As System.Windows.Forms.Button
    Friend WithEvents S86txtItem As System.Windows.Forms.TextBox
    Friend WithEvents S86txtCost As System.Windows.Forms.TextBox
    Friend WithEvents S86txtPurchase As System.Windows.Forms.TextBox
    Friend WithEvents S86txtlife As System.Windows.Forms.TextBox
    Friend WithEvents S86lblItem As System.Windows.Forms.Label
    Friend WithEvents S86lblCost As System.Windows.Forms.Label
    Friend WithEvents S86lblPurchase As System.Windows.Forms.Label
    Friend WithEvents S86lbllife As System.Windows.Forms.Label

End Class
