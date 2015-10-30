Public Class TSFinalProject

    Private Sub TSFinalProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GradebookDataSet.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.TSGradebookDataSet.Students)
        'TODO: This line of code loads data into the 'TSGradebookDataSet.Grades' table. You can move, or remove it, as needed.
        Me.GradesTableAdapter.Fill(Me.TSGradebookDataSet.Grades)
    End Sub

    Private Sub TSbtnDisplay_Click(sender As Object, e As EventArgs) Handles TSbtnDisplay.Click
        'Write the query and display it to the data grid view as is shown in the book
        'So far we must input all grades into the grade table,otherwise there is an error popping up like what I showed in the word document
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
        MessageBox.Show("Grade table updated")
    End Sub

    Private Sub TSDisplayGraph_Click(sender As Object, e As EventArgs) Handles TSDisplayGraph.Click

        Dim TSquery = From Grades In TSGradebookDataSet.Grades
                    Join Students In TSGradebookDataSet.Students
                    On Grades.studentID Equals Students.studentID
                    Let TSStudentName = Students.firstName & Students.lastName
                    Let TSsemGrade = (Grades.firstExam + Grades.secondExam + Grades.finalExam * 2) / 4
                     Let TSformattedGrade = TSsemGrade.ToString("N0")
                     Order By Grades.studentID Ascending
                     Select TSsemGrade

        Dim TSfinalGrades() As Double = TSquery.ToArray

        Dim TSarray() As Integer = {0, 0, 0, 0, 0}

        For TSj As Integer = 0 To TSfinalGrades.Count - 1
            TSarray(TSj) = CInt(TSfinalGrades(TSj))
        Next
        Dim TSsum As Integer = TSarray.Sum
        Dim TSaverage As Integer = CInt(TSsum / 5)

        'Creates the x and y axis
        Dim TSgr As Graphics = TSpicOutput.CreateGraphics
        TSgr.DrawLine(Pens.Black, 70, 210, 340, 210) 'draws lower x-axis (x1, y1, x2, y2)
        TSgr.DrawLine(Pens.Black, 70, 210, 70, 30) 'draws y-axis

        'Creates an uppper and lower tick mark to indicate the final average overall grade of all students
        TSgr.DrawLine(Pens.Black, 65, 210 - TSaverage * 2, 75, 210 - TSaverage * 2) 'draws the lower tick mark
        Dim avgLabel As String = "Avg Grade"
        TSgr.DrawString(avgLabel, Me.Font, Brushes.Black, 5, 205 - TSaverage * 2)

        'Creates the bars of the students' final grades
        For TSi As Integer = 0 To TSfinalGrades.Count - 1
            TSgr.FillRectangle(Brushes.Blue, 90 + TSi * 50, (210 - TSarray(TSi) * 2), 30, TSarray(TSi) * 2)
            '(x,y,w,h)
        Next

        'Displays the names to the right of the graph
        'Dim studentID() As String = {"AJ-123456", "FA-192837", "GG-567876", "GJ-987654", "LS-222333"}
        'For TSj As Integer = 0 To studentID.Count - 1
        'TSgr.DrawString(studentID(TSj), Me.Font, Brushes.Black, 20, 40 + TSj * 30)
        'Next

        Dim xLabel As String = "Final Grade"
        TSgr.DrawString(xLabel, Me.Font, Brushes.Black, 40, 10)


    End Sub
End Class
