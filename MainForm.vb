Imports System.IO.File
Imports System.ComponentModel
Imports System
Imports System.IO
Imports System.Collections
Imports System.Windows



Public Class MainForm



    Public reload_time As Single    'values refresh time
    Public CPU_Used As Single   'CPU usage
    Public Mem_used As Single   'Memory usage
    Public OSVersion As String  'Platform version
    Public OSPlatform As String 'Platform name
    Public OSFullName As String 'Platform fullname
    Public memsize As Single    'Maximum memory

    Public Check_AlwaysOnTop_Pub As Boolean = False
    Public Check_Border_Pub As Boolean = True

    Public RelX As Integer
    Public RelY As Integer
    Public Mouse2Clicks As Boolean = False




    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = True



        OSVersion = My.Computer.Info.OSVersion
        OSPlatform = My.Computer.Info.OSPlatform
        OSFullName = My.Computer.Info.OSFullName
        'get computer's infomation
        memsize = My.Computer.Info.TotalPhysicalMemory







        reload_time = Settings.ReloadTimeSetter.Value
        'set reload time


        OnlyTimer.Interval = reload_time * 1000

        OnlyTimer.Start()

        If Exists(Application.StartupPath & "\Dr.Hard.log") = True Then
            Kill(Application.StartupPath & "\Dr.Hard.log")
        End If

        Dim LogStream As New FileStream(Application.StartupPath & "\Dr.Hard.log", FileMode.Create)
        LogStream.Close()





    End Sub

    Private Sub OnlyTimer_Tick(sender As Object, e As EventArgs) Handles OnlyTimer.Tick


        OnlyTimer.Interval = reload_time * 1000


        CPU_Used = CPUCounter.NextValue()
        Mem_used = 100 * (1 - My.Computer.Info.AvailablePhysicalMemory / My.Computer.Info.TotalPhysicalMemory)
        'Get values




        CPU_ProgressBar.Value = CPU_Used
        Mem_ProgressBar.Value = Mem_used
        CPU_Used_Label.Text = Math.Round(CPU_Used) & "%"
        Mem_Uesd_Label.Text = Math.Round(Mem_used) & "%"


        'Show user values

        NotifyIcon.Text = "CPU" & Space(2) & Math.Round(CPU_Used) & "%" & vbCr & "Memory" & Space(2) & Math.Round(Mem_used) & "%"




    End Sub





    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        If Me.WindowState = 1 Then


            Me.ShowInTaskbar = False

        Else
            Me.ShowInTaskbar = True



        End If




    End Sub

    Private Sub NotifyIcon_Click(sender As Object, e As EventArgs) Handles NotifyIcon.MouseDoubleClick


        Me.WindowState = 0


    End Sub


    Private Sub Menu_Open_Click(sender As Object, e As EventArgs) Handles Menu_Open.Click

        Me.WindowState = 0


    End Sub

    Private Sub Menu_Close_Click(sender As Object, e As EventArgs) Handles Menu_Exit.Click

        Me.Close()

    End Sub


    Private Sub Menu_About_Click(sender As Object, e As EventArgs) Handles Menu_About.Click

        AboutForm.Show()
        AboutForm.Focus()


    End Sub

    Private Sub Menu_Homepage_Click(sender As Object, e As EventArgs) Handles Menu_Homepage.Click

        System.Diagnostics.Process.Start("https://github.com/Z-Bokle/Dr.Hard")

    End Sub

    Private Sub Menu_CheckForUpdate_Click(sender As Object, e As EventArgs) Handles Menu_CheckForUpdate.Click

        System.Diagnostics.Process.Start("https://github.com/Z-Bokle/Dr.Hard/releases")

    End Sub



    Private Sub Menu_Network_Click(sender As Object, e As EventArgs) Handles Menu_Network.Click

        NetworkForm.Show()
        NetworkForm.Focus()


    End Sub

    Private Sub Menu_ComputerInfo_Click(sender As Object, e As EventArgs) Handles Menu_ComputerInfo.Click
        ComputerInfo_Form.ComputerInfo.Text = "OSVersion" & Space(5) & OSVersion & vbCrLf & vbCrLf & "OSFullName" & Space(5) & OSFullName & vbCrLf & vbCrLf & "OSPlatform" & Space(5) & OSPlatform & vbCrLf & vbCrLf
        'Show Platform Info 


        ComputerInfo_Form.ComputerInfo.Text = ComputerInfo_Form.ComputerInfo.Text & "Total Memory" & Space(5) & Math.Round(memsize / 1024 / 1024 / 1024) & "GB" & vbCrLf & vbCrLf
        'Show Memory Info

        ComputerInfo_Form.Show()
        ComputerInfo_Form.Focus()
    End Sub

    Private Sub Menu_Settings_Click(sender As Object, e As EventArgs) Handles Menu_Settings.Click

        Settings.Focus()
        Settings.Show()

    End Sub

    Private Sub Menu_Settings_2_Click(sender As Object, e As EventArgs) Handles Menu_Settings_2.Click

        Settings.Focus()
        Settings.Show()

    End Sub

    Private Sub MainForm_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick

        If Mouse2Clicks = False Then

            Mouse2Clicks = True

        Else

            Mouse2Clicks = False


        End If

        RelX = MousePosition.X - Me.Location.X
        'Relative distance in X line.



        RelY = MousePosition.Y - Me.Location.Y
        'Relative distance in Y line.



        If e.Button = Forms.MouseButtons.Left And Mouse2Clicks = True Then



            FormMovingTimer.Start()
            Me.Opacity = 0.45

        Else

            FormMovingTimer.Stop()
            Me.Opacity = 1


        End If






    End Sub


    Private Sub MainForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown





    End Sub


    Private Sub FormMovingTimer_Tick(sender As Object, e As EventArgs) Handles FormMovingTimer.Tick









        Me.Location = New Point(MousePosition.X - RelX, MousePosition.Y - RelY)






    End Sub



End Class
