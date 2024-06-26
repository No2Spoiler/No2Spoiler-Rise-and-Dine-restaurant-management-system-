Public Class Purchase
    Private Sub EmployeeAccountButton1_Click(sender As Object, e As EventArgs) Handles EmployeeAccountButton1.Click
        Me.Hide()
        EmployeeAccount.Show()
    End Sub

    Private Sub ProductClassButton2_Click(sender As Object, e As EventArgs) Handles ProductClassButton2.Click
        Me.Hide()
        ProductClassForm2.Show()
    End Sub

    Private Sub ProductButton3_Click(sender As Object, e As EventArgs) Handles ProductButton3.Click
        Me.Hide()
        Product.Show()
    End Sub

    Private Sub PurchaseOrderButton4_Click(sender As Object, e As EventArgs) Handles PurchaseOrderButton4.Click
        Me.Hide()
        PurchaseOrderForm2.Show()
    End Sub

    Private Sub SupplierButton5_Click(sender As Object, e As EventArgs) Handles SupplierButton5.Click
        Me.Hide()
        Supplier.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        PurchaseOrderSummary.Show()
    End Sub
End Class
