Imports MySql.Data.MySqlClient
Public Class ForgotPassword
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=asm")
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim EmployeeNo As String = txtEmNo.Text.Trim()
        Dim NewPassword As String = txtNew.Text.Trim()
        Dim Confirm As String = txtConfirm.Text.Trim()

        'Validation part
        If EmployeeNo = "" OrElse NewPassword = "" OrElse Confirm = "" Then
            MessageBox.Show("Please enter all required fields.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub ' Exit the subroutine if validation fails
        End If

        If NewPassword.Length <> 8 Then
            MessageBox.Show("Password must be at least 8 characters long.", "Invalid Length", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNew.Focus()
            Exit Sub
        End If

        If Confirm <> NewPassword Then
            MessageBox.Show("Password do not match, Please Re-Enter", "Password mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirm.Focus()
            txtConfirm.Text = ""
            txtNew.Text = ""
            Exit Sub ' Exit the subroutine if passwords don't match
        End If


        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `employee` SET `Password`=@Password,`Confim`=@Confim WHERE `EmployeeNo`=@EmployeeNo", conn)
            Dim i As New Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@EmployeeNo", txtEmNo.Text)
            cmd.Parameters.AddWithValue("@Password", txtNew.Text)
            cmd.Parameters.AddWithValue("@Confim", txtConfirm.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Successfully saved !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Save failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        clear()
        DGV_load()

    End Sub

    Public Sub DGV_load()
        Employee.dgvEmployee.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM employee", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Employee.dgvEmployee.Rows.Add(dr.Item("Password"), dr.Item("Confim"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub clear()
        txtEmNo.Clear()
        txtNew.Clear()
        txtConfirm.Clear()
    End Sub

    Private Sub lblEx_Click(sender As Object, e As EventArgs) Handles lblEx.Click
        Application.Exit()
    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub chbShow1_CheckedChanged(sender As Object, e As EventArgs) Handles chbShow1.CheckedChanged
        If chbShow1.Checked = False Then
            txtNew.PasswordChar = "*"
        Else
            txtNew.PasswordChar = ""
        End If
    End Sub

    Private Sub chbShow2_CheckedChanged(sender As Object, e As EventArgs) Handles chbShow2.CheckedChanged
        If chbShow2.Checked = False Then
            txtConfirm.PasswordChar = "*"
        Else
            txtConfirm.PasswordChar = ""
        End If
    End Sub

    'Minimize the window
    Private Sub lblMin_Click(sender As Object, e As EventArgs) Handles lblMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class