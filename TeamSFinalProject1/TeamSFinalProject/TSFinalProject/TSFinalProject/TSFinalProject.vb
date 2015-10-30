Public Class TSFinalProject

    Private Sub TSFinalProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GradebookDataSet.Students' table. You can move, or remove it, as needed.
        'Me.StudentsTableAdapter.Fill(Me.GradebookDataSet.Students)
        'TODO: This line of code loads data into the 'TSGradebookDataSet.Grades' table. You can move, or remove it, as needed.
        Me.GradesTableAdapter.Fill(Me.TSGradebookDataSet.Grades)

    End Sub

End Class
