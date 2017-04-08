Imports Dr.Hard.My
Public Class AboutForm

    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim version As String = Application.Info.Version.Major & "." & Application.Info.Version.Minor & "." & Application.Info.Version.Build
        AboutLabel.Text = "Product name:" & Application.Info.ProductName & vbCrLf & "App name:" & Application.Info.Title & vbCrLf & "Version:" & version & vbCrLf & vbCrLf & "Thanks list" & vbCrLf & "Bokle"



    End Sub

End Class