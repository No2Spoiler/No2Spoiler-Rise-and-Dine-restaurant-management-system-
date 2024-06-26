Public Class InventoryMenu

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        InventorySummary.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class
