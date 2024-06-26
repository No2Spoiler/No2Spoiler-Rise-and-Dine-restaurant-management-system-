<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Product
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
        Me.ProductNameTB = New System.Windows.Forms.TextBox()
        Me.LabelEName = New System.Windows.Forms.Label()
        Me.ProductClassNameTB = New System.Windows.Forms.TextBox()
        Me.LabelEPass = New System.Windows.Forms.Label()
        Me.ProductSupplierDetailDGV = New System.Windows.Forms.DataGridView()
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
        CType(Me.ProductSupplierDetailDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Algerian", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(739, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 41)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "PRODUCT"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.ProductNameTB)
        Me.GroupBox1.Controls.Add(Me.LabelEName)
        Me.GroupBox1.Controls.Add(Me.ProductClassNameTB)
        Me.GroupBox1.Controls.Add(Me.LabelEPass)
        Me.GroupBox1.Location = New System.Drawing.Point(314, 181)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(985, 107)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'ProductNameTB
        '
        Me.ProductNameTB.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ProductNameTB.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameTB.Location = New System.Drawing.Point(222, 40)
        Me.ProductNameTB.Name = "ProductNameTB"
        Me.ProductNameTB.Size = New System.Drawing.Size(209, 34)
        Me.ProductNameTB.TabIndex = 9
        '
        'LabelEName
        '
        Me.LabelEName.AutoSize = True
        Me.LabelEName.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEName.Location = New System.Drawing.Point(30, 42)
        Me.LabelEName.Name = "LabelEName"
        Me.LabelEName.Size = New System.Drawing.Size(179, 25)
        Me.LabelEName.TabIndex = 7
        Me.LabelEName.Text = "Product Name  :"
        '
        'ProductClassNameTB
        '
        Me.ProductClassNameTB.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ProductClassNameTB.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductClassNameTB.Location = New System.Drawing.Point(697, 40)
        Me.ProductClassNameTB.Name = "ProductClassNameTB"
        Me.ProductClassNameTB.Size = New System.Drawing.Size(257, 34)
        Me.ProductClassNameTB.TabIndex = 6
        '
        'LabelEPass
        '
        Me.LabelEPass.AutoSize = True
        Me.LabelEPass.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEPass.Location = New System.Drawing.Point(437, 42)
        Me.LabelEPass.Name = "LabelEPass"
        Me.LabelEPass.Size = New System.Drawing.Size(243, 25)
        Me.LabelEPass.TabIndex = 5
        Me.LabelEPass.Text = "Product Class Name   :"
        '
        'ProductSupplierDetailDGV
        '
        Me.ProductSupplierDetailDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductSupplierDetailDGV.GridColor = System.Drawing.Color.RosyBrown
        Me.ProductSupplierDetailDGV.Location = New System.Drawing.Point(376, 359)
        Me.ProductSupplierDetailDGV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProductSupplierDetailDGV.Name = "ProductSupplierDetailDGV"
        Me.ProductSupplierDetailDGV.RowHeadersWidth = 62
        Me.ProductSupplierDetailDGV.RowTemplate.Height = 28
        Me.ProductSupplierDetailDGV.Size = New System.Drawing.Size(846, 145)
        Me.ProductSupplierDetailDGV.TabIndex = 20
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
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(228, 699)
        Me.Panel1.TabIndex = 24
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
        Me.EmployeeAccountButton1.Location = New System.Drawing.Point(12, 13)
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
        Me.ProductClassButton2.Location = New System.Drawing.Point(12, 98)
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
        Me.ProductButton3.Location = New System.Drawing.Point(11, 177)
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
        Me.PurchaseOrderButton4.Location = New System.Drawing.Point(12, 263)
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
        Me.SupplierButton5.Location = New System.Drawing.Point(11, 352)
        Me.SupplierButton5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SupplierButton5.Name = "SupplierButton5"
        Me.SupplierButton5.Size = New System.Drawing.Size(191, 61)
        Me.SupplierButton5.TabIndex = 4
        Me.SupplierButton5.Text = "Supplier"
        Me.SupplierButton5.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ResetButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ResetButton.Location = New System.Drawing.Point(956, 295)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(138, 34)
        Me.ResetButton.TabIndex = 28
        Me.ResetButton.Text = "RESET"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.SystemColors.HotTrack
        Me.DeleteButton.ForeColor = System.Drawing.SystemColors.Control
        Me.DeleteButton.Location = New System.Drawing.Point(812, 295)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(138, 34)
        Me.DeleteButton.TabIndex = 27
        Me.DeleteButton.Text = "DELETE"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.SystemColors.HotTrack
        Me.EditButton.ForeColor = System.Drawing.SystemColors.Control
        Me.EditButton.Location = New System.Drawing.Point(668, 295)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(138, 34)
        Me.EditButton.TabIndex = 26
        Me.EditButton.Text = "EDIT"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.SystemColors.HotTrack
        Me.AddButton.ForeColor = System.Drawing.Color.Transparent
        Me.AddButton.Location = New System.Drawing.Point(524, 295)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(138, 34)
        Me.AddButton.TabIndex = 25
        Me.AddButton.Text = "ADD"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 430)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 61)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Purchase Order Summary"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImage = Global.Rise_and_Dine.My.Resources.Resources.ProductBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1662, 673)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ProductSupplierDetailDGV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Product"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProductSupplierDetailDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ProductNameTB As TextBox
    Friend WithEvents LabelEName As Label
    Friend WithEvents ProductClassNameTB As TextBox
    Friend WithEvents LabelEPass As Label
    Friend WithEvents ProductSupplierDetailDGV As DataGridView
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
    Friend WithEvents Button1 As Button
End Class
