Imports System.Data.SqlClient
Imports System.Windows.Forms.AxHost

Public Class Leaves
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

    Private Sub TrainingButton_Click(sender As Object, e As EventArgs) Handles TrainingButton.Click
        Me.Hide()
        Training.Show()
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
        LeaveTypeTB.Text = ""
        ReasonTB.Text = ""
    End Sub

    Private Sub DisplayLeaves()
        connection.Open()
        Dim query = "select * from Leaves"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        LeaveDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayLeaves()
    End Sub

    Dim key = 0

    Private Sub EmployeeAccountDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles LeaveDGV.CellMouseClick
        Dim row As DataGridViewRow = LeaveDGV.Rows(e.RowIndex)
        EIdTB.Text = row.Cells(1).Value.ToString
        StartDateDTP.Text = row.Cells(2).Value.ToString
        EndDateDTP.Text = row.Cells(3).Value.ToString
        LeaveTypeTB.Text = row.Cells(4).Value.ToString
        ReasonTB.Text = row.Cells(5).Value.ToString
        If EIdTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If EIdTB.Text = "" Or StartDateDTP.Text = "" Or EndDateDTP.Text = "" Or LeaveTypeTB.Text = "" Or ReasonTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "INSERT INTO Leaves (EId, StartDate, EndDate, LeaveType, Reason) VALUES ('" & EIdTB.Text & "','" & StartDateDTP.Value.ToString("yyyy-MM-dd") & "','" & EndDateDTP.Value.ToString("yyyy-MM-dd") & "','" & LeaveTypeTB.Text & "','" & ReasonTB.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Leaves Record Added")
            connection.Close()
            Reset()
            DisplayLeaves()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If EIdTB.Text = "" Or StartDateDTP.Text = "" Or EndDateDTP.Text = "" Or LeaveTypeTB.Text = "" Or ReasonTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "UPDATE Leaves SET EId='" & EIdTB.Text & "', StartDate='" & StartDateDTP.Value.ToString("yyyy-MM-dd") & "',EndDate='" & EndDateDTP.Value.ToString("yyyy-MM-dd") & "', LeaveType='" & LeaveTypeTB.Text & "', Reason='" & ReasonTB.Text & "' WHERE LId='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Leaves Record Edited")
            connection.Close()
            Reset()
            DisplayLeaves()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from Leaves where LId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Leave Record Deleted")
            connection.Close()
            Reset()
            DisplayLeaves()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PerformanceButton_Click(sender As Object, e As EventArgs)

    End Sub
End Class