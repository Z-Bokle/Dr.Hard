Imports System.IO
Imports System.IO.File

Public Class NetworkForm




    Private Sub PingButton_Click(sender As Object, e As EventArgs) Handles PingButton.Click
        Dim url As String = Ping_URL.Text
        'load the url that will be pinged.

        Dim pinged As New System.Net.NetworkInformation.Ping

        Try

            If My.Computer.Network.Ping(url, 5000) = True Then

                Dim delay As Long = pinged.Send(url, 5000).RoundtripTime
                MsgBox("Delay:" & delay & "ms", 0, "Ping")

            Else

                MsgBox("Can't ping this url successfully!", 0, "Error")

            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            MsgBox("Please check out if your website is correct.", 0, "Error")
            Dim LogStream As New FileStream(Application.StartupPath & "\Dr.Hard.log", FileMode.OpenOrCreate)

        End Try



    End Sub
End Class