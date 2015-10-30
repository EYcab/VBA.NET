Public Class S86Frm
    Dim S86CurrDir As String = ""
    'Load all .txt files into the listbox
    Private Sub S86Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim S86num As Integer
            Dim S86namelist() As String = IO.File.ReadAllLines("Directories.txt")
            S86num = S86namelist.Count - 1
            For S86i As Integer = 0 To S86num
                S86lboxDirectory.Items.Add(S86namelist(S86i))
            Next
        Catch S86Done As IO.FileLoadException
        End Try
    End Sub

    Private Sub S86DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles S86DataGridView1.CellContentClick
        
    End Sub
    'Select and assign a directory to the directory text box
    Private Sub S86lboxDirectory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles S86lboxDirectory.SelectedIndexChanged
        S86CurrDir = S86lboxDirectory.Text
        S86txtDirectory.Text = S86CurrDir
    End Sub
    'Display all text files content
    Private Sub S86btnDisplay_Click(sender As Object, e As EventArgs) Handles S86btnDisplay.Click
        Dim S86infoDiary() As String = IO.File.ReadAllLines(S86txtDirectory.Text)
        Dim S86query = From S86line In S86infoDiary
                    Let S86name = S86line.Split(","c)(0)
                    Let S86number = CStr(S86line.Split(","c)(1))
                    Order By S86name
                    Select S86name, S86number
        S86DataGridView1.DataSource = S86query.ToList
        S86DataGridView1.CurrentCell = Nothing
        S86DataGridView1.Columns("S86name").HeaderText = "Name"
        S86DataGridView1.Columns("S86number").HeaderText = "Phone Number"
    End Sub
    'Check if the name data exists
    Sub S86ExistenceCheck(ByRef S86Check As Boolean)
        Dim S86namelist() As String = IO.File.ReadAllLines(S86txtDirectory.Text)
        Dim S86n As Integer = S86namelist.Count - 1
        Dim S86Data(1) As String
        Dim S86line As String
        For S86j As Integer = 0 To S86n
            S86line = S86namelist(S86j)
            S86Data = S86line.Split(","c)
            If S86Data(0) = S86txtName.Text Then
                S86Check = True
            End If

        Next
    End Sub
    'Add all new lists into the selected text box
    Private Sub S86btnAdd_Click(sender As Object, e As EventArgs) Handles S86btnAdd.Click
        Dim S86Name As String = S86txtName.Text
        Dim S86Number As String = S86txtNumber.Text
        Dim S86Check As Boolean = False
        If S86txtDirectory.Text = "" Then
            MessageBox.Show("Select a directory you wish to add", "Error")
        ElseIf S86txtName.Text = "" Then
            MessageBox.Show("Please enter a name", "Error")
        ElseIf S86Number = "" Then
            MessageBox.Show("Please enter a number", "Error")
        Else
            S86ExistenceCheck(S86Check)
            If S86Check Then
                S86txtName.Clear()
                MessageBox.Show("This name has already existed", "Error")
            Else
                Dim S86sw As IO.StreamWriter = IO.File.AppendText(S86txtDirectory.Text)
                S86sw.WriteLine(S86Name & "," & S86Number)
                MessageBox.Show("New list is successfully added to the directory!")
                S86txtName.Clear()
                S86txtNumber.Clear()
                S86sw.Close()
            End If
        End If        
    End Sub
    'Remove a selected list from selected text box
    Private Sub S86btnRemove_Click(sender As Object, e As EventArgs) Handles S86btnRemove.Click
        Dim S86Name As String = S86txtName.Text
        Dim S86Number As String = S86txtNumber.Text 
        Dim S86Check As Boolean = False
        If S86txtDirectory.Text = "" Then
            MessageBox.Show("Select a directory you wish to add", "Error")
        ElseIf S86txtName.Text = "" Then
            MessageBox.Show("Please enter a name", "Error")
        Else
            S86ExistenceCheck(S86Check)
            If Not S86Check Then
                MessageBox.Show("The name you entered does not exist", "Error")
            Else
                S86txtName.Clear()
                Dim S86sr As IO.StreamReader = IO.File.OpenText(S86CurrDir)
                Dim S86sw As IO.StreamWriter = IO.File.CreateText("Temp.txt")
                Dim S86line As String
                Do Until S86sr.EndOfStream
                    S86line = S86sr.ReadLine()
                    If Not S86Name = S86line.Split(","c)(0) Then
                        S86sw.WriteLine(S86line)
                    End If
                Loop
                S86sr.Close()
                S86sw.Close()
                System.IO.File.Delete(S86CurrDir)
                System.IO.File.Move("Temp.txt", S86CurrDir)
                MessageBox.Show("Name is successfully removed from directory")
                S86txtName.Clear()
                S86txtNumber.Clear()
            End If
        End If
    End Sub
    'Create a new text file 
    Private Sub S86btnCreate_Click(sender As Object, e As EventArgs) Handles S86btnCreate.Click
        'InputBox Application
        Dim S86DirectName As String = InputBox("Enter Directory Name:", "Create New Directory")
        If Not S86DirectName = "" Then
            Dim S86swDirectName As IO.StreamWriter = IO.File.CreateText(S86DirectName)
            S86swDirectName.Close()
            Dim S86swDirect As IO.StreamWriter = IO.File.AppendText("Directories.txt")
            S86swDirect.WriteLine(S86DirectName)
            S86swDirect.Close()
            MessageBox.Show("New directory has been added successully.")
            S86lboxDirectory.Items.Add(S86DirectName)
        Else
            MessageBox.Show("Please enter a directory")
        End If
    End Sub
End Class
