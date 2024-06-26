Public Class FoodAndBeverage
    Private Sub EmployeeButton_Click(sender As Object, e As EventArgs) Handles EmployeeButton.Click
        Me.Hide()
        EmployeeAccount.Show()
    End Sub

    Private Sub OrderButton_Click(sender As Object, e As EventArgs) Handles OrderButton.Click
        Me.Hide()
        Orders.Show()
    End Sub

    Private Sub OrderDetailsButton_Click(sender As Object, e As EventArgs) Handles OrderDetailsButton.Click
        Me.Hide()
        OrderDetails.Show()
    End Sub

    Private Sub ItemButton_Click(sender As Object, e As EventArgs) Handles ItemButton.Click
        Me.Hide()
        Item.Show()
    End Sub

    Private Sub CategoryButton_Click(sender As Object, e As EventArgs) Handles CategoryButton.Click
        Me.Hide()
        Category.Show()
    End Sub

    Private Sub MainMenuButton_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class
