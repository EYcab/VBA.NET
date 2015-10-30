<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TSFinalProject
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TSFinalProject))
        Me.TSnvgGradeBook = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TSGradeBookGrades = New System.Windows.Forms.BindingSource(Me.components)
        Me.TSGradebookDataSet = New WindowsApplication1.GradebookDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSbtnUpdate = New System.Windows.Forms.ToolStripButton()
        Me.GradesTableAdapter = New WindowsApplication1.GradebookDataSetTableAdapters.GradesTableAdapter()
        Me.TSGradeBookStudent = New System.Windows.Forms.BindingSource(Me.components)
        Me.GradebookDataSet = New WindowsApplication1.GradebookDataSet()
        Me.StudentsTableAdapter = New WindowsApplication1.GradebookDataSetTableAdapters.StudentsTableAdapter()
        Me.TSbtnDisplay = New System.Windows.Forms.Button()
        Me.TStxtBoxStudentID = New System.Windows.Forms.TextBox()
        Me.TSdgvGradeBook = New System.Windows.Forms.DataGridView()
        Me.TStxtBoxFirstExam = New System.Windows.Forms.TextBox()
        Me.TStxtBoxSecondExam = New System.Windows.Forms.TextBox()
        Me.TStxtBoxFinalExam = New System.Windows.Forms.TextBox()
        Me.TSlblFinalExam = New System.Windows.Forms.Label()
        Me.TSlblStudentID = New System.Windows.Forms.Label()
        Me.TSlblFirstExam = New System.Windows.Forms.Label()
        Me.TSlblSecondExam = New System.Windows.Forms.Label()
        CType(Me.TSnvgGradeBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TSnvgGradeBook.SuspendLayout()
        CType(Me.TSGradeBookGrades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSGradebookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSGradeBookStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradebookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSdgvGradeBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TSnvgGradeBook
        '
        Me.TSnvgGradeBook.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TSnvgGradeBook.BindingSource = Me.TSGradeBookGrades
        Me.TSnvgGradeBook.CountItem = Me.BindingNavigatorCountItem
        Me.TSnvgGradeBook.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TSnvgGradeBook.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TSbtnUpdate})
        Me.TSnvgGradeBook.Location = New System.Drawing.Point(0, 0)
        Me.TSnvgGradeBook.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TSnvgGradeBook.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TSnvgGradeBook.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TSnvgGradeBook.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TSnvgGradeBook.Name = "TSnvgGradeBook"
        Me.TSnvgGradeBook.PositionItem = Me.BindingNavigatorPositionItem
        Me.TSnvgGradeBook.Size = New System.Drawing.Size(552, 25)
        Me.TSnvgGradeBook.TabIndex = 0
        Me.TSnvgGradeBook.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'TSGradeBookGrades
        '
        Me.TSGradeBookGrades.DataMember = "Grades"
        Me.TSGradeBookGrades.DataSource = Me.TSGradebookDataSet
        '
        'TSGradebookDataSet
        '
        Me.TSGradebookDataSet.DataSetName = "GradebookDataSet"
        Me.TSGradebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TSbtnUpdate
        '
        Me.TSbtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSbtnUpdate.Image = CType(resources.GetObject("TSbtnUpdate.Image"), System.Drawing.Image)
        Me.TSbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSbtnUpdate.Name = "TSbtnUpdate"
        Me.TSbtnUpdate.Size = New System.Drawing.Size(23, 22)
        Me.TSbtnUpdate.Text = "Update"
        Me.TSbtnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GradesTableAdapter
        '
        Me.GradesTableAdapter.ClearBeforeFill = True
        '
        'TSGradeBookStudent
        '
        Me.TSGradeBookStudent.DataMember = "Students"
        Me.TSGradeBookStudent.DataSource = Me.GradebookDataSet
        '
        'GradebookDataSet
        '
        Me.GradebookDataSet.DataSetName = "GradebookDataSet"
        Me.GradebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'TSbtnDisplay
        '
        Me.TSbtnDisplay.Location = New System.Drawing.Point(160, 28)
        Me.TSbtnDisplay.Name = "TSbtnDisplay"
        Me.TSbtnDisplay.Size = New System.Drawing.Size(240, 23)
        Me.TSbtnDisplay.TabIndex = 1
        Me.TSbtnDisplay.Text = "Display Student Grades"
        Me.TSbtnDisplay.UseVisualStyleBackColor = True
        '
        'TStxtBoxStudentID
        '
        Me.TStxtBoxStudentID.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TStxtBoxStudentID.Location = New System.Drawing.Point(80, 71)
        Me.TStxtBoxStudentID.Name = "TStxtBoxStudentID"
        Me.TStxtBoxStudentID.Size = New System.Drawing.Size(62, 20)
        Me.TStxtBoxStudentID.TabIndex = 2
        Me.TStxtBoxStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TSdgvGradeBook
        '
        Me.TSdgvGradeBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TSdgvGradeBook.Location = New System.Drawing.Point(160, 71)
        Me.TSdgvGradeBook.Name = "TSdgvGradeBook"
        Me.TSdgvGradeBook.Size = New System.Drawing.Size(240, 150)
        Me.TSdgvGradeBook.TabIndex = 3
        '
        'TStxtBoxFirstExam
        '
        Me.TStxtBoxFirstExam.Location = New System.Drawing.Point(113, 115)
        Me.TStxtBoxFirstExam.Name = "TStxtBoxFirstExam"
        Me.TStxtBoxFirstExam.Size = New System.Drawing.Size(29, 20)
        Me.TStxtBoxFirstExam.TabIndex = 4
        Me.TStxtBoxFirstExam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TStxtBoxSecondExam
        '
        Me.TStxtBoxSecondExam.Location = New System.Drawing.Point(113, 154)
        Me.TStxtBoxSecondExam.Name = "TStxtBoxSecondExam"
        Me.TStxtBoxSecondExam.Size = New System.Drawing.Size(29, 20)
        Me.TStxtBoxSecondExam.TabIndex = 5
        Me.TStxtBoxSecondExam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TStxtBoxFinalExam
        '
        Me.TStxtBoxFinalExam.Location = New System.Drawing.Point(113, 189)
        Me.TStxtBoxFinalExam.Name = "TStxtBoxFinalExam"
        Me.TStxtBoxFinalExam.Size = New System.Drawing.Size(29, 20)
        Me.TStxtBoxFinalExam.TabIndex = 6
        Me.TStxtBoxFinalExam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TSlblFinalExam
        '
        Me.TSlblFinalExam.AutoSize = True
        Me.TSlblFinalExam.Location = New System.Drawing.Point(12, 189)
        Me.TSlblFinalExam.Name = "TSlblFinalExam"
        Me.TSlblFinalExam.Size = New System.Drawing.Size(58, 13)
        Me.TSlblFinalExam.TabIndex = 7
        Me.TSlblFinalExam.Text = "final Exam:"
        '
        'TSlblStudentID
        '
        Me.TSlblStudentID.AutoSize = True
        Me.TSlblStudentID.Location = New System.Drawing.Point(12, 74)
        Me.TSlblStudentID.Name = "TSlblStudentID"
        Me.TSlblStudentID.Size = New System.Drawing.Size(59, 13)
        Me.TSlblStudentID.TabIndex = 8
        Me.TSlblStudentID.Text = "student ID:"
        '
        'TSlblFirstExam
        '
        Me.TSlblFirstExam.AutoSize = True
        Me.TSlblFirstExam.Location = New System.Drawing.Point(12, 115)
        Me.TSlblFirstExam.Name = "TSlblFirstExam"
        Me.TSlblFirstExam.Size = New System.Drawing.Size(55, 13)
        Me.TSlblFirstExam.TabIndex = 9
        Me.TSlblFirstExam.Text = "first Exam:"
        '
        'TSlblSecondExam
        '
        Me.TSlblSecondExam.AutoSize = True
        Me.TSlblSecondExam.Location = New System.Drawing.Point(12, 154)
        Me.TSlblSecondExam.Name = "TSlblSecondExam"
        Me.TSlblSecondExam.Size = New System.Drawing.Size(74, 13)
        Me.TSlblSecondExam.TabIndex = 10
        Me.TSlblSecondExam.Text = "second Exam:"
        '
        'TSFinalProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 235)
        Me.Controls.Add(Me.TSlblSecondExam)
        Me.Controls.Add(Me.TSlblFirstExam)
        Me.Controls.Add(Me.TSlblStudentID)
        Me.Controls.Add(Me.TSlblFinalExam)
        Me.Controls.Add(Me.TStxtBoxFinalExam)
        Me.Controls.Add(Me.TStxtBoxSecondExam)
        Me.Controls.Add(Me.TStxtBoxFirstExam)
        Me.Controls.Add(Me.TSdgvGradeBook)
        Me.Controls.Add(Me.TStxtBoxStudentID)
        Me.Controls.Add(Me.TSbtnDisplay)
        Me.Controls.Add(Me.TSnvgGradeBook)
        Me.Name = "TSFinalProject"
        Me.Text = "Grade Book"
        CType(Me.TSnvgGradeBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TSnvgGradeBook.ResumeLayout(False)
        Me.TSnvgGradeBook.PerformLayout()
        CType(Me.TSGradeBookGrades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSGradebookDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSGradeBookStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradebookDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSdgvGradeBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TSnvgGradeBook As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TSGradeBookGrades As System.Windows.Forms.BindingSource
    Friend WithEvents TSGradebookDataSet As WindowsApplication1.GradebookDataSet
    Friend WithEvents GradesTableAdapter As WindowsApplication1.GradebookDataSetTableAdapters.GradesTableAdapter
    Friend WithEvents TSGradeBookStudent As System.Windows.Forms.BindingSource
    Friend WithEvents GradebookDataSet As WindowsApplication1.GradebookDataSet
    Friend WithEvents StudentsTableAdapter As WindowsApplication1.GradebookDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents TSbtnDisplay As System.Windows.Forms.Button
    Friend WithEvents TStxtBoxStudentID As System.Windows.Forms.TextBox
    Friend WithEvents TSdgvGradeBook As System.Windows.Forms.DataGridView
    Friend WithEvents TStxtBoxFirstExam As System.Windows.Forms.TextBox
    Friend WithEvents TStxtBoxSecondExam As System.Windows.Forms.TextBox
    Friend WithEvents TStxtBoxFinalExam As System.Windows.Forms.TextBox
    Friend WithEvents TSlblFinalExam As System.Windows.Forms.Label
    Friend WithEvents TSlblStudentID As System.Windows.Forms.Label
    Friend WithEvents TSlblFirstExam As System.Windows.Forms.Label
    Friend WithEvents TSlblSecondExam As System.Windows.Forms.Label
    Friend WithEvents TSbtnUpdate As System.Windows.Forms.ToolStripButton

End Class
