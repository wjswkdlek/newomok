<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCheck = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.noti1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("나눔고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(12, 481)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(355, 52)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("나눔고딕", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txtPass.Location = New System.Drawing.Point(16, 396)
        Me.txtPass.Multiline = False
        Me.txtPass.Name = "txtPass"
        Me.txtPass.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtPass.Size = New System.Drawing.Size(351, 46)
        Me.txtPass.TabIndex = 10
        Me.txtPass.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("나눔고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(12, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Font = New System.Drawing.Font("나눔고딕", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txtID.Location = New System.Drawing.Point(12, 295)
        Me.txtID.Multiline = False
        Me.txtID.Name = "txtID"
        Me.txtID.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtID.Size = New System.Drawing.Size(355, 46)
        Me.txtID.TabIndex = 8
        Me.txtID.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("나눔고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(12, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID"
        '
        'txtCheck
        '
        Me.txtCheck.AutoSize = True
        Me.txtCheck.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txtCheck.ForeColor = System.Drawing.Color.Red
        Me.txtCheck.Location = New System.Drawing.Point(13, 454)
        Me.txtCheck.Name = "txtCheck"
        Me.txtCheck.Size = New System.Drawing.Size(109, 14)
        Me.txtCheck.TabIndex = 12
        Me.txtCheck.Text = "로그인이 필요합니다"
        Me.txtCheck.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.newomok.My.Resources.Resource1.omok
        Me.PictureBox1.Location = New System.Drawing.Point(65, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'noti1
        '
        Me.noti1.BalloonTipTitle = "New Omok"
        Me.noti1.Icon = CType(resources.GetObject("noti1.Icon"), System.Drawing.Icon)
        Me.noti1.Text = "New Omok"
        Me.noti1.Visible = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(379, 546)
        Me.Controls.Add(Me.txtCheck)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPass As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtCheck As Label
    Friend WithEvents noti1 As NotifyIcon
End Class
