Public Class HumanResource
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

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs) Handles LeaveButton.Click
        Me.Hide()
        Leaves.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        LeavesTraining.Show()
    End Sub

    Private Sub MainMenuButton_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class