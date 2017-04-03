<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NetworkForm
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
        Me.Ping_Group = New System.Windows.Forms.GroupBox()
        Me.Ping_URL = New System.Windows.Forms.TextBox()
        Me.PingButton = New System.Windows.Forms.Button()
        Me.Ping_Group.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ping_Group
        '
        Me.Ping_Group.Controls.Add(Me.PingButton)
        Me.Ping_Group.Controls.Add(Me.Ping_URL)
        Me.Ping_Group.Location = New System.Drawing.Point(19, 23)
        Me.Ping_Group.Name = "Ping_Group"
        Me.Ping_Group.Size = New System.Drawing.Size(468, 107)
        Me.Ping_Group.TabIndex = 0
        Me.Ping_Group.TabStop = False
        Me.Ping_Group.Text = "Ping"
        '
        'Ping_URL
        '
        Me.Ping_URL.Location = New System.Drawing.Point(21, 43)
        Me.Ping_URL.MaxLength = 300
        Me.Ping_URL.Name = "Ping_URL"
        Me.Ping_URL.Size = New System.Drawing.Size(285, 33)
        Me.Ping_URL.TabIndex = 0
        Me.Ping_URL.Text = "microsoft.com"
        '
        'PingButton
        '
        Me.PingButton.Location = New System.Drawing.Point(354, 43)
        Me.PingButton.Name = "PingButton"
        Me.PingButton.Size = New System.Drawing.Size(75, 33)
        Me.PingButton.TabIndex = 1
        Me.PingButton.Text = "Ping"
        Me.PingButton.UseVisualStyleBackColor = True
        '
        'NetworkForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 394)
        Me.Controls.Add(Me.Ping_Group)
        Me.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NetworkForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Network"
        Me.Ping_Group.ResumeLayout(False)
        Me.Ping_Group.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ping_Group As GroupBox
    Friend WithEvents PingButton As Button
    Friend WithEvents Ping_URL As TextBox
End Class
