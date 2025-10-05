Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=asm")
    Public Sub Clear()
        cmbUser.Text = ""
        txtUser.Clear()
        txtPassword.Clear()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login()
        Clear()
    End Sub
    Public Sub Login()
        'Validation part
        Dim user As String = cmbUser.Text.Trim()
        Dim username As String = txtUser.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        If user = "" OrElse username = "" OrElse password = "" Then
            MessageBox.Show("Please enter all required fields.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub 'Exit the subroutine if validation fails
        End If

        If password.Length <> 8 Then
            MessageBox.Show("Password must be 8 characters long.", "Invalid Length", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If

        'Login part
        Try
            conn.Open()
            Dim adapter = New MySqlDataAdapter("SELECT * FROM `employee` WHERE `UserName`=@UserName And `Password`=@Password", conn)
            With adapter.SelectCommand.Parameters
                .AddWithValue("@UserName", username)
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

    Private Sub lblAdmin_Click(sender As Object, e As EventArgs) Handles lblAdmin.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub lblSignup_Click(sender As Object, e As EventArgs) Handles lblSignup.Click
        Application.Exit()
    End Sub

    Private Sub chbShow_CheckedChanged(sender As Object, e As EventArgs) Handles chbShow.CheckedChanged
        If chbShow.Checked = False Then
            txtPassword.PasswordChar = "*"
        Else
            txtPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub lblForgot_Click(sender As Object, e As EventArgs) Handles lblForgot.Click
        Me.Hide()
        ForgotPassword.Show()
    End Sub

    'Minimize the window
    Private Sub lblMin_Click(sender As Object, e As EventArgs) Handles lblMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
