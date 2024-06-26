<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Finance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Finance))
        Me.EmployeePaymentButton = New System.Windows.Forms.Button()
        Me.ReportButton = New System.Windows.Forms.Button()
        Me.InvoiceButton = New System.Windows.Forms.Button()
        Me.PaymentButton = New System.Windows.Forms.Button()
        Me.EmployeeAccountButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.FinanceMenuButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.MainMenuButton)
        Me.Panel1.Controls.Add(Me.EmployeeAccountButton)
        Me.Panel1.Controls.Add(Me.FinanceMenuButton)
        Me.Panel1.Controls.Add(Me.EmployeePaymentButton)
        Me.Panel1.Controls.Add(Me.PaymentButton)
        Me.Panel1.Controls.Add(Me.ReportButton)
        Me.Panel1.Controls.Add(Me.InvoiceButton)
        Me.Panel1.Location = New System.Drawing.Point(12, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 614)
        Me.Panel1.TabIndex = 10
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Permanent Marker", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSalmon
        Me.Label1.Location = New System.Drawing.Point(563, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(790, 124)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Finance Menu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please choose one menu on the left"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Finance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1662, 673)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Finance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finance"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmployeePaymentButton As Button
    Friend WithEvents ReportButton As Button
    Friend WithEvents InvoiceButton As Button
    Friend WithEvents PaymentButton As Button
    Friend WithEvents EmployeeAccountButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents FinanceMenuButton As Button
    Friend WithEvents MainMenuButton As Button
End Class
