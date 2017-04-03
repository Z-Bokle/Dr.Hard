Public Class NetworkForm

    Private Sub NetworkForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PingButton_Click(sender As Object, e As EventArgs) Handles PingButton.Click
        Dim url As String = Ping_URL.Text
        'load the url that will be pinged.
        Dim pinged As New System.Net.NetworkInformation.Ping
        Dim delay As Long = pinged.Send(url, 5000).RoundtripTime
        If My.Computer.Network.Ping(url, 5000) = True Then

            MsgBox("Delay:" & delay & "ms", 0, "Ping")

        Else

            MsgBox("Can't ping this url successfully!", 0, "Error")

        End If

    End Sub
End Class