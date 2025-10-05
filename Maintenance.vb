Imports System.Security.Cryptography.X509Certificates
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Maintenance
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=asm")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Dim behaviour As String = ""
    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub lblHome_Click(sender As Object, e As EventArgs) Handles lblHome.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub rdb1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb1.CheckedChanged
        If rdb1.Checked Then
            behaviour = "1"
        End If
    End Sub

    Private Sub rdb2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb2.CheckedChanged
        If rdb2.Checked Then
            behaviour = "2"
        End If
    End Sub

    Private Sub rdb3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb3.CheckedChanged
        If rdb3.Checked Then
            behaviour = "3"
        End If
    End Sub

    Private Sub rdb4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb4.CheckedChanged
        If rdb4.Checked Then
            behaviour = "4"
        End If
    End Sub

    Private Sub rdb5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb5.CheckedChanged
        If rdb5.Checked Then
            behaviour = "5"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
    End Sub

    Public Sub save()
        'Validation part
        Dim CleanedDate As String = dtpDate.Value.ToString().Trim()
        Dim Cleaner As String = cmbCleaner.Text.Trim()
        Dim Tank As String = cmbTank.Text.Trim()
        Dim WaterType As String = cmbType.Text.Trim()
        Dim FishBehaviour As String = behaviour.Trim()
        Dim FishCount As String = txtCount.Text.Trim()
        Dim Temperature As String = txtTem.Text.Trim()
        Dim phLevel As String = txtPH.Text.Trim()

        If CleanedDate = "" OrElse Cleaner = "" OrElse Tank = "" OrElse WaterType = "" OrElse FishBehaviour = "" OrElse FishCount = "" OrElse Temperature = "" OrElse phLevel = "" Then
            MessageBox.Show("Please enter all required fields.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub ' Exit the subroutine if validation fails
        End If

        Dim selectedDate As Date = dtpDate.Value.Date
        Dim today As Date = DateTime.Today

        If selectedDate > today Then
            MessageBox.Show("Please select a past date or today date without future date.", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpDate.Value = today
            Exit Sub
        End If

        Dim FishAdded As String = txtAdded.Text.Trim()
        Dim FishLost As String = txtLost.Text.Trim()

        If Not IsNumeric(FishCount) Then
            MessageBox.Show("Fish count must be numeric value.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCount.Focus()
            Exit Sub
        End If

        If Not IsNumeric(FishAdded) Then
            MessageBox.Show("Added fish amount must be numeric value.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAdded.Focus()
            Exit Sub
        End If

        If Not IsNumeric(FishLost) Then
            MessageBox.Show("Lost fish amount must be numeric value.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLost.Focus()
            Exit Sub
        End If

        If behaviour <> "" Then
            Dim query As String = "INSERT INTO `maintenance`(FishBehaviour) VALUES (@FishBehaviour)"
        End If

        'Save part
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `maintenance`(`CleanedDate`, `Cleaner`, `Tank`, `WaterType`, `FishBehaviour`, `FishCount`, `FishAdded`, `FishLost`, `Temperature`, `phLevel`, `CheckFilters`, `CFNotes`, `CheckTubing`, `CTNotes`, `CheckLighting`, `CLNotes`, `ChekConditioner`, `CCNotes`, `CheckPumps`, `CPNotes`, `CheckNet`, `CNNotes`, `CheckWaterLevel`, `CWLNotes`, `CheckHeater`, `CHNotes`) VALUES (@CleanedDate,@Cleaner,@Tank,@WaterType,@FishBehaviour,@FishCount,@FishAdded,@FishLost,@Temperature,@phLevel,@CheckFilters,@CFNotes,@CheckTubing,@CTNotes,@CheckLighting,@CLNotes,@ChekConditioner,@CCNotes,@CheckPumps,@CPNotes,@CheckNet,@CNNotes,@CheckWaterLevel,@CWLNotes,@CheckHeater,@CHNotes)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@CleanedDate", CDate(dtpDate.Text))
            cmd.Parameters.AddWithValue("@Cleaner", cmbCleaner.Text)
            cmd.Parameters.AddWithValue("@Tank", cmbTank.Text)
            cmd.Parameters.AddWithValue("@WaterType", cmbType.Text)
            cmd.Parameters.AddWithValue("@FishBehaviour", behaviour)
            cmd.Parameters.AddWithValue("@FishCount", txtCount.Text)
            cmd.Parameters.AddWithValue("@FishAdded", txtAdded.Text)
            cmd.Parameters.AddWithValue("@FishLost", txtLost.Text)
            cmd.Parameters.AddWithValue("@Temperature", txtTem.Text)
            cmd.Parameters.AddWithValue("@phLevel", txtPH.Text)
            cmd.Parameters.AddWithValue("@CheckFilters", CBool(chbFilter.Checked.ToString))
            cmd.Parameters.AddWithValue("@CFNotes", txtFilter.Text)
            cmd.Parameters.AddWithValue("@CheckTubing", CBool(chbTubing.Checked.ToString))
            cmd.Parameters.AddWithValue("@CTNotes", txtTubing.Text)
            cmd.Parameters.AddWithValue("@CheckLighting", CBool(chbLight.Checked.ToString))
            cmd.Parameters.AddWithValue("@CLNotes", txtLight.Text)
            cmd.Parameters.AddWithValue("@ChekConditioner", CBool(chbCon.Checked.ToString))
            cmd.Parameters.AddWithValue("@CCNotes", txtCon.Text)
            cmd.Parameters.AddWithValue("@CheckPumps", CBool(chbPump.Checked.ToString))
            cmd.Parameters.AddWithValue("@CPNotes", txtPump.Text)
            cmd.Parameters.AddWithValue("@CheckNet", CBool(chbNet.Checked.ToString))
            cmd.Parameters.AddWithValue("@CNNotes", txtNet.Text)
            cmd.Parameters.AddWithValue("@CheckWaterLevel", CBool(chbLevel.Checked.ToString))
            cmd.Parameters.AddWithValue("@CWLNotes", txtLevel.Text)
            cmd.Parameters.AddWithValue("@CheckHeater", CBool(chbHeater.Checked.ToString))
            cmd.Parameters.AddWithValue("@CHNotes", txtHeater.Text)

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

    Private Sub clear()
        dtpDate.Value = Now
        cmbCleaner.Text = ""
        cmbTank.Text = ""
        cmbType.Text = ""
        rdb1.Checked = False
        rdb2.Checked = False
        rdb3.Checked = False
        rdb4.Checked = False
        rdb5.Checked = False
        txtCount.Clear()
        txtAdded.Clear()
        txtLost.Clear()
        txtTem.Clear()
        txtPH.Clear()
        chbFilter.CheckState = False
        txtFilter.Clear()
        chbTubing.CheckState = False
        txtTubing.Clear()
        chbLight.CheckState = False
        txtLight.Clear()
        chbCon.CheckState = False
        txtCon.Clear()
        chbPump.CheckState = False
        txtPump.Clear()
        chbNet.CheckState = False
        txtNet.Clear()
        chbLevel.CheckState = False
        txtLevel.Clear()
        chbHeater.CheckState = False
        txtHeater.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        edit()
    End Sub

    Public Sub edit()
        'Validation part
        Dim CleanedDate As String = dtpDate.Value.ToString().Trim()
        Dim Cleaner As String = cmbCleaner.Text.Trim()
        Dim Tank As String = cmbTank.Text.Trim()
        Dim WaterType As String = cmbType.Text.Trim()
        Dim FishBehaviour As String = behaviour.Trim()
        Dim FishCount As String = txtCount.Text.Trim()
        Dim Temperature As String = txtTem.Text.Trim()
        Dim phLevel As String = txtPH.Text.Trim()

        If CleanedDate = "" OrElse Cleaner = "" OrElse Tank = "" OrElse WaterType = "" OrElse FishBehaviour = "" OrElse FishCount = "" OrElse Temperature = "" OrElse phLevel = "" Then
            MessageBox.Show("Please enter all required fields.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub ' Exit the subroutine if validation fails
        End If

        Dim selectedDate As Date = dtpDate.Value.Date
        Dim today As Date = DateTime.Today

        If selectedDate > today Then
            MessageBox.Show("Please select a past date or today date without future date.", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpDate.Value = today
            Exit Sub
        End If

        Dim FishAdded As String = txtAdded.Text
        Dim FishLost As String = txtLost.Text

        If Not IsNumeric(FishCount) Then
            MessageBox.Show("Fish count must be numeric value.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCount.Focus()
            Exit Sub
        End If

        If Not IsNumeric(FishAdded) Then
            MessageBox.Show("Added fish amount must be numeric value.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAdded.Focus()
            Exit Sub
        End If

        If Not IsNumeric(FishLost) Then
            MessageBox.Show("Lost fish amount must be numeric value.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLost.Focus()
            Exit Sub
        End If

        'Edit part
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `maintenance` SET `CleanedDate`=@CleanedDate,`Cleaner`=@Cleaner,`Tank`=@Tank,`WaterType`=@WaterType,`FishBehaviour`=@FishBehaviour,`FishCount`=@FishCount,`FishAdded`=@FishAdded,`FishLost`=@FishLost,`Temperature`=@Temperature,`phLevel`=@phLevel,`CheckFilters`=@CheckFilters,`CFNotes`=@CFNotes,`CheckTubing`=@CheckTubing,`CTNotes`=@CTNotes,`CheckLighting`=@CheckLighting,`CLNotes`=@CLNotes,`ChekConditioner`=@ChekConditioner,`CCNotes`=@CCNotes,`CheckPumps`=@CheckPumps,`CPNotes`=@CPNotes,`CheckNet`=@CheckNet,`CNNotes`=@CNNotes,`CheckWaterLevel`=@CheckWaterLevel,`CWLNotes`=@CWLNotes,`CheckHeater`=@CheckHeater,`CHNotes`=@CHNotes WHERE `Tank`=@Tank", conn)
            Dim i As New Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@CleanedDate", CDate(dtpDate.Text))
            cmd.Parameters.AddWithValue("@Cleaner", cmbCleaner.Text)
            cmd.Parameters.AddWithValue("@Tank", cmbTank.Text)
            cmd.Parameters.AddWithValue("@WaterType", cmbType.Text)
            cmd.Parameters.AddWithValue("@FishBehaviour", behaviour)
            cmd.Parameters.AddWithValue("@FishCount", txtCount.Text)
            cmd.Parameters.AddWithValue("@FishAdded", txtAdded.Text)
            cmd.Parameters.AddWithValue("@FishLost", txtLost.Text)
            cmd.Parameters.AddWithValue("@Temperature", txtTem.Text)
            cmd.Parameters.AddWithValue("@phLevel", txtPH.Text)
            cmd.Parameters.AddWithValue("@CheckFilters", CBool(chbFilter.Checked.ToString))
            cmd.Parameters.AddWithValue("@CFNotes", txtFilter.Text)
            cmd.Parameters.AddWithValue("@CheckTubing", CBool(chbTubing.Checked.ToString))
            cmd.Parameters.AddWithValue("@CTNotes", txtTubing.Text)
            cmd.Parameters.AddWithValue("@CheckLighting", CBool(chbLight.Checked.ToString))
            cmd.Parameters.AddWithValue("@CLNotes", txtLight.Text)
            cmd.Parameters.AddWithValue("@ChekConditioner", CBool(chbCon.Checked.ToString))
            cmd.Parameters.AddWithValue("@CCNotes", txtCon.Text)
            cmd.Parameters.AddWithValue("@CheckPumps", CBool(chbPump.Checked.ToString))
            cmd.Parameters.AddWithValue("@CPNotes", txtPump.Text)
            cmd.Parameters.AddWithValue("@CheckNet", CBool(chbNet.Checked.ToString))
            cmd.Parameters.AddWithValue("@CNNotes", txtNet.Text)
            cmd.Parameters.AddWithValue("@CheckWaterLevel", CBool(chbLevel.Checked.ToString))
            cmd.Parameters.AddWithValue("@CWLNotes", txtLevel.Text)
            cmd.Parameters.AddWithValue("@CheckHeater", CBool(chbHeater.Checked.ToString))
            cmd.Parameters.AddWithValue("@CHNotes", txtHeater.Text)

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
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        delete()
    End Sub

    Public Sub delete()
        If MsgBox("Are you sure you want to delete this record ?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `maintenance` WHERE `Tank`=@Tank", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Tank", cmbTank.Text)
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
        Else
            Return
        End If
    End Sub

    'Minimize the window
    Private Sub lblMin_Click(sender As Object, e As EventArgs) Handles lblMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class