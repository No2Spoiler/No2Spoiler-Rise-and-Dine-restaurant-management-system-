<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FoodAndBeverageMenuButton = New System.Windows.Forms.Button()
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.CategoryButton = New System.Windows.Forms.Button()
        Me.ItemButton = New System.Windows.Forms.Button()
        Me.EmployeeButton = New System.Windows.Forms.Button()
        Me.OrderButton = New System.Windows.Forms.Button()
        Me.OrderDetailsButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.OrderPlaceByEmployeeDGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StatusTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderDate = New System.Windows.Forms.DateTimePicker()
        Me.OrderTotalTB = New System.Windows.Forms.TextBox()
        Me.LabelItemName = New System.Windows.Forms.Label()
        Me.EIdTB = New System.Windows.Forms.TextBox()
        Me.OrderTotalPriceTB = New System.Windows.Forms.TextBox()
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.LabelEid = New System.Windows.Forms.Label()
        Me.LabelDesc = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.OrderPlaceByEmployeeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.FoodAndBeverageMenuButton)
        Me.Panel1.Controls.Add(Me.MainMenuButton)
        Me.Panel1.Controls.Add(Me.CategoryButton)
        Me.Panel1.Controls.Add(Me.ItemButton)
        Me.Panel1.Controls.Add(Me.EmployeeButton)
        Me.Panel1.Controls.Add(Me.OrderButton)
        Me.Panel1.Controls.Add(Me.OrderDetailsButton)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 673)
        Me.Panel1.TabIndex = 26
        '
        'FoodAndBeverageMenuButton
        '
        Me.FoodAndBeverageMenuButton.BackColor = System.Drawing.Color.Navy
        Me.FoodAndBeverageMenuButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoodAndBeverageMenuButton.ForeColor = System.Drawing.Color.White
        Me.FoodAndBeverageMenuButton.Location = New System.Drawing.Point(0, 506)
        Me.FoodAndBeverageMenuButton.Name = "FoodAndBeverageMenuButton"
        Me.FoodAndBeverageMenuButton.Size = New System.Drawing.Size(242, 63)
        Me.FoodAndBeverageMenuButton.TabIndex = 9
        Me.FoodAndBeverageMenuButton.Text = "Food and Beverage Menu"
        Me.FoodAndBeverageMenuButton.UseVisualStyleBackColor = False
        '
        'MainMenuButton
        '
        Me.MainMenuButton.BackColor = System.Drawing.Color.Navy
        Me.MainMenuButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuButton.ForeColor = System.Drawing.Color.White
        Me.MainMenuButton.Location = New System.Drawing.Point(0, 575)
        Me.MainMenuButton.Name = "MainMenuButton"
        Me.MainMenuButton.Size = New System.Drawing.Size(242, 63)
        Me.MainMenuButton.TabIndex = 8
        Me.MainMenuButton.Text = "Main Menu"
        Me.MainMenuButton.UseVisualStyleBackColor = False
        '
        'CategoryButton
        '
        Me.CategoryButton.BackColor = System.Drawing.Color.Navy
        Me.CategoryButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryButton.ForeColor = System.Drawing.Color.White
        Me.CategoryButton.Location = New System.Drawing.Point(0, 288)
        Me.CategoryButton.Name = "CategoryButton"
        Me.CategoryButton.Size = New System.Drawing.Size(242, 63)
        Me.CategoryButton.TabIndex = 5
        Me.CategoryButton.Text = "Category"
        Me.CategoryButton.UseVisualStyleBackColor = False
        '
        'ItemButton
        '
        Me.ItemButton.BackColor = System.Drawing.Color.Navy
        Me.ItemButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemButton.ForeColor = System.Drawing.Color.White
        Me.ItemButton.Location = New System.Drawing.Point(3, 222)
        Me.ItemButton.Name = "ItemButton"
        Me.ItemButton.Size = New System.Drawing.Size(239, 60)
        Me.ItemButton.TabIndex = 6
        Me.ItemButton.Text = "Item"
        Me.ItemButton.UseVisualStyleBackColor = False
        '
        'EmployeeButton
        '
        Me.EmployeeButton.BackColor = System.Drawing.Color.Navy
        Me.EmployeeButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeButton.ForeColor = System.Drawing.Color.White
        Me.EmployeeButton.Location = New System.Drawing.Point(3, 11)
        Me.EmployeeButton.Name = "EmployeeButton"
        Me.EmployeeButton.Size = New System.Drawing.Size(239, 63)
        Me.EmployeeButton.TabIndex = 2
        Me.EmployeeButton.Text = "Employee"
        Me.EmployeeButton.UseVisualStyleBackColor = False
        '
        'OrderButton
        '
        Me.OrderButton.BackColor = System.Drawing.Color.Navy
        Me.OrderButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderButton.ForeColor = System.Drawing.Color.White
        Me.OrderButton.Location = New System.Drawing.Point(3, 78)
        Me.OrderButton.Name = "OrderButton"
        Me.OrderButton.Size = New System.Drawing.Size(239, 60)
        Me.OrderButton.TabIndex = 4
        Me.OrderButton.Text = "Order"
        Me.OrderButton.UseVisualStyleBackColor = False
        '
        'OrderDetailsButton
        '
        Me.OrderDetailsButton.BackColor = System.Drawing.Color.Navy
        Me.OrderDetailsButton.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderDetailsButton.ForeColor = System.Drawing.Color.White
        Me.OrderDetailsButton.Location = New System.Drawing.Point(3, 149)
        Me.OrderDetailsButton.Name = "OrderDetailsButton"
        Me.OrderDetailsButton.Size = New System.Drawing.Size(239, 63)
        Me.OrderDetailsButton.TabIndex = 3
        Me.OrderDetailsButton.Text = "Order Details"
        Me.OrderDetailsButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.EditButton.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.ForeColor = System.Drawing.Color.White
        Me.EditButton.Location = New System.Drawing.Point(769, 319)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(138, 42)
        Me.EditButton.TabIndex = 25
        Me.EditButton.Text = "EDIT"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.DeleteButton.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.Location = New System.Drawing.Point(913, 319)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(126, 42)
        Me.DeleteButton.TabIndex = 24
        Me.DeleteButton.Text = "DELETE"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.AddButton.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.White
        Me.AddButton.Location = New System.Drawing.Point(625, 319)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(138, 42)
        Me.AddButton.TabIndex = 23
        Me.AddButton.Text = "ADD"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'OrderPlaceByEmployeeDGV
        '
        Me.OrderPlaceByEmployeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderPlaceByEmployeeDGV.Location = New System.Drawing.Point(365, 381)
        Me.OrderPlaceByEmployeeDGV.Name = "OrderPlaceByEmployeeDGV"
        Me.OrderPlaceByEmployeeDGV.RowHeadersWidth = 51
        Me.OrderPlaceByEmployeeDGV.RowTemplate.Height = 24
        Me.OrderPlaceByEmployeeDGV.Size = New System.Drawing.Size(1075, 223)
        Me.OrderPlaceByEmployeeDGV.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.StatusTB)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.OrderDate)
        Me.GroupBox1.Controls.Add(Me.OrderTotalTB)
        Me.GroupBox1.Controls.Add(Me.LabelItemName)
        Me.GroupBox1.Controls.Add(Me.EIdTB)
        Me.GroupBox1.Controls.Add(Me.OrderTotalPriceTB)
        Me.GroupBox1.Controls.Add(Me.LabelPrice)
        Me.GroupBox1.Controls.Add(Me.LabelEid)
        Me.GroupBox1.Controls.Add(Me.LabelDesc)
        Me.GroupBox1.Location = New System.Drawing.Point(325, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1130, 250)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'StatusTB
        '
        Me.StatusTB.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.StatusTB.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTB.Location = New System.Drawing.Point(733, 90)
        Me.StatusTB.Name = "StatusTB"
        Me.StatusTB.Size = New System.Drawing.Size(314, 34)
        Me.StatusTB.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(644, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Status:"
        '
        'OrderDate
        '
        Me.OrderDate.Location = New System.Drawing.Point(249, 95)
        Me.OrderDate.Name = "OrderDate"
        Me.OrderDate.Size = New System.Drawing.Size(305, 22)
        Me.OrderDate.TabIndex = 14
        '
        'OrderTotalTB
        '
        Me.OrderTotalTB.Location = New System.Drawing.Point(249, 159)
        Me.OrderTotalTB.Multiline = True
        Me.OrderTotalTB.Name = "OrderTotalTB"
        Me.OrderTotalTB.Size = New System.Drawing.Size(307, 33)
        Me.OrderTotalTB.TabIndex = 13
        '
        'LabelItemName
        '
        Me.LabelItemName.AutoSize = True
        Me.LabelItemName.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelItemName.Location = New System.Drawing.Point(102, 92)
        Me.LabelItemName.Name = "LabelItemName"
        Me.LabelItemName.Size = New System.Drawing.Size(136, 25)
        Me.LabelItemName.TabIndex = 9
        Me.LabelItemName.Text = "Order Date:"
        '
        'EIdTB
        '
        Me.EIdTB.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.EIdTB.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EIdTB.Location = New System.Drawing.Point(249, 29)
        Me.EIdTB.Name = "EIdTB"
        Me.EIdTB.Size = New System.Drawing.Size(305, 34)
        Me.EIdTB.TabIndex = 8
        '
        'OrderTotalPriceTB
        '
        Me.OrderTotalPriceTB.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.OrderTotalPriceTB.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderTotalPriceTB.Location = New System.Drawing.Point(733, 32)
        Me.OrderTotalPriceTB.Name = "OrderTotalPriceTB"
        Me.OrderTotalPriceTB.Size = New System.Drawing.Size(314, 34)
        Me.OrderTotalPriceTB.TabIndex = 7
        '
        'LabelPrice
        '
        Me.LabelPrice.AutoSize = True
        Me.LabelPrice.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrice.Location = New System.Drawing.Point(599, 38)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(128, 25)
        Me.LabelPrice.TabIndex = 6
        Me.LabelPrice.Text = "Total Price:"
        '
        'LabelEid
        '
        Me.LabelEid.AutoSize = True
        Me.LabelEid.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEid.Location = New System.Drawing.Point(89, 32)
        Me.LabelEid.Name = "LabelEid"
        Me.LabelEid.Size = New System.Drawing.Size(149, 25)
        Me.LabelEid.TabIndex = 4
        Me.LabelEid.Text = "Employee ID:"
        '
        'LabelDesc
        '
        Me.LabelDesc.AutoSize = True
        Me.LabelDesc.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDesc.Location = New System.Drawing.Point(89, 167)
        Me.LabelDesc.Name = "LabelDesc"
        Me.LabelDesc.Size = New System.Drawing.Size(138, 25)
        Me.LabelDesc.TabIndex = 2
        Me.LabelDesc.Text = "Order Total:"
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.ResetButton.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.White
        Me.ResetButton.Location = New System.Drawing.Point(1045, 319)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(126, 42)
        Me.ResetButton.TabIndex = 27
        Me.ResetButton.Text = "RESET"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Rise_and_Dine.My.Resources.Resources.FnBAllBackGround
        Me.ClientSize = New System.Drawing.Size(1662, 673)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.OrderPlaceByEmployeeDGV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Orders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orders"
        Me.Panel1.ResumeLayout(False)
        CType(Me.OrderPlaceByEmployeeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FoodAndBeverageMenuButton As Button
    Friend WithEvents MainMenuButton As Button
    Friend WithEvents CategoryButton As Button
    Friend WithEvents ItemButton As Button
    Friend WithEvents EmployeeButton As Button
    Friend WithEvents OrderButton As Button
    Friend WithEvents OrderDetailsButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents OrderPlaceByEmployeeDGV As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents OrderTotalTB As TextBox
    Friend WithEvents LabelItemName As Label
    Friend WithEvents EIdTB As TextBox
    Friend WithEvents OrderTotalPriceTB As TextBox
    Friend WithEvents LabelPrice As Label
    Friend WithEvents LabelEid As Label
    Friend WithEvents LabelDesc As Label
    Friend WithEvents OrderDate As DateTimePicker
    Friend WithEvents StatusTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ResetButton As Button
End Class
