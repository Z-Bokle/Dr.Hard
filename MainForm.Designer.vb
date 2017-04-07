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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OnlyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CPUCounter = New System.Diagnostics.PerformanceCounter()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TaskbarMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Menu_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_About_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Menu_Websites = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Homepage = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_CheckForUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.CPU_Used_Label = New System.Windows.Forms.Label()
        Me.Mem_Uesd_Label = New System.Windows.Forms.Label()
        Me.Menu_Network = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_ComputerInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Settings_2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Settings = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.CPUCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaskbarMenu.SuspendLayout()
        Me.FormMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'CPU_ProgressBar
        '
        Me.CPU_ProgressBar.Location = New System.Drawing.Point(152, 25)
        Me.CPU_ProgressBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CPU_ProgressBar.MarqueeAnimationSpeed = 1
        Me.CPU_ProgressBar.Name = "CPU_ProgressBar"
        Me.CPU_ProgressBar.Size = New System.Drawing.Size(373, 33)
        Me.CPU_ProgressBar.TabIndex = 0
        '
        'Mem_ProgressBar
        '
        Me.Mem_ProgressBar.Location = New System.Drawing.Point(152, 101)
        Me.Mem_ProgressBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Mem_ProgressBar.Name = "Mem_ProgressBar"
        Me.Mem_ProgressBar.Size = New System.Drawing.Size(373, 33)
        Me.Mem_ProgressBar.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(496, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "100"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(496, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "100"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CPU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 101)
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
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.TaskbarMenu
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Visible = True
        '
        'TaskbarMenu
        '
        Me.TaskbarMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Open, Me.Menu_Exit, Me.Menu_Settings_2, Me.Menu_About_2})
        Me.TaskbarMenu.Name = "TaskbarMenu"
        Me.TaskbarMenu.Size = New System.Drawing.Size(153, 114)
        '
        'Menu_Open
        '
        Me.Menu_Open.Name = "Menu_Open"
        Me.Menu_Open.Size = New System.Drawing.Size(152, 22)
        Me.Menu_Open.Text = "Open"
        '
        'Menu_Exit
        '
        Me.Menu_Exit.Name = "Menu_Exit"
        Me.Menu_Exit.Size = New System.Drawing.Size(152, 22)
        Me.Menu_Exit.Text = "Exit"
        '
        'Menu_About_2
        '
        Me.Menu_About_2.Name = "Menu_About_2"
        Me.Menu_About_2.Size = New System.Drawing.Size(152, 22)
        Me.Menu_About_2.Text = "About..."
        '
        'FormMenu
        '
        Me.FormMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_ComputerInfo, Me.Menu_Network, Me.Menu_Settings, Me.Menu_Websites, Me.Menu_About})
        Me.FormMenu.Name = "FormMenu"
        Me.FormMenu.Size = New System.Drawing.Size(162, 114)
        '
        'Menu_Websites
        '
        Me.Menu_Websites.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Homepage, Me.Menu_CheckForUpdate})
        Me.Menu_Websites.Name = "Menu_Websites"
        Me.Menu_Websites.Size = New System.Drawing.Size(161, 22)
        Me.Menu_Websites.Text = "Websites"
        '
        'Menu_Homepage
        '
        Me.Menu_Homepage.Name = "Menu_Homepage"
        Me.Menu_Homepage.Size = New System.Drawing.Size(234, 22)
        Me.Menu_Homepage.Text = "Our Website"
        '
        'Menu_CheckForUpdate
        '
        Me.Menu_CheckForUpdate.Name = "Menu_CheckForUpdate"
        Me.Menu_CheckForUpdate.Size = New System.Drawing.Size(234, 22)
        Me.Menu_CheckForUpdate.Text = "Check For Update By Hand"
        '
        'Menu_About
        '
        Me.Menu_About.Name = "Menu_About"
        Me.Menu_About.Size = New System.Drawing.Size(161, 22)
        Me.Menu_About.Text = "About..."
        '
        'CPU_Used_Label
        '
        Me.CPU_Used_Label.AutoSize = True
        Me.CPU_Used_Label.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CPU_Used_Label.Location = New System.Drawing.Point(542, 32)
        Me.CPU_Used_Label.Name = "CPU_Used_Label"
        Me.CPU_Used_Label.Size = New System.Drawing.Size(111, 27)
        Me.CPU_Used_Label.TabIndex = 10
        Me.CPU_Used_Label.Text = "CPU Used"
        '
        'Mem_Uesd_Label
        '
        Me.Mem_Uesd_Label.AutoSize = True
        Me.Mem_Uesd_Label.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Mem_Uesd_Label.Location = New System.Drawing.Point(542, 108)
        Me.Mem_Uesd_Label.Name = "Mem_Uesd_Label"
        Me.Mem_Uesd_Label.Size = New System.Drawing.Size(122, 27)
        Me.Mem_Uesd_Label.TabIndex = 11
        Me.Mem_Uesd_Label.Text = "Mem Used"
        '
        'Menu_Network
        '
        Me.Menu_Network.Name = "Menu_Network"
        Me.Menu_Network.Size = New System.Drawing.Size(161, 22)
        Me.Menu_Network.Text = "Network"
        '
        'Menu_ComputerInfo
        '
        Me.Menu_ComputerInfo.Name = "Menu_ComputerInfo"
        Me.Menu_ComputerInfo.Size = New System.Drawing.Size(161, 22)
        Me.Menu_ComputerInfo.Text = "Computer Info"
        '
        'Menu_Settings_2
        '
        Me.Menu_Settings_2.Name = "Menu_Settings_2"
        Me.Menu_Settings_2.Size = New System.Drawing.Size(152, 22)
        Me.Menu_Settings_2.Text = "Settings"
        '
        'Menu_Settings
        '
        Me.Menu_Settings.Name = "Menu_Settings"
        Me.Menu_Settings.Size = New System.Drawing.Size(161, 22)
        Me.Menu_Settings.Text = "Settings"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 189)
        Me.ContextMenuStrip = Me.FormMenu
        Me.Controls.Add(Me.Mem_Uesd_Label)
        Me.Controls.Add(Me.CPU_Used_Label)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
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
        CType(Me.CPUCounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaskbarMenu.ResumeLayout(False)
        Me.FormMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CPU_ProgressBar As ProgressBar
    Friend WithEvents Mem_ProgressBar As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents OnlyTimer As Timer
    Friend WithEvents CPUCounter As PerformanceCounter
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents TaskbarMenu As ContextMenuStrip
    Friend WithEvents Menu_Open As ToolStripMenuItem
    Friend WithEvents Menu_Exit As ToolStripMenuItem
    Friend WithEvents FormMenu As ContextMenuStrip
    Friend WithEvents Menu_About As ToolStripMenuItem
    Friend WithEvents Menu_Websites As ToolStripMenuItem
    Friend WithEvents Menu_Homepage As ToolStripMenuItem
    Friend WithEvents Menu_CheckForUpdate As ToolStripMenuItem
    Friend WithEvents CPU_Used_Label As Label
    Friend WithEvents Mem_Uesd_Label As Label
    Friend WithEvents Menu_About_2 As ToolStripMenuItem
    Friend WithEvents Menu_Network As ToolStripMenuItem
    Friend WithEvents Menu_ComputerInfo As ToolStripMenuItem
    Friend WithEvents Menu_Settings_2 As ToolStripMenuItem
    Friend WithEvents Menu_Settings As ToolStripMenuItem
End Class
