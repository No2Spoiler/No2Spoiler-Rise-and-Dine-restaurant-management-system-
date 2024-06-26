﻿Imports System.Data.SqlClient
Public Class EmployeeAccount
    Dim connection As New SqlConnection("Data Source=NO1SPOILER\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

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

    Private Sub FinanceMenu_Click(sender As Object, e As EventArgs) Handles FinanceMenuButton.Click
        Me.Hide()
        Finance.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Reset()
        EContactTB.Text = ""
        ESalaryTB.Text = ""
        ENameTB.Text = ""
    End Sub

    Private Sub DisplayEmployeeAccount()
        connection.Open()
        Dim query = "select * from EmployeeAccount"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        EmployeeAccountDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayEmployeeAccount()
    End Sub

    Dim key = 0

    Private Sub EmployeeAccountDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmployeeAccountDGV.CellMouseClick
        Dim row As DataGridViewRow = EmployeeAccountDGV.Rows(e.RowIndex)
        ENameTB.Text = row.Cells(1).Value.ToString
        EContactTB.Text = row.Cells(2).Value.ToString
        ESalaryTB.Text = row.Cells(3).Value.ToString
        If ENameTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If ENameTB.Text = "" Or EContactTB.Text = "" Or ESalaryTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "INSERT INTO EmployeeAccount (EName, EContact, ESalary) VALUES('" & ENameTB.Text & "', '" & EContactTB.Text & "', '" & ESalaryTB.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Account Added")
            connection.Close()
            Reset()
            DisplayEmployeeAccount()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If ENameTB.Text = "" Or EContactTB.Text = "" Or ESalaryTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "UPDATE EmployeeAccount SET EName='" & ENameTB.Text & "', EContact='" & EContactTB.Text & "', ESalary=" & ESalaryTB.Text & " WHERE EId='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Account edited")
            connection.Close()
            Reset()
            DisplayEmployeeAccount()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from EmployeeAccount where EId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Account deleted")
            connection.Close()
            Reset()
            DisplayEmployeeAccount()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub
End Class