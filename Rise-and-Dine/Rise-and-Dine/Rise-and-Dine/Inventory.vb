Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Inventory
    Dim connection As New SqlConnection("Data Source=NO1SPOILER\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub Button1Supplier_Click(sender As Object, e As EventArgs) Handles Button1Supplier.Click
        Me.Hide()
        Supplier.Show()
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
        InventoryNameTB.Text = ""
        InventoryAmountTB.Text = ""
        UnitPriceTB.Text = ""
        SupplierIdTB.Text = ""
    End Sub

    Private Sub DisplayInventory()
        connection.Open()
        Dim query = "select * from Inventory"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        InventoryDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayInventory()
    End Sub

    Dim key = 0

    Private Sub EmployeeAccountDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles InventoryDGV.CellMouseClick
        Dim row As DataGridViewRow = InventoryDGV.Rows(e.RowIndex)
        InventoryNameTB.Text = row.Cells(1).Value.ToString
        InventoryAmountTB.Text = row.Cells(2).Value.ToString
        UnitPriceTB.Text = row.Cells(3).Value.ToString
        SupplierIdTB.Text = row.Cells(4).Value.ToString
        If InventoryNameTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If InventoryNameTB.Text = "" Or InventoryAmountTB.Text = "" Or UnitPriceTB.Text = "" Or SupplierIdTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "INSERT INTO Inventory (InventoryName, InventoryAmount, UnitPrice, SupplierId) VALUES('" & InventoryNameTB.Text & "', '" & InventoryAmountTB.Text & "', '" & UnitPriceTB.Text & "'," & SupplierIdTB.Text & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Inventory Added")
            connection.Close()
            Reset()
            DisplayInventory()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If InventoryNameTB.Text = "" Or InventoryAmountTB.Text = "" Or UnitPriceTB.Text = "" Or SupplierIdTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "UPDATE Inventory SET InventoryName='" & InventoryNameTB.Text & "', Inventory='" & InventoryAmountTB.Text & "', UnitPrice='" & UnitPriceTB.Text & "', SupplierId='" & SupplierIdTB.Text & "' WHERE InventoryId='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Inventory Edited")
            connection.Close()
            Reset()
            DisplayInventory()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from Inventory where InventoryId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("InventoryId Deleted")
            connection.Close()
            Reset()
            DisplayInventory()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub
End Class