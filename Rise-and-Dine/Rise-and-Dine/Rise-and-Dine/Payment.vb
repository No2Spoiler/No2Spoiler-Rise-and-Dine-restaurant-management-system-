Imports System.Data.SqlClient

Public Class Payment
    Dim connection As New SqlConnection("Data Source=NO1SPOILER\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub EmployeeAccountButton_Click(sender As Object, e As EventArgs) Handles EmployeeAccountButton.Click
        Me.Hide()
        EmployeeAccount.Show()
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

    Private Sub FinanceMenu_Click(sender As Object, e As EventArgs) Handles FinanceMenuButton.Click
        Me.Hide()
        Finance.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
    Private Sub Reset()
        EIdTB.Text = ""
        PTypeTB.Text = ""
        PDate.Text = ""
        PAmountTB.Text = ""
    End Sub

    Private Sub DisplayPayment()
        connection.Open()
        Dim query = "select * from Payment"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        PaymentDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayPayment()
    End Sub

    Dim key = 0

    Private Sub EmployeeAccountDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PaymentDGV.CellMouseClick
        Dim row As DataGridViewRow = PaymentDGV.Rows(e.RowIndex)
        EIdTB.Text = row.Cells(1).Value.ToString
        PTypeTB.Text = row.Cells(2).Value.ToString
        PDate.Text = row.Cells(3).Value.ToString
        PAmountTB.Text = row.Cells(4).Value.ToString
        If EIdTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If EIdTB.Text = "" Or PTypeTB.Text = "" Or PDate.Text = "" Or PAmountTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "INSERT INTO Payment (EId, PType, PDate, PAmount) VALUES('" & EIdTB.Text & "', '" & PTypeTB.Text & "', '" & PDate.Value.ToString("yyyy-MM-dd") & "'," & PAmountTB.Text & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Payment Added")
            connection.Close()
            Reset()
            DisplayPayment()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If EIdTB.Text = "" Or PTypeTB.Text = "" Or PDate.Text = "" Or PAmountTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "UPDATE Payment SET EId='" & EIdTB.Text & "', PType='" & PTypeTB.Text & "', PDate='" & PDate.Value.ToString("yyyy-MM-dd") & "', PAmount=" & PAmountTB.Text & " WHERE PId='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Payemnt Edited")
            connection.Close()
            Reset()
            DisplayPayment()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from Payment where PId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Payment Deleted")
            connection.Close()
            Reset()
            DisplayPayment()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub
End Class