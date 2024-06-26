<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PurchaseOrderForm2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.PODate = New System.Windows.Forms.DateTimePicker()
        Me.ProductPriceTB = New System.Windows.Forms.TextBox()
        Me.LineTotalTB = New System.Windows.Forms.TextBox()
        Me.SupplierIDTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProductQuantityTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProductIdTB = New System.Windows.Forms.TextBox()
        Me.LabelERoles = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelEPass = New System.Windows.Forms.Label()
        Me.LabelEName = New System.Windows.Forms.Label()
        Me.EIdTB = New System.Windows.Forms.TextBox()
        Me.PurchaseOrderDGV = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PruchaseMenuButton = New System.Windows.Forms.Button()
        Me.EmployeeAccountButton1 = New System.Windows.Forms.Button()
        Me.ProductClassButton2 = New System.Windows.Forms.Button()
        Me.ProductButton3 = New System.Windows.Forms.Button()
        Me.PurchaseOrderButton4 = New System.Windows.Forms.Button()
        Me.SupplierButton5 = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PurchaseOrderDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(640, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 45)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "PURCHASE ORDER"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.GroupBox1.Controls.Add(Me.DeliveryDate)
        Me.GroupBox1.Controls.Add(Me.PODate)
        Me.GroupBox1.Controls.Add(Me.ProductPriceTB)
        Me.GroupBox1.Controls.Add(Me.LineTotalTB)
        Me.GroupBox1.Controls.Add(Me.SupplierIDTB)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ProductQuantityTB)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ProductIdTB)
        Me.GroupBox1.Controls.Add(Me.LabelERoles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LabelEPass)
        Me.GroupBox1.Controls.Add(Me.LabelEName)
        Me.GroupBox1.Controls.Add(Me.EIdTB)
        Me.GroupBox1.Location = New System.Drawing.Point(283, 120)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1031, 275)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'DeliveryDate
        '
        Me.DeliveryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveryDate.Location = New System.Drawing.Point(222, 176)
        Me.DeliveryDate.Name = "DeliveryDate"
        Me.DeliveryDate.Size = New System.Drawing.Size(257, 30)
        Me.DeliveryDate.TabIndex = 22
        '
        'PODate
        '
        Me.PODate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PODate.Location = New System.Drawing.Point(222, 136)
        Me.PODate.Name = "PODate"
        Me.PODate.Size = New System.Drawing.Size(257, 30)
        Me.PODate.TabIndex = 21
        '
        'ProductPriceTB
        '
        Me.ProductPriceTB.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ProductPriceTB.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductPriceTB.Location = New System.Drawing.Point(691, 132)
        Me.ProductPriceTB.Name = "ProductPriceTB"
        Me.ProductPriceTB.Size = New System.Drawing.Size(209, 34)
        Me.ProductPriceTB.TabIndex = 19
        '
        'LineTotalTB
        '
        Me.LineTotalTB.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LineTotalTB.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LineTotalTB.Location = New System.Drawing.Point(691, 172)
        Me.LineTotalTB.Name = "LineTotalTB"
        Me.LineTotalTB.Size = New System.Drawing.Size(209, 34)
        Me.LineTotalTB.TabIndex = 18
        '
        'SupplierIDTB
        '
        Me.SupplierIDTB.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SupplierIDTB.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierIDTB.Location = New System.Drawing.Point(222, 92)
        Me.SupplierIDTB.Name = "SupplierIDTB"
        Me.SupplierIDTB.Size = New System.Drawing.Size(257, 34)
        Me.SupplierIDTB.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(565, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Line Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(525, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Product Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(551, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Product ID:"
        '
        'ProductQuantityTB
        '
        Me.ProductQuantityTB.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ProductQuantityTB.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductQuantityTB.Location = New System.Drawing.Point(691, 92)
        Me.ProductQuantityTB.Name = "ProductQuantityTB"
        Me.ProductQuantityTB.Size = New System.Drawing.Size(209, 34)
        Me.ProductQuantityTB.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(489, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Product Quantity:"
        '
        'ProductIdTB
        '
        Me.ProductIdTB.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ProductIdTB.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductIdTB.Location = New System.Drawing.Point(691, 52)
        Me.ProductIdTB.Name = "ProductIdTB"
        Me.ProductIdTB.Size = New System.Drawing.Size(209, 34)
        Me.ProductIdTB.TabIndex = 9
        '
        'LabelERoles
        '
        Me.LabelERoles.AutoSize = True
        Me.LabelERoles.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.LabelERoles.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelERoles.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelERoles.Location = New System.Drawing.Point(109, 141)
        Me.LabelERoles.Name = "LabelERoles"
        Me.LabelERoles.Size = New System.Drawing.Size(107, 25)
        Me.LabelERoles.TabIndex = 8
        Me.LabelERoles.Text = "PO Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Delivery Date:"
        '
        'LabelEPass
        '
        Me.LabelEPass.AutoSize = True
        Me.LabelEPass.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEPass.Location = New System.Drawing.Point(81, 101)
        Me.LabelEPass.Name = "LabelEPass"
        Me.LabelEPass.Size = New System.Drawing.Size(135, 25)
        Me.LabelEPass.TabIndex = 5
        Me.LabelEPass.Text = "Supplier ID:"
        '
        'LabelEName
        '
        Me.LabelEName.AutoSize = True
        Me.LabelEName.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEName.Location = New System.Drawing.Point(67, 61)
        Me.LabelEName.Name = "LabelEName"
        Me.LabelEName.Size = New System.Drawing.Size(149, 25)
        Me.LabelEName.TabIndex = 7
        Me.LabelEName.Text = "Employee ID:"
        '
        'EIdTB
        '
        Me.EIdTB.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.EIdTB.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EIdTB.Location = New System.Drawing.Point(222, 52)
        Me.EIdTB.Name = "EIdTB"
        Me.EIdTB.Size = New System.Drawing.Size(257, 34)
        Me.EIdTB.TabIndex = 6
        '
        'PurchaseOrderDGV
        '
        Me.PurchaseOrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurchaseOrderDGV.GridColor = System.Drawing.Color.RosyBrown
        Me.PurchaseOrderDGV.Location = New System.Drawing.Point(385, 473)
        Me.PurchaseOrderDGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PurchaseOrderDGV.Name = "PurchaseOrderDGV"
        Me.PurchaseOrderDGV.RowHeadersWidth = 62
        Me.PurchaseOrderDGV.RowTemplate.Height = 28
        Me.PurchaseOrderDGV.Size = New System.Drawing.Size(846, 145)
        Me.PurchaseOrderDGV.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.PruchaseMenuButton)
        Me.Panel1.Controls.Add(Me.EmployeeAccountButton1)
        Me.Panel1.Controls.Add(Me.ProductClassButton2)
        Me.Panel1.Controls.Add(Me.ProductButton3)
        Me.Panel1.Controls.Add(Me.PurchaseOrderButton4)
        Me.Panel1.Controls.Add(Me.SupplierButton5)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(228, 699)
        Me.Panel1.TabIndex = 25
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DimGray
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(11, 592)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(191, 70)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Main Menu"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PruchaseMenuButton
        '
        Me.PruchaseMenuButton.BackColor = System.Drawing.Color.DimGray
        Me.PruchaseMenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PruchaseMenuButton.Location = New System.Drawing.Point(11, 518)
        Me.PruchaseMenuButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PruchaseMenuButton.Name = "PruchaseMenuButton"
        Me.PruchaseMenuButton.Size = New System.Drawing.Size(191, 70)
        Me.PruchaseMenuButton.TabIndex = 5
        Me.PruchaseMenuButton.Text = "Purchase Department Menu"
        Me.PruchaseMenuButton.UseVisualStyleBackColor = False
        '
        'EmployeeAccountButton1
        '
        Me.EmployeeAccountButton1.BackColor = System.Drawing.Color.DimGray
        Me.EmployeeAccountButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeAccountButton1.ForeColor = System.Drawing.Color.Black
        Me.EmployeeAccountButton1.Location = New System.Drawing.Point(12, 12)
        Me.EmployeeAccountButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmployeeAccountButton1.Name = "EmployeeAccountButton1"
        Me.EmployeeAccountButton1.Size = New System.Drawing.Size(191, 68)
        Me.EmployeeAccountButton1.TabIndex = 0
        Me.EmployeeAccountButton1.Text = "Employee Account"
        Me.EmployeeAccountButton1.UseVisualStyleBackColor = False
        '
        'ProductClassButton2
        '
        Me.ProductClassButton2.BackColor = System.Drawing.Color.DimGray
        Me.ProductClassButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductClassButton2.Location = New System.Drawing.Point(12, 97)
        Me.ProductClassButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProductClassButton2.Name = "ProductClassButton2"
        Me.ProductClassButton2.Size = New System.Drawing.Size(191, 64)
        Me.ProductClassButton2.TabIndex = 1
        Me.ProductClassButton2.Text = "Product Class"
        Me.ProductClassButton2.UseVisualStyleBackColor = False
        '
        'ProductButton3
        '
        Me.ProductButton3.BackColor = System.Drawing.Color.DimGray
        Me.ProductButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductButton3.Location = New System.Drawing.Point(11, 176)
        Me.ProductButton3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProductButton3.Name = "ProductButton3"
        Me.ProductButton3.Size = New System.Drawing.Size(191, 67)
        Me.ProductButton3.TabIndex = 2
        Me.ProductButton3.Text = "Product"
        Me.ProductButton3.UseVisualStyleBackColor = False
        '
        'PurchaseOrderButton4
        '
        Me.PurchaseOrderButton4.BackColor = System.Drawing.Color.DimGray
        Me.PurchaseOrderButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurchaseOrderButton4.Location = New System.Drawing.Point(12, 262)
        Me.PurchaseOrderButton4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PurchaseOrderButton4.Name = "PurchaseOrderButton4"
        Me.PurchaseOrderButton4.Size = New System.Drawing.Size(191, 70)
        Me.PurchaseOrderButton4.TabIndex = 3
        Me.PurchaseOrderButton4.Text = "Purchase Order"
        Me.PurchaseOrderButton4.UseVisualStyleBackColor = False
        '
        'SupplierButton5
        '
        Me.SupplierButton5.BackColor = System.Drawing.Color.DimGray
        Me.SupplierButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierButton5.Location = New System.Drawing.Point(11, 351)
        Me.SupplierButton5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SupplierButton5.Name = "SupplierButton5"
        Me.SupplierButton5.Size = New System.Drawing.Size(191, 61)
        Me.SupplierButton5.TabIndex = 4
        Me.SupplierButton5.Text = "Supplier"
        Me.SupplierButton5.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.Salmon
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ResetButton.Location = New System.Drawing.Point(958, 413)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(138, 34)
        Me.ResetButton.TabIndex = 32
        Me.ResetButton.Text = "RESET"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.Salmon
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.SystemColors.Control
        Me.DeleteButton.Location = New System.Drawing.Point(814, 413)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(138, 34)
        Me.DeleteButton.TabIndex = 31
        Me.DeleteButton.Text = "DELETE"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.Salmon
        Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.ForeColor = System.Drawing.SystemColors.Control
        Me.EditButton.Location = New System.Drawing.Point(670, 413)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(138, 34)
        Me.EditButton.TabIndex = 30
        Me.EditButton.Text = "EDIT"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.Salmon
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.Transparent
        Me.AddButton.Location = New System.Drawing.Point(526, 413)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(138, 34)
        Me.AddButton.TabIndex = 29
        Me.AddButton.Text = "ADD"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(11, 427)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 61)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Purchase Order Summary"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PurchaseOrderForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Rise_and_Dine.My.Resources.Resources.PurchaseMenuBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1662, 673)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PurchaseOrderDGV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PurchaseOrderForm2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PurchaseOrderDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ProductIdTB As TextBox
    Friend WithEvents LabelERoles As Label
    Friend WithEvents LabelEName As Label
    Friend WithEvents EIdTB As TextBox
    Friend WithEvents LabelEPass As Label
    Friend WithEvents ProductPriceTB As TextBox
    Friend WithEvents LineTotalTB As TextBox
    Friend WithEvents SupplierIDTB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PurchaseOrderDGV As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents PruchaseMenuButton As Button
    Friend WithEvents EmployeeAccountButton1 As Button
    Friend WithEvents ProductClassButton2 As Button
    Friend WithEvents ProductButton3 As Button
    Friend WithEvents PurchaseOrderButton4 As Button
    Friend WithEvents SupplierButton5 As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents ProductQuantityTB As TextBox
    Friend WithEvents DeliveryDate As DateTimePicker
    Friend WithEvents PODate As DateTimePicker
    Friend WithEvents Button1 As Button
End Class
