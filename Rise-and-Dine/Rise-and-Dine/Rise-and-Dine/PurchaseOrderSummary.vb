Public Class PurchaseOrderSummary
    Private Sub EmployeeAccountButton1_Click(sender As Object, e As EventArgs) Handles EmployeeAccountButton1.Click
        Me.Hide()
        EmployeeAccount.Show()
    End Sub

    Private Sub ProductClassButton2_Click(sender As Object, e As EventArgs) Handles ProductClassButton2.Click
        Me.Hide()
        ProductClassForm2.Show()
    End Sub

    Private Sub PurchaseOrderButton4_Click(sender As Object, e As EventArgs) Handles PurchaseOrderButton4.Click
        Me.Hide()
        PurchaseOrderForm2.Show()
    End Sub

    Private Sub SupplierButton5_Click(sender As Object, e As EventArgs) Handles SupplierButton5.Click
        Me.Hide()
        Supplier.Show()
    End Sub

    Private Sub PruchaseMenuButton_Click(sender As Object, e As EventArgs) Handles PruchaseMenuButton.Click
        Me.Hide()
        Purchase.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub PurchaseOrderSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinanceDataSet1.PurchaseOrderSummary' table. You can move, or remove it, as needed.
        Me.PurchaseOrderSummaryTableAdapter.Fill(Me.FinanceDataSet1.PurchaseOrderSummary)

    End Sub

End Class