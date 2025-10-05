<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        lblExit = New Label()
        lblRegistration = New Label()
        lblFirst = New Label()
        txtFirst = New TextBox()
        txtLast = New TextBox()
        lblUser = New Label()
        txtUser = New TextBox()
        txtPassword = New TextBox()
        lblPassword = New Label()
        txtConfirm = New TextBox()
        lblConfirm = New Label()
        btnRegister = New Button()
        lblRegister = New Label()
        lblLogin = New Label()
        lblLast = New Label()
        lblGender = New Label()
        txtAddress = New TextBox()
        lblAddress = New Label()
        lblContact = New Label()
        txtContact = New TextBox()
        rdbFemale = New RadioButton()
        rdbMale = New RadioButton()
        txtEmail = New TextBox()
        lblEmail = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Maroon
        Panel1.Controls.Add(lblExit)
        Panel1.Controls.Add(lblRegistration)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(360, 44)
        Panel1.TabIndex = 146
        ' 
        ' lblExit
        ' 
        lblExit.AutoSize = True
        lblExit.BackColor = Color.Maroon
        lblExit.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblExit.ForeColor = Color.Transparent
        lblExit.Location = New Point(328, 12)
        lblExit.Name = "lblExit"
        lblExit.Size = New Size(20, 19)
        lblExit.TabIndex = 29
        lblExit.Text = "X"
        ' 
        ' lblRegistration
        ' 
        lblRegistration.AutoSize = True
        lblRegistration.Font = New Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point)
        lblRegistration.Location = New Point(12, 9)
        lblRegistration.Name = "lblRegistration"
        lblRegistration.Size = New Size(123, 23)
        lblRegistration.TabIndex = 0
        lblRegistration.Text = "Registration"
        ' 
        ' lblFirst
        ' 
        lblFirst.AutoSize = True
        lblFirst.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblFirst.Location = New Point(27, 75)
        lblFirst.Name = "lblFirst"
        lblFirst.Size = New Size(73, 17)
        lblFirst.TabIndex = 147
        lblFirst.Text = "First name"
        ' 
        ' txtFirst
        ' 
        txtFirst.BackColor = Color.White
        txtFirst.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtFirst.ForeColor = Color.Black
        txtFirst.Location = New Point(179, 69)
        txtFirst.Name = "txtFirst"
        txtFirst.Size = New Size(151, 23)
        txtFirst.TabIndex = 148
        txtFirst.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtLast
        ' 
        txtLast.BackColor = Color.White
        txtLast.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtLast.ForeColor = Color.Black
        txtLast.Location = New Point(179, 110)
        txtLast.Name = "txtLast"
        txtLast.Size = New Size(151, 23)
        txtLast.TabIndex = 149
        txtLast.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblUser.Location = New Point(27, 155)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(75, 17)
        lblUser.TabIndex = 150
        lblUser.Text = "User name"
        ' 
        ' txtUser
        ' 
        txtUser.BackColor = Color.White
        txtUser.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtUser.Location = New Point(179, 149)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(151, 23)
        txtUser.TabIndex = 151
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(179, 348)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(151, 23)
        txtPassword.TabIndex = 153
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPassword.Location = New Point(26, 354)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(69, 17)
        lblPassword.TabIndex = 152
        lblPassword.Text = "Password"
        ' 
        ' txtConfirm
        ' 
        txtConfirm.BackColor = Color.White
        txtConfirm.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtConfirm.Location = New Point(179, 387)
        txtConfirm.Name = "txtConfirm"
        txtConfirm.PasswordChar = "*"c
        txtConfirm.Size = New Size(151, 23)
        txtConfirm.TabIndex = 155
        ' 
        ' lblConfirm
        ' 
        lblConfirm.AutoSize = True
        lblConfirm.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblConfirm.Location = New Point(26, 393)
        lblConfirm.Name = "lblConfirm"
        lblConfirm.Size = New Size(126, 17)
        lblConfirm.TabIndex = 154
        lblConfirm.Text = "Confirm password"
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.Maroon
        btnRegister.FlatStyle = FlatStyle.Popup
        btnRegister.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(129, 436)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(100, 33)
        btnRegister.TabIndex = 156
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' lblRegister
        ' 
        lblRegister.AutoSize = True
        lblRegister.BackColor = Color.Transparent
        lblRegister.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRegister.Location = New Point(31, 488)
        lblRegister.Name = "lblRegister"
        lblRegister.Size = New Size(135, 17)
        lblRegister.TabIndex = 157
        lblRegister.Text = "Are you registered ?"
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.BackColor = Color.Transparent
        lblLogin.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblLogin.ForeColor = Color.Maroon
        lblLogin.Location = New Point(255, 488)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(75, 16)
        lblLogin.TabIndex = 158
        lblLogin.Text = "Login here"
        ' 
        ' lblLast
        ' 
        lblLast.AutoSize = True
        lblLast.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLast.Location = New Point(27, 116)
        lblLast.Name = "lblLast"
        lblLast.Size = New Size(75, 17)
        lblLast.TabIndex = 159
        lblLast.Text = "Last name"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblGender.Location = New Point(27, 195)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(56, 17)
        lblGender.TabIndex = 160
        lblGender.Text = "Gender"
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.White
        txtAddress.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtAddress.Location = New Point(179, 228)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(151, 23)
        txtAddress.TabIndex = 162
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblAddress.Location = New Point(26, 234)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(57, 17)
        lblAddress.TabIndex = 163
        lblAddress.Text = "Address"
        ' 
        ' lblContact
        ' 
        lblContact.AutoSize = True
        lblContact.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblContact.Location = New Point(26, 273)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(86, 17)
        lblContact.TabIndex = 164
        lblContact.Text = "Contact No"
        ' 
        ' txtContact
        ' 
        txtContact.BackColor = Color.White
        txtContact.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtContact.Location = New Point(179, 267)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(151, 23)
        txtContact.TabIndex = 165
        ' 
        ' rdbFemale
        ' 
        rdbFemale.AutoSize = True
        rdbFemale.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        rdbFemale.Location = New Point(252, 191)
        rdbFemale.Name = "rdbFemale"
        rdbFemale.Size = New Size(73, 21)
        rdbFemale.TabIndex = 167
        rdbFemale.TabStop = True
        rdbFemale.Text = "Female"
        rdbFemale.UseVisualStyleBackColor = True
        ' 
        ' rdbMale
        ' 
        rdbMale.AutoSize = True
        rdbMale.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        rdbMale.Location = New Point(138, 191)
        rdbMale.Name = "rdbMale"
        rdbMale.Size = New Size(57, 21)
        rdbMale.TabIndex = 166
        rdbMale.TabStop = True
        rdbMale.Text = "Male"
        rdbMale.UseVisualStyleBackColor = True
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.White
        txtEmail.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmail.Location = New Point(179, 308)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(151, 23)
        txtEmail.TabIndex = 169
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmail.Location = New Point(26, 314)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(43, 17)
        lblEmail.TabIndex = 168
        lblEmail.Text = "Email"
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(360, 525)
        Controls.Add(txtEmail)
        Controls.Add(lblEmail)
        Controls.Add(rdbFemale)
        Controls.Add(rdbMale)
        Controls.Add(txtContact)
        Controls.Add(lblContact)
        Controls.Add(lblAddress)
        Controls.Add(txtAddress)
        Controls.Add(lblGender)
        Controls.Add(lblLast)
        Controls.Add(lblLogin)
        Controls.Add(lblRegister)
        Controls.Add(btnRegister)
        Controls.Add(txtConfirm)
        Controls.Add(lblConfirm)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        Controls.Add(txtUser)
        Controls.Add(lblUser)
        Controls.Add(txtLast)
        Controls.Add(txtFirst)
        Controls.Add(lblFirst)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Register"
        Text = "Register"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblExit As Label
    Friend WithEvents lblRegistration As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents lblConfirm As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblRegister As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
End Class
