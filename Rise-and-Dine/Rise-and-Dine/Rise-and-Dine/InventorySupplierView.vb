Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class InventorySupplierView
    Dim connection As New SqlConnection("Data Source=NO1SPOILER\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    Private Sub Button1Supplier_Click(sender As Object, e As EventArgs) Handles Button1Supplier.Click
        Me.Hide()
        Supplier.Show()
    End Sub

    Private Sub Button2Inventory_Click(sender As Object, e As EventArgs) Handles Button2Inventory.Click
        Me.Hide()
        Inventory.Show()
    End Sub

    Private Sub Button3InventoryDetails_Click(sender As Object, e As EventArgs) Handles Button3InventoryDetails.Click
        Me.Hide()
        InventoryDetails.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        InventorySummary.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
    Private Sub DisplayInventorySupplier()
        connection.Open()
        Dim query = "select * from InventorySupplier"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        InventorySupplierViewDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub InventorySupplierView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinanceDataSet.InventorySupplier' table. You can move, or remove it, as needed.
        InventorySupplierTableAdapter.Fill(Me.FinanceDataSet.InventorySupplier)

    End Sub
End Class