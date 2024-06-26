Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class InventoryDetails
    Dim connection As New SqlConnection("Data Source=NO1SPOILER\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub Button1Supplier_Click(sender As Object, e As EventArgs) Handles Button1Supplier.Click
        Me.Hide()
        Supplier.Show()
    End Sub
    Private Sub Button2Inventory_Click(sender As Object, e As EventArgs) Handles Button2Inventory.Click
        Me.Hide()
        Inventory.Show()
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
        InventoryIdTB.Text = ""
        InventoryDTypeTB.Text = ""
        InventoryDDate.Text = ""
        InventoryDUnitTB.Text = ""
        InventoryDAmountTB.Text = ""
    End Sub

    Private Sub DisplayInventoryDetail()
        connection.Open()
        Dim query = "select * from InventoryDetail"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        InventoryDDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayInventoryDetail()
    End Sub

    Dim key = 0

    Private Sub EmployeeAccountDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles InventoryDDGV.CellMouseClick
        Dim row As DataGridViewRow = InventoryDDGV.Rows(e.RowIndex)
        InventoryIdTB.Text = row.Cells(1).Value.ToString
        InventoryDTypeTB.Text = row.Cells(2).Value.ToString
        InventoryDDate.Text = row.Cells(3).Value.ToString
        InventoryDUnitTB.Text = row.Cells(4).Value.ToString
        InventoryDAmountTB.Text = row.Cells(5).Value.ToString
        If InventoryIdTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If InventoryIdTB.Text = "" Or InventoryDTypeTB.Text = "" Or InventoryDDate.Text = "" Or InventoryDUnitTB.Text = "" Or InventoryDAmountTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "INSERT INTO InventoryDetail (InventoryId, InventoryDType, InventoryDDate, InventoryDUnit, InventoryDAmount) VALUES('" & InventoryIdTB.Text & "', '" & InventoryDTypeTB.Text & "', '" & InventoryDDate.Value.ToString("yyyy-MM-dd") & "'," & InventoryDUnitTB.Text & "," & InventoryDAmountTB.Text & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Inventory Detail Added")
            connection.Close()
            Reset()
            DisplayInventoryDetail()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If InventoryIdTB.Text = "" Or InventoryDTypeTB.Text = "" Or InventoryDDate.Text = "" Or InventoryDUnitTB.Text = "" Or InventoryDAmountTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "UPDATE InventoryDetail SET InventoryId='" & InventoryIdTB.Text & "', InventoryDType='" & InventoryDTypeTB.Text & "', InventoryDDate='" & InventoryDDate.Value.ToString("yyyy-MM-dd") & "', InventoryDUnit='" & InventoryDUnitTB.Text & "',InventoryDAmount=" & InventoryDAmountTB.Text & " WHERE InventoryDId='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Inventory Detail Edited")
            connection.Close()
            Reset()
            DisplayInventoryDetail()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from InventoryDetail where InventoryDId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Inventory Detail Deleted")
            connection.Close()
            Reset()
            DisplayInventoryDetail()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub
End Class