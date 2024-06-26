<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeAccount
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeAccount))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ENameTB = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmployeeAccountDGV = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ESalaryTB = New System.Windows.Forms.TextBox()
        Me.EContactTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmployeeAccountBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeAccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.EmployeeAccountButton = New System.Windows.Forms.Button()
        Me.FinanceMenuButton = New System.Windows.Forms.Button()
        Me.EmployeePaymentButton = New System.Windows.Forms.Button()
        Me.PaymentButton = New System.Windows.Forms.Button()
        Me.ReportButton = New System.Windows.Forms.Button()
        Me.InvoiceButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.EmployeeAccountDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeAccountBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeAccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Permanent Marker", 25.8!)
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(630, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Account"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(173, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'ENameTB
        '
        Me.ENameTB.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold)
        Me.ENameTB.Location = New System.Drawing.Point(265, 17)
        Me.ENameTB.Name = "ENameTB"
        Me.ENameTB.Size = New System.Drawing.Size(336, 35)
        Me.ENameTB.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.EmployeeAccountDGV)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ResetButton)
        Me.Panel1.Controls.Add(Me.EditButton)
        Me.Panel1.Controls.Add(Me.DeleteButton)
        Me.Panel1.Controls.Add(Me.AddButton)
        Me.Panel1.Controls.Add(Me.ESalaryTB)
        Me.Panel1.Controls.Add(Me.EContactTB)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ENameTB)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(339, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 492)
        Me.Panel1.TabIndex = 6
        '
        'EmployeeAccountDGV
        '
        Me.EmployeeAccountDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.EmployeeAccountDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.EmployeeAccountDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.EmployeeAccountDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EmployeeAccountDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeeAccountDGV.DefaultCellStyle = DataGridViewCellStyle1
        Me.EmployeeAccountDGV.GridColor = System.Drawing.Color.AntiqueWhite
        Me.EmployeeAccountDGV.Location = New System.Drawing.Point(234, 224)
        Me.EmployeeAccountDGV.Name = "EmployeeAccountDGV"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeAccountDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.EmployeeAccountDGV.RowHeadersWidth = 51
        Me.EmployeeAccountDGV.RowTemplate.Height = 24
        Me.EmployeeAccountDGV.Size = New System.Drawing.Size(566, 150)
        Me.EmployeeAccountDGV.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(411, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 28)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Employee List"
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ResetButton.Font = New System.Drawing.Font("Perpetua Titling MT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.ResetButton.Location = New System.Drawing.Point(652, 116)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(80, 42)
        Me.ResetButton.TabIndex = 12
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.EditButton.Font = New System.Drawing.Font("Perpetua Titling MT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.EditButton.Location = New System.Drawing.Point(416, 116)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(80, 42)
        Me.EditButton.TabIndex = 11
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.DeleteButton.Font = New System.Drawing.Font("Perpetua Titling MT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.DeleteButton.Location = New System.Drawing.Point(530, 116)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(80, 42)
        Me.DeleteButton.TabIndex = 10
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.AddButton.Font = New System.Drawing.Font("Perpetua Titling MT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.AddButton.Location = New System.Drawing.Point(300, 116)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(80, 42)
        Me.AddButton.TabIndex = 9
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'ESalaryTB
        '
        Me.ESalaryTB.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold)
        Me.ESalaryTB.Location = New System.Drawing.Point(747, 20)
        Me.ESalaryTB.Name = "ESalaryTB"
        Me.ESalaryTB.Size = New System.Drawing.Size(137, 35)
        Me.ESalaryTB.TabIndex = 8
        '
        'EContactTB
        '
        Me.EContactTB.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold)
        Me.EContactTB.Location = New System.Drawing.Point(265, 58)
        Me.EContactTB.Name = "EContactTB"
        Me.EContactTB.Size = New System.Drawing.Size(336, 35)
        Me.EContactTB.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(630, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Salary"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(124, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 28)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contact"
        '
        'EmployeeAccountBindingSource1
        '
        Me.EmployeeAccountBindingSource1.DataMember = "EmployeeAccount"
        '
        'EmployeeAccountBindingSource
        '
        Me.EmployeeAccountBindingSource.DataMember = "EmployeeAccount"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.MainMenuButton)
        Me.Panel2.Controls.Add(Me.EmployeeAccountButton)
        Me.Panel2.Controls.Add(Me.FinanceMenuButton)
        Me.Panel2.Controls.Add(Me.EmployeePaymentButton)
        Me.Panel2.Controls.Add(Me.PaymentButton)
        Me.Panel2.Controls.Add(Me.ReportButton)
        Me.Panel2.Controls.Add(Me.InvoiceButton)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(334, 614)
        Me.Panel2.TabIndex = 17
        '
        'MainMenuButton
        '
        Me.MainMenuButton.BackColor = System.Drawing.Color.Salmon
        Me.MainMenuButton.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MainMenuButton.Image = CType(resources.GetObject("MainMenuButton.Image"), System.Drawing.Image)
        Me.MainMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainMenuButton.Location = New System.Drawing.Point(14, 526)
        Me.MainMenuButton.Name = "MainMenuButton"
        Me.MainMenuButton.Size = New System.Drawing.Size(310, 80)
        Me.MainMenuButton.TabIndex = 13
        Me.MainMenuButton.Text = "Main Menu"
        Me.MainMenuButton.UseVisualStyleBackColor = False
        '
        'EmployeeAccountButton
        '
        Me.EmployeeAccountButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.EmployeeAccountButton.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeAccountButton.Image = CType(resources.GetObject("EmployeeAccountButton.Image"), System.Drawing.Image)
        Me.EmployeeAccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeAccountButton.Location = New System.Drawing.Point(9, 10)
        Me.EmployeeAccountButton.Name = "EmployeeAccountButton"
        Me.EmployeeAccountButton.Size = New System.Drawing.Size(310, 80)
        Me.EmployeeAccountButton.TabIndex = 5
        Me.EmployeeAccountButton.Text = "Employee Account"
        Me.EmployeeAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EmployeeAccountButton.UseVisualStyleBackColor = False
        '
        'FinanceMenuButton
        '
        Me.FinanceMenuButton.BackColor = System.Drawing.Color.Salmon
        Me.FinanceMenuButton.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FinanceMenuButton.Image = CType(resources.GetObject("FinanceMenuButton.Image"), System.Drawing.Image)
        Me.FinanceMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FinanceMenuButton.Location = New System.Drawing.Point(14, 440)
        Me.FinanceMenuButton.Name = "FinanceMenuButton"
        Me.FinanceMenuButton.Size = New System.Drawing.Size(310, 80)
        Me.FinanceMenuButton.TabIndex = 12
        Me.FinanceMenuButton.Text = "Finance Menu          "
        Me.FinanceMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FinanceMenuButton.UseVisualStyleBackColor = False
        '
        'EmployeePaymentButton
        '
        Me.EmployeePaymentButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.EmployeePaymentButton.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Bold)
        Me.EmployeePaymentButton.Image = CType(resources.GetObject("EmployeePaymentButton.Image"), System.Drawing.Image)
        Me.EmployeePaymentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeePaymentButton.Location = New System.Drawing.Point(14, 354)
        Me.EmployeePaymentButton.Name = "EmployeePaymentButton"
        Me.EmployeePaymentButton.Size = New System.Drawing.Size(310, 80)
        Me.EmployeePaymentButton.TabIndex = 9
        Me.EmployeePaymentButton.Text = "Employee Payment  "
        Me.EmployeePaymentButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EmployeePaymentButton.UseVisualStyleBackColor = False
        '
        'PaymentButton
        '
        Me.PaymentButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.PaymentButton.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentButton.Image = CType(resources.GetObject("PaymentButton.Image"), System.Drawing.Image)
        Me.PaymentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PaymentButton.Location = New System.Drawing.Point(11, 96)
        Me.PaymentButton.Name = "PaymentButton"
        Me.PaymentButton.Size = New System.Drawing.Size(310, 80)
        Me.PaymentButton.TabIndex = 6
        Me.PaymentButton.Text = "Payment"
        Me.PaymentButton.UseVisualStyleBackColor = False
        '
        'ReportButton
        '
        Me.ReportButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ReportButton.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReportButton.Image = CType(resources.GetObject("ReportButton.Image"), System.Drawing.Image)
        Me.ReportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReportButton.Location = New System.Drawing.Point(14, 268)
        Me.ReportButton.Name = "ReportButton"
        Me.ReportButton.Size = New System.Drawing.Size(310, 80)
        Me.ReportButton.TabIndex = 8
        Me.ReportButton.Text = "Report"
        Me.ReportButton.UseVisualStyleBackColor = False
        '
        'InvoiceButton
        '
        Me.InvoiceButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.InvoiceButton.Font = New System.Drawing.Font("Castellar", 9.0!, System.Drawing.FontStyle.Bold)
        Me.InvoiceButton.Image = CType(resources.GetObject("InvoiceButton.Image"), System.Drawing.Image)
        Me.InvoiceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.InvoiceButton.Location = New System.Drawing.Point(11, 182)
        Me.InvoiceButton.Name = "InvoiceButton"
        Me.InvoiceButton.Size = New System.Drawing.Size(310, 80)
        Me.InvoiceButton.TabIndex = 7
        Me.InvoiceButton.Text = "Invoice"
        Me.InvoiceButton.UseVisualStyleBackColor = False
        '
        'EmployeeAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1662, 673)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EmployeeAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Account"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EmployeeAccountDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeAccountBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeAccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ENameTB As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents ESalaryTB As TextBox
    Friend WithEvents EContactTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents EmployeeAccountBindingSource As BindingSource
    Friend WithEvents EIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ENameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeAccountBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeAccountDGV As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MainMenuButton As Button
    Friend WithEvents EmployeeAccountButton As Button
    Friend WithEvents FinanceMenuButton As Button
    Friend WithEvents EmployeePaymentButton As Button
    Friend WithEvents PaymentButton As Button
    Friend WithEvents ReportButton As Button
    Friend WithEvents InvoiceButton As Button
End Class
