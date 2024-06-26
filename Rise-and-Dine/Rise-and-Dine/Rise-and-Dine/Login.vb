Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UserNameTB.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UserNameTB.Text = "" Or PasswordTB.Text = "" Then
            MsgBox("Enter User Name and Password ")
        ElseIf UserNameTB.Text = "Admin" And PasswordTB.Text = "123" Then
            Me.Hide()
            MainMenu.Show()
        Else
            MsgBox("Incorrect User Name or Password")
            UserNameTB.Text = ""
            PasswordTB.Text = ""
        End If

    End Sub
End Class