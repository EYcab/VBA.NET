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
    End Sub
End Class
