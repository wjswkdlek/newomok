Public Class frmMain
    Private Function UnicodeBytesToString(
    ByVal bytes() As Byte) As String
        Return System.Text.Encoding.Unicode.GetString(bytes)
    End Function
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Winhttp As New WinHttp.WinHttpRequest
        Dim id As String
        Dim pass As String
        Winhttp.Open("GET", "http://changhyun.dothome.co.kr/login.txt")
        Winhttp.Send()
        Winhttp.WaitForResponse()

        MsgBox(UnicodeBytesToString(Winhttp.ResponseBody))
    End Sub
End Class
