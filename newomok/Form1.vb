Public Class frmMain
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Winhttp As New WinHttp.WinHttpRequest
        Dim id As String
        Dim pass As String
        Winhttp.Open("GET", "http://changhyun.dothome.co.kr/userdata.txt")
        Winhttp.Send()
        Winhttp.WaitForResponse()

        MsgBox((Winhttp.ResponseText))
    End Sub
End Class
