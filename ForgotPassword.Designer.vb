<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        lblEx = New Label()
        Label2 = New Label()
        lblExit = New Label()
        lblForgot = New Label()
        lblLogin = New Label()
        txtEmNo = New TextBox()
        lblEmNo = New Label()
        txtNew = New TextBox()
        lblNew = New Label()
        btnSave = New Button()
        txtConfirm = New TextBox()
        lblConfirm = New Label()
        chbShow1 = New CheckBox()
        chbShow2 = New CheckBox()
        lblMin = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Maroon
        Panel1.Controls.Add(lblMin)
        Panel1.Controls.Add(lblEx)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(lblExit)
        Panel1.Controls.Add(lblForgot)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(400, 44)
        Panel1.TabIndex = 2
        ' 
        ' lblEx
        ' 
        lblEx.AutoSize = True
        lblEx.BackColor = Color.Maroon
        lblEx.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblEx.ForeColor = Color.Transparent
        lblEx.Location = New Point(368, 12)
        lblEx.Name = "lblEx"
        lblEx.Size = New Size(20, 19)
        lblEx.TabIndex = 32
        lblEx.Text = "X"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(1042, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 16)
        Label2.TabIndex = 31
        Label2.Text = "Back"
        ' 
        ' lblExit
        ' 
        lblExit.AutoSize = True
        lblExit.BackColor = Color.Maroon
        lblExit.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblExit.ForeColor = Color.Transparent
        lblExit.Location = New Point(1097, 13)
        lblExit.Name = "lblExit"
        lblExit.Size = New Size(20, 19)
        lblExit.TabIndex = 29
        lblExit.Text = "X"
        ' 
        ' lblForgot
        ' 
        lblForgot.AutoSize = True
        lblForgot.Font = New Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point)
        lblForgot.Location = New Point(12, 9)
        lblForgot.Name = "lblForgot"
        lblForgot.Size = New Size(161, 23)
        lblForgot.TabIndex = 0
        lblForgot.Text = "Reset password"
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Cursor = Cursors.Hand
        lblLogin.Font = New Font("Century Gothic", 9.75F, FontStyle.Underline, GraphicsUnit.Point)
        lblLogin.ForeColor = Color.Black
        lblLogin.Location = New Point(345, 57)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(43, 17)
        lblLogin.TabIndex = 34
        lblLogin.Text = "Login"
        ' 
        ' txtEmNo
        ' 
        txtEmNo.BackColor = Color.White
        txtEmNo.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmNo.Location = New Point(174, 87)
        txtEmNo.Name = "txtEmNo"
        txtEmNo.Size = New Size(186, 23)
        txtEmNo.TabIndex = 36
        ' 
        ' lblEmNo
        ' 
        lblEmNo.AutoSize = True
        lblEmNo.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmNo.Location = New Point(32, 93)
        lblEmNo.Name = "lblEmNo"
        lblEmNo.Size = New Size(98, 17)
        lblEmNo.TabIndex = 35
        lblEmNo.Text = "Employee No."
        ' 
        ' txtNew
        ' 
        txtNew.BackColor = Color.White
        txtNew.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtNew.Location = New Point(174, 131)
        txtNew.Name = "txtNew"
        txtNew.PasswordChar = "*"c
        txtNew.Size = New Size(186, 23)
        txtNew.TabIndex = 38
        ' 
        ' lblNew
        ' 
        lblNew.AutoSize = True
        lblNew.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblNew.Location = New Point(32, 137)
        lblNew.Name = "lblNew"
        lblNew.Size = New Size(104, 17)
        lblNew.TabIndex = 37
        lblNew.Text = "New password"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Maroon
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(174, 216)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 23)
        btnSave.TabIndex = 39
        btnSave.Text = "Save" & vbCrLf
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtConfirm
        ' 
        txtConfirm.BackColor = Color.White
        txtConfirm.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtConfirm.Location = New Point(174, 174)
        txtConfirm.Name = "txtConfirm"
        txtConfirm.PasswordChar = "*"c
        txtConfirm.Size = New Size(186, 23)
        txtConfirm.TabIndex = 41
        ' 
        ' lblConfirm
        ' 
        lblConfirm.AutoSize = True
        lblConfirm.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblConfirm.Location = New Point(32, 180)
        lblConfirm.Name = "lblConfirm"
        lblConfirm.Size = New Size(126, 17)
        lblConfirm.TabIndex = 40
        lblConfirm.Text = "Confirm password"
        ' 
        ' chbShow1
        ' 
        chbShow1.AutoSize = True
        chbShow1.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chbShow1.ForeColor = SystemColors.WindowText
        chbShow1.Location = New Point(336, 136)
        chbShow1.Name = "chbShow1"
        chbShow1.Size = New Size(15, 14)
        chbShow1.TabIndex = 115
        chbShow1.UseVisualStyleBackColor = True
        ' 
        ' chbShow2
        ' 
        chbShow2.AutoSize = True
        chbShow2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chbShow2.ForeColor = SystemColors.WindowText
        chbShow2.Location = New Point(336, 179)
        chbShow2.Name = "chbShow2"
        chbShow2.Size = New Size(15, 14)
        chbShow2.TabIndex = 116
        chbShow2.UseVisualStyleBackColor = True
        ' 
        ' lblMin
        ' 
        lblMin.AutoSize = True
        lblMin.Font = New Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblMin.Location = New Point(337, 2)
        lblMin.Name = "lblMin"
        lblMin.Size = New Size(25, 32)
        lblMin.TabIndex = 33
        lblMin.Text = "-"
        ' 
        ' ForgotPassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(400, 263)
        Controls.Add(chbShow2)
        Controls.Add(chbShow1)
        Controls.Add(txtConfirm)
        Controls.Add(lblConfirm)
        Controls.Add(btnSave)
        Controls.Add(txtNew)
        Controls.Add(lblNew)
        Controls.Add(txtEmNo)
        Controls.Add(lblEmNo)
        Controls.Add(lblLogin)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ForgotPassword"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ForgotPassword"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblEx As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents lblForgot As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents txtEmNo As TextBox
    Friend WithEvents lblEmNo As Label
    Friend WithEvents txtNew As TextBox
    Friend WithEvents lblNew As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents lblConfirm As Label
    Friend WithEvents chbShow1 As CheckBox
    Friend WithEvents chbShow2 As CheckBox
    Friend WithEvents lblMin As Label
End Class
