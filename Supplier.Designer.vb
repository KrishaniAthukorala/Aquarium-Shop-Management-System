<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Supplier))
        Panel1 = New Panel()
        lblHome = New Label()
        lblExit = New Label()
        lblSupplier = New Label()
        txtSearch = New TextBox()
        lblSearch = New Label()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnClear = New Button()
        btnSave = New Button()
        dgvSupplier = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        rdbFemale = New RadioButton()
        rdbMale = New RadioButton()
        txtNIC = New TextBox()
        txtContact = New TextBox()
        txtAddress = New TextBox()
        txtFull = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        lblFull = New Label()
        Label2 = New Label()
        lblSupNo = New Label()
        lblGender = New Label()
        lblAddress = New Label()
        lblContact = New Label()
        lblNIC = New Label()
        lblInventory = New Label()
        cmbInventory = New ComboBox()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        txtSupNo = New TextBox()
        Panel3 = New Panel()
        lblMin = New Label()
        Panel1.SuspendLayout()
        CType(dgvSupplier, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Controls.Add(lblSupplier)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1053, 44)
        Panel1.TabIndex = 1
        ' 
        ' lblHome
        ' 
        lblHome.AutoSize = True
        lblHome.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblHome.Location = New Point(936, 12)
        lblHome.Name = "lblHome"
        lblHome.Size = New Size(44, 16)
        lblHome.TabIndex = 57
        lblHome.Text = "Home"
        ' 
        ' lblExit
        ' 
        lblExit.AutoSize = True
        lblExit.BackColor = Color.Maroon
        lblExit.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblExit.ForeColor = Color.Transparent
        lblExit.Location = New Point(1017, 12)
        lblExit.Name = "lblExit"
        lblExit.Size = New Size(20, 19)
        lblExit.TabIndex = 29
        lblExit.Text = "X"
        ' 
        ' lblSupplier
        ' 
        lblSupplier.AutoSize = True
        lblSupplier.Font = New Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point)
        lblSupplier.Location = New Point(12, 9)
        lblSupplier.Name = "lblSupplier"
        lblSupplier.Size = New Size(157, 23)
        lblSupplier.TabIndex = 0
        lblSupplier.Text = "Supplier details"
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.White
        txtSearch.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearch.Location = New Point(375, 263)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(151, 23)
        txtSearch.TabIndex = 51
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblSearch.Location = New Point(294, 266)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(51, 17)
        lblSearch.TabIndex = 50
        lblSearch.Text = "Search"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Maroon
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(136, 293)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 23)
        btnDelete.TabIndex = 49
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Maroon
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(136, 252)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 23)
        btnUpdate.TabIndex = 48
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Maroon
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(22, 293)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 23)
        btnClear.TabIndex = 47
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Maroon
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(22, 252)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 23)
        btnSave.TabIndex = 46
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' dgvSupplier
        ' 
        dgvSupplier.BackgroundColor = Color.White
        dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSupplier.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        dgvSupplier.Location = New Point(286, 305)
        dgvSupplier.Name = "dgvSupplier"
        dgvSupplier.RowTemplate.Height = 25
        dgvSupplier.Size = New Size(742, 221)
        dgvSupplier.TabIndex = 45
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Supplier No"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Full name"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Gender"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Address"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Contact No"
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "NIC"
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Inventory item"
        Column7.Name = "Column7"
        ' 
        ' rdbFemale
        ' 
        rdbFemale.AutoSize = True
        rdbFemale.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        rdbFemale.Location = New Point(579, 155)
        rdbFemale.Name = "rdbFemale"
        rdbFemale.Size = New Size(73, 21)
        rdbFemale.TabIndex = 43
        rdbFemale.TabStop = True
        rdbFemale.Text = "Female"
        rdbFemale.UseVisualStyleBackColor = True
        ' 
        ' rdbMale
        ' 
        rdbMale.AutoSize = True
        rdbMale.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        rdbMale.Location = New Point(501, 155)
        rdbMale.Name = "rdbMale"
        rdbMale.Size = New Size(57, 21)
        rdbMale.TabIndex = 42
        rdbMale.TabStop = True
        rdbMale.Text = "Male"
        rdbMale.UseVisualStyleBackColor = True
        ' 
        ' txtNIC
        ' 
        txtNIC.BackColor = Color.White
        txtNIC.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtNIC.Location = New Point(877, 112)
        txtNIC.Name = "txtNIC"
        txtNIC.Size = New Size(151, 23)
        txtNIC.TabIndex = 41
        ' 
        ' txtContact
        ' 
        txtContact.BackColor = Color.White
        txtContact.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtContact.Location = New Point(877, 73)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(151, 23)
        txtContact.TabIndex = 40
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.White
        txtAddress.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtAddress.Location = New Point(501, 186)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(151, 23)
        txtAddress.TabIndex = 39
        ' 
        ' txtFull
        ' 
        txtFull.BackColor = Color.White
        txtFull.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtFull.Location = New Point(501, 115)
        txtFull.Name = "txtFull"
        txtFull.Size = New Size(151, 23)
        txtFull.TabIndex = 38
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(-140, 333)
        Label10.Name = "Label10"
        Label10.Size = New Size(90, 17)
        Label10.TabIndex = 36
        Label10.Text = "Date of birth"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(-140, 290)
        Label9.Name = "Label9"
        Label9.Size = New Size(32, 17)
        Label9.TabIndex = 35
        Label9.Text = "NIC"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(-141, 255)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 17)
        Label8.TabIndex = 34
        Label8.Text = "Contact No."
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(-141, 215)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 17)
        Label7.TabIndex = 33
        Label7.Text = "Address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(-140, 180)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 17)
        Label6.TabIndex = 32
        Label6.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(-140, 180)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 17)
        Label4.TabIndex = 31
        ' 
        ' lblFull
        ' 
        lblFull.AutoSize = True
        lblFull.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblFull.Location = New Point(294, 118)
        lblFull.Name = "lblFull"
        lblFull.Size = New Size(148, 17)
        lblFull.TabIndex = 30
        lblFull.Text = "Full name with initialls"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(-140, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 17)
        Label2.TabIndex = 29
        Label2.Text = "Employee No."
        ' 
        ' lblSupNo
        ' 
        lblSupNo.AutoSize = True
        lblSupNo.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblSupNo.Location = New Point(294, 79)
        lblSupNo.Name = "lblSupNo"
        lblSupNo.Size = New Size(81, 17)
        lblSupNo.TabIndex = 52
        lblSupNo.Text = "Supplier No"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblGender.Location = New Point(294, 155)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(56, 17)
        lblGender.TabIndex = 53
        lblGender.Text = "Gender"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblAddress.Location = New Point(294, 189)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(57, 17)
        lblAddress.TabIndex = 54
        lblAddress.Text = "Address"
        ' 
        ' lblContact
        ' 
        lblContact.AutoSize = True
        lblContact.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblContact.Location = New Point(689, 76)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(86, 17)
        lblContact.TabIndex = 55
        lblContact.Text = "Contact No"
        ' 
        ' lblNIC
        ' 
        lblNIC.AutoSize = True
        lblNIC.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblNIC.Location = New Point(689, 115)
        lblNIC.Name = "lblNIC"
        lblNIC.Size = New Size(32, 17)
        lblNIC.TabIndex = 56
        lblNIC.Text = "NIC"
        ' 
        ' lblInventory
        ' 
        lblInventory.AutoSize = True
        lblInventory.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblInventory.Location = New Point(688, 154)
        lblInventory.Name = "lblInventory"
        lblInventory.Size = New Size(100, 17)
        lblInventory.TabIndex = 58
        lblInventory.Text = "Inventory item"
        ' 
        ' cmbInventory
        ' 
        cmbInventory.BackColor = Color.White
        cmbInventory.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmbInventory.FormattingEnabled = True
        cmbInventory.Items.AddRange(New Object() {"Equipment", "Fish", "Food", "Medicine", "Plant"})
        cmbInventory.Location = New Point(877, 151)
        cmbInventory.Name = "cmbInventory"
        cmbInventory.Size = New Size(151, 25)
        cmbInventory.TabIndex = 111
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.PapayaWhip
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(btnSave)
        Panel2.Controls.Add(btnUpdate)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(btnDelete)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 44)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(263, 505)
        Panel2.TabIndex = 112
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(22, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(208, 206)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 50
        PictureBox1.TabStop = False
        ' 
        ' txtSupNo
        ' 
        txtSupNo.BackColor = Color.White
        txtSupNo.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtSupNo.Location = New Point(501, 73)
        txtSupNo.Name = "txtSupNo"
        txtSupNo.Size = New Size(151, 23)
        txtSupNo.TabIndex = 114
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Maroon
        Panel3.Location = New Point(294, 224)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(734, 23)
        Panel3.TabIndex = 116
        ' 
        ' lblMin
        ' 
        lblMin.AutoSize = True
        lblMin.Font = New Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblMin.Location = New Point(986, 2)
        lblMin.Name = "lblMin"
        lblMin.Size = New Size(25, 32)
        lblMin.TabIndex = 58
        lblMin.Text = "-"
        ' 
        ' Supplier
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1053, 549)
        Controls.Add(Panel3)
        Controls.Add(txtSupNo)
        Controls.Add(Panel2)
        Controls.Add(cmbInventory)
        Controls.Add(lblInventory)
        Controls.Add(lblNIC)
        Controls.Add(lblContact)
        Controls.Add(lblAddress)
        Controls.Add(lblGender)
        Controls.Add(lblSupNo)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        Controls.Add(dgvSupplier)
        Controls.Add(rdbFemale)
        Controls.Add(rdbMale)
        Controls.Add(txtNIC)
        Controls.Add(txtContact)
        Controls.Add(txtAddress)
        Controls.Add(txtFull)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(lblFull)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Supplier"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Supplier"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvSupplier, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblExit As Label
    Friend WithEvents lblSupplier As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvSupplier As DataGridView
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents txtNIC As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtFull As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblFull As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSupNo As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblNIC As Label
    Friend WithEvents lblHome As Label
    Friend WithEvents lblInventory As Label
    Friend WithEvents cmbInventory As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSupNo As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblMin As Label
End Class
