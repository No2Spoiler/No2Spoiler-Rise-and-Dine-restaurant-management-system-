Public Class Finance
    Private Sub EmployeeAccountButton_Click(sender As Object, e As EventArgs) Handles EmployeeAccountButton.Click
        Me.Hide()
        EmployeeAccount.Show()
    End Sub

    Private Sub PaymentButton_Click(sender As Object, e As EventArgs) Handles PaymentButton.Click
        Me.Hide()
        Payment.Show()
    End Sub

    Private Sub InvoiceButton_Click(sender As Object, e As EventArgs) Handles InvoiceButton.Click
        Me.Hide()
        Invoice.Show()
    End Sub

    Private Sub ReportButton_Click(sender As Object, e As EventArgs) Handles ReportButton.Click
        Me.Hide()
        Report.Show()
    End Sub

    Private Sub EmployeePaymentButton_Click(sender As Object, e As EventArgs) Handles EmployeePaymentButton.Click
        Me.Hide()
        EmployeePayment.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Finance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class