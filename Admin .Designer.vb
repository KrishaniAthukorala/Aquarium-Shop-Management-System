<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        lblAdmin = New Label()
        lblLogout = New Label()
        txtPassword = New TextBox()
        btnLogin = New Button()
        chbShow = New CheckBox()
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
        Panel1.Controls.Add(lblAdmin)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(304, 44)
        Panel1.TabIndex = 1
        ' 
        ' lblEx
        ' 
        lblEx.AutoSize = True
        lblEx.BackColor = Color.Maroon
        lblEx.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblEx.ForeColor = Color.Transparent
        lblEx.Location = New Point(271, 13)
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
        ' lblAdmin
        ' 
        lblAdmin.AutoSize = True
        lblAdmin.Font = New Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point)
        lblAdmin.Location = New Point(12, 9)
        lblAdmin.Name = "lblAdmin"
        lblAdmin.Size = New Size(128, 23)
        lblAdmin.TabIndex = 0
        lblAdmin.Text = "Admin login"
        ' 
        ' lblLogout
        ' 
        lblLogout.AutoSize = True
        lblLogout.Cursor = Cursors.Hand
        lblLogout.Font = New Font("Century Gothic", 9.75F, FontStyle.Underline, GraphicsUnit.Point)
        lblLogout.ForeColor = Color.Black
        lblLogout.Location = New Point(238, 47)
        lblLogout.Name = "lblLogout"
        lblLogout.Size = New Size(58, 17)
        lblLogout.TabIndex = 33
        lblLogout.Text = "Log out"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(46, 81)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = " Password"
        txtPassword.Size = New Size(210, 26)
        txtPassword.TabIndex = 17
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Maroon
        btnLogin.BackgroundImageLayout = ImageLayout.None
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(96, 127)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(106, 33)
        btnLogin.TabIndex = 18
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' chbShow
        ' 
        chbShow.AutoSize = True
        chbShow.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chbShow.ForeColor = SystemColors.WindowText
        chbShow.Location = New Point(238, 89)
        chbShow.Name = "chbShow"
        chbShow.Size = New Size(15, 14)
        chbShow.TabIndex = 115
        chbShow.UseVisualStyleBackColor = True
        ' 
        ' lblMin
        ' 
        lblMin.AutoSize = True
        lblMin.Font = New Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblMin.Location = New Point(240, 3)
        lblMin.Name = "lblMin"
        lblMin.Size = New Size(25, 32)
        lblMin.TabIndex = 33
        lblMin.Text = "-"
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(304, 186)
        Controls.Add(chbShow)
        Controls.Add(lblLogout)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(Panel1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents lblAdmin As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblLogout As Label
    Friend WithEvents lblEx As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents chbShow As CheckBox
    Friend WithEvents lblMin As Label
End Class
