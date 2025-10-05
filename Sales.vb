Imports System.Drawing.Printing
Imports System.Xml.Schema
Imports System.Security.Cryptography.X509Certificates
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.Resultset
Imports System.Drawing.Text
Imports Org.BouncyCastle.Utilities

Public Class Sales
    Dim WithEvents Document As New PrintDocument
    Dim Dialog As New PrintPreviewDialog
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=asm")
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub Document_BeginPrint(sender As Object, e As PrintEventArgs) Handles Document.BeginPrint
        Dim pagesetup As New PageSettings
        Dialog.WindowState = FormWindowState.Maximized
        Dialog.PrintPreviewControl.Zoom = 2.5
        pagesetup.PaperSize = New PaperSize("MySize", 250, 600)
        Document.DefaultPageSettings = pagesetup
    End Sub

    Private Sub Document_PrintPage(sender As Object, e As PrintPageEventArgs) Handles Document.PrintPage
        Dim f1 As New Font("Franklin Gothic", 8, FontStyle.Regular)
        Dim f2 As New Font("Lucida Handwriting", 10, FontStyle.Italic)
        Dim f1b As New Font("Franklin Gothic", 8, FontStyle.Bold)
        Dim f2b As New Font("Lucida Handwriting", 10, FontStyle.Bold)

        Dim right As New StringFormat
        Dim center As New StringFormat
        Dim left As New StringFormat
        Dim ReceiptNo As Integer = txtRecNo.Text
        Dim Cashier As String = cmbCashier.SelectedItem.ToString()
        Dim selectedDate As DateTime = dtpDate.Value
        Dim Payment As Integer = txtPayment.Text
        Dim Balance As Integer = txtBalance.Text

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center
        left.Alignment = StringAlignment.Near

        Dim Rect1 As New Rectangle(5, 5, 240, 17)
        Dim Rect2 As New Rectangle(5, 22, 240, 17)
        Dim Rect3 As New Rectangle(5, 39, 240, 17)
        Dim Rect4 As New Rectangle(5, 56, 240, 17)
        Dim Rect5 As New Rectangle(5, 73, 240, 17)
        Dim Rect6 As New Rectangle(5, 90, 240, 17)
        Dim Rect7 As New Rectangle(5, 107, 240, 17)

        e.Graphics.DrawRectangle(Pens.Black, Rect1)
        e.Graphics.DrawRectangle(Pens.Black, Rect2)
        e.Graphics.DrawRectangle(Pens.Black, Rect3)
        e.Graphics.DrawRectangle(Pens.Black, Rect4)
        e.Graphics.DrawRectangle(Pens.Black, Rect5)
        e.Graphics.DrawRectangle(Pens.Black, Rect6)
        e.Graphics.DrawRectangle(Pens.Black, Rect7)

        e.Graphics.DrawString("Atrium", f2b, Brushes.Black, Rect1, center)
        e.Graphics.DrawString("Atrium, Mahena road,Horana", f1, Brushes.Black, Rect2, center)
        e.Graphics.DrawString("atrium@gmail.com", f1, Brushes.Black, Rect3, center)
        e.Graphics.DrawString("0713929683", f1, Brushes.Black, Rect4, center)
        e.Graphics.DrawString("Receipt No : " & ReceiptNo, f1, Brushes.Black, Rect5, left)
        e.Graphics.DrawString("Cashier : " & Cashier, f1, Brushes.Black, Rect6, left)
        e.Graphics.DrawString("Date : " & selectedDate, f1, Brushes.Black, Rect7, left)


        Dim Rect8 As New Rectangle(5, 141, 60, 17)
        Dim Rect9 As New Rectangle(65, 141, 60, 17)
        Dim Rect10 As New Rectangle(125, 141, 60, 17)
        Dim Rect11 As New Rectangle(185, 141, 60, 17)

        e.Graphics.DrawRectangle(Pens.Black, Rect8)
        e.Graphics.DrawRectangle(Pens.Black, Rect9)
        e.Graphics.DrawRectangle(Pens.Black, Rect10)
        e.Graphics.DrawRectangle(Pens.Black, Rect11)


        e.Graphics.DrawString("Code", f1b, Brushes.Black, Rect8, center)
        e.Graphics.DrawString("Quantity", f1b, Brushes.Black, Rect9, center)
        e.Graphics.DrawString("Unit price", f1b, Brushes.Black, Rect10, center)
        e.Graphics.DrawString("Sum", f1b, Brushes.Black, Rect11, center)

        Dim Rect12 As New Rectangle(5, 158, 60, 17)
        Dim Rect13 As New Rectangle(65, 158, 60, 17)
        Dim Rect14 As New Rectangle(125, 158, 60, 17)
        Dim Rect15 As New Rectangle(185, 158, 60, 17)

        e.Graphics.DrawRectangle(Pens.Black, Rect12)
        e.Graphics.DrawRectangle(Pens.Black, Rect13)
        e.Graphics.DrawRectangle(Pens.Black, Rect14)
        e.Graphics.DrawRectangle(Pens.Black, Rect15)

        e.Graphics.DrawString(dgvSales.Rows(0).Cells(0).Value, f1, Brushes.Black, Rect12, center)
        e.Graphics.DrawString(dgvSales.Rows(0).Cells(1).Value, f1, Brushes.Black, Rect13, center)
        e.Graphics.DrawString(dgvSales.Rows(0).Cells(2).Value, f1, Brushes.Black, Rect14, center)
        e.Graphics.DrawString(dgvSales.Rows(0).Cells(1).Value * dgvSales.Rows(0).Cells(2).Value, f1, Brushes.Black, Rect15, center)

        Dim y As Integer = 158
        Dim total As Decimal = 0


        For i = 0 To dgvSales.Rows.Count - 1

            Dim Rect16 As New Rectangle(5, y, 60, 17)
            Dim Rect17 As New Rectangle(65, y, 60, 17)
            Dim Rect18 As New Rectangle(125, y, 60, 17)
            Dim Rect19 As New Rectangle(185, y, 60, 17)

            e.Graphics.DrawRectangle(Pens.Black, Rect16)
            e.Graphics.DrawRectangle(Pens.Black, Rect17)
            e.Graphics.DrawRectangle(Pens.Black, Rect18)
            e.Graphics.DrawRectangle(Pens.Black, Rect19)

            e.Graphics.DrawString(dgvSales.Rows(i).Cells(0).Value, f1, Brushes.Black, Rect16, center)
            e.Graphics.DrawString(dgvSales.Rows(i).Cells(1).Value, f1, Brushes.Black, Rect17, center)
            e.Graphics.DrawString(dgvSales.Rows(i).Cells(2).Value, f1, Brushes.Black, Rect18, center)
            e.Graphics.DrawString(dgvSales.Rows(i).Cells(1).Value * dgvSales.Rows(i).Cells(2).Value, f1, Brushes.Black, Rect19, center)

            y += 17
            total += dgvSales.Rows(i).Cells(1).Value * dgvSales.Rows(i).Cells(2).Value

        Next

        Dim Rect20 As New Rectangle(5, y, 240, 17)
        e.Graphics.DrawRectangle(Pens.Black, Rect20)
        e.Graphics.DrawString("Total : " & "Rs. " & total, f1b, Brushes.Black, Rect20, left)

        Dim Rect21 As New Rectangle(5, y + 17, 240, 17)
        e.Graphics.DrawRectangle(Pens.Black, Rect21)
        e.Graphics.DrawString("Payment : " & "Rs. " & Payment, f1b, Brushes.Black, Rect21, left)

        Dim Rect22 As New Rectangle(5, y + 34, 240, 17)
        e.Graphics.DrawRectangle(Pens.Black, Rect22)
        e.Graphics.DrawString("Balance : " & "Rs. " & Balance, f1b, Brushes.Black, Rect22, left)

        Dim Rect23 As New Rectangle(5, y + 68, 240, 17)
        e.Graphics.DrawRectangle(Pens.Black, Rect23)
        e.Graphics.DrawString("Thank you, Visit Again!", f1, Brushes.Black, Rect23, center)

        Dim x As Integer = 20
        Dim z As Integer = Me.Height - barcode.Height
        e.Graphics.DrawImage(barcode.Image, x, z)

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Validation part
        Dim ReceiptNo As String = txtRecNo.Text.Trim()
        Dim Cashier As String = cmbCashier.Text.Trim()
        Dim Dates As String = dtpDate.Value.ToString().Trim()
        Dim Total As String = txtCalculate.Text.Trim()
        Dim Payment As String = txtPayment.Text.Trim()
        Dim Balance As String = txtBalance.Text.Trim()

        If ReceiptNo = "" OrElse Cashier = "" OrElse Dates = "" OrElse Total = "" OrElse Payment = "" OrElse Balance = "" Then
            MessageBox.Show("Please enter all required fields.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub ' Exit the subroutine if validation fails
        End If

        Dim selectedDate As Date = dtpDate.Value.Date
        Dim today As Date = DateTime.Today
        If selectedDate > today Then
            MessageBox.Show("Please enter correct date.", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpDate.Value = today
            Exit Sub
        End If

        If Payment < 0 Then
            MessageBox.Show("Negative values are not allowed.", "Invalid payment", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPayment.Focus()
            Exit Sub
        End If

        'Print part
        Dialog.Document = Document
        Dialog.ShowDialog()
    End Sub

    Private Sub labelExit_Click(sender As Object, e As EventArgs) Handles labelExit.Click
        Application.Exit()
    End Sub

    Private Sub lblHome_Click(sender As Object, e As EventArgs) Handles lblHome.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
    End Sub



    Public Sub save()
        'Validation part
        Dim ReceiptNo As String = txtRecNo.Text.Trim()
        Dim Cashier As String = cmbCashier.Text.Trim()
        Dim Dates As String = dtpDate.Value.ToString().Trim()
        Dim Total As String = txtCalculate.Text.Trim()
        Dim Payment As String = txtPayment.Text.Trim()
        Dim Balance As String = txtBalance.Text.Trim()

        If ReceiptNo = "" OrElse Cashier = "" OrElse Dates = "" OrElse Total = "" OrElse Payment = "" OrElse Balance = "" Then
            MessageBox.Show("Please enter all required fields.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub ' Exit the subroutine if validation fails
        End If

        Dim selectedDate As Date = dtpDate.Value.Date
        Dim today As Date = DateTime.Today
        If selectedDate > today Then
            MessageBox.Show("Please enter correct date.", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpDate.Value = today
            Exit Sub
        End If

        If Payment < 0 Then
            MessageBox.Show("Negative values are not allowed.", "Invalid payment", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Save part
        Try
            conn.Open()
            For Each row As DataGridViewRow In dgvSales.Rows
                If Not row.IsNewRow Then
                    Dim cmd As New MySqlCommand("INSERT INTO `sales`(`ReceiptNo`, `Cashier`, `Date`, `Code`, `Quantity`, `UnitPrice`, `Sum`, `Total`, `Payment`, `Balance`) VALUES (@ReceiptNo, @Cashier, @Date, @Code, @Quantity, @UnitPrice, @Sum, @Total, @Payment, @Balance)", conn)
                    cmd.Parameters.AddWithValue("@ReceiptNo", txtRecNo.Text)
                    cmd.Parameters.AddWithValue("@Cashier", cmbCashier.Text)
                    cmd.Parameters.AddWithValue("@Date", CDate(dtpDate.Text))
                    cmd.Parameters.AddWithValue("Code", row.Cells("Column1").Value)
                    cmd.Parameters.AddWithValue("Quantity", row.Cells("Column2").Value)
                    cmd.Parameters.AddWithValue("UnitPrice", row.Cells("Column3").Value)
                    cmd.Parameters.AddWithValue("Sum", row.Cells("Column2").Value * row.Cells("Column3").Value)
                    cmd.Parameters.AddWithValue("@Total", txtCalculate.Text)
                    cmd.Parameters.AddWithValue("@Payment", txtPayment.Text)
                    cmd.Parameters.AddWithValue("@Balance", txtBalance.Text)
                    cmd.ExecuteNonQuery()
                End If
            Next
            MessageBox.Show("Successfully saved !", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Save failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub clear()
        txtRecNo.Clear()
        cmbCashier.Text = ""
        dtpDate.Value = Now
        dgvSales.Rows.Clear()
        txtCalculate.Clear()
        txtPayment.Clear()
        txtBalance.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        delete()
    End Sub

    Public Sub delete()
        If MsgBox("Are you sure you want to delete this record ?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `sales` WHERE `ReceiptNo`=@ReceiptNo", conn)
                MessageBox.Show("Successfully deleted !", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ReceiptNo", txtRecNo.Text)
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

    'Calculate total
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim totalBill As Decimal = 0
        For Each row As DataGridViewRow In dgvSales.Rows
            If Not row.IsNewRow Then
                Dim unitPrice As Decimal = Convert.ToDecimal(row.Cells("Column3").Value)
                Dim quantity As Integer = Convert.ToInt32(row.Cells("Column2").Value)
                Dim totalPrice As Decimal = unitPrice * quantity
                totalBill += totalPrice
            End If
        Next
        txtCalculate.Text = totalBill
    End Sub

    'Calculate balance
    Private Sub btnBalance_Click(sender As Object, e As EventArgs) Handles btnBalance.Click
        Dim Payment As Decimal = txtPayment.Text
        Dim totalBill As Decimal = txtCalculate.Text
        If Decimal.TryParse(txtPayment.Text, Payment) Then
            Dim Balance As Decimal = Payment - totalBill
            txtBalance.Text = Balance
        Else
            MessageBox.Show("Please enter a valid payment amount.")
        End If
    End Sub

    'Minimize the window
    Private Sub lblMin_Click(sender As Object, e As EventArgs) Handles lblMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class