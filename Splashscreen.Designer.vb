<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splashscreen
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Splashscreen))
        picWater = New PictureBox()
        Splash = New ProgressBar()
        Timer1 = New Timer(components)
        lblAtrium = New Label()
        CType(picWater, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picWater
        ' 
        picWater.Image = CType(resources.GetObject("picWater.Image"), Image)
        picWater.Location = New Point(0, -1)
        picWater.Name = "picWater"
        picWater.Size = New Size(206, 310)
        picWater.SizeMode = PictureBoxSizeMode.AutoSize
        picWater.TabIndex = 0
        picWater.TabStop = False
        ' 
        ' Splash
        ' 
        Splash.Location = New Point(0, 304)
        Splash.Name = "Splash"
        Splash.Size = New Size(206, 30)
        Splash.TabIndex = 2
        ' 
        ' Timer1
        ' 
        ' 
        ' lblAtrium
        ' 
        lblAtrium.AutoSize = True
        lblAtrium.BackColor = Color.MidnightBlue
        lblAtrium.Font = New Font("Lucida Handwriting", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lblAtrium.ForeColor = Color.White
        lblAtrium.Location = New Point(27, 140)
        lblAtrium.Name = "lblAtrium"
        lblAtrium.Size = New Size(152, 41)
        lblAtrium.TabIndex = 3
        lblAtrium.Text = "Atrium"
        ' 
        ' Splashscreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(206, 334)
        Controls.Add(lblAtrium)
        Controls.Add(Splash)
        Controls.Add(picWater)
        FormBorderStyle = FormBorderStyle.None
        Name = "Splashscreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Splashscreen"
        CType(picWater, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picWater As PictureBox
    Friend WithEvents Splash As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblAtrium As Label
End Class
