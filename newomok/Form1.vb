Public Class frmMain
    Dim logincount = 0
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        txtCheck.Visible = False
        Dim Winhttp As New WinHttp.WinHttpRequest
        Dim idpass As String = txtID.Text + "|" + txtPass.Text
        Winhttp.Open("GET", "http://182.31.200.53:8080/userdata.txt") '외부 접속시 사용 (다른 사람에게 테스트 요청할때)
        'Winhttp.Open("GET", "http://192.168.168.100:8080/userdata.txt") '내부 접속시 사용 (내가 테스트 할때)
        Winhttp.Send()
        Winhttp.WaitForResponse()
        Dim result() As String = Split(Winhttp.ResponseText, vbCrLf)
        For i = 0 To result.Length - 1
            If result(i) = idpass Then
                noti1.Visible = False
                logincount = 1
                frmStart.Visible = True
                frmStart.Show()
                Me.Hide()
            Else
                txtCheck.Text = "아이디 또는 비밀번호가 올바르지 않습니다."
                txtCheck.Visible = True
            End If
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmAbout.Show()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles noti1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateContextMenu()
    End Sub

    Public Sub CreateContextMenu()
        Dim contextMenu As New ContextMenu
        Dim exitapp As New MenuItem("Exit")
        contextMenu.MenuItems.Add(exitapp)
        noti1.ContextMenu = contextMenu
        AddHandler exitapp.Click, AddressOf exitapp_Click
    End Sub

    Private Sub exitapp_Click(ByVal sender As Object, ByVal e As EventArgs)
        End
    End Sub

    Private Sub noti1_DoubleClick(sender As Object, e As EventArgs) Handles noti1.DoubleClick
        If (Me.WindowState = FormWindowState.Minimized And logincount = 0) Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
        Else

        End If

        Me.Activate()
        Focus()
    End Sub
End Class
