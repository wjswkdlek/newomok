<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStart
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
        Me.btnMessenger = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOmok = New System.Windows.Forms.Button()
        Me.btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Notice = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMessenger
        '
        Me.btnMessenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMessenger.Location = New System.Drawing.Point(12, 60)
        Me.btnMessenger.Name = "btnMessenger"
        Me.btnMessenger.Size = New System.Drawing.Size(60, 60)
        Me.btnMessenger.TabIndex = 0
        Me.btnMessenger.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VScrollBar1)
        Me.GroupBox1.Font = New System.Drawing.Font("나눔고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 278)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Server List"
        '
        'btnOmok
        '
        Me.btnOmok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOmok.Location = New System.Drawing.Point(78, 60)
        Me.btnOmok.Name = "btnOmok"
        Me.btnOmok.Size = New System.Drawing.Size(60, 60)
        Me.btnOmok.TabIndex = 2
        Me.btnOmok.UseVisualStyleBackColor = True
        '
        'btn
        '
        Me.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn.Location = New System.Drawing.Point(144, 60)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(60, 60)
        Me.btn.TabIndex = 3
        Me.btn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.Location = New System.Drawing.Point(372, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(385, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name/Level"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(440, 21)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 254)
        Me.VScrollBar1.TabIndex = 0
        '
        'Notice
        '
        Me.Notice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Notice.Enabled = False
        Me.Notice.Font = New System.Drawing.Font("나눔고딕", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Notice.Location = New System.Drawing.Point(12, 12)
        Me.Notice.Multiline = False
        Me.Notice.Name = "Notice"
        Me.Notice.ReadOnly = True
        Me.Notice.Size = New System.Drawing.Size(354, 42)
        Me.Notice.TabIndex = 6
        Me.Notice.Text = ""
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Notice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.btnOmok)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMessenger)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStart"
        Me.ShowIcon = False
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMessenger As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnOmok As Button
    Friend WithEvents btn As Button
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Notice As RichTextBox
End Class
