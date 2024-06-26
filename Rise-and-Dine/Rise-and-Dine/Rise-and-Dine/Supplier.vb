Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Windows.Forms.AxHost

Public Class Supplier
    Dim connection As New SqlConnection("Data Source=NO1SPOILER\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")


    Private Sub Button2Inventory_Click(sender As Object, e As EventArgs) Handles Button2Inventory.Click
        Me.Hide()
        Inventory.Show()
    End Sub

    Private Sub Button3InventoryDetails_Click(sender As Object, e As EventArgs) Handles Button3InventoryDetails.Click
        Me.Hide()
        InventoryDetails.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        InventorySupplierView.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        InventorySummary.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Reset()
        SupplierNameTB.Text = ""
        SupplierContactTB.Text = ""
        SupplierAddressTB.Text = ""
    End Sub

    Private Sub DisplaySupplier()
        connection.Open()
        Dim query = "select * from Supplier"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        SupplierDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySupplier()
    End Sub

    Dim key = 0

    Private Sub EmployeeAccountDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SupplierDGV.CellMouseClick
        Dim row As DataGridViewRow = SupplierDGV.Rows(e.RowIndex)
        SupplierNameTB.Text = row.Cells(1).Value.ToString
        SupplierContactTB.Text = row.Cells(2).Value.ToString
        SupplierAddressTB.Text = row.Cells(3).Value.ToString
        If SupplierNameTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If SupplierNameTB.Text = "" Or SupplierContactTB.Text = "" Or SupplierContactTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "INSERT INTO Supplier (SupplierName, SupplierContact, SupplierAddress) VALUES('" & SupplierNameTB.Text & "', '" & SupplierContactTB.Text & "', '" & SupplierAddressTB.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Supplier Added")
            connection.Close()
            Reset()
            DisplaySupplier()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If SupplierNameTB.Text = "" Or SupplierContactTB.Text = "" Or SupplierContactTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "UPDATE Supplier SET SupplierName='" & SupplierNameTB.Text & "', SupplierContact='" & SupplierContactTB.Text & "', SupplierAddress='" & SupplierAddressTB.Text & "' WHERE SupplierId='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Supplier Edited")
            connection.Close()
            Reset()
            DisplaySupplier()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from Supplier where SupplierId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Supplier Deleted")
            connection.Close()
            Reset()
            DisplaySupplier()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub
End Class
