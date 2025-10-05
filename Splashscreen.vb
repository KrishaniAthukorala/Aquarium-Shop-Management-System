Public Class Splashscreen

    Private Sub Splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Splash.Increment(1)
        Splash.Text = Splash.Value & "%"

        If (Splash.Value = 100) Then
            Me.Hide()
            Form1.Show()
            Timer1.Enabled = False
            Timer1.Stop()
        End If
    End Sub

End Class