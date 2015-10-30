Public Class S86YEarnestProj5

    Private Sub S86btnTotal_Click(sender As Object, e As EventArgs) Handles S86btnTotal.Click
        Const S86PizzaUnitPrice As Double = 1.75
        Const S86friesUnitPrice As Double = 2.0
        Const S86softDrinkUnitPrice As Double = 1.25
        'initiate 2 types of values for the 3 units variables
        Dim S86a, S86b, S86c As Integer
        Dim S86m, S86n, S86l As Double
        S86a = CInt(S86txtBoxSlices.Text)
        S86m = CDbl(S86txtBoxSlices.Text)
        S86b = CInt(S86txtBoxFries.Text)
        S86n = CDbl(S86txtBoxFries.Text)
        S86c = CInt(S86txtBoxDrinks.Text)
        S86l = CDbl(S86txtBoxDrinks.Text)
        S86lstBox.Items.Clear()
        If (S86m <> S86a) Or (S86n <> S86b) Or (S86l <> S86c) Then
            S86lstBox.Items.Add("Please enter integers only!")
        Else
            S86lstBox.Items.Add("ITEM                 " & "QUALITY         " & "PRICE  ")
            S86lstBox.Items.Add("prizza slices        " & (S86a).ToString("N0") & "                        " & SubSum(S86PizzaUnitPrice, S86a))
            S86lstBox.Items.Add("fries                    " & (S86b).ToString("N0") & "                        " & SubSum(S86friesUnitPrice, S86b))
            S86lstBox.Items.Add("soft drinks          " & (S86c).ToString("N0") & "                        " & SubSum(S86softDrinkUnitPrice, S86c))
            S86lstBox.Items.Add("Total                                            " & Total(SubSum(S86PizzaUnitPrice, S86a), SubSum(S86friesUnitPrice, S86b), SubSum(S86softDrinkUnitPrice, S86c)))
        End If
    End Sub
    Function SubSum(S86unitPrice As Double, S86units As Integer) As Double
        Dim S86z As Double
        S86z = S86unitPrice * S86units
        Return S86z
    End Function
    Function Total(S86Item1 As Double, S86Item2 As Double, S86Item3 As Double) As Double
        Dim S86sum As Double
        S86sum = S86Item1 + S86Item2 + S86Item3
        Return S86sum
    End Function

    Private Sub S86txtBoxSlices_TextChanged(sender As Object, e As EventArgs) Handles S86txtBoxSlices.TextChanged

    End Sub
End Class
