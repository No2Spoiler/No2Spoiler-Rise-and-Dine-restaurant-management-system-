Imports System.Data.SqlClient

Public Class PurchaseOrderForm2
    Dim connection As New SqlConnection("Data Source=NO1SPOILER\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub EmployeeAccountButton1_Click(sender As Object, e As EventArgs) Handles EmployeeAccountButton1.Click
        Me.Hide()
        EmployeeAccount.Show()
    End Sub

    Private Sub ProductClassButton2_Click(sender As Object, e As EventArgs) Handles ProductClassButton2.Click
        Me.Hide()
        ProductClassForm2.Show()
    End Sub
    Private Sub ProductButton3_Click(sender As Object, e As EventArgs) Handles ProductButton3.Click
        Me.Hide()
        ProductClassForm2.Show()
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
        EIdTB.Text = ""
        SupplierIDTB.Text = ""
        PODate.Text = ""
        DeliveryDate.Text = ""
        ProductIdTB.Text = ""
        ProductQuantityTB.Text = ""
        ProductPriceTB.Text = ""
        LineTotalTB.Text = ""
    End Sub

    Private Sub DisplayPurchaseOrder()
        connection.Open()
        Dim query = "select * from PurchaseOrder"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        PurchaseOrderDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayPurchaseOrder()
    End Sub

    Dim key = 0

    Private Sub EmployeeAccountDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PurchaseOrderDGV.CellMouseClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < PurchaseOrderDGV.Rows.Count Then ' Check if row index is valid
            Dim row As DataGridViewRow = PurchaseOrderDGV.Rows(e.RowIndex)
            EIdTB.Text = row.Cells("EId").Value.ToString
            SupplierIDTB.Text = row.Cells("SupplierId").Value.ToString
            PODate.Text = row.Cells("PODate").Value.ToString
            DeliveryDate.Text = row.Cells("DeliveryDate").Value.ToString
            ProductIdTB.Text = row.Cells("ProductId").Value.ToString
            ProductQuantityTB.Text = row.Cells("ProductQty").Value.ToString
            ProductPriceTB.Text = row.Cells("ProductPrice").Value.ToString
            LineTotalTB.Text = row.Cells("LineTotal").Value.ToString
            If EIdTB.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells("POId").Value.ToString)
            End If
        End If
    End Sub





    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If EIdTB.Text = "" Or SupplierIDTB.Text = "" Or PODate.Text = "" Or DeliveryDate.Text = "" Or ProductIdTB.Text = "" Or ProductQuantityTB.Text = "" Or ProductPriceTB.Text = "" Or LineTotalTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "INSERT INTO PurchaseOrder (EId, SupplierId, PODate, DeliveryDate, ProductID, ProductQty, ProductPrice, LineTotal) VALUES ('" & EIdTB.Text & "', '" & SupplierIDTB.Text & "', '" & PODate.Value.ToString("yyyy-MM-dd") & "', '" & DeliveryDate.Value.ToString("yyyy-MM-dd") & "', '" & ProductIdTB.Text & "', '" & ProductQuantityTB.Text & "', '" & ProductPriceTB.Text & "', '" & LineTotalTB.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Purchase Order Added")
            connection.Close()
            Reset()
            DisplayPurchaseOrder()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If EIdTB.Text = "" Or SupplierIDTB.Text = "" Or PODate.Text = "" Or DeliveryDate.Text = "" Or ProductIdTB.Text = "" Or ProductQuantityTB.Text = "" Or ProductPriceTB.Text = "" Or LineTotalTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query As String = "UPDATE PurchaseOrder SET EId='" & EIdTB.Text & "', SupplierId='" & SupplierIDTB.Text & "', PODate='" & PODate.Value.ToString("yyyy-MM-dd") & "', DeliveryDate='" & DeliveryDate.Value.ToString("yyyy-MM-dd") & "', ProductID='" & ProductIdTB.Text & "', ProductQty='" & ProductQuantityTB.Text & "', ProductPrice='" & ProductPriceTB.Text & "', LineTotal='" & LineTotalTB.Text & "' WHERE POId=" & key
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Purchase Order Edited")
            connection.Close()
            Reset()
            DisplayPurchaseOrder()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from PurchaseOrder where POId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Purchase Order Deleted")
            connection.Close()
            Reset()
            DisplayPurchaseOrder()
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