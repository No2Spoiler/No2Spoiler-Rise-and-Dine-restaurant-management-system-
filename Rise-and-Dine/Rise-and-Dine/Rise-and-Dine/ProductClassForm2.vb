Imports System.Data.SqlClient

Public Class ProductClassForm2
    Dim connection As New SqlConnection("Data Source=NO1SPOILER\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub EmployeeAccountButton1_Click(sender As Object, e As EventArgs) Handles EmployeeAccountButton1.Click
        Me.Hide()
        EmployeeAccount.Show()
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

    Private Sub PruchaseMenuButton_Click(sender As Object, e As EventArgs) Handles PruchaseMenuButton.Click
        Me.Hide()
        Purchase.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Reset()
        ProductClassNameTB.Text = ""
    End Sub

    Private Sub DisplayProductClass()
        connection.Open()
        Dim query = "select * from ProductClass"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ProductClassDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayProductClass()
    End Sub

    Dim key = 0

    Private Sub EmployeeAccountDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ProductClassDGV.CellMouseClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < ProductClassDGV.Rows.Count Then ' Check if row index is valid
            Dim row As DataGridViewRow = ProductClassDGV.Rows(e.RowIndex)
            ProductClassNameTB.Text = row.Cells("ProductClassName").Value.ToString
            If ProductClassNameTB.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        End If
    End Sub




    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If ProductClassNameTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "INSERT INTO ProductClass (ProductClassName) VALUES ('" & ProductClassNameTB.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Product Class Added")
            connection.Close()
            Reset()
            DisplayProductClass()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If ProductClassNameTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "UPDATE ProductClass SET ProductClassName='" & ProductClassNameTB.Text & "' WHERE ProductClassId='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Product Class Edited")
            connection.Close()
            Reset()
            DisplayProductClass()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from ProductClass where ProductClassId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("ProductClass Deleted")
            connection.Close()
            Reset()
            DisplayProductClass()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        PurchaseOrderSummary.Show()
    End Sub
End Class