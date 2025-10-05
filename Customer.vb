Imports System.Security.Cryptography.X509Certificates
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Customer
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
        Dim CustomerNo As String = txtCusNo.Text.Trim()
        Dim FullName As String = txtFull.Text.Trim()
        Dim Sex As String = Gender.Trim()
        Dim Address As String = txtAddress.Text.Trim()
        Dim ContactNo As String = txtContact.Text.Trim()

        If CustomerNo = "" OrElse FullName = "" OrElse Sex = "" OrElse Address = "" OrElse ContactNo = "" Then
            MessageBox.Show("Please enter all required fields.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub ' Exit the subroutine if validation fails
        End If

        Dim valueExists As Boolean = False
        For Each row As DataGridViewRow In dgvCustomer.Rows
            If row.Cells("Column1").Value IsNot Nothing AndAlso row.Cells("Column1").Value.ToString().Trim() = CustomerNo Then
                valueExists = True
                Exit For
            End If
        Next
        If valueExists Then
            MessageBox.Show("A duplicate customer no has been entered. Please enter a unique no.", "Duplicated No", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCusNo.Focus()
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

        If Gender <> "" Then
            Dim query As String = "INSERT INTO `customer`(Gender) VALUES (@Gender)"
        End If

        'Save part
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `customer`(`CustomerNo`, `FullName`, `Gender`, `Address`, `ContactNo`) VALUES (@CustomerNo,@FullName,@Gender,@Address,@ContactNo)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@CustomerNo", txtCusNo.Text)
            cmd.Parameters.AddWithValue("@FullName", txtFull.Text)
            cmd.Parameters.AddWithValue("@Gender", Gender)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@ContactNo", txtContact.Text)

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
        dgvCustomer.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM customer", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgvCustomer.Rows.Add(dr.Item("CustomerNo"), dr.Item("FullName"), Format(CObj(dr.Item("Gender"))), dr.Item("Address"), dr.Item("ContactNo"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub clear()
        txtCusNo.Clear()
        txtFull.Clear()
        rdbMale.Checked = False
        rdbFemale.Checked = False
        txtAddress.Clear()
        txtContact.Clear()
    End Sub

    Private Sub dgvCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellContentClick
        txtCusNo.Text = dgvCustomer.CurrentRow.Cells(1).Value
        txtFull.Text = dgvCustomer.CurrentRow.Cells(2).Value
        lblGender.Text = dgvCustomer.CurrentRow.Cells(3).Value
        txtAddress.Text = dgvCustomer.CurrentRow.Cells(4).Value
        txtContact.Text = dgvCustomer.CurrentRow.Cells(5).Value

        txtCusNo.ReadOnly = True
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
        Dim CustomerNo As String = txtCusNo.Text.Trim()
        Dim FullName As String = txtFull.Text.Trim()
        Dim Sex As String = Gender.Trim()
        Dim Address As String = txtAddress.Text.Trim()
        Dim ContactNo As String = txtContact.Text.Trim()

        If CustomerNo = "" OrElse FullName = "" OrElse Sex = "" OrElse Address = "" OrElse ContactNo = "" Then
            MessageBox.Show("Please enter all required fields.", "REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub ' Exit the subroutine if validation fails
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

        'Edit part
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `customer` SET `CustomerNo`=@CustomerNo,`FullName`=@FullName,`Gender`=@Gender,`Address`=@Address,`ContactNo`=@ContactNo WHERE `CustomerNo`=@CustomerNo", conn)
            Dim i As New Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@CustomerNo", txtCusNo.Text)
            cmd.Parameters.AddWithValue("@FullName", txtFull.Text)
            cmd.Parameters.AddWithValue("@Gender", Gender)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@ContactNo", txtContact.Text)

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
                Dim cmd As New MySqlCommand("DELETE FROM `customer` WHERE `CustomerNo`=@CustomerNo", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@CustomerNo", txtCusNo.Text)
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
        dgvCustomer.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM customer WHERE CustomerNo like '%" & txtSearch.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgvCustomer.Rows.Add(dr.Item("CustomerNo"), dr.Item("FullName"), Format(CObj(dr.Item("Gender"))), dr.Item("Address"), dr.Item("ContactNo"))
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

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM customer", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgvCustomer.Rows.Add(dr.Item("CustomerNo"), dr.Item("FullName"), Format(CObj(dr.Item("Gender"))), dr.Item("Address"), dr.Item("ContactNo"))
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