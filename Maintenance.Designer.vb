<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maintenance
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Maintenance))
        Panel1 = New Panel()
        lblMin = New Label()
        lblHome = New Label()
        lblExit = New Label()
        lblMain = New Label()
        lblDate = New Label()
        dtpDate = New DateTimePicker()
        lblTank = New Label()
        cmbTank = New ComboBox()
        lblType = New Label()
        cmbType = New ComboBox()
        lblQuality = New Label()
        txtTem = New TextBox()
        txtPH = New TextBox()
        lblBehavior = New Label()
        rdb1 = New RadioButton()
        rdb2 = New RadioButton()
        rdb3 = New RadioButton()
        rdb4 = New RadioButton()
        rdb5 = New RadioButton()
        lblLazy = New Label()
        lblActive = New Label()
        lblCount = New Label()
        txtCount = New TextBox()
        txtAdded = New TextBox()
        lblAdded = New Label()
        txtLost = New TextBox()
        lblLost = New Label()
        lblCheck = New Label()
        lblHeater = New Label()
        lblLevel = New Label()
        lblLight = New Label()
        lblNet = New Label()
        lblTubing = New Label()
        lblPump = New Label()
        lblFilter = New Label()
        lblCon = New Label()
        chbFilter = New CheckBox()
        chbPump = New CheckBox()
        chbTubing = New CheckBox()
        chbNet = New CheckBox()
        chbLight = New CheckBox()
        chbLevel = New CheckBox()
        chbHeater = New CheckBox()
        chbCon = New CheckBox()
        txtFilter = New TextBox()
        Panel2 = New Panel()
        btnUpdate = New Button()
        btnClear = New Button()
        btnSave = New Button()
        txtPump = New TextBox()
        txtTubing = New TextBox()
        txtNet = New TextBox()
        txtLevel = New TextBox()
        txtLight = New TextBox()
        txtCon = New TextBox()
        txtHeater = New TextBox()
        Panel3 = New Panel()
        btnDelete = New Button()
        Panel4 = New Panel()
        PictureBox1 = New PictureBox()
        cmbCleaner = New ComboBox()
        lblCleaner = New Label()
        Panel5 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Maroon
        Panel1.Controls.Add(lblMin)
        Panel1.Controls.Add(lblHome)
        Panel1.Controls.Add(lblExit)
        Panel1.Controls.Add(lblMain)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1008, 44)
        Panel1.TabIndex = 4
        ' 
        ' lblMin
        ' 
        lblMin.AutoSize = True
        lblMin.Font = New Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblMin.Location = New Point(942, 2)
        lblMin.Name = "lblMin"
        lblMin.Size = New Size(25, 32)
        lblMin.TabIndex = 147
        lblMin.Text = "-"
        ' 
        ' lblHome
        ' 
        lblHome.AutoSize = True
        lblHome.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblHome.Location = New Point(892, 12)
        lblHome.Name = "lblHome"
        lblHome.Size = New Size(44, 16)
        lblHome.TabIndex = 146
        lblHome.Text = "Home"
        ' 
        ' lblExit
        ' 
        lblExit.AutoSize = True
        lblExit.BackColor = Color.Maroon
        lblExit.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblExit.ForeColor = Color.Transparent
        lblExit.Location = New Point(973, 12)
        lblExit.Name = "lblExit"
        lblExit.Size = New Size(20, 19)
        lblExit.TabIndex = 29
        lblExit.Text = "X"
        ' 
        ' lblMain
        ' 
        lblMain.AutoSize = True
        lblMain.Font = New Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point)
        lblMain.Location = New Point(12, 9)
        lblMain.Name = "lblMain"
        lblMain.Size = New Size(253, 23)
        lblMain.TabIndex = 0
        lblMain.Text = "Maintenance scheduling"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblDate.Location = New Point(300, 79)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(99, 17)
        lblDate.TabIndex = 78
        lblDate.Text = "Cleaned date"
        ' 
        ' dtpDate
        ' 
        dtpDate.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        dtpDate.Location = New Point(413, 73)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(200, 23)
        dtpDate.TabIndex = 79
        ' 
        ' lblTank
        ' 
        lblTank.AutoSize = True
        lblTank.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTank.Location = New Point(301, 158)
        lblTank.Name = "lblTank"
        lblTank.Size = New Size(37, 17)
        lblTank.TabIndex = 81
        lblTank.Text = "Tank"
        ' 
        ' cmbTank
        ' 
        cmbTank.FormattingEnabled = True
        cmbTank.Items.AddRange(New Object() {"S1", "S2", "S3", "S4", "S5", "S6", "S7", "M1", "M2", "M3", "M4", "M5", "M6", "M7", "M8", "M9", "M10", "L1", "L2", "L3", "L4", "L5", "L6", "L7", "L8"})
        cmbTank.Location = New Point(413, 156)
        cmbTank.Name = "cmbTank"
        cmbTank.Size = New Size(121, 23)
        cmbTank.TabIndex = 82
        ' 
        ' lblType
        ' 
        lblType.AutoSize = True
        lblType.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblType.Location = New Point(300, 198)
        lblType.Name = "lblType"
        lblType.Size = New Size(79, 17)
        lblType.TabIndex = 84
        lblType.Text = "Water type"
        ' 
        ' cmbType
        ' 
        cmbType.FormattingEnabled = True
        cmbType.Items.AddRange(New Object() {"Slightly acidic water", "Slightly Alkaline water", "Slightly acidic - neutral water", "Slightly alkaline - neutral water", "Slightly acidic - alkaline water"})
        cmbType.Location = New Point(413, 196)
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(121, 23)
        cmbType.TabIndex = 85
        ' 
        ' lblQuality
        ' 
        lblQuality.AutoSize = True
        lblQuality.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblQuality.Location = New Point(713, 193)
        lblQuality.Name = "lblQuality"
        lblQuality.Size = New Size(94, 17)
        lblQuality.TabIndex = 86
        lblQuality.Text = "Water quality"
        ' 
        ' txtTem
        ' 
        txtTem.BackColor = Color.White
        txtTem.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtTem.ForeColor = Color.Black
        txtTem.Location = New Point(826, 190)
        txtTem.Name = "txtTem"
        txtTem.PlaceholderText = "Temperature('C)"
        txtTem.Size = New Size(121, 23)
        txtTem.TabIndex = 89
        txtTem.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPH
        ' 
        txtPH.BackColor = Color.White
        txtPH.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtPH.ForeColor = Color.Black
        txtPH.Location = New Point(826, 229)
        txtPH.Name = "txtPH"
        txtPH.PlaceholderText = "PH level"
        txtPH.Size = New Size(77, 23)
        txtPH.TabIndex = 90
        txtPH.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblBehavior
        ' 
        lblBehavior.AutoSize = True
        lblBehavior.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblBehavior.Location = New Point(300, 252)
        lblBehavior.Name = "lblBehavior"
        lblBehavior.Size = New Size(100, 17)
        lblBehavior.TabIndex = 95
        lblBehavior.Text = "Fish behaviour"
        ' 
        ' rdb1
        ' 
        rdb1.AutoSize = True
        rdb1.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        rdb1.Location = New Point(12, 27)
        rdb1.Name = "rdb1"
        rdb1.Size = New Size(33, 21)
        rdb1.TabIndex = 96
        rdb1.TabStop = True
        rdb1.Text = "1"
        rdb1.TextAlign = ContentAlignment.TopCenter
        rdb1.UseVisualStyleBackColor = True
        ' 
        ' rdb2
        ' 
        rdb2.AutoSize = True
        rdb2.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        rdb2.Location = New Point(51, 27)
        rdb2.Name = "rdb2"
        rdb2.Size = New Size(33, 21)
        rdb2.TabIndex = 97
        rdb2.TabStop = True
        rdb2.Text = "2"
        rdb2.TextAlign = ContentAlignment.TopCenter
        rdb2.UseVisualStyleBackColor = True
        ' 
        ' rdb3
        ' 
        rdb3.AutoSize = True
        rdb3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        rdb3.Location = New Point(90, 27)
        rdb3.Name = "rdb3"
        rdb3.Size = New Size(33, 21)
        rdb3.TabIndex = 98
        rdb3.TabStop = True
        rdb3.Text = "3"
        rdb3.TextAlign = ContentAlignment.TopCenter
        rdb3.UseVisualStyleBackColor = True
        ' 
        ' rdb4
        ' 
        rdb4.AutoSize = True
        rdb4.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        rdb4.Location = New Point(129, 27)
        rdb4.Name = "rdb4"
        rdb4.Size = New Size(33, 21)
        rdb4.TabIndex = 99
        rdb4.TabStop = True
        rdb4.Text = "4"
        rdb4.TextAlign = ContentAlignment.TopCenter
        rdb4.UseVisualStyleBackColor = True
        ' 
        ' rdb5
        ' 
        rdb5.AutoSize = True
        rdb5.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        rdb5.Location = New Point(168, 27)
        rdb5.Name = "rdb5"
        rdb5.Size = New Size(33, 21)
        rdb5.TabIndex = 100
        rdb5.TabStop = True
        rdb5.Text = "5"
        rdb5.TextAlign = ContentAlignment.TopCenter
        rdb5.UseVisualStyleBackColor = True
        ' 
        ' lblLazy
        ' 
        lblLazy.AutoSize = True
        lblLazy.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLazy.Location = New Point(30, 11)
        lblLazy.Name = "lblLazy"
        lblLazy.Size = New Size(35, 17)
        lblLazy.TabIndex = 101
        lblLazy.Text = "Lazy"
        ' 
        ' lblActive
        ' 
        lblActive.AutoSize = True
        lblActive.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblActive.Location = New Point(129, 11)
        lblActive.Name = "lblActive"
        lblActive.Size = New Size(49, 17)
        lblActive.TabIndex = 102
        lblActive.Text = "Active"
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblCount.Location = New Point(713, 75)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(72, 17)
        lblCount.TabIndex = 103
        lblCount.Text = "Fish count"
        ' 
        ' txtCount
        ' 
        txtCount.BackColor = Color.White
        txtCount.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtCount.Location = New Point(826, 69)
        txtCount.Name = "txtCount"
        txtCount.Size = New Size(151, 23)
        txtCount.TabIndex = 104
        ' 
        ' txtAdded
        ' 
        txtAdded.BackColor = Color.White
        txtAdded.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtAdded.Location = New Point(826, 109)
        txtAdded.Name = "txtAdded"
        txtAdded.Size = New Size(151, 23)
        txtAdded.TabIndex = 106
        ' 
        ' lblAdded
        ' 
        lblAdded.AutoSize = True
        lblAdded.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblAdded.Location = New Point(713, 115)
        lblAdded.Name = "lblAdded"
        lblAdded.Size = New Size(78, 17)
        lblAdded.TabIndex = 105
        lblAdded.Text = "Fish added"
        ' 
        ' txtLost
        ' 
        txtLost.BackColor = Color.White
        txtLost.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtLost.Location = New Point(826, 150)
        txtLost.Name = "txtLost"
        txtLost.Size = New Size(151, 23)
        txtLost.TabIndex = 108
        ' 
        ' lblLost
        ' 
        lblLost.AutoSize = True
        lblLost.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLost.Location = New Point(713, 156)
        lblLost.Name = "lblLost"
        lblLost.Size = New Size(56, 17)
        lblLost.TabIndex = 107
        lblLost.Text = "Fish lost"
        ' 
        ' lblCheck
        ' 
        lblCheck.AutoSize = True
        lblCheck.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblCheck.ForeColor = Color.Maroon
        lblCheck.Location = New Point(301, 301)
        lblCheck.Name = "lblCheck"
        lblCheck.Size = New Size(82, 19)
        lblCheck.TabIndex = 109
        lblCheck.Text = "Check list"
        ' 
        ' lblHeater
        ' 
        lblHeater.AutoSize = True
        lblHeater.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblHeater.Location = New Point(646, 478)
        lblHeater.Name = "lblHeater"
        lblHeater.Size = New Size(96, 17)
        lblHeater.TabIndex = 110
        lblHeater.Text = "Check heater"
        ' 
        ' lblLevel
        ' 
        lblLevel.AutoSize = True
        lblLevel.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLevel.Location = New Point(646, 440)
        lblLevel.Name = "lblLevel"
        lblLevel.Size = New Size(126, 17)
        lblLevel.TabIndex = 111
        lblLevel.Text = "Check water level"
        ' 
        ' lblLight
        ' 
        lblLight.AutoSize = True
        lblLight.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblLight.Location = New Point(301, 440)
        lblLight.Name = "lblLight"
        lblLight.Size = New Size(102, 17)
        lblLight.TabIndex = 112
        lblLight.Text = "Check lighting"
        ' 
        ' lblNet
        ' 
        lblNet.AutoSize = True
        lblNet.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblNet.Location = New Point(646, 399)
        lblNet.Name = "lblNet"
        lblNet.Size = New Size(75, 17)
        lblNet.TabIndex = 113
        lblNet.Text = "Check net"
        ' 
        ' lblTubing
        ' 
        lblTubing.AutoSize = True
        lblTubing.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTubing.Location = New Point(300, 399)
        lblTubing.Name = "lblTubing"
        lblTubing.Size = New Size(96, 17)
        lblTubing.TabIndex = 114
        lblTubing.Text = "Check tubing"
        ' 
        ' lblPump
        ' 
        lblPump.AutoSize = True
        lblPump.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPump.Location = New Point(646, 358)
        lblPump.Name = "lblPump"
        lblPump.Size = New Size(98, 17)
        lblPump.TabIndex = 115
        lblPump.Text = "Check pumps"
        ' 
        ' lblFilter
        ' 
        lblFilter.AutoSize = True
        lblFilter.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblFilter.Location = New Point(300, 362)
        lblFilter.Name = "lblFilter"
        lblFilter.Size = New Size(86, 17)
        lblFilter.TabIndex = 116
        lblFilter.Text = "Check filters"
        ' 
        ' lblCon
        ' 
        lblCon.AutoSize = True
        lblCon.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblCon.Location = New Point(301, 478)
        lblCon.Name = "lblCon"
        lblCon.Size = New Size(128, 17)
        lblCon.TabIndex = 117
        lblCon.Text = "Check conditioner"
        ' 
        ' chbFilter
        ' 
        chbFilter.AutoSize = True
        chbFilter.Location = New Point(444, 364)
        chbFilter.Name = "chbFilter"
        chbFilter.Size = New Size(15, 14)
        chbFilter.TabIndex = 118
        chbFilter.UseVisualStyleBackColor = True
        ' 
        ' chbPump
        ' 
        chbPump.AutoSize = True
        chbPump.Location = New Point(795, 360)
        chbPump.Name = "chbPump"
        chbPump.Size = New Size(15, 14)
        chbPump.TabIndex = 119
        chbPump.UseVisualStyleBackColor = True
        ' 
        ' chbTubing
        ' 
        chbTubing.AutoSize = True
        chbTubing.Location = New Point(444, 401)
        chbTubing.Name = "chbTubing"
        chbTubing.Size = New Size(15, 14)
        chbTubing.TabIndex = 120
        chbTubing.UseVisualStyleBackColor = True
        ' 
        ' chbNet
        ' 
        chbNet.AutoSize = True
        chbNet.Location = New Point(795, 401)
        chbNet.Name = "chbNet"
        chbNet.Size = New Size(15, 14)
        chbNet.TabIndex = 121
        chbNet.UseVisualStyleBackColor = True
        ' 
        ' chbLight
        ' 
        chbLight.AutoSize = True
        chbLight.Location = New Point(444, 442)
        chbLight.Name = "chbLight"
        chbLight.Size = New Size(15, 14)
        chbLight.TabIndex = 122
        chbLight.UseVisualStyleBackColor = True
        ' 
        ' chbLevel
        ' 
        chbLevel.AutoSize = True
        chbLevel.Location = New Point(795, 442)
        chbLevel.Name = "chbLevel"
        chbLevel.Size = New Size(15, 14)
        chbLevel.TabIndex = 123
        chbLevel.UseVisualStyleBackColor = True
        ' 
        ' chbHeater
        ' 
        chbHeater.AutoSize = True
        chbHeater.Location = New Point(795, 480)
        chbHeater.Name = "chbHeater"
        chbHeater.Size = New Size(15, 14)
        chbHeater.TabIndex = 124
        chbHeater.UseVisualStyleBackColor = True
        ' 
        ' chbCon
        ' 
        chbCon.AutoSize = True
        chbCon.Location = New Point(444, 480)
        chbCon.Name = "chbCon"
        chbCon.Size = New Size(15, 14)
        chbCon.TabIndex = 125
        chbCon.UseVisualStyleBackColor = True
        ' 
        ' txtFilter
        ' 
        txtFilter.BackColor = Color.White
        txtFilter.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtFilter.ForeColor = Color.Black
        txtFilter.Location = New Point(471, 355)
        txtFilter.Name = "txtFilter"
        txtFilter.PlaceholderText = "Additional notes"
        txtFilter.Size = New Size(151, 23)
        txtFilter.TabIndex = 126
        txtFilter.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(lblLazy)
        Panel2.Controls.Add(lblActive)
        Panel2.Controls.Add(rdb1)
        Panel2.Controls.Add(rdb2)
        Panel2.Controls.Add(rdb3)
        Panel2.Controls.Add(rdb4)
        Panel2.Controls.Add(rdb5)
        Panel2.Location = New Point(413, 240)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(209, 53)
        Panel2.TabIndex = 134
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Maroon
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(143, 238)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 23)
        btnUpdate.TabIndex = 137
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Maroon
        btnClear.FlatStyle = FlatStyle.Popup
        btnClear.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(23, 279)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 23)
        btnClear.TabIndex = 136
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Maroon
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(23, 238)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 23)
        btnSave.TabIndex = 135
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtPump
        ' 
        txtPump.BackColor = Color.White
        txtPump.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtPump.ForeColor = Color.Black
        txtPump.Location = New Point(826, 355)
        txtPump.Name = "txtPump"
        txtPump.PlaceholderText = "Additional notes"
        txtPump.Size = New Size(151, 23)
        txtPump.TabIndex = 138
        txtPump.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtTubing
        ' 
        txtTubing.BackColor = Color.White
        txtTubing.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtTubing.ForeColor = Color.Black
        txtTubing.Location = New Point(471, 397)
        txtTubing.Name = "txtTubing"
        txtTubing.PlaceholderText = "Additional notes"
        txtTubing.Size = New Size(151, 23)
        txtTubing.TabIndex = 139
        txtTubing.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtNet
        ' 
        txtNet.BackColor = Color.White
        txtNet.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtNet.ForeColor = Color.Black
        txtNet.Location = New Point(826, 397)
        txtNet.Name = "txtNet"
        txtNet.PlaceholderText = "Additional notes"
        txtNet.Size = New Size(151, 23)
        txtNet.TabIndex = 140
        txtNet.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtLevel
        ' 
        txtLevel.BackColor = Color.White
        txtLevel.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtLevel.ForeColor = Color.Black
        txtLevel.Location = New Point(826, 437)
        txtLevel.Name = "txtLevel"
        txtLevel.PlaceholderText = "Additional notes"
        txtLevel.Size = New Size(151, 23)
        txtLevel.TabIndex = 141
        txtLevel.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtLight
        ' 
        txtLight.BackColor = Color.White
        txtLight.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtLight.ForeColor = Color.Black
        txtLight.Location = New Point(471, 437)
        txtLight.Name = "txtLight"
        txtLight.PlaceholderText = "Additional notes"
        txtLight.Size = New Size(151, 23)
        txtLight.TabIndex = 142
        txtLight.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCon
        ' 
        txtCon.BackColor = Color.White
        txtCon.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtCon.ForeColor = Color.Black
        txtCon.Location = New Point(471, 476)
        txtCon.Name = "txtCon"
        txtCon.PlaceholderText = "Additional notes"
        txtCon.Size = New Size(151, 23)
        txtCon.TabIndex = 143
        txtCon.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtHeater
        ' 
        txtHeater.BackColor = Color.White
        txtHeater.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtHeater.ForeColor = Color.Black
        txtHeater.Location = New Point(826, 476)
        txtHeater.Name = "txtHeater"
        txtHeater.PlaceholderText = "Additional notes"
        txtHeater.Size = New Size(151, 23)
        txtHeater.TabIndex = 144
        txtHeater.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.PapayaWhip
        Panel3.Controls.Add(btnDelete)
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(btnSave)
        Panel3.Controls.Add(btnUpdate)
        Panel3.Controls.Add(btnClear)
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 44)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(263, 481)
        Panel3.TabIndex = 146
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Maroon
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(143, 279)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 23)
        btnDelete.TabIndex = 138
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(PictureBox1)
        Panel4.Location = New Point(23, 29)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(214, 179)
        Panel4.TabIndex = 28
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(208, 173)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' cmbCleaner
        ' 
        cmbCleaner.FormattingEnabled = True
        cmbCleaner.Items.AddRange(New Object() {"Athukorala K.M.", "L.V.S. Sandeepa", "D.L. Rajasinghe", "D.S. Danthanarayana", "T.G.K. Serasinghe", "W.G. Wickramaarachchi", "A.N. De Silva", "K.S. Rajakaruna", "R.H.V. Hettige", "R.D.S. Kobbagala", "L.O. Bendarage", "U.B.T. Perera", "A.M.G. Adathsuriya"})
        cmbCleaner.Location = New Point(413, 115)
        cmbCleaner.Name = "cmbCleaner"
        cmbCleaner.Size = New Size(121, 23)
        cmbCleaner.TabIndex = 147
        ' 
        ' lblCleaner
        ' 
        lblCleaner.AutoSize = True
        lblCleaner.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblCleaner.Location = New Point(301, 117)
        lblCleaner.Name = "lblCleaner"
        lblCleaner.Size = New Size(59, 17)
        lblCleaner.TabIndex = 148
        lblCleaner.Text = "Cleaner"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Maroon
        Panel5.Location = New Point(301, 323)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(676, 10)
        Panel5.TabIndex = 149
        ' 
        ' Maintenance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1008, 525)
        Controls.Add(Panel5)
        Controls.Add(lblCleaner)
        Controls.Add(cmbCleaner)
        Controls.Add(Panel3)
        Controls.Add(txtHeater)
        Controls.Add(txtCon)
        Controls.Add(txtLight)
        Controls.Add(txtLevel)
        Controls.Add(txtNet)
        Controls.Add(txtTubing)
        Controls.Add(txtPump)
        Controls.Add(Panel2)
        Controls.Add(txtFilter)
        Controls.Add(chbCon)
        Controls.Add(chbHeater)
        Controls.Add(chbLevel)
        Controls.Add(chbLight)
        Controls.Add(chbNet)
        Controls.Add(chbTubing)
        Controls.Add(chbPump)
        Controls.Add(chbFilter)
        Controls.Add(lblCon)
        Controls.Add(lblFilter)
        Controls.Add(lblPump)
        Controls.Add(lblTubing)
        Controls.Add(lblNet)
        Controls.Add(lblLight)
        Controls.Add(lblLevel)
        Controls.Add(lblHeater)
        Controls.Add(lblCheck)
        Controls.Add(txtLost)
        Controls.Add(lblLost)
        Controls.Add(txtAdded)
        Controls.Add(lblAdded)
        Controls.Add(txtCount)
        Controls.Add(lblCount)
        Controls.Add(lblBehavior)
        Controls.Add(txtPH)
        Controls.Add(txtTem)
        Controls.Add(lblQuality)
        Controls.Add(cmbType)
        Controls.Add(lblType)
        Controls.Add(cmbTank)
        Controls.Add(lblTank)
        Controls.Add(dtpDate)
        Controls.Add(lblDate)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Maintenance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Maintenance"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblExit As Label
    Friend WithEvents lblMain As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblTank As Label
    Friend WithEvents cmbTank As ComboBox
    Friend WithEvents lblType As Label
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents lblQuality As Label
    Friend WithEvents txtTem As TextBox
    Friend WithEvents txtPH As TextBox
    Friend WithEvents lblBehavior As Label
    Friend WithEvents rdb1 As RadioButton
    Friend WithEvents rdb2 As RadioButton
    Friend WithEvents rdb3 As RadioButton
    Friend WithEvents rdb4 As RadioButton
    Friend WithEvents rdb5 As RadioButton
    Friend WithEvents lblLazy As Label
    Friend WithEvents lblActive As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents txtCount As TextBox
    Friend WithEvents txtAdded As TextBox
    Friend WithEvents lblAdded As Label
    Friend WithEvents txtLost As TextBox
    Friend WithEvents lblLost As Label
    Friend WithEvents lblCheck As Label
    Friend WithEvents lblHeater As Label
    Friend WithEvents lblLevel As Label
    Friend WithEvents lblLight As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents lblTubing As Label
    Friend WithEvents lblPump As Label
    Friend WithEvents lblFilter As Label
    Friend WithEvents lblCon As Label
    Friend WithEvents chbFilter As CheckBox
    Friend WithEvents chbPump As CheckBox
    Friend WithEvents chbTubing As CheckBox
    Friend WithEvents chbNet As CheckBox
    Friend WithEvents chbLight As CheckBox
    Friend WithEvents chbLevel As CheckBox
    Friend WithEvents chbHeater As CheckBox
    Friend WithEvents chbCon As CheckBox
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtPump As TextBox
    Friend WithEvents txtTubing As TextBox
    Friend WithEvents txtNet As TextBox
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents txtLight As TextBox
    Friend WithEvents txtCon As TextBox
    Friend WithEvents txtHeater As TextBox
    Friend WithEvents lblHome As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents cmbCleaner As ComboBox
    Friend WithEvents lblCleaner As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblMin As Label
End Class
