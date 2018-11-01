Public Class frmStart
    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateContextMenu()
    End Sub

    Private Sub frmStart_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        noti1.BalloonTipText = "You have not closed New Omok" + vbCrLf +
            "It has be moved to the tray" + vbCrLf +
            "Right click the icon to close."
        noti1.ShowBalloonTip(5000)
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
        If (Me.WindowState = FormWindowState.Minimized) Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
        End If

        Me.Activate()
        Focus()
    End Sub
End Class