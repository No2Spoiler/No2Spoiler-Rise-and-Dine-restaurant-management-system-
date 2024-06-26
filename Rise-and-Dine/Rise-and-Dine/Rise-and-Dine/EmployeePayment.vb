Imports System.Data.SqlClient

Public Class EmployeePayment
    Dim connection As New SqlConnection("Data Source=NO1SPOILER\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

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
        PIdTB.Text = ""
        EPAmountTB.Text = ""
    End Sub

    Private Sub DisplayEmployeePayment()
        connection.Open()
        Dim query = "select * from EmployeeSalaryPayment"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        EmployeePaymentDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayEmployeePayment()
    End Sub

    Dim key = 0

    Private Sub EmployeePaymentDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmployeePaymentDGV.CellMouseClick
        If e.RowIndex >= 0 Then ' make sure a row is actually clicked
            Dim row As DataGridViewRow = EmployeePaymentDGV.Rows(e.RowIndex)
            EIdTB.Text = row.Cells("EId").Value.ToString()
            PIdTB.Text = row.Cells("PId").Value.ToString()
            EPAmountTB.Text = row.Cells("PAmount").Value.ToString()
            key = Convert.ToInt32(row.Cells("EId").Value.ToString())
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If EIdTB.Text = "" Or PIdTB.Text = "" Or EPAmountTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "INSERT INTO EmployeePayment (EId, PId, EPAmount) VALUES('" & EIdTB.Text & "', '" & PIdTB.Text & "', '" & EPAmountTB.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Payment Added")
            connection.Close()
            Reset()
            DisplayEmployeePayment()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If EIdTB.Text = "" Or PIdTB.Text = "" Or EPAmountTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "UPDATE EmployeePayment SET EId='" & EIdTB.Text & "', PId='" & PIdTB.Text & "', EPAmount='" & EPAmountTB.Text & "' WHERE EId='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Payment Edited")
            connection.Close()
            Reset()
            DisplayEmployeePayment()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from EmployeePayment where EId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Payment Deleted")
            connection.Close()
            Reset()
            DisplayEmployeePayment()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub
End Class