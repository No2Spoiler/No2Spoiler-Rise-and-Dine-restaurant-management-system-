﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hiring
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HiringDateDTP = New System.Windows.Forms.DateTimePicker()
        Me.EmployeeHiringviewDGV = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.JobTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EIdTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.EmployeeAccountButton = New System.Windows.Forms.Button()
        Me.HRMenuButton = New System.Windows.Forms.Button()
        Me.LeaveButton = New System.Windows.Forms.Button()
        Me.HiringButton = New System.Windows.Forms.Button()
        Me.TrainingButton = New System.Windows.Forms.Button()
        Me.PerformanceButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.EmployeeHiringviewDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.HiringDateDTP)
        Me.Panel1.Controls.Add(Me.EmployeeHiringviewDGV)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ResetButton)
        Me.Panel1.Controls.Add(Me.EditButton)
        Me.Panel1.Controls.Add(Me.DeleteButton)
        Me.Panel1.Controls.Add(Me.AddButton)
        Me.Panel1.Controls.Add(Me.JobTB)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.EIdTB)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(341, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 492)
        Me.Panel1.TabIndex = 8
        '
        'HiringDateDTP
        '
        Me.HiringDateDTP.Font = New System.Drawing.Font("Perpetua Titling MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HiringDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HiringDateDTP.Location = New System.Drawing.Point(820, 23)
        Me.HiringDateDTP.Name = "HiringDateDTP"
        Me.HiringDateDTP.Size = New System.Drawing.Size(163, 29)
        Me.HiringDateDTP.TabIndex = 17
        '
        'EmployeeHiringviewDGV
        '
        Me.EmployeeHiringviewDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.EmployeeHiringviewDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.EmployeeHiringviewDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.EmployeeHiringviewDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EmployeeHiringviewDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeeHiringviewDGV.DefaultCellStyle = DataGridViewCellStyle1
        Me.EmployeeHiringviewDGV.GridColor = System.Drawing.Color.AntiqueWhite
        Me.EmployeeHiringviewDGV.Location = New System.Drawing.Point(234, 224)
        Me.EmployeeHiringviewDGV.Name = "EmployeeHiringviewDGV"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeHiringviewDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.EmployeeHiringviewDGV.RowHeadersWidth = 51
        Me.EmployeeHiringviewDGV.RowTemplate.Height = 24
        Me.EmployeeHiringviewDGV.Size = New System.Drawing.Size(566, 253)
        Me.EmployeeHiringviewDGV.TabIndex = 16
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
        'JobTB
        '
        Me.JobTB.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold)
        Me.JobTB.Location = New System.Drawing.Point(265, 58)
        Me.JobTB.Name = "JobTB"
        Me.JobTB.Size = New System.Drawing.Size(336, 35)
        Me.JobTB.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(630, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hiring Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(195, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 28)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Job:"
        '
        'EIdTB
        '
        Me.EIdTB.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold)
        Me.EIdTB.Location = New System.Drawing.Point(265, 17)
        Me.EIdTB.Name = "EIdTB"
        Me.EIdTB.Size = New System.Drawing.Size(336, 35)
        Me.EIdTB.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(77, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Permanent Marker", 25.8!)
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(815, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 62)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Hiring"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.MainMenuButton)
        Me.Panel2.Controls.Add(Me.EmployeeAccountButton)
        Me.Panel2.Controls.Add(Me.HRMenuButton)
        Me.Panel2.Controls.Add(Me.LeaveButton)
        Me.Panel2.Controls.Add(Me.HiringButton)
        Me.Panel2.Controls.Add(Me.TrainingButton)
        Me.Panel2.Controls.Add(Me.PerformanceButton)
        Me.Panel2.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(334, 675)
        Me.Panel2.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Button1.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(17, 362)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(310, 64)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Leave and Training"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MainMenuButton
        '
        Me.MainMenuButton.BackColor = System.Drawing.Color.Salmon
        Me.MainMenuButton.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold)
        Me.MainMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainMenuButton.Location = New System.Drawing.Point(14, 580)
        Me.MainMenuButton.Name = "MainMenuButton"
        Me.MainMenuButton.Size = New System.Drawing.Size(310, 80)
        Me.MainMenuButton.TabIndex = 13
        Me.MainMenuButton.Text = "Main Menu"
        Me.MainMenuButton.UseVisualStyleBackColor = False
        '
        'EmployeeAccountButton
        '
        Me.EmployeeAccountButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.EmployeeAccountButton.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold)
        Me.EmployeeAccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmployeeAccountButton.Location = New System.Drawing.Point(14, 12)
        Me.EmployeeAccountButton.Name = "EmployeeAccountButton"
        Me.EmployeeAccountButton.Size = New System.Drawing.Size(310, 64)
        Me.EmployeeAccountButton.TabIndex = 5
        Me.EmployeeAccountButton.Text = "Employee Account"
        Me.EmployeeAccountButton.UseVisualStyleBackColor = False
        '
        'HRMenuButton
        '
        Me.HRMenuButton.BackColor = System.Drawing.Color.Salmon
        Me.HRMenuButton.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold)
        Me.HRMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HRMenuButton.Location = New System.Drawing.Point(14, 494)
        Me.HRMenuButton.Name = "HRMenuButton"
        Me.HRMenuButton.Size = New System.Drawing.Size(310, 80)
        Me.HRMenuButton.TabIndex = 12
        Me.HRMenuButton.Text = "Human Resource Menu"
        Me.HRMenuButton.UseVisualStyleBackColor = False
        '
        'LeaveButton
        '
        Me.LeaveButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.LeaveButton.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold)
        Me.LeaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LeaveButton.Location = New System.Drawing.Point(17, 292)
        Me.LeaveButton.Name = "LeaveButton"
        Me.LeaveButton.Size = New System.Drawing.Size(310, 64)
        Me.LeaveButton.TabIndex = 9
        Me.LeaveButton.Text = "Leave"
        Me.LeaveButton.UseVisualStyleBackColor = False
        '
        'HiringButton
        '
        Me.HiringButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.HiringButton.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold)
        Me.HiringButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HiringButton.Location = New System.Drawing.Point(17, 82)
        Me.HiringButton.Name = "HiringButton"
        Me.HiringButton.Size = New System.Drawing.Size(310, 64)
        Me.HiringButton.TabIndex = 6
        Me.HiringButton.Text = "Hiring"
        Me.HiringButton.UseVisualStyleBackColor = False
        '
        'TrainingButton
        '
        Me.TrainingButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TrainingButton.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold)
        Me.TrainingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TrainingButton.Location = New System.Drawing.Point(17, 222)
        Me.TrainingButton.Name = "TrainingButton"
        Me.TrainingButton.Size = New System.Drawing.Size(310, 64)
        Me.TrainingButton.TabIndex = 8
        Me.TrainingButton.Text = "Training"
        Me.TrainingButton.UseVisualStyleBackColor = False
        '
        'PerformanceButton
        '
        Me.PerformanceButton.BackColor = System.Drawing.Color.AntiqueWhite
        Me.PerformanceButton.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold)
        Me.PerformanceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PerformanceButton.Location = New System.Drawing.Point(17, 152)
        Me.PerformanceButton.Name = "PerformanceButton"
        Me.PerformanceButton.Size = New System.Drawing.Size(310, 64)
        Me.PerformanceButton.TabIndex = 7
        Me.PerformanceButton.Text = "Performance"
        Me.PerformanceButton.UseVisualStyleBackColor = False
        '
        'Hiring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1662, 673)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Hiring"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hiring"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EmployeeHiringviewDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents EmployeeHiringviewDGV As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents JobTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents EIdTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents HiringDateDTP As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents MainMenuButton As Button
    Friend WithEvents EmployeeAccountButton As Button
    Friend WithEvents HRMenuButton As Button
    Friend WithEvents LeaveButton As Button
    Friend WithEvents HiringButton As Button
    Friend WithEvents TrainingButton As Button
    Friend WithEvents PerformanceButton As Button
End Class
