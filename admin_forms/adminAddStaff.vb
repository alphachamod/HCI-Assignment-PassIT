Imports System.Management
Imports System.Text.RegularExpressions
Imports System.IO

Public Class adminAddStaff


    ' Create an instance of ErrorProvider
    Dim errorProvider As New ErrorProvider()

    ' Function to validate if a control is empty
    Private Function IsControlEmpty(control As Control) As Boolean
        Return String.IsNullOrWhiteSpace(control.Text)
    End Function

    ' Function to validate email format
    Private Function IsValidEmail(email As String) As Boolean
        Dim emailRegex As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
        Return emailRegex.IsMatch(email)
    End Function

    ' Function to validate phone number format
    Private Function IsValidPhoneNumber(phoneNumber As String) As Boolean
        ' Check if the phone number has exactly 10 digits
        Return phoneNumber.Length = 10 AndAlso IsNumeric(phoneNumber)
    End Function


    ' Event handler for validating controls on button click or any other event
    Private Sub ValidateControls()
        ' Clear previous error messages
        errorProvider.Clear()

        ' Validate Name textbox
        If IsControlEmpty(txtName) Then
            errorProvider.SetError(txtName, "Name cannot be empty.")
        End If


        ' Validate Email textbox
        If IsControlEmpty(txtEmail) Then
            errorProvider.SetError(txtEmail, "Email cannot be empty.")
        ElseIf Not IsValidEmail(txtEmail.Text) Then
            errorProvider.SetError(txtEmail, "Invalid email format.")
        End If

        ' Validate Contact Number textbox
        If IsControlEmpty(txtContactNumber) Then
            errorProvider.SetError(txtContactNumber, "Contact Number cannot be empty.")
        ElseIf Not IsValidPhoneNumber(txtContactNumber.Text) Then
            errorProvider.SetError(txtContactNumber, "Invalid phone number format.")
        End If

        ' Validate Level combobox
        If cboLevel.SelectedIndex = -1 Then
            errorProvider.SetError(cboLevel, "Please select a level.")
        End If


        ' Check if any errors occurred
        If errorProvider.GetError(txtName) <> "" OrElse
                errorProvider.GetError(txtEmail) <> "" OrElse
                errorProvider.GetError(txtContactNumber) <> "" OrElse
                errorProvider.GetError(cboLevel) <> "" Then
            ' Display a message if there are validation errors
            MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Validation successful, perform further actions or submit data
            MessageBox.Show("Staff Added Successfully.  ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Reset the form
            ResetForm()
        End If
    End Sub




    Private Sub ResetForm()
        ' Clear the form controls
        txtName.Clear()
        txtEmail.Clear()
        txtContactNumber.Clear()
        cboLevel.SelectedIndex = -1

        ' Clear the error provider
        errorProvider.Clear()
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        Me.Hide()
    End Sub

    Private Sub IconPictureBox5_Click(sender As Object, e As EventArgs) Handles IconPictureBox5.Click
        Me.Hide()
    End Sub

    ' Event handler for the button click 

    Private Sub btnSubmit_Click_1(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ValidateControls()
    End Sub
End Class