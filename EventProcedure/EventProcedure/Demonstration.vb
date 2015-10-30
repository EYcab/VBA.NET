Public Class Demonstration


    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed_Click
        txtFirst.ForeColor = Color.Red
    End Sub

    Private Sub txtFirst_Leave(sender As Object, e As EventArgs) Handles txtFirst_TextChanged
        txtFirst.ForeColor = Color.Black
    End Sub

    Private Sub txtFirst_TextChanged(sender As Object, e As EventArgs) Handles txtFirst_TextChanged.Leave
        txtFirst_Leave.ForeColor = Color.Blue
    End Sub

    Private Sub txtFirst_TextChanged_TextChanged(sender As Object, e As EventArgs) Handles txtFirst_TextChanged.TextChanged

    End Sub
End Class
