Public Class S86Frm

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles S86lblDuration.Click

    End Sub

    Private Sub S86btnRate_Click(sender As Object, e As EventArgs) Handles S86btnRate.Click
        S86lBox.Items.Add("Price of Equipment     " & "Half-day    " & "Full-day")
        S86lBox.Items.Add("1.Rug cleaner          " & "$16.00      " & "$24.00")
        S86lBox.Items.Add("2.Lawn mower           " & "$12.00      " & "$18.00")
        S86lBox.Items.Add("3.Paint sprayer        " & "$20.00      " & "$30.00")
    End Sub

    Private Sub S86Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub S86btn_Click(sender As Object, e As EventArgs) Handles S86btn.Click
        S86lBox2.Items.Clear()
        Const S86p1 As Double = 24   'p is short for the price of 3 options in order
        Const S86p2 As Double = 18
        Const S86p3 As Double = 30
        Dim S86str As String = "", S86p As Double = 0.0
        Dim S86type As String = ""
        Dim S86total As Double = 0.0
        Dim S86ID As Integer = 0
        Select Case CInt(S86txtItem.Text) 'Attention here
            Case 1
                S86str = "Rug Cleaner"
                S86p = S86p1
            Case 2
                S86str = "Lawn mower"
                S86p = S86p2
            Case 3
                S86str = "Paint sprayer"
                S86p = S86p3
        End Select
        Select Case S86txtDuration.Text
            Case "H"
                S86p = 2 * S86p / 3
                S86type = "Half"
                S86ID = 1
            Case "F"
                S86type = "Full"
                S86ID = 1
        End Select
        If S86ID = 0 Or (S86p = 0.0) Then
            S86lBox2.Items.Add("There is an error")
        Else
            S86lBox2.Items.Add("Receipt from Eddie's Equipment Rental")
            S86lBox2.Items.Add("                                 ")
            S86lBox2.Items.Add(S86str & ": " & (S86p).ToString("C") & "  (" & S86type & " day rental)")
            S86lBox2.Items.Add("Deposit: $30")

            S86total = S86p + 30
            S86lBox2.Items.Add("Total:  " & (S86total).ToString("C"))

        End If
    End Sub
End Class
