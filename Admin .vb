Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Admin
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=asm")
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
        Clear()

    End Sub
    Public Sub Login()
        'Validation part
        Dim password As String = txtPassword.Text.Trim()
        If password.Length <> 8 Then
            MessageBox.Show("Password must be 8 characters long.", "Invalid Length", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If

        If password = "" Then
            MessageBox.Show("Please enter required password field.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub 'Exit the subroutine if validation fails
        End If

        'Login part
        Try
            conn.Open()
            Dim adapter = New MySqlDataAdapter("SELECT * FROM `admin` WHERE `Password`=@Password", conn)
            With adapter.SelectCommand.Parameters
                .AddWithValue("@Password", password)
            End With
            Dim table = New DataTable()
            adapter.Fill(table)
            If (table.Rows.Count > 0) Then
                Me.Hide()
                Dashboard.Show()
            Else
                MessageBox.Show("Login unsuccessful", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Dispose()
            conn.Close()
        End Try


    End Sub
    Public Sub Clear()
        txtPassword.Clear()
    End Sub

    Private Sub lblEx_Click(sender As Object, e As EventArgs) Handles lblEx.Click
        Application.Exit()
    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub chbShow_CheckedChanged(sender As Object, e As EventArgs) Handles chbShow.CheckedChanged
        If chbShow.Checked = False Then
            txtPassword.PasswordChar = "*"
        Else
            txtPassword.PasswordChar = ""
        End If
    End Sub

    'Minimize the window
    Private Sub lblMin_Click(sender As Object, e As EventArgs) Handles lblMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class