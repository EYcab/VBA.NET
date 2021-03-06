﻿Public Class YEarnestProj7
    Structure S86Conv
        Dim S86name As String
        Dim S86rate As Double
    End Structure
    Dim S86Unit() As String = IO.File.ReadAllLines("Units.txt")
    Dim S86Convs() As S86Conv
    Dim S86Original, S86Desired As Integer
    Dim S86FinalRate, S86Rate As Double
    Private Sub S86btn_Click(sender As Object, e As EventArgs) Handles S86btn.Click
        If S86ErrorCheck() Then
            S86Original = CInt(S86txtOriginal.Text) - 1
            S86Desired = CInt(S86txtDesired.Text) - 1
            If S86Desired = S86Original Then
                S86FinalRate = 1
            ElseIf S86Desired = 3 Then
                S86DesiredIsInFT(S86Original, 0, S86Rate)
                S86FinalRate = S86Rate
            ElseIf S86Original = 3 Then
                S86DesiredIsInFT(S86Original, 1, S86Rate)
                S86FinalRate = S86Rate
            Else
                S86DesiredIsInFT(S86Original, 0, S86Rate)
                S86FinalRate = S86Rate
                S86DesiredIsInFT(S86Desired, 1, S86Rate)
                S86FinalRate = S86FinalRate * S86Rate
            End If
            S86txtOutcome.Text = (CDbl(S86txtLength.Text) * S86FinalRate).ToString("N2")
        Else
            S86txtOutcome.Text = "There is an error in your input!"
        End If
    End Sub
    Private Sub YEarnestProj7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim S86n As Integer = S86Unit.Count - 1
        ReDim S86Convs(S86n)
        Dim S86line As String
        Dim data(1) As String
        For S86i As Integer = 0 To S86n
            S86line = S86Unit(S86i)
            data = S86line.Split(","c)
            S86Convs(S86i).S86name = data(0)
            S86lBoxUnits.Items.Add(S86i + 1 & ". " & S86Convs(S86i).S86name)
            S86Convs(S86i).S86rate = CDbl(data(1))
        Next
    End Sub
    Sub S86DesiredIsInFT(ByRef S86OrginalCode As Integer, ByRef S86Caltype As Integer, ByRef S86Rate As Double)
        If S86Caltype = 0 Then
            S86Rate = S86Convs(S86OrginalCode).S86rate
        Else
            S86Rate = 1 / S86Convs(S86OrginalCode).S86rate
        End If
    End Sub
    Function S86ErrorCheck() As Boolean
        If Not IsNumeric(S86txtLength.Text) Then
            Return False
        ElseIf CDbl(S86txtLength.Text) < 0 Then
            Return False
        ElseIf Not IsNumeric(S86txtOriginal.Text) Then
            Return False
        ElseIf CDbl(S86txtOriginal.Text) <> CInt(S86txtOriginal.Text) Or CDbl(S86txtOriginal.Text) < 0 Then
            Return False
        ElseIf CInt(S86txtOriginal.Text) > 9 Or CInt(S86txtOriginal.Text) < 1 Then
            Return False
        ElseIf Not IsNumeric(S86txtDesired.Text) Then
            Return False
        ElseIf CDbl(S86txtDesired.Text) <> CInt(S86txtDesired.Text) Or CDbl(S86txtDesired.Text) < 0 Then
            Return False
        ElseIf CInt(S86txtDesired.Text) > 9 Or CInt(S86txtDesired.Text) < 1 Then
            Return False
        End If
        Return True
    End Function
End Class
