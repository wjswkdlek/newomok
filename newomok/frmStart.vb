Public Class frmStart
    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Winhttp As New WinHttp.WinHttpRequest
        'Winhttp.Open("GET", "http://182.31.200.53:8080/userpermission.txt")
        Winhttp.Open("GET", "http://192.168.168.100:8080/userpermission.txt")
        Winhttp.Send()
        Winhttp.WaitForResponse()
        Dim frmMain As New frmMain
        Dim result() As String = Split(Winhttp.ResponseText, vbCrLf) 'result(globalvariables.whichuser) << 이게 로그인한 사용자 permission (easy2see도)
        Dim easy2see As String = result(GlobalVariables.whichuser)
        Dim name As String, grade As String
        lblUser.Text = easy2see
    End Sub

End Class