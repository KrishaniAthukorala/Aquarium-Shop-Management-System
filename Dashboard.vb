Public Class Dashboard
    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        If Form1.cmbUser.SelectedItem.ToString() = "  Employee" Then
            btnEmployee.Enabled = False
            MessageBox.Show("Employees can not login to the employee form.", "Checked", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.Hide()
            Employee.Show()
        End If
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        If Form1.cmbUser.SelectedItem.ToString() = "  Employee" Then
            btnEmployee.Enabled = False
            MessageBox.Show("Employees can not login to the supplier form.", "Checked", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.Hide()
            Supplier.Show()
        End If
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Me.Hide()
        Customer.Show()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Me.Hide()
        Sales.Show()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Me.Hide()
        Inventory.Show()
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Me.Hide()
        Maintenance.Show()
    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Me.Hide()
        Form1.Show()
    End Sub

    'Update employee count
    Private Sub UpdateTotalEmployees()
        Dim totalEmployee As Integer = Employee.dgvEmployee.Rows.Count
        If Employee.dgvEmployee.AllowUserToAddRows AndAlso totalEmployee > 0 Then
            totalEmployee -= 1
        End If
        txtEmployees.Text = totalEmployee.ToString()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTotalEmployees()
        AddHandler Employee.dgvEmployee.RowsAdded, AddressOf dgvEmployee_RowsChanged
        AddHandler Employee.dgvEmployee.RowsRemoved, AddressOf dgvEmployee_RowsChanged

        UpdateInventoryCounts()
        AddHandler Inventory.dgvInventory.RowsAdded, AddressOf dgvInventory_RowsChanged
        AddHandler Inventory.dgvInventory.RowsRemoved, AddressOf dgvInventory_RowsChanged

        UpdateTotalSuppliers()
        AddHandler Supplier.dgvSupplier.RowsAdded, AddressOf dgvSupplier_RowsChanged
        AddHandler Supplier.dgvSupplier.RowsRemoved, AddressOf dgvSupplier_RowsChanged

        UpdateTotalCustomers()
        AddHandler Customer.dgvCustomer.RowsAdded, AddressOf dgvCustomer_RowsChanged
        AddHandler Customer.dgvCustomer.RowsRemoved, AddressOf dgvCustomer_RowsChanged
    End Sub

    Private Sub dgvEmployee_RowsChanged(sender As Object, e As DataGridViewRowsAddedEventArgs)
        UpdateTotalEmployees()
    End Sub

    Private Sub dgvEmployee_RowsChanged(sender As Object, e As DataGridViewRowsRemovedEventArgs)
        UpdateTotalEmployees()
    End Sub

    'Update inventory count
    Private Sub UpdateInventoryCounts()
        Dim fishCount As Integer = 0
        Dim plantsCount As Integer = 0
        Dim equipmentCount As Integer = 0
        Dim foodCount As Integer = 0
        Dim medicineCount As Integer = 0

        ' Iterate through each row in the DataGridView
        For Each row As DataGridViewRow In Inventory.dgvInventory.Rows
            ' Ensure the row is not a new row
            If Not row.IsNewRow Then
                ' Check the value of the first column
                Dim itemType As String = row.Cells("Column1").Value.ToString()

                If itemType IsNot Nothing Then
                    Select Case itemType
                        Case "Fish"
                            fishCount += 1
                        Case "Plant"
                            plantsCount += 1
                        Case "Equipment"
                            equipmentCount += 1
                        Case "Food"
                            foodCount += 1
                        Case "Medicine"
                            medicineCount += 1
                    End Select
                End If
            End If
        Next

        'Update the TextBoxes with the counts
        txtFish.Text = fishCount.ToString()
        txtPlants.Text = plantsCount.ToString()
        txtEquipments.Text = equipmentCount.ToString()
        txtFood.Text = foodCount.ToString()
        txtMedicine.Text = medicineCount.ToString()
    End Sub

    Private Sub dgvInventory_RowsChanged(sender As Object, e As DataGridViewRowsAddedEventArgs)
        UpdateInventoryCounts()
    End Sub

    Private Sub dgvInventory_RowsChanged(sender As Object, e As DataGridViewRowsRemovedEventArgs)
        UpdateInventoryCounts()
    End Sub

    'Update supplier count
    Private Sub UpdateTotalSuppliers()
        Dim totalSupplier As Integer = Supplier.dgvSupplier.Rows.Count
        If Supplier.dgvSupplier.AllowUserToAddRows AndAlso totalSupplier > 0 Then
            totalSupplier -= 1
        End If
        txtSuppliers.Text = totalSupplier.ToString()
    End Sub

    Private Sub dgvSupplier_RowsChanged(sender As Object, e As DataGridViewRowsAddedEventArgs)
        UpdateTotalSuppliers()
    End Sub

    Private Sub dgvSupplier_RowsChanged(sender As Object, e As DataGridViewRowsRemovedEventArgs)
        UpdateTotalSuppliers()
    End Sub

    'Update customer count
    Private Sub UpdateTotalCustomers()
        Dim totalCustomer As Integer = Customer.dgvCustomer.Rows.Count
        If Customer.dgvCustomer.AllowUserToAddRows AndAlso totalCustomer > 0 Then
            totalCustomer -= 1
        End If
        txtCustomers.Text = totalCustomer.ToString()
    End Sub

    Private Sub dgvCustomer_RowsChanged(sender As Object, e As DataGridViewRowsAddedEventArgs)
        UpdateTotalCustomers()
    End Sub

    Private Sub dgvCustomer_RowsChanged(sender As Object, e As DataGridViewRowsRemovedEventArgs)
        UpdateTotalCustomers()
    End Sub

    'Minimize the window
    Private Sub lblMin_Click(sender As Object, e As EventArgs) Handles lblMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class