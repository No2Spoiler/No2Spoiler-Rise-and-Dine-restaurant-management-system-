Public Class LeavesTraining
    Private Sub EmployeeAccountButton_Click(sender As Object, e As EventArgs) Handles EmployeeAccountButton.Click
        Me.Hide()
        EmployeeAccount.Show()
    End Sub

    Private Sub HiringButton_Click(sender As Object, e As EventArgs) Handles HiringButton.Click
        Me.Hide()
        Hiring.Show()
    End Sub

    Private Sub PerformanceButton_Click(sender As Object, e As EventArgs) Handles PerformanceButton.Click
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

    Private Sub HRMenuButton_Click(sender As Object, e As EventArgs) Handles HRMenuButton.Click
        Me.Hide()
        HumanResource.Show()
    End Sub

    Private Sub MainMenuButton_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub LeavesTraining_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LeavesTrainingDataset.EmployeeLeaveTrainingView' table. You can move, or remove it, as needed.
        Me.EmployeeLeaveTrainingViewTableAdapter.Fill(Me.LeavesTrainingDataset.EmployeeLeaveTrainingView)

    End Sub
    Private Sub EmployeeAccountDGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles LeaveTrainingvViewDGV.CellFormatting
        If e.Value Is DBNull.Value Then
            e.Value = "-"
            e.FormattingApplied = True
        End If
    End Sub
End Class