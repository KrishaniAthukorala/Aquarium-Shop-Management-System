<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Customer))
        Panel1 = New Panel()
        lblHome = New Label()
        lblExit = New Label()
        lblCustomer = New Label()
        lblContact = New Label()
        lblAddress = New Label()
        lblGender = New Label()
        lblCusNo = New Label()
        txtSearch = New TextBox()
        lblSearch = New Label()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnClear = New Button()
        btnSave = New Button()
        dgvCustomer = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        rdbFemale = New RadioButton()
        rdbMale = New RadioButton()
        txtContact = New TextBox()
        txtAddress = New TextBox()
        txtFull = New TextBox()
        txtCusNo = New TextBox()
        lblFull = New Label()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        lblMin = New Label()
        Panel1.SuspendLayout()
        CType(dgvCustomer, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Controls.Add(lblCustomer)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(903, 44)
        Panel1.TabIndex = 2
        ' 
        ' lblHome
        ' 
        lblHome.AutoSize = True
        lblHome.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblHome.Location = New Point(790, 12)
        lblHome.Name = "lblHome"
        lblHome.Size = New Size(44, 16)
        lblHome.TabIndex = 32
        lblHome.Text = "Home"
        ' 
        ' lblExit
        ' 
        lblExit.AutoSize = True
        lblExit.BackColor = Color.Maroon
        lblExit.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblExit.ForeColor = Color.Transparent
        lblExit.Location = New Point(871, 12)
        lblExit.Name = "lblExit"
        lblExit.Size = New Size(20, 19)
        lblExit.TabIndex = 29
        lblExit.Text = "X"
        ' 
        ' lblCustomer
        ' 
        lblCustomer.AutoSize = True
        lblCustomer.Font = New Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point)
        lblCustomer.Location = New Point(12, 9)
        lblCustomer.Name = "lblCustomer"
        lblCustomer.Size = New Size(174, 23)
        lblCustomer.TabIndex = 0
        lblCustomer.Text = "Customer details"
        ' 
        ' lblContact
        ' 
        lblContact.AutoSize = True
        lblContact.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblContact.Location = New Point(625, 116)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(86, 17)
        lblContact.TabIndex = 75
        lblContact.Text = "Contact No"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblAddress.Location = New Point(625, 71)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(57, 17)
        lblAddress.TabIndex = 74
        lblAddress.Text = "Address"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblGender.Location = New Point(292, 157)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(56, 17)
        lblGender.TabIndex = 73
        lblGender.Text = "Gender"
        ' 
        ' lblCusNo
        ' 
        lblCusNo.AutoSize = True
        lblCusNo.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblCusNo.Location = New Point(292, 74)
        lblCusNo.Name = "lblCusNo"
        lblCusNo.Size = New Size(94, 17)
        lblCusNo.TabIndex = 72
        lblCusNo.Text = "Customer No"
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.White
        txtSearch.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearch.Location = New Point(371, 235)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(151, 23)
        txtSearch.TabIndex = 71
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblSearch.Location = New Point(292, 238)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(51, 17)
        lblSearch.TabIndex = 70
        lblSearch.Text = "Search"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Maroon
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(136, 307)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 23)
        btnDelete.TabIndex = 69
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Maroon
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(136, 263)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 23)
        btnUpdate.TabIndex = 68
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Maroon
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(30, 307)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 23)
        btnClear.TabIndex = 67
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Maroon
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(30, 263)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 23)
        btnSave.TabIndex = 66
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' dgvCustomer
        ' 
        dgvCustomer.BackgroundColor = Color.White
        dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomer.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column5, Column6, Column7})
        dgvCustomer.Location = New Point(316, 277)
        dgvCustomer.Name = "dgvCustomer"
        dgvCustomer.RowTemplate.Height = 25
        dgvCustomer.Size = New Size(542, 150)
        dgvCustomer.TabIndex = 65
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Customer No"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Full name"
        Column2.Name = "Column2"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Gender"
        Column5.Name = "Column5"
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
        ' rdbFemale
        ' 
        rdbFemale.AutoSize = True
        rdbFemale.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        rdbFemale.Location = New Point(523, 155)
        rdbFemale.Name = "rdbFemale"
        rdbFemale.Size = New Size(73, 21)
        rdbFemale.TabIndex = 64
        rdbFemale.TabStop = True
        rdbFemale.Text = "Female"
        rdbFemale.UseVisualStyleBackColor = True
        ' 
        ' rdbMale
        ' 
        rdbMale.AutoSize = True
        rdbMale.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        rdbMale.Location = New Point(445, 155)
        rdbMale.Name = "rdbMale"
        rdbMale.Size = New Size(57, 21)
        rdbMale.TabIndex = 63
        rdbMale.TabStop = True
        rdbMale.Text = "Male"
        rdbMale.UseVisualStyleBackColor = True
        ' 
        ' txtContact
        ' 
        txtContact.BackColor = Color.White
        txtContact.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtContact.Location = New Point(728, 113)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(151, 23)
        txtContact.TabIndex = 61
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.White
        txtAddress.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtAddress.Location = New Point(728, 71)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(151, 23)
        txtAddress.TabIndex = 60
        ' 
        ' txtFull
        ' 
        txtFull.BackColor = Color.White
        txtFull.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtFull.Location = New Point(445, 113)
        txtFull.Name = "txtFull"
        txtFull.Size = New Size(151, 23)
        txtFull.TabIndex = 59
        ' 
        ' txtCusNo
        ' 
        txtCusNo.BackColor = Color.White
        txtCusNo.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtCusNo.Location = New Point(445, 71)
        txtCusNo.Name = "txtCusNo"
        txtCusNo.Size = New Size(151, 23)
        txtCusNo.TabIndex = 58
        ' 
        ' lblFull
        ' 
        lblFull.AutoSize = True
        lblFull.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblFull.Location = New Point(292, 116)
        lblFull.Name = "lblFull"
        lblFull.Size = New Size(148, 17)
        lblFull.TabIndex = 57
        lblFull.Text = "Full name with initialls"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.PapayaWhip
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(btnSave)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(btnDelete)
        Panel2.Controls.Add(btnUpdate)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 44)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(263, 408)
        Panel2.TabIndex = 76
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(30, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 200)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Maroon
        Panel3.Location = New Point(292, 194)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(587, 23)
        Panel3.TabIndex = 115
        ' 
        ' lblMin
        ' 
        lblMin.AutoSize = True
        lblMin.Font = New Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblMin.Location = New Point(840, 2)
        lblMin.Name = "lblMin"
        lblMin.Size = New Size(25, 32)
        lblMin.TabIndex = 33
        lblMin.Text = "-"
        ' 
        ' Customer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(903, 452)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(lblContact)
        Controls.Add(lblAddress)
        Controls.Add(lblGender)
        Controls.Add(lblCusNo)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        Controls.Add(dgvCustomer)
        Controls.Add(rdbFemale)
        Controls.Add(rdbMale)
        Controls.Add(txtContact)
        Controls.Add(txtAddress)
        Controls.Add(txtFull)
        Controls.Add(txtCusNo)
        Controls.Add(lblFull)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Customer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Customer"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvCustomer, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblExit As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblCusNo As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvCustomer As DataGridView
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtFull As TextBox
    Friend WithEvents txtCusNo As TextBox
    Friend WithEvents lblFull As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHome As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblMin As Label
End Class
