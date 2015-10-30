Public Class Form1

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles S86chkFries.CheckedChanged

    End Sub

    Private Sub S86btn_Click(sender As Object, e As EventArgs) Handles S86btn.Click
        S86btn.BackColor = Color.DodgerBlue
        Dim S86total As Double = 0.0
        If S86radRegular.Checked Then
            S86total += 4.19
            S86chkBurgers.Checked = True
        ElseIf S86radCheese.Checked Or S86radbacon.Checked Then
            S86total += 4.79
            S86chkBurgers.Checked = True
        ElseIf S86radBoth.Checked Then
            S86total += 5.39
            S86chkBurgers.Checked = True
        Else
            S86grpBurgers.Visible = False
        End If

        If S86radSmall.Checked Then
            S86total += 5.39
            S86chkFries.Checked = True
        ElseIf S86radMedium.Checked Then
            S86total += 3.09
            S86chkFries.Checked = True
        ElseIf S86radLarge.Checked Then
            S86total += 4.99
            S86chkFries.Checked = True
        Else
            S86grpFries.Visible = False
        End If
        If S86radSoda.Checked Then
            S86total += 1.69
            S86chkDrinks.Checked = True
        ElseIf S86radWater.Checked Then
            S86total += 1.49
            S86chkDrinks.Checked = True
        Else
            S86grpDrinks.Visible = False
        End If
        S86txt.Text = (S86total).ToString("C")
    End Sub
End Class
