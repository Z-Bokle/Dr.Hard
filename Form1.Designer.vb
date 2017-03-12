<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.CPU_ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Mem_ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AlwaysOnTop = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ReloadTimeSetter = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OnlyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CPUCounter = New System.Diagnostics.PerformanceCounter()
        Me.ComputerInfo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ReloadTimeSetter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CPUCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CPU_ProgressBar
        '
        Me.CPU_ProgressBar.Location = New System.Drawing.Point(157, 42)
        Me.CPU_ProgressBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CPU_ProgressBar.Name = "CPU_ProgressBar"
        Me.CPU_ProgressBar.Size = New System.Drawing.Size(463, 33)
        Me.CPU_ProgressBar.TabIndex = 0
        '
        'Mem_ProgressBar
        '
        Me.Mem_ProgressBar.Location = New System.Drawing.Point(157, 180)
        Me.Mem_ProgressBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Mem_ProgressBar.Name = "Mem_ProgressBar"
        Me.Mem_ProgressBar.Size = New System.Drawing.Size(463, 33)
        Me.Mem_ProgressBar.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(591, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "100"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(154, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(591, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "100"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AlwaysOnTop)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ReloadTimeSetter)
        Me.GroupBox1.Location = New System.Drawing.Point(341, 301)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 185)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'AlwaysOnTop
        '
        Me.AlwaysOnTop.AutoSize = True
        Me.AlwaysOnTop.Location = New System.Drawing.Point(20, 86)
        Me.AlwaysOnTop.Name = "AlwaysOnTop"
        Me.AlwaysOnTop.Size = New System.Drawing.Size(114, 21)
        Me.AlwaysOnTop.TabIndex = 2
        Me.AlwaysOnTop.Text = "Always On Top"
        Me.AlwaysOnTop.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Reload Time (seconds)"
        '
        'ReloadTimeSetter
        '
        Me.ReloadTimeSetter.DecimalPlaces = 1
        Me.ReloadTimeSetter.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ReloadTimeSetter.Location = New System.Drawing.Point(202, 44)
        Me.ReloadTimeSetter.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.ReloadTimeSetter.Minimum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.ReloadTimeSetter.Name = "ReloadTimeSetter"
        Me.ReloadTimeSetter.Size = New System.Drawing.Size(47, 23)
        Me.ReloadTimeSetter.TabIndex = 0
        Me.ReloadTimeSetter.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CPU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 26)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Memory"
        '
        'OnlyTimer
        '
        '
        'CPUCounter
        '
        Me.CPUCounter.CategoryName = "Processor"
        Me.CPUCounter.CounterName = "% Processor Time"
        Me.CPUCounter.InstanceName = "_Total"
        '
        'ComputerInfo
        '
        Me.ComputerInfo.AcceptsTab = True
        Me.ComputerInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComputerInfo.Location = New System.Drawing.Point(54, 301)
        Me.ComputerInfo.Multiline = True
        Me.ComputerInfo.Name = "ComputerInfo"
        Me.ComputerInfo.ReadOnly = True
        Me.ComputerInfo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.ComputerInfo.Size = New System.Drawing.Size(234, 185)
        Me.ComputerInfo.TabIndex = 9
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 538)
        Me.Controls.Add(Me.ComputerInfo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Mem_ProgressBar)
        Me.Controls.Add(Me.CPU_ProgressBar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dr.Hard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ReloadTimeSetter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CPUCounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CPU_ProgressBar As ProgressBar
    Friend WithEvents Mem_ProgressBar As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ReloadTimeSetter As NumericUpDown
    Friend WithEvents OnlyTimer As Timer
    Friend WithEvents CPUCounter As PerformanceCounter
    Friend WithEvents AlwaysOnTop As CheckBox
    Friend WithEvents ComputerInfo As TextBox
End Class
