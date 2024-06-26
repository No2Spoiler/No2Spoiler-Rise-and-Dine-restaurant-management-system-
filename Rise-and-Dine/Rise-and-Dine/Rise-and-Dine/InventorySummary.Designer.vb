<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventorySummary
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
        Me.Button3InventoryDetails = New System.Windows.Forms.Button()
        Me.Button1Supplier = New System.Windows.Forms.Button()
        Me.InventorySupplierTableAdapter = New Rise_and_Dine.FinanceDataSetTableAdapters.InventorySupplierTableAdapter()
        Me.InventorySupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinanceDataSet = New Rise_and_Dine.FinanceDataSet()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel2Logo = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2Inventory = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.InventorySummaryDataset = New Rise_and_Dine.InventorySummaryDataset()
        Me.InventorySummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventorySummaryTableAdapter = New Rise_and_Dine.InventorySummaryDatasetTableAdapters.InventorySummaryTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.InventorySupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2Logo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.InventorySummaryDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventorySummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'InventorySupplierTableAdapter
        '
        Me.InventorySupplierTableAdapter.ClearBeforeFill = True
        '
        'InventorySupplierBindingSource
        '
        Me.InventorySupplierBindingSource.DataMember = "InventorySupplier"
        Me.InventorySupplierBindingSource.DataSource = Me.FinanceDataSet
        '
        'FinanceDataSet
        '
        Me.FinanceDataSet.DataSetName = "FinanceDataSet"
        Me.FinanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Panel1.TabIndex = 42
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(949, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 39)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Inventory Summary"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Location = New System.Drawing.Point(431, 30)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1360, 39)
        Me.Panel2.TabIndex = 41
        '
        'InventorySummaryDataset
        '
        Me.InventorySummaryDataset.DataSetName = "InventorySummaryDataset"
        Me.InventorySummaryDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventorySummaryBindingSource
        '
        Me.InventorySummaryBindingSource.DataMember = "InventorySummary"
        Me.InventorySummaryBindingSource.DataSource = Me.InventorySummaryDataset
        '
        'InventorySummaryTableAdapter
        '
        Me.InventorySummaryTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Type, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DataGridView1.DataSource = Me.InventorySummaryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(730, 129)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(908, 150)
        Me.DataGridView1.TabIndex = 43
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Inventory ID"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Inventory ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Inventory ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Inventory Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Inventory Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'Type
        '
        Me.Type.DataPropertyName = "Type"
        Me.Type.HeaderText = "Type"
        Me.Type.MinimumWidth = 6
        Me.Type.Name = "Type"
        Me.Type.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Inventory Amount"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Inventory Amount"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'InventorySummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1827, 838)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "InventorySummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InventorySummary"
        CType(Me.InventorySupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2Logo.ResumeLayout(False)
        Me.Panel2Logo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.InventorySummaryDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventorySummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3InventoryDetails As Button
    Friend WithEvents Button1Supplier As Button
    Friend WithEvents InventorySupplierTableAdapter As FinanceDataSetTableAdapters.InventorySupplierTableAdapter
    Friend WithEvents InventorySupplierBindingSource As BindingSource
    Friend WithEvents FinanceDataSet As FinanceDataSet
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel2Logo As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2Inventory As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents InventorySummaryDataset As InventorySummaryDataset
    Friend WithEvents InventorySummaryBindingSource As BindingSource
    Friend WithEvents InventorySummaryTableAdapter As InventorySummaryDatasetTableAdapters.InventorySummaryTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
