Imports System.Data.SqlClient

Public Class OrderDetails
    Dim connection As New SqlConnection("Data Source=NO1SPOILER\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

    Private Sub EmployeeButton_Click(sender As Object, e As EventArgs) Handles EmployeeButton.Click
        Me.Hide()
        EmployeeAccount.Show()
    End Sub

    Private Sub OrderButton_Click(sender As Object, e As EventArgs) Handles OrderButton.Click
        Me.Hide()
        Orders.Show()
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
        OrderIdTB.Text = ""
        ItemIdTB.Text = ""
        QuantityTB.Text = ""
    End Sub

    Private Sub DisplayOrderDetails()
        connection.Open()
        Dim query = "select * from OrderDetails"
        Dim cmd = New SqlCommand(query, connection)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        OrderDetailsDGV.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayOrderDetails()
    End Sub

    Dim key = 0

    Private Sub EmployeeAccountDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles OrderDetailsDGV.CellMouseClick
        Dim row As DataGridViewRow = OrderDetailsDGV.Rows(e.RowIndex)
        OrderIdTB.Text = row.Cells(1).Value.ToString
        ItemIdTB.Text = row.Cells(2).Value.ToString
        QuantityTB.Text = row.Cells(3).Value.ToString
        If OrderIdTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If OrderIdTB.Text = "" Or ItemIdTB.Text = "" Or QuantityTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "INSERT INTO OrderDetails (OrderId, ItemId, Quantity) VALUES ('" & OrderIdTB.Text & "', '" & ItemIdTB.Text & "', '" & QuantityTB.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Order Detail Added")
            connection.Close()
            Reset()
            DisplayOrderDetails()
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If OrderIdTB.Text = "" Or ItemIdTB.Text = "" Or QuantityTB.Text = "" Then
            MsgBox("Please fill in all the information")
        Else
            connection.Open()
            Dim query = "UPDATE OrderDetails SET OrderId='" & OrderIdTB.Text & "', ItemId='" & ItemIdTB.Text & "', Quantity='" & QuantityTB.Text & "' WHERE OrderId='" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Order Detail Edited")
            connection.Close()
            Reset()
            DisplayOrderDetails()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            connection.Open()
            Dim query = "delete from OrderDetails where DetailId=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            MsgBox("Order Detail Deleted")
            connection.Close()
            Reset()
            DisplayOrderDetails()
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Reset()
    End Sub
End Class