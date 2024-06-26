<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LeavesTraining
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.EmployeeAccountButton = New System.Windows.Forms.Button()
        Me.HRMenuButton = New System.Windows.Forms.Button()
        Me.LeaveButton = New System.Windows.Forms.Button()
        Me.HiringButton = New System.Windows.Forms.Button()
        Me.TrainingButton = New System.Windows.Forms.Button()
        Me.PerformanceButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LeaveTrainingvViewDGV = New System.Windows.Forms.DataGridView()
        Me.EmployeeIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaveIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaveStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaveEndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaveTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainingIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainingNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrainerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeLeaveTrainingViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LeavesTrainingDataset = New Rise_and_Dine.LeavesTrainingDataset()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmployeeLeaveTrainingViewTableAdapter = New Rise_and_Dine.LeavesTrainingDatasetTableAdapters.EmployeeLeaveTrainingViewTableAdapter()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.LeaveTrainingvViewDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeLeaveTrainingViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeavesTrainingDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(334, 675)
        Me.Panel2.TabIndex = 18
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.LeaveTrainingvViewDGV)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(338, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1281, 492)
        Me.Panel1.TabIndex = 20
        '
        'LeaveTrainingvViewDGV
        '
        Me.LeaveTrainingvViewDGV.AllowUserToAddRows = False
        Me.LeaveTrainingvViewDGV.AllowUserToDeleteRows = False
        Me.LeaveTrainingvViewDGV.AutoGenerateColumns = False
        Me.LeaveTrainingvViewDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.LeaveTrainingvViewDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.LeaveTrainingvViewDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.LeaveTrainingvViewDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LeaveTrainingvViewDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LeaveTrainingvViewDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIdDataGridViewTextBoxColumn, Me.EmployeeNameDataGridViewTextBoxColumn, Me.LeaveIdDataGridViewTextBoxColumn, Me.LeaveStartDateDataGridViewTextBoxColumn, Me.LeaveEndDateDataGridViewTextBoxColumn, Me.LeaveTypeDataGridViewTextBoxColumn, Me.ReasonDataGridViewTextBoxColumn, Me.TrainingIdDataGridViewTextBoxColumn, Me.TrainingDateDataGridViewTextBoxColumn, Me.TrainingNameDataGridViewTextBoxColumn, Me.TrainerDataGridViewTextBoxColumn})
        Me.LeaveTrainingvViewDGV.DataSource = Me.EmployeeLeaveTrainingViewBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LeaveTrainingvViewDGV.DefaultCellStyle = DataGridViewCellStyle1
        Me.LeaveTrainingvViewDGV.GridColor = System.Drawing.Color.AntiqueWhite
        Me.LeaveTrainingvViewDGV.Location = New System.Drawing.Point(53, 222)
        Me.LeaveTrainingvViewDGV.Name = "LeaveTrainingvViewDGV"
        Me.LeaveTrainingvViewDGV.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LeaveTrainingvViewDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.LeaveTrainingvViewDGV.RowHeadersWidth = 51
        Me.LeaveTrainingvViewDGV.RowTemplate.Height = 24
        Me.LeaveTrainingvViewDGV.Size = New System.Drawing.Size(1206, 253)
        Me.LeaveTrainingvViewDGV.TabIndex = 16
        '
        'EmployeeIdDataGridViewTextBoxColumn
        '
        Me.EmployeeIdDataGridViewTextBoxColumn.DataPropertyName = "Employee Id"
        Me.EmployeeIdDataGridViewTextBoxColumn.HeaderText = "Employee Id"
        Me.EmployeeIdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmployeeIdDataGridViewTextBoxColumn.Name = "EmployeeIdDataGridViewTextBoxColumn"
        Me.EmployeeIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeIdDataGridViewTextBoxColumn.Width = 103
        '
        'EmployeeNameDataGridViewTextBoxColumn
        '
        Me.EmployeeNameDataGridViewTextBoxColumn.DataPropertyName = "Employee Name"
        Me.EmployeeNameDataGridViewTextBoxColumn.HeaderText = "Employee Name"
        Me.EmployeeNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmployeeNameDataGridViewTextBoxColumn.Name = "EmployeeNameDataGridViewTextBoxColumn"
        Me.EmployeeNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeNameDataGridViewTextBoxColumn.Width = 127
        '
        'LeaveIdDataGridViewTextBoxColumn
        '
        Me.LeaveIdDataGridViewTextBoxColumn.DataPropertyName = "Leave Id"
        Me.LeaveIdDataGridViewTextBoxColumn.HeaderText = "Leave Id"
        Me.LeaveIdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LeaveIdDataGridViewTextBoxColumn.Name = "LeaveIdDataGridViewTextBoxColumn"
        Me.LeaveIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.LeaveIdDataGridViewTextBoxColumn.Width = 82
        '
        'LeaveStartDateDataGridViewTextBoxColumn
        '
        Me.LeaveStartDateDataGridViewTextBoxColumn.DataPropertyName = "Leave Start Date"
        Me.LeaveStartDateDataGridViewTextBoxColumn.HeaderText = "Leave Start Date"
        Me.LeaveStartDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LeaveStartDateDataGridViewTextBoxColumn.Name = "LeaveStartDateDataGridViewTextBoxColumn"
        Me.LeaveStartDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.LeaveStartDateDataGridViewTextBoxColumn.Width = 99
        '
        'LeaveEndDateDataGridViewTextBoxColumn
        '
        Me.LeaveEndDateDataGridViewTextBoxColumn.DataPropertyName = "Leave End Date"
        Me.LeaveEndDateDataGridViewTextBoxColumn.HeaderText = "Leave End Date"
        Me.LeaveEndDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LeaveEndDateDataGridViewTextBoxColumn.Name = "LeaveEndDateDataGridViewTextBoxColumn"
        Me.LeaveEndDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.LeaveEndDateDataGridViewTextBoxColumn.Width = 96
        '
        'LeaveTypeDataGridViewTextBoxColumn
        '
        Me.LeaveTypeDataGridViewTextBoxColumn.DataPropertyName = "Leave Type"
        Me.LeaveTypeDataGridViewTextBoxColumn.HeaderText = "Leave Type"
        Me.LeaveTypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LeaveTypeDataGridViewTextBoxColumn.Name = "LeaveTypeDataGridViewTextBoxColumn"
        Me.LeaveTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.LeaveTypeDataGridViewTextBoxColumn.Width = 101
        '
        'ReasonDataGridViewTextBoxColumn
        '
        Me.ReasonDataGridViewTextBoxColumn.DataPropertyName = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.HeaderText = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ReasonDataGridViewTextBoxColumn.Name = "ReasonDataGridViewTextBoxColumn"
        Me.ReasonDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReasonDataGridViewTextBoxColumn.Width = 84
        '
        'TrainingIdDataGridViewTextBoxColumn
        '
        Me.TrainingIdDataGridViewTextBoxColumn.DataPropertyName = "Training Id"
        Me.TrainingIdDataGridViewTextBoxColumn.HeaderText = "Training Id"
        Me.TrainingIdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TrainingIdDataGridViewTextBoxColumn.Name = "TrainingIdDataGridViewTextBoxColumn"
        Me.TrainingIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.TrainingIdDataGridViewTextBoxColumn.Width = 92
        '
        'TrainingDateDataGridViewTextBoxColumn
        '
        Me.TrainingDateDataGridViewTextBoxColumn.DataPropertyName = "Training Date"
        Me.TrainingDateDataGridViewTextBoxColumn.HeaderText = "Training Date"
        Me.TrainingDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TrainingDateDataGridViewTextBoxColumn.Name = "TrainingDateDataGridViewTextBoxColumn"
        Me.TrainingDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.TrainingDateDataGridViewTextBoxColumn.Width = 108
        '
        'TrainingNameDataGridViewTextBoxColumn
        '
        Me.TrainingNameDataGridViewTextBoxColumn.DataPropertyName = "Training Name"
        Me.TrainingNameDataGridViewTextBoxColumn.HeaderText = "Training Name"
        Me.TrainingNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TrainingNameDataGridViewTextBoxColumn.Name = "TrainingNameDataGridViewTextBoxColumn"
        Me.TrainingNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.TrainingNameDataGridViewTextBoxColumn.Width = 115
        '
        'TrainerDataGridViewTextBoxColumn
        '
        Me.TrainerDataGridViewTextBoxColumn.DataPropertyName = "Trainer"
        Me.TrainerDataGridViewTextBoxColumn.HeaderText = "Trainer"
        Me.TrainerDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TrainerDataGridViewTextBoxColumn.Name = "TrainerDataGridViewTextBoxColumn"
        Me.TrainerDataGridViewTextBoxColumn.ReadOnly = True
        Me.TrainerDataGridViewTextBoxColumn.Width = 79
        '
        'EmployeeLeaveTrainingViewBindingSource
        '
        Me.EmployeeLeaveTrainingViewBindingSource.DataMember = "EmployeeLeaveTrainingView"
        Me.EmployeeLeaveTrainingViewBindingSource.DataSource = Me.LeavesTrainingDataset
        '
        'LeavesTrainingDataset
        '
        Me.LeavesTrainingDataset.DataSetName = "LeavesTrainingDataset"
        Me.LeavesTrainingDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(466, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 28)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Employee Leave and Training"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Permanent Marker", 25.8!)
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(798, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(444, 62)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Leaves and Training"
        '
        'EmployeeLeaveTrainingViewTableAdapter
        '
        Me.EmployeeLeaveTrainingViewTableAdapter.ClearBeforeFill = True
        '
        'LeavesTraining
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1662, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "LeavesTraining"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leave and Training"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LeaveTrainingvViewDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeLeaveTrainingViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeavesTrainingDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents MainMenuButton As Button
    Friend WithEvents EmployeeAccountButton As Button
    Friend WithEvents HRMenuButton As Button
    Friend WithEvents LeaveButton As Button
    Friend WithEvents HiringButton As Button
    Friend WithEvents TrainingButton As Button
    Friend WithEvents PerformanceButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LeaveTrainingvViewDGV As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LeavesTrainingDataset As LeavesTrainingDataset
    Friend WithEvents EmployeeLeaveTrainingViewBindingSource As BindingSource
    Friend WithEvents EmployeeLeaveTrainingViewTableAdapter As LeavesTrainingDatasetTableAdapters.EmployeeLeaveTrainingViewTableAdapter
    Friend WithEvents EmployeeIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeaveIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeaveStartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeaveEndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeaveTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReasonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrainingIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrainingDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrainingNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrainerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
