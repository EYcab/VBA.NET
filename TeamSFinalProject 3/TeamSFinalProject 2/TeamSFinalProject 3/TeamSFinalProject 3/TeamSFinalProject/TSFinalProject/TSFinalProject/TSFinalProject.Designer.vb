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
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim TSStudentIDLabel1 As System.Windows.Forms.Label
        Dim TSFirstExamLabel As System.Windows.Forms.Label
        Dim TSSecondExamLabel As System.Windows.Forms.Label
        Dim TSFinalExamLabel As System.Windows.Forms.Label
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
        Me.StudentsTableAdapter = New WindowsApplication1.GradebookDataSetTableAdapters.StudentsTableAdapter()
        Me.TSbtnDisplay = New System.Windows.Forms.Button()
        Me.TSdgvGradeBook = New System.Windows.Forms.DataGridView()
        Me.TSlblStudentID = New System.Windows.Forms.Label()
        Me.GradebookDataSet1 = New WindowsApplication1.GradebookDataSet()
        Me.TableAdapterManager = New WindowsApplication1.GradebookDataSetTableAdapters.TableAdapterManager()
        Me.TSStudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.TSFirstExamTextBox = New System.Windows.Forms.TextBox()
        Me.TSSecondExamTextBox = New System.Windows.Forms.TextBox()
        Me.TSFinalExamTextBox = New System.Windows.Forms.TextBox()
        Me.TSDisplayGraph = New System.Windows.Forms.Button()
        Me.TSpicOutput = New System.Windows.Forms.PictureBox()
        StudentIDLabel = New System.Windows.Forms.Label()
        TSStudentIDLabel1 = New System.Windows.Forms.Label()
        TSFirstExamLabel = New System.Windows.Forms.Label()
        TSSecondExamLabel = New System.Windows.Forms.Label()
        TSFinalExamLabel = New System.Windows.Forms.Label()
        CType(Me.TSnvgGradeBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TSnvgGradeBook.SuspendLayout()
        CType(Me.TSGradeBookGrades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSGradebookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSGradeBookStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSdgvGradeBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradebookDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSpicOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Location = New System.Drawing.Point(12, 71)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(0, 13)
        StudentIDLabel.TabIndex = 11
        '
        'TSStudentIDLabel1
        '
        TSStudentIDLabel1.AutoSize = True
        TSStudentIDLabel1.Location = New System.Drawing.Point(18, 75)
        TSStudentIDLabel1.Name = "TSStudentIDLabel1"
        TSStudentIDLabel1.Size = New System.Drawing.Size(59, 13)
        TSStudentIDLabel1.TabIndex = 11
        TSStudentIDLabel1.Text = "student ID:"
        '
        'TSFirstExamLabel
        '
        TSFirstExamLabel.AutoSize = True
        TSFirstExamLabel.Location = New System.Drawing.Point(22, 107)
        TSFirstExamLabel.Name = "TSFirstExamLabel"
        TSFirstExamLabel.Size = New System.Drawing.Size(55, 13)
        TSFirstExamLabel.TabIndex = 12
        TSFirstExamLabel.Text = "first Exam:"
        '
        'TSSecondExamLabel
        '
        TSSecondExamLabel.AutoSize = True
        TSSecondExamLabel.Location = New System.Drawing.Point(3, 137)
        TSSecondExamLabel.Name = "TSSecondExamLabel"
        TSSecondExamLabel.Size = New System.Drawing.Size(74, 13)
        TSSecondExamLabel.TabIndex = 13
        TSSecondExamLabel.Text = "second Exam:"
        '
        'TSFinalExamLabel
        '
        TSFinalExamLabel.AutoSize = True
        TSFinalExamLabel.Location = New System.Drawing.Point(19, 165)
        TSFinalExamLabel.Name = "TSFinalExamLabel"
        TSFinalExamLabel.Size = New System.Drawing.Size(58, 13)
        TSFinalExamLabel.TabIndex = 14
        TSFinalExamLabel.Text = "final Exam:"
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
        Me.TSnvgGradeBook.Size = New System.Drawing.Size(415, 25)
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
        'TSdgvGradeBook
        '
        Me.TSdgvGradeBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TSdgvGradeBook.Location = New System.Drawing.Point(160, 71)
        Me.TSdgvGradeBook.Name = "TSdgvGradeBook"
        Me.TSdgvGradeBook.Size = New System.Drawing.Size(240, 150)
        Me.TSdgvGradeBook.TabIndex = 3
        '
        'TSlblStudentID
        '
        Me.TSlblStudentID.AutoSize = True
        Me.TSlblStudentID.Location = New System.Drawing.Point(12, 74)
        Me.TSlblStudentID.Name = "TSlblStudentID"
        Me.TSlblStudentID.Size = New System.Drawing.Size(0, 13)
        Me.TSlblStudentID.TabIndex = 8
        '
        'GradebookDataSet1
        '
        Me.GradebookDataSet1.DataSetName = "GradebookDataSet"
        Me.GradebookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GradesTableAdapter = Me.GradesTableAdapter
        Me.TableAdapterManager.StudentsTableAdapter = Me.StudentsTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.GradebookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TSStudentIDTextBox
        '
        Me.TSStudentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TSGradeBookGrades, "studentID", True))
        Me.TSStudentIDTextBox.Location = New System.Drawing.Point(86, 75)
        Me.TSStudentIDTextBox.Name = "TSStudentIDTextBox"
        Me.TSStudentIDTextBox.Size = New System.Drawing.Size(68, 20)
        Me.TSStudentIDTextBox.TabIndex = 12
        '
        'TSFirstExamTextBox
        '
        Me.TSFirstExamTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TSGradeBookGrades, "firstExam", True))
        Me.TSFirstExamTextBox.Location = New System.Drawing.Point(118, 107)
        Me.TSFirstExamTextBox.Name = "TSFirstExamTextBox"
        Me.TSFirstExamTextBox.Size = New System.Drawing.Size(36, 20)
        Me.TSFirstExamTextBox.TabIndex = 13
        '
        'TSSecondExamTextBox
        '
        Me.TSSecondExamTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TSGradeBookGrades, "secondExam", True))
        Me.TSSecondExamTextBox.Location = New System.Drawing.Point(118, 137)
        Me.TSSecondExamTextBox.Name = "TSSecondExamTextBox"
        Me.TSSecondExamTextBox.Size = New System.Drawing.Size(36, 20)
        Me.TSSecondExamTextBox.TabIndex = 14
        '
        'TSFinalExamTextBox
        '
        Me.TSFinalExamTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TSGradeBookGrades, "finalExam", True))
        Me.TSFinalExamTextBox.Location = New System.Drawing.Point(118, 165)
        Me.TSFinalExamTextBox.Name = "TSFinalExamTextBox"
        Me.TSFinalExamTextBox.Size = New System.Drawing.Size(36, 20)
        Me.TSFinalExamTextBox.TabIndex = 15
        '
        'TSDisplayGraph
        '
        Me.TSDisplayGraph.Location = New System.Drawing.Point(58, 227)
        Me.TSDisplayGraph.Name = "TSDisplayGraph"
        Me.TSDisplayGraph.Size = New System.Drawing.Size(282, 23)
        Me.TSDisplayGraph.TabIndex = 16
        Me.TSDisplayGraph.Text = "Display Graph"
        Me.TSDisplayGraph.UseVisualStyleBackColor = True
        '
        'TSpicOutput
        '
        Me.TSpicOutput.Location = New System.Drawing.Point(12, 256)
        Me.TSpicOutput.Name = "TSpicOutput"
        Me.TSpicOutput.Size = New System.Drawing.Size(388, 203)
        Me.TSpicOutput.TabIndex = 17
        Me.TSpicOutput.TabStop = False
        '
        'TSFinalProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 472)
        Me.Controls.Add(Me.TSpicOutput)
        Me.Controls.Add(Me.TSDisplayGraph)
        Me.Controls.Add(TSFinalExamLabel)
        Me.Controls.Add(Me.TSFinalExamTextBox)
        Me.Controls.Add(TSSecondExamLabel)
        Me.Controls.Add(Me.TSSecondExamTextBox)
        Me.Controls.Add(TSFirstExamLabel)
        Me.Controls.Add(Me.TSFirstExamTextBox)
        Me.Controls.Add(TSStudentIDLabel1)
        Me.Controls.Add(Me.TSStudentIDTextBox)
        Me.Controls.Add(StudentIDLabel)
        Me.Controls.Add(Me.TSlblStudentID)
        Me.Controls.Add(Me.TSdgvGradeBook)
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
        CType(Me.TSdgvGradeBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradebookDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSpicOutput, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents StudentsTableAdapter As WindowsApplication1.GradebookDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents TSbtnDisplay As System.Windows.Forms.Button
    Friend WithEvents TSdgvGradeBook As System.Windows.Forms.DataGridView
    Friend WithEvents TSlblStudentID As System.Windows.Forms.Label
    Friend WithEvents TSbtnUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents GradebookDataSet1 As WindowsApplication1.GradebookDataSet
    Friend WithEvents TableAdapterManager As WindowsApplication1.GradebookDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TSStudentIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TSFirstExamTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TSSecondExamTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TSFinalExamTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TSDisplayGraph As System.Windows.Forms.Button
    Friend WithEvents TSpicOutput As System.Windows.Forms.PictureBox

End Class
