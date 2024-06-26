<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RDate = New System.Windows.Forms.DateTimePicker()
        Me.PaymentDGV = New System.Windows.Forms.DataGridView()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PIdTB = New System.Windows.Forms.TextBox()
        Me.InvoiceIdTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.EmployeeAccountButton = New System.Windows.Forms.Button()
        Me.FinanceMenuButton = New System.Windows.Forms.Button()
        Me.EmployeePaymentButton = New System.Windows.Forms.Button()
        Me.PaymentButton = New System.Windows.Forms.Button()
        Me.ReportButton = New System.Windows.Forms.Button()
        Me.InvoiceButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PaymentDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.RDate)
        Me.Panel1.Controls.Add(Me.PaymentDGV)
        Me.Panel1.Controls.Add(Me.ResetButton)
        Me.Panel1.Controls.Add(Me.EditButton)
        Me.Panel1.Controls.Add(Me.DeleteButton)
        Me.Panel1.Controls.Add(Me.AddButton)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PIdTB)
        Me.Panel1.Controls.Add(Me.InvoiceIdTB)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(327, 181)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 401)
        Me.Panel1.TabIndex = 10
        '
        'RDate
        '
        Me.RDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RDate.Location = New System.Drawing.Point(640, 61)
        Me.RDate.Name = "RDate"
        Me.RDate.Size = New System.Drawing.Size(97, 22)
        Me.RDate.TabIndex = 37
        '
        'PaymentDGV
        '
        Me.PaymentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.PaymentDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.PaymentDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.PaymentDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PaymentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PaymentDGV.DefaultCellStyle = DataGridViewCellStyle1
        Me.PaymentDGV.GridColor = System.Drawing.Color.AntiqueWhite
        Me.PaymentDGV.Location = New System.Drawing.Point(210, 214)
        Me.PaymentDGV.Name = "PaymentDGV"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PaymentDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.PaymentDGV.RowHeadersWidth = 51
        Me.PaymentDGV.RowTemplate.Height = 24
        Me.PaymentDGV.Size = New System.Drawing.Size(566, 150)
        Me.PaymentDGV.TabIndex = 36
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ResetButton.Font = New System.Drawing.Font("Perpetua Titling MT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.ResetButton.Location = New System.Drawing.Point(640, 93)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(80, 42)
        Me.ResetButton.TabIndex = 35
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.EditButton.Font = New System.Drawing.Font("Perpetua Titling MT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.EditButton.Location = New System.Drawing.Point(404, 93)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(80, 42)
        Me.EditButton.TabIndex = 34
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.DeleteButton.Font = New System.Drawing.Font("Perpetua Titling MT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.DeleteButton.Location = New System.Drawing.Point(518, 93)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(80, 42)
        Me.DeleteButton.TabIndex = 33
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.AddButton.Font = New System.Drawing.Font("Perpetua Titling MT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.AddButton.Location = New System.Drawing.Point(288, 93)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(80, 42)
        Me.AddButton.TabIndex = 32
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Location = New System.Drawing.Point(642, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 28)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(385, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 28)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Report History"
        '
        'PIdTB
        '
        Me.PIdTB.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold)
        Me.PIdTB.Location = New System.Drawing.Point(405, 53)
        Me.PIdTB.Name = "PIdTB"
        Me.PIdTB.Size = New System.Drawing.Size(166, 35)
        Me.PIdTB.TabIndex = 8
        '
        'InvoiceIdTB
        '
        Me.InvoiceIdTB.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold)
        Me.InvoiceIdTB.Location = New System.Drawing.Point(204, 53)
        Me.InvoiceIdTB.Name = "InvoiceIdTB"
        Me.InvoiceIdTB.Size = New System.Drawing.Size(144, 35)
        Me.InvoiceIdTB.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(400, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Payment ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(199, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 28)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Invoice Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Permanent Marker", 25.8!)
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(745, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 62)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Report"
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
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(334, 614)
        Me.Panel2.TabIndex = 38
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
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1662, 673)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PaymentDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents PaymentDGV As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents PIdTB As TextBox
    Friend WithEvents InvoiceIdTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RDate As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MainMenuButton As Button
    Friend WithEvents EmployeeAccountButton As Button
    Friend WithEvents FinanceMenuButton As Button
    Friend WithEvents EmployeePaymentButton As Button
    Friend WithEvents PaymentButton As Button
    Friend WithEvents ReportButton As Button
    Friend WithEvents InvoiceButton As Button
End Class
