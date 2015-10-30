Public Class S86YEarnestProj8
    Public Property CurrentCell As DataGridViewCell
    Structure S86Conv
        Dim S86name As String
        Dim S86number As Double
    End Structure
    Dim S86Convs() As S86Conv
    Private Sub S86btnDisplay_Click(sender As Object, e As EventArgs) Handles S86btnDisplay.Click
        
    End Sub

    Private Sub S86btnNew_Click(sender As Object, e As EventArgs) Handles S86btnNew.Click
        'Dim S86n As Integer = S86Unit.Count - 1

    End Sub

    Private Sub S86YEarnestProj8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num As Integer
        Dim namelist() As String = IO.File.ReadAllLines("Directories.txt")
        num = namelist.Count - 1
        Dim block() As String
        For i As Integer = 0 To num
            block = namelist
            S86lboxDirectory.Items.Add(namelist(i))
        Next
    End Sub

    Private Sub S86lboxDirectory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles S86lboxDirectory.SelectedIndexChanged
        Dim selectedDir As String = S86lboxDirectory.Text
        S86txtDirectory.Text = selectedDir
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles S86DataGridView1.CellContentClick
        Dim infoDiary() As String = IO.File.ReadAllLines(S86txtDirectory.Text)
        Dim query = From line In infoDiary
                    Let name = line.Split(","c)(0)
                    Let number = CStr(line.Split(","c)(1))
                    Order By name
                    Select name, number
        S86DataGridView1.DataSource = query.ToList
        S86DataGridView1.CurrentCell = Nothing
    End Sub

    Private Sub S86DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles S86DataGridView1.CellContentClick
        
    End Sub
End Class
