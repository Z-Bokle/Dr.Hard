<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AboutForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LogoBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoBox
        '
        Me.LogoBox.Location = New System.Drawing.Point(12, 12)
        Me.LogoBox.Name = "LogoBox"
        Me.LogoBox.Size = New System.Drawing.Size(500, 180)
        Me.LogoBox.TabIndex = 0
        Me.LogoBox.TabStop = False
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 208)
        Me.Controls.Add(Me.LogoBox)
        Me.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogoBox As PictureBox
End Class
