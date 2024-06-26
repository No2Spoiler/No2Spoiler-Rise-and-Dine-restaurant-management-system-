Public Class InventorySummary
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
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        InventorySupplierView.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub InventorySummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventorySummaryDataset.InventorySummary' table. You can move, or remove it, as needed.
        Me.InventorySummaryTableAdapter.Fill(Me.InventorySummaryDataset.InventorySummary)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class