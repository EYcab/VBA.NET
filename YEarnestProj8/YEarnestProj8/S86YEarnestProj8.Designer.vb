<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class S86YEarnestProj8
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
        Me.S86lbl = New System.Windows.Forms.Label()
        Me.S86btnNew = New System.Windows.Forms.Button()
        Me.S86lboxDirectory = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.S86lbl2 = New System.Windows.Forms.Label()
        Me.S86lblName = New System.Windows.Forms.Label()
        Me.S86lblNumber = New System.Windows.Forms.Label()
        Me.S86txtDirectory = New System.Windows.Forms.TextBox()
        Me.S86txtboxName = New System.Windows.Forms.TextBox()
        Me.S86txtBoxNumber = New System.Windows.Forms.TextBox()
        Me.S86btnAdd = New System.Windows.Forms.Button()
        Me.S86btnRemove = New System.Windows.Forms.Button()
        Me.S86btnDisplay = New System.Windows.Forms.Button()
        Me.S86DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.S86DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'S86lbl
        '
        Me.S86lbl.AutoSize = True
        Me.S86lbl.Location = New System.Drawing.Point(38, 26)
        Me.S86lbl.Name = "S86lbl"
        Me.S86lbl.Size = New System.Drawing.Size(221, 26)
        Me.S86lbl.TabIndex = 0
        Me.S86lbl.Text = "Click on one of the existing phone directories " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "below to make it the current pho" & _
    "ne directory."
        '
        'S86btnNew
        '
        Me.S86btnNew.Location = New System.Drawing.Point(265, 26)
        Me.S86btnNew.Name = "S86btnNew"
        Me.S86btnNew.Size = New System.Drawing.Size(165, 32)
        Me.S86btnNew.TabIndex = 1
        Me.S86btnNew.Text = "Create a New Phone Directory"
        Me.S86btnNew.UseVisualStyleBackColor = True
        '
        'S86lboxDirectory
        '
        Me.S86lboxDirectory.FormattingEnabled = True
        Me.S86lboxDirectory.Location = New System.Drawing.Point(41, 77)
        Me.S86lboxDirectory.Name = "S86lboxDirectory"
        Me.S86lboxDirectory.Size = New System.Drawing.Size(159, 108)
        Me.S86lboxDirectory.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Phone Directories"
        '
        'S86lbl2
        '
        Me.S86lbl2.AutoSize = True
        Me.S86lbl2.Location = New System.Drawing.Point(206, 83)
        Me.S86lbl2.Name = "S86lbl2"
        Me.S86lbl2.Size = New System.Drawing.Size(121, 13)
        Me.S86lbl2.TabIndex = 4
        Me.S86lbl2.Text = "Current Phone directory:"
        '
        'S86lblName
        '
        Me.S86lblName.AutoSize = True
        Me.S86lblName.Location = New System.Drawing.Point(206, 120)
        Me.S86lblName.Name = "S86lblName"
        Me.S86lblName.Size = New System.Drawing.Size(38, 13)
        Me.S86lblName.TabIndex = 5
        Me.S86lblName.Text = "Name:"
        '
        'S86lblNumber
        '
        Me.S86lblNumber.AutoSize = True
        Me.S86lblNumber.Location = New System.Drawing.Point(206, 162)
        Me.S86lblNumber.Name = "S86lblNumber"
        Me.S86lblNumber.Size = New System.Drawing.Size(81, 13)
        Me.S86lblNumber.TabIndex = 6
        Me.S86lblNumber.Text = "Phone Number:"
        '
        'S86txtDirectory
        '
        Me.S86txtDirectory.Location = New System.Drawing.Point(333, 80)
        Me.S86txtDirectory.Name = "S86txtDirectory"
        Me.S86txtDirectory.Size = New System.Drawing.Size(100, 20)
        Me.S86txtDirectory.TabIndex = 7
        '
        'S86txtboxName
        '
        Me.S86txtboxName.Location = New System.Drawing.Point(250, 117)
        Me.S86txtboxName.Name = "S86txtboxName"
        Me.S86txtboxName.Size = New System.Drawing.Size(207, 20)
        Me.S86txtboxName.TabIndex = 8
        Me.S86txtboxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86txtBoxNumber
        '
        Me.S86txtBoxNumber.Location = New System.Drawing.Point(293, 159)
        Me.S86txtBoxNumber.Name = "S86txtBoxNumber"
        Me.S86txtBoxNumber.Size = New System.Drawing.Size(149, 20)
        Me.S86txtBoxNumber.TabIndex = 9
        Me.S86txtBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86btnAdd
        '
        Me.S86btnAdd.Location = New System.Drawing.Point(41, 214)
        Me.S86btnAdd.Name = "S86btnAdd"
        Me.S86btnAdd.Size = New System.Drawing.Size(121, 39)
        Me.S86btnAdd.TabIndex = 10
        Me.S86btnAdd.Text = "Adding a list to the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "current Directory"
        Me.S86btnAdd.UseVisualStyleBackColor = True
        '
        'S86btnRemove
        '
        Me.S86btnRemove.Location = New System.Drawing.Point(198, 214)
        Me.S86btnRemove.Name = "S86btnRemove"
        Me.S86btnRemove.Size = New System.Drawing.Size(111, 39)
        Me.S86btnRemove.TabIndex = 11
        Me.S86btnRemove.Text = "Remove a listing from the Current Directory"
        Me.S86btnRemove.UseVisualStyleBackColor = True
        '
        'S86btnDisplay
        '
        Me.S86btnDisplay.Location = New System.Drawing.Point(346, 206)
        Me.S86btnDisplay.Name = "S86btnDisplay"
        Me.S86btnDisplay.Size = New System.Drawing.Size(111, 55)
        Me.S86btnDisplay.TabIndex = 12
        Me.S86btnDisplay.Text = "Display the listings in the Current Directory"
        Me.S86btnDisplay.UseVisualStyleBackColor = True
        '
        'S86DataGridView1
        '
        Me.S86DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.S86DataGridView1.Location = New System.Drawing.Point(41, 275)
        Me.S86DataGridView1.Name = "S86DataGridView1"
        Me.S86DataGridView1.Size = New System.Drawing.Size(439, 192)
        Me.S86DataGridView1.TabIndex = 13
        '
        'S86YEarnestProj8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 479)
        Me.Controls.Add(Me.S86DataGridView1)
        Me.Controls.Add(Me.S86btnDisplay)
        Me.Controls.Add(Me.S86btnRemove)
        Me.Controls.Add(Me.S86btnAdd)
        Me.Controls.Add(Me.S86txtBoxNumber)
        Me.Controls.Add(Me.S86txtboxName)
        Me.Controls.Add(Me.S86txtDirectory)
        Me.Controls.Add(Me.S86lblNumber)
        Me.Controls.Add(Me.S86lblName)
        Me.Controls.Add(Me.S86lbl2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.S86lboxDirectory)
        Me.Controls.Add(Me.S86btnNew)
        Me.Controls.Add(Me.S86lbl)
        Me.Name = "S86YEarnestProj8"
        Me.Text = "Create and Maintain Telephone Directories "
        CType(Me.S86DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents S86lbl As System.Windows.Forms.Label
    Friend WithEvents S86btnNew As System.Windows.Forms.Button
    Friend WithEvents S86lboxDirectory As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents S86lbl2 As System.Windows.Forms.Label
    Friend WithEvents S86lblName As System.Windows.Forms.Label
    Friend WithEvents S86lblNumber As System.Windows.Forms.Label
    Friend WithEvents S86txtDirectory As System.Windows.Forms.TextBox
    Friend WithEvents S86txtboxName As System.Windows.Forms.TextBox
    Friend WithEvents S86txtBoxNumber As System.Windows.Forms.TextBox
    Friend WithEvents S86btnAdd As System.Windows.Forms.Button
    Friend WithEvents S86btnRemove As System.Windows.Forms.Button
    Friend WithEvents S86btnDisplay As System.Windows.Forms.Button
    Friend WithEvents S86DataGridView1 As System.Windows.Forms.DataGridView

End Class
