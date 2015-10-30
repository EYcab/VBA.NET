Public Class S86Frm

    Private Sub S86Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles S86txtBx2.TextChanged

    End Sub

    Private Sub S86btn_Click(sender As Object, e As EventArgs) Handles S86btn.Click
        Const TAX_RATE As Double = 0.05
        Dim Name As String, LaborCost, PartsCost, Total As Double
        Name = S86txtbx1.Text
        S86lstBx.Items.Clear()
        LaborCost = CDbl(S86txtBx2.Text) * 35.0
        PartsCost = CDbl(S86txtBx3.Text) * (1 + TAX_RATE)
        Total = LaborCost + PartsCost
        S86lstBx.Items.Add("Customer:     " & Name)
        S86lstBx.Items.Add("Labor cost:   " & (LaborCost).ToString("C2"))
        S86lstBx.Items.Add("Parts cost:   " & (PartsCost).ToString("C2"))
        S86lstBx.Items.Add("Total cost:   " & (Total).ToString("C2"))
    End Sub
End Class
