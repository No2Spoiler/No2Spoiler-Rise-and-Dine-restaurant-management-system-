Imports System.Data.SqlClient

Public Class Item
    Dim connection As New SqlConnection("Data Source=NO1SPOILER\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub EmployeeButton_Click(sender As Object, e As EventArgs) Handles EmployeeButton.Click
        Me.Hide()
        EmployeeAccount.Show()
    End Sub

    Private Sub OrderButton_Click(sender As Object, e As EventArgs) Handles OrderButton.Click
        Me.Hide()
        Orders.Show()
    End Sub

    Private Sub OrderDetailsButton_Click(sender As Object, e As EventArgs) Handles OrderDetailsButton.Click
        Me.Hide()
        OrderDetails.Show()
    End Sub

    Private Sub CategoryButton_Click(sender As Object, e As EventArgs) Handles CategoryButton.Click
        Me.Hide()
        Category.Show()
    End Sub

    Private Sub FoodAndBeverageMenuButton_Click(sender As Object, e As EventArgs) Handles FoodAndBeverageMenuButton.Click, FoodAndBeverageMenuButton.Click
        Me.Hide()
        FoodAndBeverage.Show()
    End Sub

    Private Sub MainMenuButton_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Reset()
        CatIdTB.Text = ""
        ItemNameTB.Text = ""
        DescriptionTB.Text = ""
        PriceTB.Text = ""
    End Sub

    Private Sub DisplayItemDetailView()
        connection.Open()
        Dim query = "select * from ItemDetails"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDetailViewDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItemDetailView()
    End Sub

    Dim key = 0

    Private Sub EmployeeAccountDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDetailViewDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDetailViewDGV.Rows(e.RowIndex)
        CatIdTB.Text = row.Cells(1).Value.ToString
        ItemNameTB.Text = row.Cells(2).Value.ToString
        DescriptionTB.Text = row.Cells(3).Value.ToString
        PriceTB.Text = row.Cells(4).Value.ToString
        If CatIdTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If CatIdTB.Text = "" Or ItemNameTB.Text = "" Or DescriptionTB.Text = "" Or PriceTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "INSERT INTO Item (CatId, ItemName, Description, Price) VALUES ('" & CatIdTB.Text & "', '" & ItemNameTB.Text & "', '" & DescriptionTB.Text & "', '" & PriceTB.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Item Added")
            connection.Close()
            Reset()
            DisplayItemDetailView()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If CatIdTB.Text = "" Or ItemNameTB.Text = "" Or DescriptionTB.Text = "" Or PriceTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "UPDATE Item SET CatId='" & CatIdTB.Text & "', ItemName='" & ItemNameTB.Text & "', Description='" & DescriptionTB.Text & "', Price='" & PriceTB.Text & "' WHERE ItemId='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Item Edited")
            connection.Close()
            Reset()
            DisplayItemDetailView()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from Item where ItemId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Item Deleted")
            connection.Close()
            Reset()
            DisplayItemDetailView()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub
End Class