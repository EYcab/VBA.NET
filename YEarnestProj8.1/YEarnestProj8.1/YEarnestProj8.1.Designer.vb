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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.S86lbl1 = New System.Windows.Forms.Label()
        Me.S86btnCreate = New System.Windows.Forms.Button()
        Me.S86lboxDirectory = New System.Windows.Forms.ListBox()
        Me.S86lblDirectory = New System.Windows.Forms.Label()
        Me.S86lblName = New System.Windows.Forms.Label()
        Me.S86lblNumber = New System.Windows.Forms.Label()
        Me.S86DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.S86btnAdd = New System.Windows.Forms.Button()
        Me.S86btnRemove = New System.Windows.Forms.Button()
        Me.S86btnDisplay = New System.Windows.Forms.Button()
        Me.S86txtDirectory = New System.Windows.Forms.TextBox()
        Me.S86txtName = New System.Windows.Forms.TextBox()
        Me.S86txtNumber = New System.Windows.Forms.TextBox()
        CType(Me.S86DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'S86lbl1
        '
        Me.S86lbl1.AutoSize = True
        Me.S86lbl1.Location = New System.Drawing.Point(12, 24)
        Me.S86lbl1.Name = "S86lbl1"
        Me.S86lbl1.Size = New System.Drawing.Size(220, 26)
        Me.S86lbl1.TabIndex = 0
        Me.S86lbl1.Text = "Click on one of the existing phone directories" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "below to make it the current phon" & _
    "e directory. "
        '
        'S86btnCreate
        '
        Me.S86btnCreate.Location = New System.Drawing.Point(260, 24)
        Me.S86btnCreate.Name = "S86btnCreate"
        Me.S86btnCreate.Size = New System.Drawing.Size(200, 37)
        Me.S86btnCreate.TabIndex = 1
        Me.S86btnCreate.Text = "Create a New Phone Directory"
        Me.S86btnCreate.UseVisualStyleBackColor = True
        '
        'S86lboxDirectory
        '
        Me.S86lboxDirectory.FormattingEnabled = True
        Me.S86lboxDirectory.Location = New System.Drawing.Point(15, 71)
        Me.S86lboxDirectory.Name = "S86lboxDirectory"
        Me.S86lboxDirectory.Size = New System.Drawing.Size(186, 95)
        Me.S86lboxDirectory.TabIndex = 2
        '
        'S86lblDirectory
        '
        Me.S86lblDirectory.AutoSize = True
        Me.S86lblDirectory.Location = New System.Drawing.Point(211, 78)
        Me.S86lblDirectory.Name = "S86lblDirectory"
        Me.S86lblDirectory.Size = New System.Drawing.Size(120, 13)
        Me.S86lblDirectory.TabIndex = 3
        Me.S86lblDirectory.Text = "Current phone directory:"
        '
        'S86lblName
        '
        Me.S86lblName.AutoSize = True
        Me.S86lblName.Location = New System.Drawing.Point(241, 109)
        Me.S86lblName.Name = "S86lblName"
        Me.S86lblName.Size = New System.Drawing.Size(38, 13)
        Me.S86lblName.TabIndex = 4
        Me.S86lblName.Text = "Name:"
        '
        'S86lblNumber
        '
        Me.S86lblNumber.AutoSize = True
        Me.S86lblNumber.Location = New System.Drawing.Point(224, 145)
        Me.S86lblNumber.Name = "S86lblNumber"
        Me.S86lblNumber.Size = New System.Drawing.Size(79, 13)
        Me.S86lblNumber.TabIndex = 5
        Me.S86lblNumber.Text = "Phone number:"
        '
        'S86DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.S86DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.S86DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.S86DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.S86DataGridView1.Location = New System.Drawing.Point(122, 265)
        Me.S86DataGridView1.Name = "S86DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.S86DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.S86DataGridView1.Size = New System.Drawing.Size(278, 103)
        Me.S86DataGridView1.TabIndex = 6
        '
        'S86btnAdd
        '
        Me.S86btnAdd.Location = New System.Drawing.Point(33, 195)
        Me.S86btnAdd.Name = "S86btnAdd"
        Me.S86btnAdd.Size = New System.Drawing.Size(120, 38)
        Me.S86btnAdd.TabIndex = 7
        Me.S86btnAdd.Text = "Add a listing to the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Currect Directory" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.S86btnAdd.UseVisualStyleBackColor = True
        '
        'S86btnRemove
        '
        Me.S86btnRemove.Location = New System.Drawing.Point(181, 195)
        Me.S86btnRemove.Name = "S86btnRemove"
        Me.S86btnRemove.Size = New System.Drawing.Size(122, 38)
        Me.S86btnRemove.TabIndex = 8
        Me.S86btnRemove.Text = "Remove a Listing from" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the Current Directory" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.S86btnRemove.UseVisualStyleBackColor = True
        '
        'S86btnDisplay
        '
        Me.S86btnDisplay.Location = New System.Drawing.Point(337, 195)
        Me.S86btnDisplay.Name = "S86btnDisplay"
        Me.S86btnDisplay.Size = New System.Drawing.Size(123, 38)
        Me.S86btnDisplay.TabIndex = 9
        Me.S86btnDisplay.Text = "Display the Listings in " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the Current Directory" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.S86btnDisplay.UseVisualStyleBackColor = True
        '
        'S86txtDirectory
        '
        Me.S86txtDirectory.Location = New System.Drawing.Point(337, 75)
        Me.S86txtDirectory.Name = "S86txtDirectory"
        Me.S86txtDirectory.Size = New System.Drawing.Size(100, 20)
        Me.S86txtDirectory.TabIndex = 10
        '
        'S86txtName
        '
        Me.S86txtName.Location = New System.Drawing.Point(296, 106)
        Me.S86txtName.Name = "S86txtName"
        Me.S86txtName.Size = New System.Drawing.Size(193, 20)
        Me.S86txtName.TabIndex = 11
        '
        'S86txtNumber
        '
        Me.S86txtNumber.Location = New System.Drawing.Point(337, 142)
        Me.S86txtNumber.Name = "S86txtNumber"
        Me.S86txtNumber.Size = New System.Drawing.Size(100, 20)
        Me.S86txtNumber.TabIndex = 12
        Me.S86txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'S86Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 451)
        Me.Controls.Add(Me.S86txtNumber)
        Me.Controls.Add(Me.S86txtName)
        Me.Controls.Add(Me.S86txtDirectory)
        Me.Controls.Add(Me.S86btnDisplay)
        Me.Controls.Add(Me.S86btnRemove)
        Me.Controls.Add(Me.S86btnAdd)
        Me.Controls.Add(Me.S86DataGridView1)
        Me.Controls.Add(Me.S86lblNumber)
        Me.Controls.Add(Me.S86lblName)
        Me.Controls.Add(Me.S86lblDirectory)
        Me.Controls.Add(Me.S86lboxDirectory)
        Me.Controls.Add(Me.S86btnCreate)
        Me.Controls.Add(Me.S86lbl1)
        Me.Name = "S86Frm"
        Me.Text = "Create and Maintain Telephone Directories"
        CType(Me.S86DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents S86lbl1 As System.Windows.Forms.Label
    Friend WithEvents S86btnCreate As System.Windows.Forms.Button
    Friend WithEvents S86lboxDirectory As System.Windows.Forms.ListBox
    Friend WithEvents S86lblDirectory As System.Windows.Forms.Label
    Friend WithEvents S86lblName As System.Windows.Forms.Label
    Friend WithEvents S86lblNumber As System.Windows.Forms.Label
    Friend WithEvents S86DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents S86btnAdd As System.Windows.Forms.Button
    Friend WithEvents S86btnRemove As System.Windows.Forms.Button
    Friend WithEvents S86btnDisplay As System.Windows.Forms.Button
    Friend WithEvents S86txtDirectory As System.Windows.Forms.TextBox
    Friend WithEvents S86txtName As System.Windows.Forms.TextBox
    Friend WithEvents S86txtNumber As System.Windows.Forms.TextBox

End Class
