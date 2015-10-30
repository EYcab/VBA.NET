Public Class TSFinalProject

    Private Sub TSFinalProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GradebookDataSet.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.TSGradebookDataSet.Students)
        'TODO: This line of code loads data into the 'TSGradebookDataSet.Grades' table. You can move, or remove it, as needed.
        Me.GradesTableAdapter.Fill(Me.TSGradebookDataSet.Grades)
    End Sub

    Private Sub TSbtnDisplay_Click(sender As Object, e As EventArgs) Handles TSbtnDisplay.Click
        'Write the query and display it to the data grid view as is shown in the book
        'So far we must input all grades into the grade table,
        'otherwise there is an error popping up like what I showed in the word document
        Dim TSquery = From Grades In TSGradebookDataSet.Grades
                    Join Students In TSGradebookDataSet.Students
                    On Grades.studentID Equals Students.studentID
                    Let TSStudentName = Students.firstName & Students.lastName
                    Let TSsemGrade = (Grades.firstExam + Grades.secondExam + Grades.finalExam * 2) / 4
                     Let TSformattedGrade = TSsemGrade.ToString("N0")
                     Order By Grades.studentID Ascending
                     Select TSStudentName, TSformattedGrade
        TSdgvGradeBook.DataSource = TSquery.ToList
        TSdgvGradeBook.CurrentCell = Nothing
        TSdgvGradeBook.Columns("TSStudentName").HeaderText = "fullName "
        TSdgvGradeBook.Columns("TSformattedGrade").HeaderText = "semGrade"
    End Sub

    Private Sub TSbtnUpdate_Click(sender As Object, e As EventArgs) Handles TSbtnUpdate.Click
        TSGradeBookGrades.EndEdit()
        GradesTableAdapter.Update(TSGradebookDataSet.Grades)
    End Sub

    Private Sub TSDisplayGraph_Click(sender As Object, e As EventArgs) Handles TSDisplayGraph.Click
        'Creates the x and y axis
        Dim TSgr As Graphics = TSpicOutput.CreateGraphics
        TSgr.DrawLine(Pens.Black, 100, 30, 340, 30) 'draws upper x-axis (x1, y1, x2, y2)
        TSgr.DrawLine(Pens.Black, 100, 190, 340, 190) 'draws lower x-axis (x1, y1, x2, y2)
        TSgr.DrawLine(Pens.Black, 100, 190, 100, 30) 'draws y-axis

        'Creates an uppper and lower tick mark to indicate the final average overall grade of all students
        Dim finalgrade As Integer = 80 'place holder for the final grade average of all students
        TSgr.DrawLine(Pens.Black, 100 + finalgrade * 2, 25, 100 + finalgrade * 2, 35) 'draws the upper tick mark
        TSgr.DrawLine(Pens.Black, 100 + finalgrade * 2, 185, 100 + finalgrade * 2, 195) 'draws the lower tick mark

        'Creates the bars of the students' final grades
        ''I am using an array until we have the query ready where I can grab the 
        ''final grades of all the students
        Dim quantity() As Single = {80, 89, 90, 70, 75}
        For TSi As Integer = 0 To quantity.Count - 1
            TSgr.FillRectangle(Brushes.Blue, 100, 40 + TSi * 30, quantity(TSi) * 2, 20)
            '(x,y,w,h)
        Next

        'Displays the names to the right of the graph
        ''I am only using an array in place of the query until we have that ready to work
        ''but this will work in a very similar way with a query
        Dim studentID() As String = {"AJ-123456", "FA-192837", "GG-567876", "GJ-987654", "LS-222333"}
        For TSj As Integer = 0 To studentID.Count - 1
            TSgr.DrawString(studentID(TSj), Me.Font, Brushes.Black, 20, 40 + TSj * 30)
        Next

    End Sub
End Class
