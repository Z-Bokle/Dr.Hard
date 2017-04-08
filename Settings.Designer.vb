<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SettingsGroup = New System.Windows.Forms.GroupBox()
        Me.Check_Border = New System.Windows.Forms.CheckBox()
        Me.Check_AlwaysOnTop = New System.Windows.Forms.CheckBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.ReloadTimeSetter = New System.Windows.Forms.NumericUpDown()
        Me.ThemesGroup = New System.Windows.Forms.GroupBox()
        Me.SettingsGroup.SuspendLayout()
        CType(Me.ReloadTimeSetter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SettingsGroup
        '
        Me.SettingsGroup.Controls.Add(Me.Check_Border)
        Me.SettingsGroup.Controls.Add(Me.Check_AlwaysOnTop)
        Me.SettingsGroup.Controls.Add(Me.Label)
        Me.SettingsGroup.Controls.Add(Me.ReloadTimeSetter)
        Me.SettingsGroup.Location = New System.Drawing.Point(10, 12)
        Me.SettingsGroup.Name = "SettingsGroup"
        Me.SettingsGroup.Size = New System.Drawing.Size(312, 125)
        Me.SettingsGroup.TabIndex = 7
        Me.SettingsGroup.TabStop = False
        Me.SettingsGroup.Text = "Settings"
        '
        'Check_Border
        '
        Me.Check_Border.AutoSize = True
        Me.Check_Border.Checked = True
        Me.Check_Border.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Check_Border.Location = New System.Drawing.Point(167, 86)
        Me.Check_Border.Name = "Check_Border"
        Me.Check_Border.Size = New System.Drawing.Size(68, 21)
        Me.Check_Border.TabIndex = 3
        Me.Check_Border.Text = "Border"
        Me.Check_Border.UseVisualStyleBackColor = True
        '
        'Check_AlwaysOnTop
        '
        Me.Check_AlwaysOnTop.AutoSize = True
        Me.Check_AlwaysOnTop.Location = New System.Drawing.Point(20, 86)
        Me.Check_AlwaysOnTop.Name = "Check_AlwaysOnTop"
        Me.Check_AlwaysOnTop.Size = New System.Drawing.Size(114, 21)
        Me.Check_AlwaysOnTop.TabIndex = 2
        Me.Check_AlwaysOnTop.Text = "Always On Top"
        Me.Check_AlwaysOnTop.UseVisualStyleBackColor = True
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(17, 46)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(141, 17)
        Me.Label.TabIndex = 1
        Me.Label.Text = "Reload Time (seconds)"
        '
        'ReloadTimeSetter
        '
        Me.ReloadTimeSetter.DecimalPlaces = 1
        Me.ReloadTimeSetter.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ReloadTimeSetter.Location = New System.Drawing.Point(183, 44)
        Me.ReloadTimeSetter.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.ReloadTimeSetter.Minimum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.ReloadTimeSetter.Name = "ReloadTimeSetter"
        Me.ReloadTimeSetter.Size = New System.Drawing.Size(44, 23)
        Me.ReloadTimeSetter.TabIndex = 0
        Me.ReloadTimeSetter.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ThemesGroup
        '
        Me.ThemesGroup.Location = New System.Drawing.Point(12, 143)
        Me.ThemesGroup.Name = "ThemesGroup"
        Me.ThemesGroup.Size = New System.Drawing.Size(310, 158)
        Me.ThemesGroup.TabIndex = 8
        Me.ThemesGroup.TabStop = False
        Me.ThemesGroup.Text = "Themes"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 313)
        Me.Controls.Add(Me.ThemesGroup)
        Me.Controls.Add(Me.SettingsGroup)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.SettingsGroup.ResumeLayout(False)
        Me.SettingsGroup.PerformLayout()
        CType(Me.ReloadTimeSetter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SettingsGroup As GroupBox
    Friend WithEvents Check_AlwaysOnTop As CheckBox
    Friend WithEvents Label As Label
    Friend WithEvents ReloadTimeSetter As NumericUpDown
    Friend WithEvents Check_Border As CheckBox
    Friend WithEvents ThemesGroup As GroupBox
End Class
