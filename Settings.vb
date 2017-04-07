Public Class Settings

    Private Sub ReloadTimeSetter_ValueChanged(sender As Object, e As EventArgs)

        MainForm.reload_time = ReloadTimeSetter.Value
        'Change reload time


    End Sub





    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Check_AlwaysOnTop.Checked = MainForm.Check_AlwaysOnTop_Pub
        MainForm.TopMost = MainForm.Check_AlwaysOnTop_Pub

        Check_Border.Checked = MainForm.Check_Border_Pub

        If MainForm.Check_Border_Pub = True Then

            MainForm.FormBorderStyle = FormBorderStyle.Sizable

        Else

            MainForm.FormBorderStyle = FormBorderStyle.None


        End If

    End Sub

    Private Sub Check_AlwaysOnTop_Click(sender As Object, e As EventArgs) Handles Check_AlwaysOnTop.Click

        If Check_AlwaysOnTop.Checked = True Then

            MainForm.TopMost = True
            MainForm.Check_AlwaysOnTop_Pub = True
            Check_AlwaysOnTop.Checked = True


        Else

            MainForm.TopMost = False
            MainForm.Check_AlwaysOnTop_Pub = False
            Check_AlwaysOnTop.Checked = False

        End If


    End Sub


    Private Sub Check_Border_Click(sender As Object, e As EventArgs) Handles Check_Border.Click

        If Check_Border.Checked = True Then

            MainForm.FormBorderStyle = FormBorderStyle.Sizable
            MainForm.Check_Border_Pub = True
            Check_Border.Checked = True

        Else

            MainForm.FormBorderStyle = FormBorderStyle.None
            Check_Border.Checked = False
            MainForm.Check_Border_Pub = False

        End If

    End Sub


End Class