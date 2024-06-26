<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Montserrat Subrayada", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.CadetBlue
        Me.Button1.Image = Global.Rise_and_Dine.My.Resources.Resources.HRIcon
        Me.Button1.Location = New System.Drawing.Point(251, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 200)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Human Resource"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Montserrat Subrayada", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.CadetBlue
        Me.Button2.Image = Global.Rise_and_Dine.My.Resources.Resources.FnBIcon
        Me.Button2.Location = New System.Drawing.Point(505, 265)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 200)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Food and Beverage"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Montserrat Subrayada", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.CadetBlue
        Me.Button3.Image = Global.Rise_and_Dine.My.Resources.Resources.InventoryIcon1
        Me.Button3.Location = New System.Drawing.Point(750, 265)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 200)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Inventory"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Montserrat Subrayada", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.CadetBlue
        Me.Button4.Image = Global.Rise_and_Dine.My.Resources.Resources.PurchaseIcon
        Me.Button4.Location = New System.Drawing.Point(998, 265)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(200, 200)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Purchase"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Montserrat Subrayada", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.CadetBlue
        Me.Button5.Image = Global.Rise_and_Dine.My.Resources.Resources.FinanceHomeIcon
        Me.Button5.Location = New System.Drawing.Point(1243, 265)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(200, 200)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Finance"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Permanent Marker", 25.8!)
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(328, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1017, 62)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome To Rise and Dine Management System"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1662, 673)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
End Class
