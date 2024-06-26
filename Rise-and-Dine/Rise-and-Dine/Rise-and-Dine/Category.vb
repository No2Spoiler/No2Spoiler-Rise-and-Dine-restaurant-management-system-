Imports System.Data.SqlClient

Public Class Category
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

    Private Sub ItemButton_Click(sender As Object, e As EventArgs) Handles ItemButton.Click
        Me.Hide()
        Item.Show()
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
        CatNameTB.Text = ""
    End Sub

    Private Sub DisplayCategory()
        connection.Open()
        Dim query = "select * from Category"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        CatDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCategory()
    End Sub

    Dim key = 0

    Private Sub EmployeeAccountDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CatDGV.CellMouseClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < CatDGV.Rows.Count Then ' Check if row index is valid
            Dim row As DataGridViewRow = CatDGV.Rows(e.RowIndex)
            CatIdTB.Text = row.Cells("CatId").Value.ToString
            CatNameTB.Text = row.Cells("CatName").Value.ToString
            If CatIdTB.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells("CatId").Value.ToString)
            End If
        End If
    End Sub






    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If CatIdTB.Text = "" Or CatNameTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "INSERT INTO Category (CatId, CatName) VALUES ('" & CatIdTB.Text & "', '" & CatNameTB.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Category Added")
            connection.Close()
            Reset()
            DisplayCategory()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If CatIdTB.Text = "" Or CatNameTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "UPDATE Category SET CatId='" & CatIdTB.Text & "', CatName='" & CatNameTB.Text & "' WHERE CatId='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Category Edited")
            connection.Close()
            Reset()
            DisplayCategory()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from Category where CatId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Category Deleted")
            connection.Close()
            Reset()
            DisplayCategory()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub
End Class