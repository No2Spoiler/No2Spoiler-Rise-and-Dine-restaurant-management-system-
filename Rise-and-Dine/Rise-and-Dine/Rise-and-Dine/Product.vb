Imports System.Data.SqlClient

Public Class Product
    Dim connection As New SqlConnection("Data Source=NO1SPOILER\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

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

    Private Sub Reset()
        ProductNameTB.Text = ""
        ProductClassNameTB.Text = ""
    End Sub

    Private Sub DisplayProductSupplierDetail()
        connection.Open()
        Dim query = "select * from ProductSupplierDetail"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ProductSupplierDetailDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayProductSupplierDetail()
    End Sub

    Dim key = 0

    Private Sub EmployeeAccountDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ProductSupplierDetailDGV.CellMouseClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < ProductSupplierDetailDGV.Rows.Count Then ' Check if row index is valid
            Dim row As DataGridViewRow = ProductSupplierDetailDGV.Rows(e.RowIndex)
            ProductNameTB.Text = row.Cells("ProductName").Value.ToString
            ProductClassNameTB.Text = row.Cells("ProductClassName").Value.ToString
            If ProductNameTB.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells("ProductId").Value.ToString)
            End If
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If ProductNameTB.Text = "" Or ProductClassNameTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "INSERT INTO Product (ProductName, ProductClassName) VALUES ('" & ProductNameTB.Text & "', '" & ProductClassNameTB.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Product Added")
            connection.Close()
            Reset()
            DisplayProductSupplierDetail()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If ProductNameTB.Text = "" Or ProductClassNameTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "UPDATE Product SET  ProductName='" & ProductNameTB.Text & "', ProductClassName='" & ProductClassNameTB.Text & "' WHERE ProductId='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Product Edited")
            connection.Close()
            Reset()
            DisplayProductSupplierDetail()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from Product where ProductId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Product Deleted")
            connection.Close()
            Reset()
            DisplayProductSupplierDetail()
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