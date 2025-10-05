Imports System.Security.Cryptography.X509Certificates
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Inventory
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=asm")
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub lblHome_Click(sender As Object, e As EventArgs) Handles lblHome.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
        DGV_load()
    End Sub

    Public Sub save()
        'Validation part
        Dim Category As String = cmbCategory.Text.Trim()
        Dim SubCategory As String = txtSubCat.Text.Trim()
        Dim Code As String = txtCode.Text.Trim()
        Dim Colour As String = txtColour.Text.Trim()
        Dim Size As String = txtSize.Text.Trim()
        Dim Quantity As String = txtQuantity.Text.Trim()
        Dim UnitPrice As String = txtUPrice.Text.Trim()
        Dim SupplierNo As String = cmbSupNo.Text.Trim()

        If Category = "" OrElse SubCategory = "" OrElse Code = "" OrElse Colour = "" OrElse Size = "" OrElse Quantity = "" OrElse UnitPrice = "" OrElse SupplierNo = "" Then
            MessageBox.Show("Please enter all required fields.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub ' Exit the subroutine if validation fails
        End If

        If Not IsNumeric(Quantity) Then
            MessageBox.Show("Quantity must be numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQuantity.Focus()
            Exit Sub
        End If

        'Save part
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `inventory`(`Category`, `SubCategory`, `Code`, `Colour`, `Size`, `Quantity`, `UnitPrice`, `SupplierNo`) VALUES (@Category,@SubCategory,@Code,@Colour,@Size,@Quantity,@UnitPrice,@SupplierNo)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Category", cmbCategory.Text)
            cmd.Parameters.AddWithValue("@SubCategory", txtSubCat.Text)
            cmd.Parameters.AddWithValue("@Code", txtCode.Text)
            cmd.Parameters.AddWithValue("@Colour", txtColour.Text)
            cmd.Parameters.AddWithValue("@Size", txtSize.Text)
            cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text)
            cmd.Parameters.AddWithValue("@UnitPrice", CDec(txtUPrice.Text))
            cmd.Parameters.AddWithValue("@SupplierNo", cmbSupNo.Text)

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
        dgvInventory.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM inventory", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgvInventory.Rows.Add(dr.Item("Category"), dr.Item("SubCategory"), dr.Item("Code"), dr.Item("Colour"), dr.Item("Size"), dr.Item("Quantity"), dr.Item("UnitPrice"), dr.Item("SupplierNo"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub clear()
        cmbCategory.Text = ""
        txtSubCat.Clear()
        txtCode.Clear()
        txtColour.Clear()
        txtSize.Clear()
        txtQuantity.Clear()
        txtUPrice.Clear()
        cmbSupNo.Text = ""
    End Sub

    Private Sub dgvEmployee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick
        cmbCategory.Text = dgvInventory.CurrentRow.Cells(1).Value
        txtSubCat.Text = dgvInventory.CurrentRow.Cells(2).Value
        txtCode.Text = dgvInventory.CurrentRow.Cells(3).Value
        txtColour.Text = dgvInventory.CurrentRow.Cells(4).Value
        txtSize.Text = dgvInventory.CurrentRow.Cells(5).Value
        txtQuantity.Text = dgvInventory.CurrentRow.Cells(6).Value
        txtUPrice.Text = dgvInventory.CurrentRow.Cells(7).Value
        cmbSupNo.Text = dgvInventory.CurrentRow.Cells(8).Value

        txtCode.ReadOnly = True
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
        Dim Category As String = cmbCategory.Text.Trim()
        Dim SubCategory As String = txtSubCat.Text.Trim()
        Dim Code As String = txtCode.Text.Trim()
        Dim Colour As String = txtColour.Text.Trim()
        Dim Size As String = txtSize.Text.Trim()
        Dim Quantity As String = txtQuantity.Text.Trim()
        Dim UnitPrice As String = txtUPrice.Text.Trim()
        Dim SupplierNo As String = cmbSupNo.Text.Trim()

        If Category = "" OrElse SubCategory = "" OrElse Code = "" OrElse Colour = "" OrElse Size = "" OrElse Quantity = "" OrElse UnitPrice = "" OrElse SupplierNo = "" Then
            MessageBox.Show("Please enter all required fields.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub ' Exit the subroutine if validation fails
        End If

        If Not IsNumeric(Quantity) Then
            MessageBox.Show("Quantity must be numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQuantity.Focus()
            Exit Sub
        End If

        'Edit part
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `inventory` SET `Category`=@Category,`SubCategory`=@SubCategory,`Code`=@Code,`Colour`=@Colour,`Size`=@Size,`Quantity`=@Quantity,`UnitPrice`=@UnitPrice,`SupplierNo`=@SupplierNo WHERE `Code`=@Code", conn)
            Dim i As New Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Category", cmbCategory.Text)
            cmd.Parameters.AddWithValue("@SubCategory", txtSubCat.Text)
            cmd.Parameters.AddWithValue("@Code", txtCode.Text)
            cmd.Parameters.AddWithValue("@Colour", txtColour.Text)
            cmd.Parameters.AddWithValue("@Size", txtSize.Text)
            cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text)
            cmd.Parameters.AddWithValue("@UnitPrice", CDec(txtUPrice.Text))
            cmd.Parameters.AddWithValue("@SupplierNo", cmbSupNo.Text)

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
                Dim cmd As New MySqlCommand("DELETE FROM `inventory` WHERE `Code`=@Code AND `SupplierNo`=@SupplierNo", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Code", txtCode.Text)
                cmd.Parameters.AddWithValue("@SupplierNo", cmbSupNo.Text)
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
        dgvInventory.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM inventory WHERE Category like '%" & cmbCategory.Text & "%' OR SubCategory like '%" & txtSubCat.Text & "%' OR Code like '%" & txtCode.Text & "%' OR SupplierNo like '%" & cmbSupNo.Text & " %'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgvInventory.Rows.Add(dr.Item("Category"), dr.Item("SubCategory"), dr.Item("Code"), dr.Item("Colour"), dr.Item("Size"), dr.Item("Quantity"), dr.Item("UnitPrice"), dr.Item("SupplierNo"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM inventory", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgvInventory.Rows.Add(dr.Item("Category"), dr.Item("SubCategory"), dr.Item("Code"), dr.Item("Colour"), dr.Item("Size"), dr.Item("Quantity"), dr.Item("UnitPrice"), dr.Item("SupplierNo"))
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