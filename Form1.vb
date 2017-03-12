
Public Class MainForm

    Public reload_time As Single
    Public CPU_Used As Single
    Public Mem_used As Single
    Public OSVersion As String
    Public OSPlatform As String
    Public OSFullName As String
    Public memsize As Single







    Private Sub ReloadTimeSetter_ValueChanged(sender As Object, e As EventArgs) Handles ReloadTimeSetter.ValueChanged

        reload_time = ReloadTimeSetter.Value
        'Change reload time


    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        OSVersion = My.Computer.Info.OSVersion
        OSPlatform = My.Computer.Info.OSPlatform
        OSFullName = My.Computer.Info.OSFullName
        'get computer's infomation
        ComputerInfo.Text = "OSVersion" & Space(5) & OSVersion & vbCrLf & vbCrLf & "OSFullName" & Space(5) & OSFullName & vbCrLf & vbCrLf & "OSPlatform" & Space(5) & OSPlatform & vbCrLf & vbCrLf
        'Platform Info Show


        memsize = My.Computer.Info.TotalPhysicalMemory
        ComputerInfo.Text = ComputerInfo.Text & "Total Memory" & Space(5) & Math.Round(memsize / 1024 / 1024 / 1024) & "GB" & vbCrLf & vbCrLf
        'Memory Info Show





        reload_time = ReloadTimeSetter.Value
        'set reload time


        OnlyTimer.Interval = reload_time * 1000

        OnlyTimer.Start()






    End Sub

    Private Sub OnlyTimer_Tick(sender As Object, e As EventArgs) Handles OnlyTimer.Tick


        OnlyTimer.Interval = reload_time * 1000


        CPU_Used = CPUCounter.NextValue()
        Mem_used = 100 * (1 - My.Computer.Info.AvailablePhysicalMemory / My.Computer.Info.TotalPhysicalMemory)
        'Get values




        CPU_ProgressBar.Value = CPU_Used
        Mem_ProgressBar.Value = Mem_used

        'Show user values




    End Sub

    Private Sub AlwaysOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles AlwaysOnTop.CheckedChanged

        If AlwaysOnTop.Checked = True Then

            Me.TopMost = True
        Else
            Me.TopMost = False

        End If


    End Sub
End Class
