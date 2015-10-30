Public Class S86YEarnest

    Private Sub S86txtbox1_TextChanged(sender As Object, e As EventArgs) Handles S86txtLoanAmt.TextChanged

    End Sub

    Private Sub S86btn_Click(sender As Object, e As EventArgs) Handles S86btn.Click
        Dim S86MthlyPmt As Double
        Dim S86loanAmt As Double
        Dim S86IntRate As Double
        Dim S86IntMthlyRate As Double
        Dim S86DurationMths As Double
        Const S86MthFactor As Integer = 1200
        S86loanAmt = CDbl(S86txtLoanAmt.Text)
        S86IntRate = CDbl(S86txtIntRate.Text)       
        S86IntMthlyRate = S86IntRate / S86MthFactor
        S86DurationMths = CDbl(S86txtDurationMths.Text)
        S86MthlyPmt = S86loanAmt * S86IntMthlyRate / (1 - (1 + S86IntMthlyRate) ^ (-S86DurationMths))
        S86txtMthlyPmt.Text = (S86MthlyPmt).ToString("C2")
        S86txtTotal.Text = (S86DurationMths * S86MthlyPmt - S86loanAmt).ToString("C")

    End Sub

    Private Sub S86txtTotal_TextChanged(sender As Object, e As EventArgs) Handles S86txtTotal.TextChanged

    End Sub
End Class
