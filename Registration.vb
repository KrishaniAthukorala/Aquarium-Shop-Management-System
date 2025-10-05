Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class Register
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=asm")

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        register()
        clear()
    End Sub
    Public Sub register()
        Try
            conn.Open()
            Dim cmd = New MySqlCommand("INSERT INTO `registration`(`FirstName`, `LastName`, `UserName`, `Gender`, `Address`, `ContactNo`, `Email`, `Password`, `ConfirmPassword`) VALUES (@FirstName,@LastName,@UserName,@Gender,@Address,@ContactNo,@Email,@Password,@ConfirmPassword))", conn)
            With cmd.Parameters
                .AddWithValue("@FirstName", txtFirst.Text)
                .AddWithValue("@LastName", txtLast.Text)
                .AddWithValue("@UserName", txtUser.Text)
                .AddWithValue("@Gender", CBool(rdbMale.Checked.ToString))
                .AddWithValue("@Gender", CBool(rdbFemale.Checked.ToString))
                .AddWithValue("@Address", txtAddress.Text)
                .AddWithValue("@ContactNo", txtContact.Text)
                .AddWithValue("@Email", txtEmail.Text)
                .AddWithValue("@Password", txtPassword.Text)
                .AddWithValue("@ConfirmPassword", txtConfirm.Text)
                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If (i > 0) Then
                    MessageBox.Show("Registration is successful", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Registration failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Dispose()
            conn.Close()
        End Try

        Dim FirstName As String = txtFirst.Text.Trim()
        Dim LastName As String = txtLast.Text.Trim()
        Dim UserName As String = txtUser.Text.Trim()
        Dim Gender As String = rdbMale.Checked.ToString.Trim()
        Dim Address As String = txtAddress.Text.Trim()
        Dim ContactNo As String = txtContact.Text.Trim()
        Dim Email As String = txtEmail.Text.Trim()
        Dim Password As String = txtPassword.Text.Trim()
        Dim ConfirmPassword As String = txtConfirm.Text.Trim()

        If FirstName = "" OrElse LastName = "" OrElse UserName = "" OrElse rdbMale.Checked = False OrElse rdbFemale.Checked = False OrElse Address = "" OrElse ContactNo = "" OrElse Password = "" OrElse ConfirmPassword = "" Then
            MessageBox.Show("Please enter all required fields.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub ' Exit the subroutine if validation fails
        End If

        'Check password length (adjust as method)
        If ContactNo.Length < 10 Then
            MessageBox.Show("Contact number must be 10 characters long.", "Invalid Length", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContact.Focus()
            Exit Sub
        End If

        If Not Regex.IsMatch(Email, "^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$") Then
            MessageBox.Show("Invalid emaill format. Please use example@domain.com format.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
            Exit Sub
        End If

        If Confirmpassword <> Password Then
            MessageBox.Show("Password do not match, Please Re-Enter", "PASSWORD MISMATCH", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirm.Focus()
            txtConfirm.Text = ""
            txtPassword.Text = ""
            Exit Sub ' Exit the subroutine if passwords don't match
        End If

        'Check password length (adjust as method)
        If Password.Length < 8 Then
            MessageBox.Show("Password must be at least 8 characters long.", "Invalid Length", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If

    End Sub
    Public Sub clear()
        txtFirst.Clear()
        txtLast.Clear()
        txtUser.Clear()
        rdbMale.Checked = False
        rdbFemale.Checked = False
        txtAddress.Clear()
        txtContact.Clear()
        txtPassword.Clear()
        txtConfirm.Clear()
    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class



