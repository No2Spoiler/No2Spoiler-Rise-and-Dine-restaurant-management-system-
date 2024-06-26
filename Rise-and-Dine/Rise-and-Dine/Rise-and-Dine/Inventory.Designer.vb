<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.InventoryDGV = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.InventoryAmountTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.InventoryNameTB = New System.Windows.Forms.TextBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.SupplierIdTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UnitPriceTB = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3InventoryDetails = New System.Windows.Forms.Button()
        Me.Button2Inventory = New System.Windows.Forms.Button()
        Me.Button1Supplier = New System.Windows.Forms.Button()
        Me.Panel2Logo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.InventoryDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2Logo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Location = New System.Drawing.Point(433, 32)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1360, 39)
        Me.Panel2.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(1043, 377)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 29)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Inventory List"
        '
        'InventoryDGV
        '
        Me.InventoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InventoryDGV.Location = New System.Drawing.Point(475, 423)
        Me.InventoryDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.InventoryDGV.Name = "InventoryDGV"
        Me.InventoryDGV.RowHeadersWidth = 51
        Me.InventoryDGV.Size = New System.Drawing.Size(1305, 315)
        Me.InventoryDGV.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(1144, 167)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Unit Price"
        '
        'InventoryAmountTB
        '
        Me.InventoryAmountTB.Location = New System.Drawing.Point(890, 216)
        Me.InventoryAmountTB.Margin = New System.Windows.Forms.Padding(4)
        Me.InventoryAmountTB.Name = "InventoryAmountTB"
        Me.InventoryAmountTB.Size = New System.Drawing.Size(204, 22)
        Me.InventoryAmountTB.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(796, 218)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Amount"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(951, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 39)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Inventory Management"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(811, 165)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Name"
        '
        'InventoryNameTB
        '
        Me.InventoryNameTB.Location = New System.Drawing.Point(889, 163)
        Me.InventoryNameTB.Margin = New System.Windows.Forms.Padding(4)
        Me.InventoryNameTB.Name = "InventoryNameTB"
        Me.InventoryNameTB.Size = New System.Drawing.Size(204, 22)
        Me.InventoryNameTB.TabIndex = 42
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ResetButton.FlatAppearance.BorderSize = 0
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.White
        Me.ResetButton.Location = New System.Drawing.Point(1396, 294)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(212, 42)
        Me.ResetButton.TabIndex = 46
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DeleteButton.FlatAppearance.BorderSize = 0
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.Location = New System.Drawing.Point(1146, 294)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(212, 42)
        Me.DeleteButton.TabIndex = 45
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EditButton.FlatAppearance.BorderSize = 0
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.ForeColor = System.Drawing.Color.White
        Me.EditButton.Location = New System.Drawing.Point(900, 294)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(212, 42)
        Me.EditButton.TabIndex = 44
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AddButton.FlatAppearance.BorderSize = 0
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.White
        Me.AddButton.Location = New System.Drawing.Point(649, 294)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(212, 42)
        Me.AddButton.TabIndex = 43
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'SupplierIdTB
        '
        Me.SupplierIdTB.Location = New System.Drawing.Point(1250, 218)
        Me.SupplierIdTB.Margin = New System.Windows.Forms.Padding(4)
        Me.SupplierIdTB.Name = "SupplierIdTB"
        Me.SupplierIdTB.Size = New System.Drawing.Size(204, 22)
        Me.SupplierIdTB.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(1118, 218)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Supplier ID"
        '
        'UnitPriceTB
        '
        Me.UnitPriceTB.Location = New System.Drawing.Point(1250, 165)
        Me.UnitPriceTB.Margin = New System.Windows.Forms.Padding(4)
        Me.UnitPriceTB.Name = "UnitPriceTB"
        Me.UnitPriceTB.Size = New System.Drawing.Size(204, 22)
        Me.UnitPriceTB.TabIndex = 32
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button3InventoryDetails)
        Me.Panel1.Controls.Add(Me.Button2Inventory)
        Me.Panel1.Controls.Add(Me.Button1Supplier)
        Me.Panel1.Controls.Add(Me.Panel2Logo)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 875)
        Me.Panel1.TabIndex = 47
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia
        Me.Button2.FlatAppearance.BorderSize = 4
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 720)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(400, 105)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "   Main Menu"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Cyan
        Me.Button1.FlatAppearance.BorderSize = 4
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 615)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(400, 105)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Inventory Summary"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button6.FlatAppearance.BorderSize = 4
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(0, 510)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(400, 105)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Inventory Supplier"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3InventoryDetails
        '
        Me.Button3InventoryDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3InventoryDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3InventoryDetails.FlatAppearance.BorderSize = 4
        Me.Button3InventoryDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3InventoryDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3InventoryDetails.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button3InventoryDetails.Image = Global.Rise_and_Dine.My.Resources.Resources.inventory_
        Me.Button3InventoryDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3InventoryDetails.Location = New System.Drawing.Point(0, 395)
        Me.Button3InventoryDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3InventoryDetails.Name = "Button3InventoryDetails"
        Me.Button3InventoryDetails.Size = New System.Drawing.Size(400, 115)
        Me.Button3InventoryDetails.TabIndex = 7
        Me.Button3InventoryDetails.Text = "   Inventory Detail"
        Me.Button3InventoryDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3InventoryDetails.UseVisualStyleBackColor = True
        '
        'Button2Inventory
        '
        Me.Button2Inventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2Inventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2Inventory.FlatAppearance.BorderSize = 4
        Me.Button2Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2Inventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2Inventory.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button2Inventory.Image = Global.Rise_and_Dine.My.Resources.Resources.inventory2
        Me.Button2Inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2Inventory.Location = New System.Drawing.Point(0, 280)
        Me.Button2Inventory.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2Inventory.Name = "Button2Inventory"
        Me.Button2Inventory.Size = New System.Drawing.Size(400, 115)
        Me.Button2Inventory.TabIndex = 6
        Me.Button2Inventory.Text = "Inventory"
        Me.Button2Inventory.UseVisualStyleBackColor = True
        '
        'Button1Supplier
        '
        Me.Button1Supplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1Supplier.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Button1Supplier.FlatAppearance.BorderSize = 4
        Me.Button1Supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1Supplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1Supplier.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1Supplier.Image = Global.Rise_and_Dine.My.Resources.Resources.supplier
        Me.Button1Supplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1Supplier.Location = New System.Drawing.Point(0, 165)
        Me.Button1Supplier.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1Supplier.Name = "Button1Supplier"
        Me.Button1Supplier.Size = New System.Drawing.Size(400, 115)
        Me.Button1Supplier.TabIndex = 5
        Me.Button1Supplier.Text = "Supplier"
        Me.Button1Supplier.UseVisualStyleBackColor = True
        '
        'Panel2Logo
        '
        Me.Panel2Logo.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Panel2Logo.Controls.Add(Me.Label2)
        Me.Panel2Logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2Logo.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel2Logo.Location = New System.Drawing.Point(0, 0)
        Me.Panel2Logo.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2Logo.Name = "Panel2Logo"
        Me.Panel2Logo.Size = New System.Drawing.Size(400, 165)
        Me.Panel2Logo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Fugaz One", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(398, 49)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rise N Dine Inventory "
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1827, 838)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.InventoryNameTB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.InventoryDGV)
        Me.Controls.Add(Me.UnitPriceTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.InventoryAmountTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SupplierIdTB)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.InventoryDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2Logo.ResumeLayout(False)
        Me.Panel2Logo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents InventoryDGV As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents InventoryAmountTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents InventoryNameTB As TextBox
    Friend WithEvents ResetButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents SupplierIdTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents UnitPriceTB As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3InventoryDetails As Button
    Friend WithEvents Button2Inventory As Button
    Friend WithEvents Button1Supplier As Button
    Friend WithEvents Panel2Logo As Panel
    Friend WithEvents Label2 As Label
End Class
