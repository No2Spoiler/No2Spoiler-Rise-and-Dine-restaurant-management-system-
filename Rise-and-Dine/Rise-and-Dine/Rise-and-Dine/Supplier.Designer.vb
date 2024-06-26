<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Supplier
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3InventoryDetails = New System.Windows.Forms.Button()
        Me.Button2Inventory = New System.Windows.Forms.Button()
        Me.Button1Supplier = New System.Windows.Forms.Button()
        Me.Panel2Logo = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SupplierNameTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SupplierAddressTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SupplierContactTB = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SupplierDGV = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2Logo.SuspendLayout()
        CType(Me.SupplierDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 875)
        Me.Panel1.TabIndex = 4
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
        Me.Panel2Logo.Controls.Add(Me.Label7)
        Me.Panel2Logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2Logo.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel2Logo.Location = New System.Drawing.Point(0, 0)
        Me.Panel2Logo.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2Logo.Name = "Panel2Logo"
        Me.Panel2Logo.Size = New System.Drawing.Size(400, 165)
        Me.Panel2Logo.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Fugaz One", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(398, 49)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Rise N Dine Inventory "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(951, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Supplier Management"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(631, 191)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Name"
        '
        'SupplierNameTB
        '
        Me.SupplierNameTB.Location = New System.Drawing.Point(703, 187)
        Me.SupplierNameTB.Margin = New System.Windows.Forms.Padding(4)
        Me.SupplierNameTB.Name = "SupplierNameTB"
        Me.SupplierNameTB.Size = New System.Drawing.Size(204, 22)
        Me.SupplierNameTB.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(938, 191)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Address"
        '
        'SupplierAddressTB
        '
        Me.SupplierAddressTB.Location = New System.Drawing.Point(1032, 189)
        Me.SupplierAddressTB.Margin = New System.Windows.Forms.Padding(4)
        Me.SupplierAddressTB.Name = "SupplierAddressTB"
        Me.SupplierAddressTB.Size = New System.Drawing.Size(204, 22)
        Me.SupplierAddressTB.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(1258, 191)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Contact"
        '
        'SupplierContactTB
        '
        Me.SupplierContactTB.Location = New System.Drawing.Point(1344, 190)
        Me.SupplierContactTB.Margin = New System.Windows.Forms.Padding(4)
        Me.SupplierContactTB.Name = "SupplierContactTB"
        Me.SupplierContactTB.Size = New System.Drawing.Size(204, 22)
        Me.SupplierContactTB.TabIndex = 14
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AddButton.FlatAppearance.BorderSize = 0
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.White
        Me.AddButton.Location = New System.Drawing.Point(652, 268)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(212, 42)
        Me.AddButton.TabIndex = 15
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EditButton.FlatAppearance.BorderSize = 0
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.ForeColor = System.Drawing.Color.White
        Me.EditButton.Location = New System.Drawing.Point(903, 268)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(212, 42)
        Me.EditButton.TabIndex = 16
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DeleteButton.FlatAppearance.BorderSize = 0
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.Location = New System.Drawing.Point(1149, 268)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(212, 42)
        Me.DeleteButton.TabIndex = 17
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ResetButton.FlatAppearance.BorderSize = 0
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.White
        Me.ResetButton.Location = New System.Drawing.Point(1399, 268)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(212, 42)
        Me.ResetButton.TabIndex = 18
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'SupplierDGV
        '
        Me.SupplierDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupplierDGV.Location = New System.Drawing.Point(475, 423)
        Me.SupplierDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.SupplierDGV.Name = "SupplierDGV"
        Me.SupplierDGV.RowHeadersWidth = 51
        Me.SupplierDGV.Size = New System.Drawing.Size(1305, 315)
        Me.SupplierDGV.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(1043, 377)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 29)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Supplier List"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Location = New System.Drawing.Point(433, 32)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1360, 39)
        Me.Panel2.TabIndex = 22
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1827, 838)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SupplierDGV)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.SupplierContactTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SupplierAddressTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SupplierNameTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Supplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier Detail"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2Logo.ResumeLayout(False)
        Me.Panel2Logo.PerformLayout()
        CType(Me.SupplierDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3InventoryDetails As Button
    Friend WithEvents Button2Inventory As Button
    Friend WithEvents Button1Supplier As Button
    Friend WithEvents Panel2Logo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label3 As Label
    Friend WithEvents SupplierNameTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SupplierAddressTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SupplierContactTB As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents SupplierDGV As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
