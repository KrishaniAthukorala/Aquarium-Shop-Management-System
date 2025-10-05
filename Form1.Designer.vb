<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        btnLogin = New Button()
        PictureBox1 = New PictureBox()
        lblHello = New Label()
        lblWelcome = New Label()
        Label1 = New Label()
        txtUser = New TextBox()
        lblAdmin = New Label()
        cmbUser = New ComboBox()
        txtPassword = New TextBox()
        lblSignup = New Label()
        chbShow = New CheckBox()
        lblForgot = New Label()
        lblMin = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Maroon
        btnLogin.BackgroundImageLayout = ImageLayout.None
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(78, 393)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(136, 33)
        btnLogin.TabIndex = 17
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(294, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(338, 568)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' lblHello
        ' 
        lblHello.AutoSize = True
        lblHello.Font = New Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblHello.ForeColor = Color.Maroon
        lblHello.Location = New Point(42, 74)
        lblHello.Name = "lblHello"
        lblHello.Size = New Size(0, 33)
        lblHello.TabIndex = 19
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point)
        lblWelcome.ForeColor = Color.Maroon
        lblWelcome.Location = New Point(33, 107)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(219, 47)
        lblWelcome.TabIndex = 20
        lblWelcome.Text = "Welcome!"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(42, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 33)
        Label1.TabIndex = 22
        Label1.Text = "Hello,"
        ' 
        ' txtUser
        ' 
        txtUser.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtUser.Location = New Point(42, 269)
        txtUser.Name = "txtUser"
        txtUser.PlaceholderText = " User Name"
        txtUser.Size = New Size(210, 26)
        txtUser.TabIndex = 24
        ' 
        ' lblAdmin
        ' 
        lblAdmin.AutoSize = True
        lblAdmin.Cursor = Cursors.Hand
        lblAdmin.Font = New Font("Century Gothic", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        lblAdmin.ForeColor = Color.Maroon
        lblAdmin.Location = New Point(22, 527)
        lblAdmin.Name = "lblAdmin"
        lblAdmin.Size = New Size(45, 16)
        lblAdmin.TabIndex = 25
        lblAdmin.Text = "Admin"
        ' 
        ' cmbUser
        ' 
        cmbUser.BackColor = Color.White
        cmbUser.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cmbUser.FormattingEnabled = True
        cmbUser.Items.AddRange(New Object() {"  Employee", "  Admin"})
        cmbUser.Location = New Point(42, 221)
        cmbUser.Name = "cmbUser"
        cmbUser.Size = New Size(210, 28)
        cmbUser.TabIndex = 110
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(42, 315)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = " Password"
        txtPassword.Size = New Size(210, 26)
        txtPassword.TabIndex = 112
        ' 
        ' lblSignup
        ' 
        lblSignup.AutoSize = True
        lblSignup.BackColor = Color.White
        lblSignup.Cursor = Cursors.Hand
        lblSignup.Font = New Font("Century Gothic", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        lblSignup.ForeColor = Color.Maroon
        lblSignup.Location = New Point(228, 527)
        lblSignup.Name = "lblSignup"
        lblSignup.Size = New Size(49, 16)
        lblSignup.TabIndex = 113
        lblSignup.Text = "Sign up"
        ' 
        ' chbShow
        ' 
        chbShow.AutoSize = True
        chbShow.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        chbShow.ForeColor = SystemColors.WindowText
        chbShow.Location = New Point(228, 323)
        chbShow.Name = "chbShow"
        chbShow.Size = New Size(15, 14)
        chbShow.TabIndex = 114
        chbShow.UseVisualStyleBackColor = True
        ' 
        ' lblForgot
        ' 
        lblForgot.AutoSize = True
        lblForgot.Cursor = Cursors.Hand
        lblForgot.Font = New Font("Century Gothic", 9F, FontStyle.Underline, GraphicsUnit.Point)
        lblForgot.ForeColor = Color.Maroon
        lblForgot.Location = New Point(42, 344)
        lblForgot.Name = "lblForgot"
        lblForgot.Size = New Size(106, 17)
        lblForgot.TabIndex = 115
        lblForgot.Text = "Forgot password"
        ' 
        ' lblMin
        ' 
        lblMin.AutoSize = True
        lblMin.BackColor = Color.White
        lblMin.Font = New Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblMin.ForeColor = Color.Maroon
        lblMin.Location = New Point(263, 9)
        lblMin.Name = "lblMin"
        lblMin.Size = New Size(25, 32)
        lblMin.TabIndex = 116
        lblMin.Text = "-"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(629, 566)
        Controls.Add(lblMin)
        Controls.Add(lblForgot)
        Controls.Add(chbShow)
        Controls.Add(lblSignup)
        Controls.Add(txtPassword)
        Controls.Add(cmbUser)
        Controls.Add(lblAdmin)
        Controls.Add(txtUser)
        Controls.Add(Label1)
        Controls.Add(lblWelcome)
        Controls.Add(lblHello)
        Controls.Add(PictureBox1)
        Controls.Add(btnLogin)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Page"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHello As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblAdmin As Label
    Friend WithEvents cmbUser As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblSignup As Label
    Friend WithEvents chbShow As CheckBox
    Friend WithEvents lblForgot As Label
    Friend WithEvents lblMin As Label
End Class
