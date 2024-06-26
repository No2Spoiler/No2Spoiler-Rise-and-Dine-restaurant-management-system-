Imports System.Data.SqlClient

Public Class Hiring
    Dim connection As New SqlConnection("Data Source=NO1SPOILER\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub EmployeeAccountButton_Click(sender As Object, e As EventArgs) Handles EmployeeAccountButton.Click
        Me.Hide()
        EmployeeAccount.Show()
    End Sub

    Private Sub PerformanceButton_Click_1(sender As Object, e As EventArgs) Handles PerformanceButton.Click
        Me.Hide()
        Performance.Show()
    End Sub

    Private Sub TrainingButton_Click(sender As Object, e As EventArgs) Handles TrainingButton.Click
        Me.Hide()
        Training.Show()
    End Sub

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs) Handles LeaveButton.Click
        Me.Hide()
        Leaves.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        LeavesTraining.Show()
    End Sub

    Private Sub HRMenuButton_Click(sender As Object, e As EventArgs) Handles HRMenuButton.Click
        Me.Hide()
        HumanResource.Show()
    End Sub

    Private Sub MainMenuButton_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Reset()
        EIdTB.Text = ""
        JobTB.Text = ""
        HiringDateDTP.Text = ""
    End Sub

    Private Sub DisplayEmployeeHiringView()
        connection.Open()
        Dim query = "select * from EmployeeHiringView"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        EmployeeHiringviewDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayEmployeeHiringView()
    End Sub

    Dim key = 0

    Private Sub EmployeeAccountDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmployeeHiringviewDGV.CellMouseClick
        Dim row As DataGridViewRow = EmployeeHiringviewDGV.Rows(e.RowIndex)
        EIdTB.Text = row.Cells(1).Value.ToString
        JobTB.Text = row.Cells(2).Value.ToString
        HiringDateDTP.Text = row.Cells(3).Value.ToString
        If EIdTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If EIdTB.Text = "" Or JobTB.Text = "" Or HiringDateDTP.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "INSERT INTO Hiring (EId, Job, HiringDate) VALUES ('" & EIdTB.Text & "', '" & JobTB.Text & "', '" & HiringDateDTP.Value.ToString("yyyy-MM-dd") & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Hiring Record Added")
            connection.Close()
            Reset()
            DisplayEmployeeHiringView()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If EIdTB.Text = "" Or JobTB.Text = "" Or HiringDateDTP.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "UPDATE Hiring SET EId='" & EIdTB.Text & "', Job= '" & JobTB.Text & "', HiringDate = '" & HiringDateDTP.Value.ToString("yyyy-MM-dd") & "' WHERE HId = '" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Hiring Record Edited")
            connection.Close()
            Reset()
            DisplayEmployeeHiringView()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from Hiring where HId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Hirng Record Deleted")
            connection.Close()
            Reset()
            DisplayEmployeeHiringView()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub
End Class