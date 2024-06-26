<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrderSummary
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PruchaseMenuButton = New System.Windows.Forms.Button()
        Me.EmployeeAccountButton1 = New System.Windows.Forms.Button()
        Me.ProductClassButton2 = New System.Windows.Forms.Button()
        Me.ProductButton3 = New System.Windows.Forms.Button()
        Me.PurchaseOrderButton4 = New System.Windows.Forms.Button()
        Me.SupplierButton5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FinanceDataSet1 = New Rise_and_Dine.FinanceDataSet1()
        Me.PurchaseOrderSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseOrderSummaryTableAdapter = New Rise_and_Dine.FinanceDataSet1TableAdapters.PurchaseOrderSummaryTableAdapter()
        Me.ProductIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinanceDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(1, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(228, 677)
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
        Me.EmployeeAccountButton1.Location = New System.Drawing.Point(11, 12)
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
        Me.ProductClassButton2.Location = New System.Drawing.Point(11, 97)
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
        Me.ProductButton3.Location = New System.Drawing.Point(10, 176)
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
        Me.PurchaseOrderButton4.Location = New System.Drawing.Point(11, 262)
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
        Me.SupplierButton5.Location = New System.Drawing.Point(10, 351)
        Me.SupplierButton5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SupplierButton5.Name = "SupplierButton5"
        Me.SupplierButton5.Size = New System.Drawing.Size(191, 61)
        Me.SupplierButton5.TabIndex = 4
        Me.SupplierButton5.Text = "Supplier"
        Me.SupplierButton5.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Algerian", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(624, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(532, 41)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Purchase Order Summary"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIdDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.EmployeeIdDataGridViewTextBoxColumn, Me.EmployeeNameDataGridViewTextBoxColumn, Me.SupplierIdDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PurchaseOrderSummaryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(472, 197)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(837, 308)
        Me.DataGridView1.TabIndex = 26
        '
        'FinanceDataSet1
        '
        Me.FinanceDataSet1.DataSetName = "FinanceDataSet1"
        Me.FinanceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurchaseOrderSummaryBindingSource
        '
        Me.PurchaseOrderSummaryBindingSource.DataMember = "PurchaseOrderSummary"
        Me.PurchaseOrderSummaryBindingSource.DataSource = Me.FinanceDataSet1
        '
        'PurchaseOrderSummaryTableAdapter
        '
        Me.PurchaseOrderSummaryTableAdapter.ClearBeforeFill = True
        '
        'ProductIdDataGridViewTextBoxColumn
        '
        Me.ProductIdDataGridViewTextBoxColumn.DataPropertyName = "Product Id"
        Me.ProductIdDataGridViewTextBoxColumn.HeaderText = "Product Id"
        Me.ProductIdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductIdDataGridViewTextBoxColumn.Name = "ProductIdDataGridViewTextBoxColumn"
        Me.ProductIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductIdDataGridViewTextBoxColumn.Width = 125
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductNameDataGridViewTextBoxColumn.Width = 125
        '
        'EmployeeIdDataGridViewTextBoxColumn
        '
        Me.EmployeeIdDataGridViewTextBoxColumn.DataPropertyName = "Employee Id"
        Me.EmployeeIdDataGridViewTextBoxColumn.HeaderText = "Employee Id"
        Me.EmployeeIdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmployeeIdDataGridViewTextBoxColumn.Name = "EmployeeIdDataGridViewTextBoxColumn"
        Me.EmployeeIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeIdDataGridViewTextBoxColumn.Width = 125
        '
        'EmployeeNameDataGridViewTextBoxColumn
        '
        Me.EmployeeNameDataGridViewTextBoxColumn.DataPropertyName = "Employee Name"
        Me.EmployeeNameDataGridViewTextBoxColumn.HeaderText = "Employee Name"
        Me.EmployeeNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmployeeNameDataGridViewTextBoxColumn.Name = "EmployeeNameDataGridViewTextBoxColumn"
        Me.EmployeeNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeNameDataGridViewTextBoxColumn.Width = 125
        '
        'SupplierIdDataGridViewTextBoxColumn
        '
        Me.SupplierIdDataGridViewTextBoxColumn.DataPropertyName = "Supplier Id"
        Me.SupplierIdDataGridViewTextBoxColumn.HeaderText = "Supplier Id"
        Me.SupplierIdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SupplierIdDataGridViewTextBoxColumn.Name = "SupplierIdDataGridViewTextBoxColumn"
        Me.SupplierIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierIdDataGridViewTextBoxColumn.Width = 125
        '
        'SupplierNameDataGridViewTextBoxColumn
        '
        Me.SupplierNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier Name"
        Me.SupplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier Name"
        Me.SupplierNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SupplierNameDataGridViewTextBoxColumn.Name = "SupplierNameDataGridViewTextBoxColumn"
        Me.SupplierNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierNameDataGridViewTextBoxColumn.Width = 125
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(10, 427)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 61)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Purchase Order Summary"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PurchaseOrderSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Rise_and_Dine.My.Resources.Resources.ProductBackground
        Me.ClientSize = New System.Drawing.Size(1662, 673)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PurchaseOrderSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PurchaseOrderSummary"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinanceDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderSummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents PruchaseMenuButton As Button
    Friend WithEvents EmployeeAccountButton1 As Button
    Friend WithEvents ProductClassButton2 As Button
    Friend WithEvents ProductButton3 As Button
    Friend WithEvents PurchaseOrderButton4 As Button
    Friend WithEvents SupplierButton5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FinanceDataSet1 As FinanceDataSet1
    Friend WithEvents PurchaseOrderSummaryBindingSource As BindingSource
    Friend WithEvents PurchaseOrderSummaryTableAdapter As FinanceDataSet1TableAdapters.PurchaseOrderSummaryTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents ProductIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
