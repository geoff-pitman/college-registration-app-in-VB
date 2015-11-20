'Project: Registration Application
'Author: Geoffrey Pitman
'Creation: September 30, 2014 
'Due Date: October 6, 2014 
'Course: CSC241 
'Professor Name: Prof. Day 
'File Name: frmRegistration.vb 
'Purpose: Contains the interface and routines for registering courses and calculating cost of tuition

Public Class frmRegistration

    'keeps track of total registered hours
    Dim totalHours As Double

    'Name: btnAdd_Click 
    'Purpose: adds course and hours to shopping cart 
    'Parameters: the button and the event 
    'Return: none
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If radNonresident.Checked = False And radResident.Checked = False Then
            'forces selection of resident status so btnAdd does NOT alter residency and btnReset DOES alter it
            MessageBox.Show("Select a resident status!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            grpProgram.Focus()
        ElseIf txtCourse.Text = "" Then
            MessageBox.Show("Enter a course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCourse.Focus()
        Else
            totalHours = totalHours + CDbl(cboHours.Text)
            txtTotalHours.Text = totalHours
            Dim frmtString As String = "{0,-25} {1,-3}"
            lstCart.Items.Add(String.Format(frmtString, txtCourse.Text, cboHours.Text))
            changeEnabled(True)
            clearInput()
        End If
    End Sub

    'Name: btnExit_Click 
    'Purpose: ends the program 
    'Parameters: the button and the event 
    'Return: none
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    'Name: btnFinalize_Click 
    'Purpose: outputs total hours, fees, tuition, and owed
    'Parameters: the button and the event 
    'Return: none
    Private Sub btnFinalize_Click(sender As Object, e As EventArgs) Handles btnFinalize.Click
        txtTotalFees.Text = FormatCurrency(calcFees())
        txtTotalTuition.Text = FormatCurrency(calcTuition(CDbl(txtTotalHours.Text)))
        txtTotalOwed.Text = FormatCurrency(CDbl(txtTotalFees.Text) + CDbl(txtTotalTuition.Text))
    End Sub

    'Name: btnRemove_Click 
    'Purpose: removes a selected item from the shopping cart and subtracts hours from total hours
    'Parameters: the button and the event 
    'Return: none
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If Not lstCart.SelectedIndex = -1 Then
            Dim listItem As String = lstCart.SelectedItem
            Dim listHours As String = listItem.Substring(26)
            listHours.Trim()
            totalHours -= CDbl(listHours)
            lstCart.Items.Remove(lstCart.SelectedItem)
            txtTotalHours.Text = totalHours
            If lstCart.Items.Count = 0 Then 'if all shopping cart items are removed the totals are automatically cleared
                changeEnabled(False)
                txtTotalHours.Clear()
                txtTotalFees.Clear()
                txtTotalTuition.Clear()
                txtTotalOwed.Clear()
            End If
        Else
            MessageBox.Show("Select a Shopping Cart item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lstCart.Focus()
        End If
    End Sub

    'Name: btnReset_Click 
    'Purpose: resets all selections, inputs and values
    'Parameters: the button and the event 
    'Return: none
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        clearInput()
        lstCart.Items.Clear()
        changeEnabled(False)
        txtTotalHours.Clear()
        txtTotalFees.Clear()
        txtTotalTuition.Clear()
        txtTotalOwed.Clear()
        totalHours = 0
        radNonresident.Checked = False
        radResident.Checked = False
        chkFirsttime.Checked = False
    End Sub

    'Name: calcFees
    'Purpose: calculates fees associated with residency and first time student status
    'Parameters: none
    'Return: total fees
    Private Function calcFees() As Double
        If chkFirsttime.Checked = True And radResident.Checked = True Then
            Return 1098.6 + 238
        ElseIf chkFirsttime.Checked = False And radResident.Checked = True Then
            Return 1098.6
        ElseIf chkFirsttime.Checked = True And radNonresident.Checked = True Then
            Return 1193.6 + 238
        Else
            Return 1193.6
        End If
    End Function

    'Name: calcTuition
    'Purpose: calculates tuition 
    'Parameters: total hours 
    'Return: total tuition
    Private Function calcTuition(ByVal totalHours As Double) As Double
        If (totalHours >= 12 And totalHours <= 18) And radResident.Checked = True Then
            Return 3311
        ElseIf totalHours < 12 And radResident.Checked = True Then
            Return totalHours * 276
        ElseIf totalHours > 18 And radResident.Checked = True Then
            Return 3311 + ((totalHours - 18) * 276)
        ElseIf totalHours < 12 And radResident.Checked = True Then
            Return totalHours * 276
        ElseIf (totalHours >= 12 And totalHours <= 18) And radNonresident.Checked = True Then
            Return 8278
        ElseIf totalHours < 12 And radNonresident.Checked = True Then
            Return totalHours * 690
        ElseIf totalHours > 18 And radNonresident.Checked = True Then
            Return 8278 + ((totalHours - 18) * 690)
        Else
            Return totalHours * 690
        End If
    End Function

    'Name: changeEnabled 
    'Purpose: enable/disable specified buttons
    'Parameters: boolean value 
    'Return: none
    Private Sub changeEnabled(ByVal state As Boolean)
        btnFinalize.Enabled = state
        btnRemove.Enabled = state
        btnReset.Enabled = state
    End Sub

    'Name: clearInput
    'Purpose: clears input
    'Parameters: none
    'Return: none
    Private Sub clearInput()
        txtCourse.Clear()
        cboHours.Text = 3
        txtCourse.Focus()
    End Sub

    'Name: frmRegistration_Load 
    'Purpose: sets specifications of form on load
    'Parameters: the button and the event 
    'Return: none
    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load
        changeEnabled(False)
        totalHours = 0
        cboHours.Text = 3
    End Sub

End Class
