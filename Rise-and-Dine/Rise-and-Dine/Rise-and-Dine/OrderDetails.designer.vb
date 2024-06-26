<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderDetails
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
        Me.OrderDetailsDGV = New System.Windows.Forms.DataGridView()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FoodAndBeverageMenuButton = New System.Windows.Forms.Button()
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.CategoryButton = New System.Windows.Forms.Button()
        Me.ItemButton = New System.Windows.Forms.Button()
        Me.EmployeeButton = New System.Windows.Forms.Button()
        Me.OrderButton = New System.Windows.Forms.Button()
        Me.OrderDetailsButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ItemIdTB = New System.Windows.Forms.TextBox()
        Me.LabelItemName = New System.Windows.Forms.Label()
        Me.OrderIdTB = New System.Windows.Forms.TextBox()
        Me.QuantityTB = New System.Windows.Forms.TextBox()
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.LabelDesc = New System.Windows.Forms.Label()
        CType(Me.OrderDetailsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OrderDetailsDGV
        '
        Me.OrderDetailsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderDetailsDGV.Location = New System.Drawing.Point(428, 363)
        Me.OrderDetailsDGV.Name = "OrderDetailsDGV"
        Me.OrderDetailsDGV.RowHeadersWidth = 51
        Me.OrderDetailsDGV.RowTemplate.Height = 24
        Me.OrderDetailsDGV.Size = New System.Drawing.Size(849, 223)
        Me.OrderDetailsDGV.TabIndex = 16
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.ResetButton.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.White
        Me.ResetButton.Location = New System.Drawing.Point(995, 308)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(126, 42)
        Me.ResetButton.TabIndex = 31
        Me.ResetButton.Text = "RESET"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.EditButton.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.ForeColor = System.Drawing.Color.White
        Me.EditButton.Location = New System.Drawing.Point(719, 308)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(138, 42)
        Me.EditButton.TabIndex = 30
        Me.EditButton.Text = "EDIT"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.DeleteButton.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.Location = New System.Drawing.Point(863, 308)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(126, 42)
        Me.DeleteButton.TabIndex = 29
        Me.DeleteButton.Text = "DELETE"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.AddButton.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.White
        Me.AddButton.Location = New System.Drawing.Point(575, 308)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(138, 42)
        Me.AddButton.TabIndex = 28
        Me.AddButton.Text = "ADD"
        Me.AddButton.UseVisualStyleBackColor = False
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
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 673)
        Me.Panel1.TabIndex = 32
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ItemIdTB)
        Me.GroupBox1.Controls.Add(Me.LabelItemName)
        Me.GroupBox1.Controls.Add(Me.OrderIdTB)
        Me.GroupBox1.Controls.Add(Me.QuantityTB)
        Me.GroupBox1.Controls.Add(Me.LabelPrice)
        Me.GroupBox1.Controls.Add(Me.LabelDesc)
        Me.GroupBox1.Location = New System.Drawing.Point(428, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(849, 106)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'ItemIdTB
        '
        Me.ItemIdTB.Location = New System.Drawing.Point(410, 38)
        Me.ItemIdTB.Multiline = True
        Me.ItemIdTB.Name = "ItemIdTB"
        Me.ItemIdTB.Size = New System.Drawing.Size(135, 33)
        Me.ItemIdTB.TabIndex = 13
        '
        'LabelItemName
        '
        Me.LabelItemName.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.LabelItemName.AutoSize = True
        Me.LabelItemName.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelItemName.Location = New System.Drawing.Point(44, 46)
        Me.LabelItemName.Name = "LabelItemName"
        Me.LabelItemName.Size = New System.Drawing.Size(114, 25)
        Me.LabelItemName.TabIndex = 9
        Me.LabelItemName.Text = "Order ID:"
        '
        'OrderIdTB
        '
        Me.OrderIdTB.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.OrderIdTB.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderIdTB.Location = New System.Drawing.Point(164, 36)
        Me.OrderIdTB.Name = "OrderIdTB"
        Me.OrderIdTB.Size = New System.Drawing.Size(133, 34)
        Me.OrderIdTB.TabIndex = 8
        '
        'QuantityTB
        '
        Me.QuantityTB.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.QuantityTB.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTB.Location = New System.Drawing.Point(657, 38)
        Me.QuantityTB.Name = "QuantityTB"
        Me.QuantityTB.Size = New System.Drawing.Size(142, 34)
        Me.QuantityTB.TabIndex = 7
        '
        'LabelPrice
        '
        Me.LabelPrice.AutoSize = True
        Me.LabelPrice.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrice.Location = New System.Drawing.Point(551, 46)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(100, 25)
        Me.LabelPrice.TabIndex = 6
        Me.LabelPrice.Text = "Quantity"
        '
        'LabelDesc
        '
        Me.LabelDesc.AutoSize = True
        Me.LabelDesc.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDesc.Location = New System.Drawing.Point(303, 45)
        Me.LabelDesc.Name = "LabelDesc"
        Me.LabelDesc.Size = New System.Drawing.Size(99, 25)
        Me.LabelDesc.TabIndex = 2
        Me.LabelDesc.Text = "Item ID:"
        '
        'OrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.BackgroundImage = Global.Rise_and_Dine.My.Resources.Resources.FnBAllBackGround
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1662, 673)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.OrderDetailsDGV)
        Me.Name = "OrderDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OrderDetails"
        CType(Me.OrderDetailsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OrderDetailsDGV As DataGridView
    Friend WithEvents ResetButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FoodAndBeverageMenuButton As Button
    Friend WithEvents MainMenuButton As Button
    Friend WithEvents CategoryButton As Button
    Friend WithEvents ItemButton As Button
    Friend WithEvents EmployeeButton As Button
    Friend WithEvents OrderButton As Button
    Friend WithEvents OrderDetailsButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ItemIdTB As TextBox
    Friend WithEvents LabelItemName As Label
    Friend WithEvents OrderIdTB As TextBox
    Friend WithEvents QuantityTB As TextBox
    Friend WithEvents LabelPrice As Label
    Friend WithEvents LabelDesc As Label
End Class
