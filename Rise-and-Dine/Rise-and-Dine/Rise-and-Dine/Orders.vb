Imports System.Data.SqlClient

Public Class Orders
    Dim connection As New SqlConnection("Data Source=NO1SPOILER\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub EmployeeButton_Click(sender As Object, e As EventArgs) Handles EmployeeButton.Click
        Me.Hide()
        EmployeeAccount.Show()
    End Sub

    Private Sub OrderDetailsButton_Click(sender As Object, e As EventArgs) Handles OrderDetailsButton.Click
        Me.Hide()
        OrderDetails.Show()
    End Sub

    Private Sub ItemButton_Click(sender As Object, e As EventArgs) Handles ItemButton.Click
        Me.Hide()
        Item.Show()
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
        EIdTB.Text = ""
        OrderTotalPriceTB.Text = ""
        OrderDate.Text = ""
        OrderTotalTB.Text = ""
        StatusTB.Text = ""
    End Sub

    Private Sub DisplayOrderPlaceByEmployee()
        connection.Open()
        Dim query = "select * from OrderPlaceByEmployee"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        OrderPlaceByEmployeeDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayOrderPlaceByEmployee()
    End Sub

    Dim key = 0

    Private Sub EmployeeAccountDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles OrderPlaceByEmployeeDGV.CellMouseClick
        Dim row As DataGridViewRow = OrderPlaceByEmployeeDGV.Rows(e.RowIndex)
        EIdTB.Text = row.Cells(1).Value.ToString
        OrderDate.Text = row.Cells(2).Value.ToString
        OrderTotalTB.Text = row.Cells(3).Value.ToString
        OrderTotalPriceTB.Text = row.Cells(4).Value.ToString
        StatusTB.Text = row.Cells(5).Value.ToString
        If EIdTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If EIdTB.Text = "" Or OrderDate.Text = "" Or OrderTotalTB.Text = "" Or OrderTotalPriceTB.Text = "" Or StatusTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "INSERT INTO Orders (EId, OrderDate, OrderTotal, OrderTotalPrice, Status) VALUES ('" & EIdTB.Text & "', '" & OrderDate.Value.ToString("yyyy-MM-dd") & "', '" & OrderTotalTB.Text & "', '" & OrderTotalPriceTB.Text & "', '" & StatusTB.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Order Added")
            connection.Close()
            Reset()
            DisplayOrderPlaceByEmployee()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If EIdTB.Text = "" Or OrderDate.Text = "" Or OrderTotalTB.Text = "" Or OrderTotalPriceTB.Text = "" Or StatusTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "UPDATE Orders SET EId='" & EIdTB.Text & "', OrderDate='" & OrderDate.Value.ToString("yyyy-MM-dd") & "', OrderTotal='" & OrderTotalTB.Text & "', OrderTotalPrice='" & OrderTotalPriceTB.Text & "', Status='" & StatusTB.Text & "' WHERE OrderId='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Order Edited")
            connection.Close()
            Reset()
            DisplayOrderPlaceByEmployee()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from Orders where OrderId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Order Deleted")
            connection.Close()
            Reset()
            DisplayOrderPlaceByEmployee()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub
End Class