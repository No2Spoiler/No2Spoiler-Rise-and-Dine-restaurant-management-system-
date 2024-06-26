Imports System.Data.SqlClient
Imports System.Windows.Forms.AxHost

Public Class Performance
    Dim connection As New SqlConnection("Data Source=NO1SPOILER\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub EmployeeAccountButton_Click(sender As Object, e As EventArgs) Handles EmployeeAccountButton.Click
        Me.Hide()
        EmployeeAccount.Show()
    End Sub

    Private Sub HiringButton_Click(sender As Object, e As EventArgs) Handles HiringButton.Click
        Me.Hide()
        Hiring.Show()
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
        StartDateDTP.Text = ""
        EndDateDTP.Text = ""
        PerformanceTB.Text = ""
        RatingTB.Text = ""
    End Sub

    Private Sub DisplayEmployeePerformanceView()
        connection.Open()
        Dim query = "select * from EmployeePerformanceview"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        EmployeePerformanceViewDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayEmployeePerformanceView()
    End Sub

    Dim key = 0

    Private Sub EmployeeAccountDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmployeePerformanceViewDGV.CellMouseClick
        Dim row As DataGridViewRow = EmployeePerformanceViewDGV.Rows(e.RowIndex)
        EIdTB.Text = row.Cells(1).Value.ToString
        StartDateDTP.Text = row.Cells(2).Value.ToString
        EndDateDTP.Text = row.Cells(3).Value.ToString
        PerformanceTB.Text = row.Cells(4).Value.ToString
        RatingTB.Text = row.Cells(4).Value.ToString
        If EIdTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If EIdTB.Text = "" Or StartDateDTP.Text = "" Or EndDateDTP.Text = "" Or PerformanceTB.Text = "" Or RatingTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "INSERT INTO Performance (EId, StartDate, EndDate, Performance, Rating) VALUES ('" & EIdTB.Text & "','" & StartDateDTP.Value.ToString("yyyy-MM-dd") & "','" & EndDateDTP.Value.ToString("yyyy-MM-dd") & "','" & PerformanceTB.Text & "','" & RatingTB.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Performance Record Added")
            connection.Close()
            Reset()
            DisplayEmployeePerformanceView()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If EIdTB.Text = "" Or StartDateDTP.Text = "" Or EndDateDTP.Text = "" Or PerformanceTB.Text = "" Or RatingTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "UPDATE Performance SET EId='" & EIdTB.Text & "', StartDate='" & StartDateDTP.Value.ToString("yyyy-MM-dd") & "',EndDate='" & EndDateDTP.Value.ToString("yyyy-MM-dd") & "', Performance='" & PerformanceTB.Text & "', Rating='" & RatingTB.Text & "' WHERE PId='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Performance Record Edited")
            connection.Close()
            Reset()
            DisplayEmployeePerformanceView()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from Performance where PId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Performance Record Deleted")
            connection.Close()
            Reset()
            DisplayEmployeePerformanceView()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub
End Class