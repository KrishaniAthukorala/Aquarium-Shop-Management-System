Imports System.Security.Cryptography.X509Certificates
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Employee
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=asm")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Dim Gender As String = ""

    Private Sub rdbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMale.CheckedChanged
        If rdbMale.Checked Then
            Gender = "Male"
        End If
    End Sub

    Private Sub rdbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFemale.CheckedChanged
        If rdbFemale.Checked Then
            Gender = "Female"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
        DGV_load()
    End Sub

    Public Sub save()

        'Validation part
        Dim EmployeeNo As String = txtEmNo.Text.Trim()
        Dim FullName As String = txtFull.Text.Trim()
        Dim UserName As String = txtUser.Text.Trim()
        Dim Password As String = txtPassword.Text.Trim()
        Dim Confirm As String = txtConfirm.Text.Trim()
        Dim Sex As String = Gender.Trim()
        Dim Address As String = txtAddress.Text.Trim()
        Dim ContactNo As String = txtContact.Text.Trim()
        Dim Email As String = txtEmail.Text.Trim()
        Dim NIC As String = txtNIC.Text.Trim()
        Dim BOD As String = dtpDOB.Value.ToString().Trim()

        If EmployeeNo = "" OrElse FullName = "" OrElse UserName = "" OrElse Password = "" OrElse Confirm = "" OrElse Sex = "" OrElse Address = "" OrElse ContactNo = "" OrElse Email = "" OrElse NIC = "" OrElse BOD = "" Then
            MessageBox.Show("Please enter all required fields.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub ' Exit the subroutine if validation fails
        End If

        Dim valueExists As Boolean = False
        For Each row As DataGridViewRow In dgvEmployee.Rows
            If row.Cells("Column1").Value IsNot Nothing AndAlso row.Cells("Column1").Value.ToString().Trim() = EmployeeNo Then
                valueExists = True
                Exit For
            End If
        Next
        If valueExists Then
            MessageBox.Show("A duplicate employee no has been entered. Please enter a unique no.", "Duplicated No", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmNo.Focus()
            Exit Sub
        End If

        If Password.Length <> 8 Then
            MessageBox.Show("Password must be at least 8 characters long.", "Invalid Length", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If

        If Confirm <> Password Then
            MessageBox.Show("Password do not match, Please Re-Enter", "Password mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirm.Focus()
            txtConfirm.Text = ""
            txtPassword.Text = ""
            Exit Sub ' Exit the subroutine if passwords don't match
        End If

        If ContactNo.Length <> 10 Then
            MessageBox.Show("Contact number must be 10 characters long.", "Invalid Length", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContact.Focus()
            Exit Sub
        End If

        If Not IsNumeric(ContactNo) Then
            MessageBox.Show("Contact number must be numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContact.Focus()
            Exit Sub
        End If

        If Not Regex.IsMatch(Email, "^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$") Then
            MessageBox.Show("Invalid emaill format. Please use example@domain.com format.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
            Exit Sub
        End If

        Dim selectedDate As Date = dtpDOB.Value.Date
        Dim today As Date = DateTime.Today

        If selectedDate >= today Then
            MessageBox.Show("Please select a birth date without a future date or today date.", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpDOB.Value = today
            Exit Sub
        End If

        If Gender <> "" Then
            Dim query As String = "INSERT INTO `employee`(Gender) VALUES (@Gender)"
        End If

        'Save part
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `employee`(`EmployeeNo`, `FullName`,`UserName`, `Password`, `Confim`, `Gender`, `Address`, `ContactNo`, `Email`,`NIC`, `BOD`) VALUES (@EmployeeNo,@FullName,@UserName,@Password,@Confim,@Gender,@Address,@ContactNo,@Email,@NIC,@BOD)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@EmployeeNo", txtEmNo.Text)
            cmd.Parameters.AddWithValue("@FullName", txtFull.Text)
            cmd.Parameters.AddWithValue("@UserName", txtUser.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@Confim", txtConfirm.Text)
            cmd.Parameters.AddWithValue("@Gender", Gender)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@ContactNo", txtContact.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@NIC", txtNIC.Text)
            cmd.Parameters.AddWithValue("@BOD", CDate(dtpDOB.Text))

            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MessageBox.Show("Successfully saved !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Save failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        clear()
    End Sub

    Public Sub DGV_load()
        dgvEmployee.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM employee", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgvEmployee.Rows.Add(dr.Item("EmployeeNo"), dr.Item("FullName"), dr.Item("UserName"), dr.Item("Password"), dr.Item("Confim"), Format(CObj(dr.Item("Gender"))), dr.Item("Address"), dr.Item("ContactNo"), dr.Item("Email"), dr.Item("NIC"), dr.Item("BOD"))
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
        txtFull.Clear()
        txtUser.Clear()
        txtPassword.Clear()
        txtConfirm.Clear()
        rdbMale.Checked = False
        rdbFemale.Checked = False
        txtAddress.Clear()
        txtContact.Clear()
        txtEmail.Clear()
        txtNIC.Clear()
        dtpDOB.Value = Now
    End Sub

    Private Sub dgvEmployee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployee.CellContentClick
        txtEmNo.Text = dgvEmployee.CurrentRow.Cells(1).Value
        txtFull.Text = dgvEmployee.CurrentRow.Cells(2).Value
        txtUser.Text = dgvEmployee.CurrentRow.Cells(3).Value
        txtPassword.Text = dgvEmployee.CurrentRow.Cells(4).Value
        txtConfirm.Text = dgvEmployee.CurrentRow.Cells(5).Value
        lblGender.Text = dgvEmployee.CurrentRow.Cells(6).Value
        txtAddress.Text = dgvEmployee.CurrentRow.Cells(7).Value
        txtContact.Text = dgvEmployee.CurrentRow.Cells(8).Value
        txtEmail.Text = dgvEmployee.CurrentRow.Cells(9).Value
        txtNIC.Text = dgvEmployee.CurrentRow.Cells(10).Value
        dtpDOB.Value = dgvEmployee.CurrentRow.Cells(11).Value

        txtEmNo.ReadOnly = True
        btnSave.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        edit()
    End Sub
    Public Sub edit()

        'Validation part
        Dim EmployeeNo As String = txtEmNo.Text.Trim()
        Dim FullName As String = txtFull.Text.Trim()
        Dim UserName As String = txtUser.Text.Trim()
        Dim Password As String = txtPassword.Text.Trim()
        Dim Confirm As String = txtConfirm.Text.Trim()
        Dim Sex As String = Gender.Trim()
        Dim Address As String = txtAddress.Text.Trim()
        Dim ContactNo As String = txtContact.Text.Trim()
        Dim Email As String = txtEmail.Text.Trim()
        Dim NIC As String = txtNIC.Text.Trim()
        Dim BOD As String = dtpDOB.Value.ToString().Trim()

        If EmployeeNo = "" OrElse FullName = "" OrElse UserName = "" OrElse Password = "" OrElse Confirm = "" OrElse Sex = "" OrElse Address = "" OrElse ContactNo = "" OrElse Email = "" OrElse NIC = "" OrElse BOD = "" Then
            MessageBox.Show("Please enter all required fields.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub ' Exit the subroutine if validation fails
        End If

        If Confirm <> Password Then
            MessageBox.Show("Password do not match, Please Re-Enter", "Password mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirm.Focus()
            txtConfirm.Text = ""
            txtPassword.Text = ""
            Exit Sub ' Exit the subroutine if passwords don't match
        End If

        If Password.Length <> 8 Then
            MessageBox.Show("Password must be at least 8 characters long.", "Invalid Length", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If

        If ContactNo.Length <> 10 Then
            MessageBox.Show("Contact number must be 10 characters long.", "Invalid Length", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContact.Focus()
            Exit Sub
        End If

        If Not IsNumeric(ContactNo) Then
            MessageBox.Show("Contact number must be numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContact.Focus()
            Exit Sub
        End If

        If Not Regex.IsMatch(Email, "^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$") Then
            MessageBox.Show("Invalid emaill format. Please use example@domain.com format.", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
            Exit Sub
        End If

        Dim selectedDate As Date = dtpDOB.Value.Date
        Dim today As Date = DateTime.Today

        If selectedDate >= today Then
            MessageBox.Show("Please select a birth date without a future date or today date.", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpDOB.Value = today
            Exit Sub
        End If

        'Edit part
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `employee` SET `EmployeeNo`=@EmployeeNo,`FullName`=@FullName,`UserName`=@UserName,`Password`=@Password,`Confim`=@Confim,`Gender`=@Gender,`Address`=@Address,`ContactNo`=@ContactNo,`Email`=@Email,`NIC`=@NIC,`BOD`=@BOD WHERE `EmployeeNo`=@EmployeeNo", conn)
            Dim i As New Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@EmployeeNo", txtEmNo.Text)
            cmd.Parameters.AddWithValue("@FullName", txtFull.Text)
            cmd.Parameters.AddWithValue("@UserName", txtUser.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@Confim", txtConfirm.Text)
            cmd.Parameters.AddWithValue("@Gender", Gender)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@ContactNo", txtContact.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@NIC", txtNIC.Text)
            cmd.Parameters.AddWithValue("@BOD", CDate(dtpDOB.Text))

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Successfully updated !", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Update failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        clear()
        DGV_load()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        delete()
    End Sub

    Public Sub delete()
        If MsgBox("Are you sure you want to delete this record ?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `employee` WHERE `EmployeeNo`=@EmployeeNo", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@EmployeeNo", txtEmNo.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Successfully deleted !", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Delete failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            clear()
            DGV_load()
        Else
            Return
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvEmployee.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM employee WHERE EmployeeNo like '%" & txtSearch.Text & "%' OR NIC like '%" & txtSearch.Text & " %'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgvEmployee.Rows.Add(dr.Item("EmployeeNo"), dr.Item("FullName"), dr.Item("UserName"), dr.Item("Password"), dr.Item("Confim"), Format(CObj(dr.Item("Gender"))), dr.Item("Address"), dr.Item("ContactNo"), dr.Item("Email"), dr.Item("NIC"), dr.Item("BOD"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub lblHome_Click(sender As Object, e As EventArgs) Handles lblHome.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM employee", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgvEmployee.Rows.Add(dr.Item("EmployeeNo"), dr.Item("FullName"), dr.Item("UserName"), dr.Item("Password"), dr.Item("Confim"), Format(CObj(dr.Item("Gender"))), dr.Item("Address"), dr.Item("ContactNo"), dr.Item("Email"), dr.Item("NIC"), dr.Item("BOD"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    'Minimize the window
    Private Sub lblMin_Click(sender As Object, e As EventArgs) Handles lblMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class