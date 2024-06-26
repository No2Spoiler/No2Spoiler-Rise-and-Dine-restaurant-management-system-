Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Report
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
        InvoiceIdTB.Text = ""
        RDate.Text = ""
        PIdTB.Text = ""
    End Sub

    Private Sub DisplayReportDetail()
        connection.Open()
        Dim query = "SELECT R.ReportId AS [Report ID], R.RDate AS [Report Date], P.PId AS [Payment ID], P.PDate AS [Payment Date], I.InvoiceId AS [Invoice ID], I.InvoiceDate AS [Invoice Date] FROM Report R LEFT JOIN Payment P ON R.PId = P.PId LEFT JOIN Invoice I ON R.InvoiceId = I.InvoiceId"
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
        DisplayReportDetail()
    End Sub

    Dim key = 0

    Private Sub EmployeeAccountDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PaymentDGV.CellMouseClick
        Dim row As DataGridViewRow = PaymentDGV.Rows(e.RowIndex)
        InvoiceIdTB.Text = row.Cells(1).Value.ToString
        PIdTB.Text = row.Cells(2).Value.ToString
        RDate.Text = row.Cells(3).Value.ToString
        If InvoiceIdTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub EmployeeAccountDGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles PaymentDGV.CellFormatting
        If e.Value Is DBNull.Value Then
            e.Value = "N/A"
            e.FormattingApplied = True
        End If
    End Sub


    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If RDate.Text = "" Then
            MsgBox("Please fill in Report Date")
        ElseIf InvoiceIdTB.Text = "" AndAlso PIdTB.Text = "" Then
            MsgBox("Please fill in either Invoice ID or Payment ID")
        ElseIf InvoiceIdTB.Text <> "" AndAlso PIdTB.Text <> "" Then
            MsgBox("Please fill in either Invoice ID or Payment ID, but not both")
        Else
            connection.Open()
            Dim query As String = ""
            If InvoiceIdTB.Text <> "" Then
                query = "INSERT INTO Report (InvoiceId, RDate) VALUES (@InvoiceId, @RDate)"
            Else
                query = "INSERT INTO Report (PId, RDate) VALUES (@PId, @RDate)"
            End If
            Dim cmd As SqlCommand = New SqlCommand(query, connection)
            If InvoiceIdTB.Text <> "" Then
                cmd.Parameters.AddWithValue("@InvoiceId", InvoiceIdTB.Text)
            Else
                cmd.Parameters.AddWithValue("@PId", PIdTB.Text)
            End If
            cmd.Parameters.AddWithValue("@RDate", RDate.Value.ToString("yyyy-MM-dd"))
            cmd.ExecuteNonQuery()
            MsgBox("Report Added")
            connection.Close()
            Reset()
            DisplayReportDetail()
        End If
    End Sub


    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If InvoiceIdTB.Text = "" Or Payment.Text = "" Or RDate.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "UPDATE Report SET InvoiceId='" & InvoiceIdTB.Text & "', PId='" & PIdTB.Text & "', RDate='" & RDate.Value.ToString("yyyy-MM-dd") & "' WHERE ReportId='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Invoice Edited")
            connection.Close()
            Reset()
            DisplayReportDetail()
        End If
    End Sub


    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from Report where ReportId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Invoice Deleted")
            connection.Close()
            Reset()
            DisplayReportDetail()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub
End Class