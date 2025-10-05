<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Employee))
        Panel1 = New Panel()
        lblMin = New Label()
        lblHome = New Label()
        lblExit = New Label()
        lblEmployee = New Label()
        lblEmNo = New Label()
        lblFull = New Label()
        Label4 = New Label()
        lblGender = New Label()
        lblAddress = New Label()
        lblContact = New Label()
        lblNIC = New Label()
        lblDOB = New Label()
        txtEmNo = New TextBox()
        txtFull = New TextBox()
        txtAddress = New TextBox()
        txtContact = New TextBox()
        txtNIC = New TextBox()
        rdbMale = New RadioButton()
        rdbFemale = New RadioButton()
        dtpDOB = New DateTimePicker()
        dgvEmployee = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Colum5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        btnSave = New Button()
        btnClear = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        lblSearch = New Label()
        txtSearch = New TextBox()
        txtEmail = New TextBox()
        Label1 = New Label()
        txtPassword = New TextBox()
        txtUser = New TextBox()
        Label3 = New Label()
        Label5 = New Label()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        txtConfirm = New TextBox()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        CType(dgvEmployee, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Maroon
        Panel1.Controls.Add(lblMin)
        Panel1.Controls.Add(lblHome)
        Panel1.Controls.Add(lblExit)
        Panel1.Controls.Add(lblEmployee)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1004, 44)
        Panel1.TabIndex = 0
        ' 
        ' lblMin
        ' 
        lblMin.AutoSize = True
        lblMin.Font = New Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblMin.Location = New Point(941, 3)
        lblMin.Name = "lblMin"
        lblMin.Size = New Size(25, 32)
        lblMin.TabIndex = 32
        lblMin.Text = "-"
        ' 
        ' lblHome
        ' 
        lblHome.AutoSize = True
        lblHome.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblHome.Location = New Point(891, 12)
        lblHome.Name = "lblHome"
        lblHome.Size = New Size(44, 16)
        lblHome.TabIndex = 31
        lblHome.Text = "Home"
        ' 
        ' lblExit
        ' 
        lblExit.AutoSize = True
        lblExit.BackColor = Color.Maroon
        lblExit.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblExit.ForeColor = Color.Transparent
        lblExit.Location = New Point(972, 12)
        lblExit.Name = "lblExit"
        lblExit.Size = New Size(20, 19)
        lblExit.TabIndex = 29
        lblExit.Text = "X"
        ' 
        ' lblEmployee
        ' 
        lblEmployee.AutoSize = True
        lblEmployee.Font = New Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmployee.Location = New Point(12, 9)
        lblEmployee.Name = "lblEmployee"
        lblEmployee.Size = New Size(178, 23)
        lblEmployee.TabIndex = 0
        lblEmployee.Text = "Employee details"
        ' 
        ' lblEmNo
        ' 
        lblEmNo.AutoSize = True
        lblEmNo.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmNo.Location = New Point(300, 83)
        lblEmNo.Name = "lblEmNo"
        lblEmNo.Size = New Size(98, 17)
        lblEmNo.TabIndex = 1
        lblEmNo.Text = "Employee No."
        ' 
        ' lblFull
        ' 
        lblFull.AutoSize = True
        lblFull.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblFull.Location = New Point(299, 121)
        lblFull.Name = "lblFull"
        lblFull.Size = New Size(148, 17)
        lblFull.TabIndex = 2
        lblFull.Text = "Full name with initialls"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(19, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 17)
        Label4.TabIndex = 3
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblGender.Location = New Point(671, 81)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(56, 17)
        lblGender.TabIndex = 5
        lblGender.Text = "Gender"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblAddress.Location = New Point(670, 118)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(57, 17)
        lblAddress.TabIndex = 6
        lblAddress.Text = "Address"
        ' 
        ' lblContact
        ' 
        lblContact.AutoSize = True
        lblContact.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblContact.Location = New Point(670, 152)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(90, 17)
        lblContact.TabIndex = 7
        lblContact.Text = "Contact No."
        ' 
        ' lblNIC
        ' 
        lblNIC.AutoSize = True
        lblNIC.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblNIC.Location = New Point(671, 228)
        lblNIC.Name = "lblNIC"
        lblNIC.Size = New Size(32, 17)
        lblNIC.TabIndex = 8
        lblNIC.Text = "NIC"
        ' 
        ' lblDOB
        ' 
        lblDOB.AutoSize = True
        lblDOB.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblDOB.Location = New Point(671, 264)
        lblDOB.Name = "lblDOB"
        lblDOB.Size = New Size(90, 17)
        lblDOB.TabIndex = 9
        lblDOB.Text = "Date of birth"
        ' 
        ' txtEmNo
        ' 
        txtEmNo.BackColor = Color.White
        txtEmNo.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmNo.Location = New Point(463, 77)
        txtEmNo.Name = "txtEmNo"
        txtEmNo.Size = New Size(151, 23)
        txtEmNo.TabIndex = 12
        ' 
        ' txtFull
        ' 
        txtFull.BackColor = Color.White
        txtFull.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtFull.Location = New Point(463, 115)
        txtFull.Name = "txtFull"
        txtFull.Size = New Size(151, 23)
        txtFull.TabIndex = 13
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.White
        txtAddress.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtAddress.Location = New Point(745, 108)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(240, 23)
        txtAddress.TabIndex = 16
        ' 
        ' txtContact
        ' 
        txtContact.BackColor = Color.White
        txtContact.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtContact.Location = New Point(834, 146)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(151, 23)
        txtContact.TabIndex = 17
        ' 
        ' txtNIC
        ' 
        txtNIC.BackColor = Color.White
        txtNIC.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtNIC.Location = New Point(834, 219)
        txtNIC.Name = "txtNIC"
        txtNIC.Size = New Size(151, 23)
        txtNIC.TabIndex = 18
        ' 
        ' rdbMale
        ' 
        rdbMale.AutoSize = True
        rdbMale.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        rdbMale.Location = New Point(798, 81)
        rdbMale.Name = "rdbMale"
        rdbMale.Size = New Size(57, 21)
        rdbMale.TabIndex = 19
        rdbMale.TabStop = True
        rdbMale.Text = "Male"
        rdbMale.UseVisualStyleBackColor = True
        ' 
        ' rdbFemale
        ' 
        rdbFemale.AutoSize = True
        rdbFemale.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        rdbFemale.Location = New Point(912, 81)
        rdbFemale.Name = "rdbFemale"
        rdbFemale.Size = New Size(73, 21)
        rdbFemale.TabIndex = 20
        rdbFemale.TabStop = True
        rdbFemale.Text = "Female"
        rdbFemale.UseVisualStyleBackColor = True
        ' 
        ' dtpDOB
        ' 
        dtpDOB.CalendarMonthBackground = Color.White
        dtpDOB.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        dtpDOB.Location = New Point(785, 258)
        dtpDOB.Name = "dtpDOB"
        dtpDOB.Size = New Size(200, 23)
        dtpDOB.TabIndex = 21
        ' 
        ' dgvEmployee
        ' 
        dgvEmployee.BackgroundColor = Color.White
        dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployee.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Colum5, Column6, Column7, Column8, Column9, Column10})
        dgvEmployee.Location = New Point(19, 375)
        dgvEmployee.Name = "dgvEmployee"
        dgvEmployee.RowTemplate.Height = 25
        dgvEmployee.Size = New Size(966, 212)
        dgvEmployee.TabIndex = 22
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Employee No"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Full name"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "User name"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Password"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Confirm password"
        Column5.Name = "Column5"
        ' 
        ' Colum5
        ' 
        Colum5.HeaderText = "Gender"
        Colum5.Name = "Colum5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Address"
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Contact No"
        Column7.Name = "Column7"
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "E mail"
        Column8.Name = "Column8"
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "NIC"
        Column9.Name = "Column9"
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Date of birth"
        Column10.Name = "Column10"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Maroon
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(25, 230)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 23)
        btnSave.TabIndex = 23
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Maroon
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(25, 271)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 23)
        btnClear.TabIndex = 24
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Maroon
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(146, 227)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 23)
        btnUpdate.TabIndex = 25
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Maroon
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(146, 271)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 23)
        btnDelete.TabIndex = 26
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblSearch.Location = New Point(300, 339)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(51, 17)
        lblSearch.TabIndex = 27
        lblSearch.Text = "Search"
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.White
        txtSearch.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearch.Location = New Point(376, 336)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(151, 23)
        txtSearch.TabIndex = 28
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.White
        txtEmail.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmail.Location = New Point(834, 181)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(151, 23)
        txtEmail.TabIndex = 29
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(671, 187)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 17)
        Label1.TabIndex = 30
        Label1.Text = "Email"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(463, 197)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(151, 23)
        txtPassword.TabIndex = 34
        ' 
        ' txtUser
        ' 
        txtUser.BackColor = Color.White
        txtUser.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtUser.Location = New Point(463, 156)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(151, 23)
        txtUser.TabIndex = 33
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(300, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 17)
        Label3.TabIndex = 32
        Label3.Text = "Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(300, 162)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 17)
        Label5.TabIndex = 31
        Label5.Text = "User name"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.PapayaWhip
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(btnSave)
        Panel2.Controls.Add(btnUpdate)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(btnDelete)
        Panel2.Location = New Point(0, 44)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(263, 312)
        Panel2.TabIndex = 35
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(25, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(215, 190)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(300, 242)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 17)
        Label2.TabIndex = 36
        Label2.Text = "Confirm password"
        ' 
        ' txtConfirm
        ' 
        txtConfirm.BackColor = Color.White
        txtConfirm.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtConfirm.Location = New Point(463, 236)
        txtConfirm.Name = "txtConfirm"
        txtConfirm.Size = New Size(151, 23)
        txtConfirm.TabIndex = 37
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Maroon
        Panel3.Location = New Point(300, 297)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(686, 23)
        Panel3.TabIndex = 39
        ' 
        ' Employee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1004, 603)
        Controls.Add(Panel3)
        Controls.Add(txtConfirm)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(txtPassword)
        Controls.Add(txtUser)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(txtEmail)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        Controls.Add(dgvEmployee)
        Controls.Add(dtpDOB)
        Controls.Add(rdbFemale)
        Controls.Add(rdbMale)
        Controls.Add(txtNIC)
        Controls.Add(txtContact)
        Controls.Add(txtAddress)
        Controls.Add(txtFull)
        Controls.Add(txtEmNo)
        Controls.Add(lblDOB)
        Controls.Add(lblNIC)
        Controls.Add(lblContact)
        Controls.Add(lblAddress)
        Controls.Add(lblGender)
        Controls.Add(Label4)
        Controls.Add(lblFull)
        Controls.Add(lblEmNo)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Employee"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvEmployee, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblEmployee As Label
    Friend WithEvents lblEmNo As Label
    Friend WithEvents lblFull As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblNIC As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents txtEmNo As TextBox
    Friend WithEvents txtFull As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtNIC As TextBox
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents dgvEmployee As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblExit As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHome As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Colum5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblMin As Label
End Class
