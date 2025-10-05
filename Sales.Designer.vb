<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Sales))
        Panel1 = New Panel()
        lblMin = New Label()
        labelExit = New Label()
        lblHome = New Label()
        lblBack = New Label()
        lblExit = New Label()
        lblSales = New Label()
        Panel2 = New Panel()
        btnClear = New Button()
        btnDelete = New Button()
        PictureBox1 = New PictureBox()
        btnSave = New Button()
        btnPrint = New Button()
        lblRecNo = New Label()
        lblCashier = New Label()
        lblDate = New Label()
        txtRecNo = New TextBox()
        cmbCashier = New ComboBox()
        dtpDate = New DateTimePicker()
        dgvSales = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Document = New Printing.PrintDocument()
        Dialog = New PrintPreviewDialog()
        btnCalculate = New Button()
        txtCalculate = New TextBox()
        lblPayment = New Label()
        txtPayment = New TextBox()
        btnBalance = New Button()
        txtBalance = New TextBox()
        barcode = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvSales, ComponentModel.ISupportInitialize).BeginInit()
        CType(barcode, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Maroon
        Panel1.Controls.Add(lblMin)
        Panel1.Controls.Add(labelExit)
        Panel1.Controls.Add(lblHome)
        Panel1.Controls.Add(lblBack)
        Panel1.Controls.Add(lblExit)
        Panel1.Controls.Add(lblSales)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(676, 44)
        Panel1.TabIndex = 1
        ' 
        ' lblMin
        ' 
        lblMin.AutoSize = True
        lblMin.Font = New Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblMin.Location = New Point(617, 2)
        lblMin.Name = "lblMin"
        lblMin.Size = New Size(25, 32)
        lblMin.TabIndex = 120
        lblMin.Text = "-"
        ' 
        ' labelExit
        ' 
        labelExit.AutoSize = True
        labelExit.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        labelExit.Location = New Point(648, 15)
        labelExit.Name = "labelExit"
        labelExit.Size = New Size(16, 16)
        labelExit.TabIndex = 119
        labelExit.Text = "X"
        ' 
        ' lblHome
        ' 
        lblHome.AutoSize = True
        lblHome.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblHome.Location = New Point(567, 15)
        lblHome.Name = "lblHome"
        lblHome.Size = New Size(44, 16)
        lblHome.TabIndex = 118
        lblHome.Text = "Home"
        ' 
        ' lblBack
        ' 
        lblBack.AutoSize = True
        lblBack.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblBack.Location = New Point(912, 15)
        lblBack.Name = "lblBack"
        lblBack.Size = New Size(40, 16)
        lblBack.TabIndex = 31
        lblBack.Text = "Back"
        ' 
        ' lblExit
        ' 
        lblExit.AutoSize = True
        lblExit.BackColor = Color.Maroon
        lblExit.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblExit.ForeColor = Color.Transparent
        lblExit.Location = New Point(965, 13)
        lblExit.Name = "lblExit"
        lblExit.Size = New Size(20, 19)
        lblExit.TabIndex = 29
        lblExit.Text = "X"
        ' 
        ' lblSales
        ' 
        lblSales.AutoSize = True
        lblSales.Font = New Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point)
        lblSales.Location = New Point(12, 9)
        lblSales.Name = "lblSales"
        lblSales.Size = New Size(130, 23)
        lblSales.TabIndex = 0
        lblSales.Text = "Sales details"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.PapayaWhip
        Panel2.Controls.Add(barcode)
        Panel2.Controls.Add(btnClear)
        Panel2.Controls.Add(btnDelete)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(btnSave)
        Panel2.Controls.Add(btnPrint)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 44)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(263, 481)
        Panel2.TabIndex = 117
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Maroon
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(27, 285)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 23)
        btnClear.TabIndex = 96
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Maroon
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(138, 285)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 23)
        btnDelete.TabIndex = 95
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
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
        ' btnSave
        ' 
        btnSave.BackColor = Color.Maroon
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(27, 243)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 23)
        btnSave.TabIndex = 91
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.Maroon
        btnPrint.FlatStyle = FlatStyle.Popup
        btnPrint.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(138, 243)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(94, 23)
        btnPrint.TabIndex = 93
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' lblRecNo
        ' 
        lblRecNo.AutoSize = True
        lblRecNo.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRecNo.Location = New Point(296, 71)
        lblRecNo.Name = "lblRecNo"
        lblRecNo.Size = New Size(84, 17)
        lblRecNo.TabIndex = 118
        lblRecNo.Text = "Receipt No."
        ' 
        ' lblCashier
        ' 
        lblCashier.AutoSize = True
        lblCashier.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblCashier.Location = New Point(296, 115)
        lblCashier.Name = "lblCashier"
        lblCashier.Size = New Size(56, 17)
        lblCashier.TabIndex = 119
        lblCashier.Text = "Cashier"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblDate.Location = New Point(296, 163)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(40, 17)
        lblDate.TabIndex = 120
        lblDate.Text = "Date"
        ' 
        ' txtRecNo
        ' 
        txtRecNo.BackColor = Color.White
        txtRecNo.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtRecNo.Location = New Point(396, 68)
        txtRecNo.Name = "txtRecNo"
        txtRecNo.Size = New Size(151, 23)
        txtRecNo.TabIndex = 121
        ' 
        ' cmbCashier
        ' 
        cmbCashier.BackColor = Color.White
        cmbCashier.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmbCashier.FormattingEnabled = True
        cmbCashier.Items.AddRange(New Object() {"Athukorala K.M.", "L.V.S. Sandeepa", "D.L. Rajasinghe", "D.S. Danthanarayana", "T.G.K. Serasinghe", "W.G. Wickramaarachchi", "A.N. De Silva", "K.S. Rajakaruna", "R.H.V. Hettige", "R.D.S. Kobbagala", "L.O. Bendarage", "U.B.T. Perera", "A.M.G. Adathsuriya"})
        cmbCashier.Location = New Point(396, 112)
        cmbCashier.Name = "cmbCashier"
        cmbCashier.Size = New Size(151, 25)
        cmbCashier.TabIndex = 122
        ' 
        ' dtpDate
        ' 
        dtpDate.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        dtpDate.Location = New Point(396, 158)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(200, 23)
        dtpDate.TabIndex = 123
        ' 
        ' dgvSales
        ' 
        dgvSales.BackgroundColor = Color.White
        dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSales.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        dgvSales.Location = New Point(296, 202)
        dgvSales.Name = "dgvSales"
        dgvSales.RowTemplate.Height = 25
        dgvSales.Size = New Size(344, 150)
        dgvSales.TabIndex = 124
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Code"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Quantity"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Unit price"
        Column3.Name = "Column3"
        ' 
        ' Document
        ' 
        ' 
        ' Dialog
        ' 
        Dialog.AutoScrollMargin = New Size(0, 0)
        Dialog.AutoScrollMinSize = New Size(0, 0)
        Dialog.ClientSize = New Size(400, 300)
        Dialog.Enabled = True
        Dialog.Icon = CType(resources.GetObject("Dialog.Icon"), Icon)
        Dialog.Name = "PPD"
        Dialog.Visible = False
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.Maroon
        btnCalculate.FlatStyle = FlatStyle.Popup
        btnCalculate.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnCalculate.ForeColor = Color.White
        btnCalculate.Location = New Point(296, 376)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(128, 23)
        btnCalculate.TabIndex = 125
        btnCalculate.Text = "Calculate Total"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' txtCalculate
        ' 
        txtCalculate.BackColor = Color.White
        txtCalculate.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtCalculate.Location = New Point(445, 376)
        txtCalculate.Name = "txtCalculate"
        txtCalculate.Size = New Size(151, 23)
        txtCalculate.TabIndex = 126
        ' 
        ' lblPayment
        ' 
        lblPayment.AutoSize = True
        lblPayment.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPayment.Location = New Point(296, 426)
        lblPayment.Name = "lblPayment"
        lblPayment.Size = New Size(65, 17)
        lblPayment.TabIndex = 127
        lblPayment.Text = "Payment"
        ' 
        ' txtPayment
        ' 
        txtPayment.BackColor = Color.White
        txtPayment.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtPayment.Location = New Point(445, 420)
        txtPayment.Name = "txtPayment"
        txtPayment.Size = New Size(151, 23)
        txtPayment.TabIndex = 128
        ' 
        ' btnBalance
        ' 
        btnBalance.BackColor = Color.Maroon
        btnBalance.FlatStyle = FlatStyle.Popup
        btnBalance.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnBalance.ForeColor = Color.White
        btnBalance.Location = New Point(296, 468)
        btnBalance.Name = "btnBalance"
        btnBalance.Size = New Size(94, 23)
        btnBalance.TabIndex = 129
        btnBalance.Text = "Balance"
        btnBalance.UseVisualStyleBackColor = False
        ' 
        ' txtBalance
        ' 
        txtBalance.BackColor = Color.White
        txtBalance.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtBalance.Location = New Point(445, 468)
        txtBalance.Name = "txtBalance"
        txtBalance.Size = New Size(151, 23)
        txtBalance.TabIndex = 130
        ' 
        ' barcode
        ' 
        barcode.Image = CType(resources.GetObject("barcode.Image"), Image)
        barcode.Location = New Point(64, 361)
        barcode.Name = "barcode"
        barcode.Size = New Size(134, 60)
        barcode.SizeMode = PictureBoxSizeMode.Zoom
        barcode.TabIndex = 125
        barcode.TabStop = False
        ' 
        ' Sales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(676, 525)
        Controls.Add(txtBalance)
        Controls.Add(btnBalance)
        Controls.Add(txtPayment)
        Controls.Add(lblPayment)
        Controls.Add(txtCalculate)
        Controls.Add(btnCalculate)
        Controls.Add(dgvSales)
        Controls.Add(dtpDate)
        Controls.Add(cmbCashier)
        Controls.Add(txtRecNo)
        Controls.Add(lblDate)
        Controls.Add(lblCashier)
        Controls.Add(lblRecNo)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Sales"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sales"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvSales, ComponentModel.ISupportInitialize).EndInit()
        CType(barcode, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblBack As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents lblSales As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents labelExit As Label
    Friend WithEvents lblHome As Label
    Friend WithEvents lblRecNo As Label
    Friend WithEvents lblCashier As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtRecNo As TextBox
    Friend WithEvents cmbCashier As ComboBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents dgvSales As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Doc As Printing.PrintDocument
    Friend WithEvents PPD As PrintPreviewDialog
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtCalculate As TextBox
    Friend WithEvents lblPayment As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents btnBalance As Button
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents lblMin As Label
    Friend WithEvents barcode As PictureBox
End Class
