Imports System.Data.SqlClient
Imports System.Windows.Forms.AxHost

Public Class Training
    Dim connection As New SqlConnection("Data Source=NO1SPOILER\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub EmployeeAccountButton_Click(sender As Object, e As EventArgs) Handles EmployeeAccountButton.Click
        Me.Hide()
        EmployeeAccount.Show()
    End Sub

    Private Sub HiringButton_Click(sender As Object, e As EventArgs) Handles HiringButton.Click
        Me.Hide()
        Hiring.Show()
    End Sub

    Private Sub PerformanceButton_Click_1(sender As Object, e As EventArgs) Handles PerformanceButton.Click
        Me.Hide()
        Performance.Show()
    End Sub

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs) Handles LeaveButton.Click
        Me.Hide()
        Leaves.Show()
    End Sub

    Private Sub LeaveTraining_Click(sender As Object, e As EventArgs) Handles LeaveTraining.Click
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
        TrainingDateDTP.Text = ""
        TrainingNameTB.Text = ""
        TrainerTB.Text = ""
    End Sub

    Private Sub DisplayTraining()
        connection.Open()
        Dim query = "select * from Training"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        TrainingDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayTraining()
    End Sub

    Dim key = 0

    Private Sub EmployeeAccountDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TrainingDGV.CellMouseClick
        Dim row As DataGridViewRow = TrainingDGV.Rows(e.RowIndex)
        EIdTB.Text = row.Cells(1).Value.ToString
        TrainingDateDTP.Text = row.Cells(2).Value.ToString
        TrainingNameTB.Text = row.Cells(3).Value.ToString
        TrainerTB.Text = row.Cells(4).Value.ToString
        If EIdTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If EIdTB.Text = "" Or TrainingDateDTP.Text = "" Or TrainingNameTB.Text = "" Or TrainerTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "INSERT INTO Training (EId, TrainingDate, TrainingName, Trainer) VALUES ('" & EIdTB.Text & "','" & TrainingDateDTP.Value.ToString("yyyy-MM-dd") & "','" & TrainingNameTB.Text & "','" & TrainerTB.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Training Record Added")
            connection.Close()
            Reset()
            DisplayTraining()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If EIdTB.Text = "" Or EIdTB.Text = "" Or TrainingDateDTP.Text = "" Or TrainingNameTB.Text = "" Or TrainerTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "UPDATE Training SET EId='" & EIdTB.Text & "', TrainingDate='" & TrainingDateDTP.Value.ToString("yyyy-MM-dd") & "', TrainingName='" & TrainingNameTB.Text & "', Trainer='" & TrainerTB.Text & "' WHERE TId='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Training Record Edited")
            connection.Close()
            Reset()
            DisplayTraining()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from Training where TId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Training Record Deleted")
            connection.Close()
            Reset()
            DisplayTraining()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub
End Class