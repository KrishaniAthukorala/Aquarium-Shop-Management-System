<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Inventory))
        Panel1 = New Panel()
        lblMin = New Label()
        lblHome = New Label()
        lblExit = New Label()
        lblInventory = New Label()
        lblCategory = New Label()
        cmbCategory = New ComboBox()
        lblSCCode = New Label()
        lblQuantity = New Label()
        txtColour = New TextBox()
        txtSize = New TextBox()
        lblColour = New Label()
        lblUPrice = New Label()
        txtQuantity = New TextBox()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnClear = New Button()
        btnSave = New Button()
        txtSearch = New TextBox()
        lblSearch = New Label()
        dgvInventory = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        lblSize = New Label()
        txtUPrice = New TextBox()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        txtCode = New TextBox()
        lblSubCat = New Label()
        txtSubCat = New TextBox()
        cmbSupNo = New ComboBox()
        lblSupNo = New Label()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        CType(dgvInventory, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Controls.Add(lblInventory)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1007, 44)
        Panel1.TabIndex = 3
        ' 
        ' lblMin
        ' 
        lblMin.AutoSize = True
        lblMin.Font = New Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblMin.Location = New Point(944, 2)
        lblMin.Name = "lblMin"
        lblMin.Size = New Size(25, 32)
        lblMin.TabIndex = 117
        lblMin.Text = "-"
        ' 
        ' lblHome
        ' 
        lblHome.AutoSize = True
        lblHome.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblHome.Location = New Point(894, 12)
        lblHome.Name = "lblHome"
        lblHome.Size = New Size(44, 16)
        lblHome.TabIndex = 116
        lblHome.Text = "Home"
        ' 
        ' lblExit
        ' 
        lblExit.AutoSize = True
        lblExit.BackColor = Color.Maroon
        lblExit.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblExit.ForeColor = Color.Transparent
        lblExit.Location = New Point(975, 12)
        lblExit.Name = "lblExit"
        lblExit.Size = New Size(20, 19)
        lblExit.TabIndex = 29
        lblExit.Text = "X"
        ' 
        ' lblInventory
        ' 
        lblInventory.AutoSize = True
        lblInventory.Font = New Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point)
        lblInventory.Location = New Point(12, 9)
        lblInventory.Name = "lblInventory"
        lblInventory.Size = New Size(171, 23)
        lblInventory.TabIndex = 0
        lblInventory.Text = "Inventory details"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblCategory.Location = New Point(292, 72)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(69, 17)
        lblCategory.TabIndex = 76
        lblCategory.Text = "Category"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.BackColor = Color.White
        cmbCategory.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Equipment", "Fish", "Food", "Medicine", "Plant"})
        cmbCategory.Location = New Point(439, 67)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(151, 25)
        cmbCategory.TabIndex = 78
        ' 
        ' lblSCCode
        ' 
        lblSCCode.AutoSize = True
        lblSCCode.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblSCCode.Location = New Point(292, 155)
        lblSCCode.Name = "lblSCCode"
        lblSCCode.Size = New Size(45, 17)
        lblSCCode.TabIndex = 79
        lblSCCode.Text = "Code"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblQuantity.Location = New Point(695, 113)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(63, 17)
        lblQuantity.TabIndex = 81
        lblQuantity.Text = "Quantity"
        ' 
        ' txtColour
        ' 
        txtColour.BackColor = Color.White
        txtColour.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtColour.Location = New Point(439, 194)
        txtColour.Name = "txtColour"
        txtColour.Size = New Size(151, 23)
        txtColour.TabIndex = 82
        ' 
        ' txtSize
        ' 
        txtSize.BackColor = Color.White
        txtSize.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtSize.Location = New Point(826, 67)
        txtSize.Name = "txtSize"
        txtSize.Size = New Size(151, 23)
        txtSize.TabIndex = 83
        ' 
        ' lblColour
        ' 
        lblColour.AutoSize = True
        lblColour.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblColour.Location = New Point(292, 197)
        lblColour.Name = "lblColour"
        lblColour.Size = New Size(52, 17)
        lblColour.TabIndex = 84
        lblColour.Text = "Colour"
        ' 
        ' lblUPrice
        ' 
        lblUPrice.AutoSize = True
        lblUPrice.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblUPrice.Location = New Point(695, 155)
        lblUPrice.Name = "lblUPrice"
        lblUPrice.Size = New Size(68, 17)
        lblUPrice.TabIndex = 87
        lblUPrice.Text = "Unit price"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.BackColor = Color.White
        txtQuantity.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtQuantity.Location = New Point(826, 108)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(151, 23)
        txtQuantity.TabIndex = 88
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Maroon
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(138, 290)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 23)
        btnDelete.TabIndex = 94
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Maroon
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(138, 245)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 23)
        btnUpdate.TabIndex = 93
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Maroon
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(27, 290)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 23)
        btnClear.TabIndex = 92
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Maroon
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(27, 245)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 23)
        btnSave.TabIndex = 91
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.White
        txtSearch.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtSearch.Location = New Point(464, 278)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(151, 23)
        txtSearch.TabIndex = 112
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblSearch.Location = New Point(292, 281)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(51, 17)
        lblSearch.TabIndex = 111
        lblSearch.Text = "Search"
        ' 
        ' dgvInventory
        ' 
        dgvInventory.BackgroundColor = Color.White
        dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInventory.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column5, Column6, Column7, Column8, Column9, Column4})
        dgvInventory.Location = New Point(292, 322)
        dgvInventory.Name = "dgvInventory"
        dgvInventory.RowTemplate.Height = 25
        dgvInventory.Size = New Size(685, 191)
        dgvInventory.TabIndex = 113
        ' 
        ' Column1
        ' 
        DataGridViewCellStyle1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Column1.DefaultCellStyle = DataGridViewCellStyle1
        Column1.HeaderText = "Category"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Column2.DefaultCellStyle = DataGridViewCellStyle2
        Column2.HeaderText = "Sub category"
        Column2.Name = "Column2"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Code"
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Colour"
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Size"
        Column7.Name = "Column7"
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Quantity"
        Column8.Name = "Column8"
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Unit price"
        Column9.Name = "Column9"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Supplier No"
        Column4.Name = "Column4"
        ' 
        ' lblSize
        ' 
        lblSize.AutoSize = True
        lblSize.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblSize.Location = New Point(695, 70)
        lblSize.Name = "lblSize"
        lblSize.Size = New Size(31, 17)
        lblSize.TabIndex = 114
        lblSize.Text = "Size"
        ' 
        ' txtUPrice
        ' 
        txtUPrice.BackColor = Color.White
        txtUPrice.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtUPrice.Location = New Point(826, 150)
        txtUPrice.Name = "txtUPrice"
        txtUPrice.Size = New Size(151, 23)
        txtUPrice.TabIndex = 115
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
        Panel2.Size = New Size(263, 494)
        Panel2.TabIndex = 116
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(27, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(205, 194)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txtCode
        ' 
        txtCode.BackColor = Color.White
        txtCode.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtCode.Location = New Point(439, 152)
        txtCode.Name = "txtCode"
        txtCode.Size = New Size(151, 23)
        txtCode.TabIndex = 117
        ' 
        ' lblSubCat
        ' 
        lblSubCat.AutoSize = True
        lblSubCat.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblSubCat.Location = New Point(292, 113)
        lblSubCat.Name = "lblSubCat"
        lblSubCat.Size = New Size(97, 17)
        lblSubCat.TabIndex = 77
        lblSubCat.Text = "Sub category "
        ' 
        ' txtSubCat
        ' 
        txtSubCat.BackColor = Color.White
        txtSubCat.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtSubCat.Location = New Point(439, 111)
        txtSubCat.Name = "txtSubCat"
        txtSubCat.Size = New Size(151, 23)
        txtSubCat.TabIndex = 118
        ' 
        ' cmbSupNo
        ' 
        cmbSupNo.BackColor = Color.White
        cmbSupNo.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmbSupNo.FormattingEnabled = True
        cmbSupNo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"})
        cmbSupNo.Location = New Point(826, 192)
        cmbSupNo.Name = "cmbSupNo"
        cmbSupNo.Size = New Size(151, 25)
        cmbSupNo.TabIndex = 124
        ' 
        ' lblSupNo
        ' 
        lblSupNo.AutoSize = True
        lblSupNo.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblSupNo.Location = New Point(695, 197)
        lblSupNo.Name = "lblSupNo"
        lblSupNo.Size = New Size(81, 17)
        lblSupNo.TabIndex = 123
        lblSupNo.Text = "Supplier No"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Maroon
        Panel3.Location = New Point(292, 235)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(685, 23)
        Panel3.TabIndex = 125
        ' 
        ' Inventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1007, 538)
        Controls.Add(Panel3)
        Controls.Add(cmbSupNo)
        Controls.Add(lblSupNo)
        Controls.Add(txtSubCat)
        Controls.Add(txtCode)
        Controls.Add(Panel2)
        Controls.Add(txtUPrice)
        Controls.Add(lblSize)
        Controls.Add(dgvInventory)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        Controls.Add(txtQuantity)
        Controls.Add(lblUPrice)
        Controls.Add(lblColour)
        Controls.Add(txtSize)
        Controls.Add(txtColour)
        Controls.Add(lblQuantity)
        Controls.Add(lblSCCode)
        Controls.Add(cmbCategory)
        Controls.Add(lblSubCat)
        Controls.Add(lblCategory)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Inventory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvInventory, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblExit As Label
    Friend WithEvents lblInventory As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents lblSCCode As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtColour As TextBox
    Friend WithEvents txtSize As TextBox
    Friend WithEvents lblColour As Label
    Friend WithEvents lblUPrice As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents lblSize As Label
    Friend WithEvents txtUPrice As TextBox
    Friend WithEvents lblHome As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents lblSubCat As Label
    Friend WithEvents txtSubCat As TextBox
    Friend WithEvents cmbSupNo As ComboBox
    Friend WithEvents lblSupNo As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblMin As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
