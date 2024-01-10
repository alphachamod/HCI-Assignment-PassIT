Imports System.Management
Imports System.Text.RegularExpressions

Public Class adminAddStudent

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

        ' Validate Username textbox
        If IsControlEmpty(txtUsername) Then
            errorProvider.SetError(txtUsername, "Username cannot be empty.")
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

        ' Validate TempPassword textbox
        If IsControlEmpty(txtTempPassword) Then
            errorProvider.SetError(txtTempPassword, "Temporary Password cannot be empty.")
        End If


        ' Validate Address textbox
        If IsControlEmpty(txtAddress) Then
            errorProvider.SetError(txtAddress, "Contact Number cannot be empty.")
        End If
        ' Validate Type combobox
        If cboType.SelectedIndex = -1 Then
            errorProvider.SetError(cboType, "Please select a type.")
        End If

        ' Validate Level combobox
        If cboLevel.SelectedIndex = -1 Then
            errorProvider.SetError(cboLevel, "Please select a level.")
        End If

        ' Validate Status combobox
        If cboStatus.SelectedIndex = -1 Then
            errorProvider.SetError(cboStatus, "Please select a status.")
        End If

        ' Validate Vehicle Type listbox
        If lstVehicleType.SelectedItems.Count = 0 Then
            errorProvider.SetError(lstVehicleType, "Please select at least one vehicle type.")
        End If

        ' Validate Currently Active listbox
        If lstCurrentlyActive.SelectedItems.Count = 0 Then
            errorProvider.SetError(lstCurrentlyActive, "Please select at least one active status.")
        End If

        ' Check if any errors occurred
        If errorProvider.GetError(txtName) <> "" OrElse
                errorProvider.GetError(txtUsername) <> "" OrElse
                errorProvider.GetError(txtEmail) <> "" OrElse
                errorProvider.GetError(txtTempPassword) <> "" OrElse
                errorProvider.GetError(txtContactNumber) <> "" OrElse
                errorProvider.GetError(txtAddress) <> "" OrElse
                errorProvider.GetError(cboType) <> "" OrElse
                errorProvider.GetError(cboLevel) <> "" OrElse
                errorProvider.GetError(cboStatus) <> "" OrElse
                errorProvider.GetError(lstVehicleType) <> "" OrElse
                errorProvider.GetError(lstCurrentlyActive) <> "" Then
            ' Display a message if there are validation errors
            MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Validation successful, perform further actions or submit data
            MessageBox.Show("Student Added Successfully. Password Reset Link has been sent to the entered email: " & txtEmail.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Reset the form
            ResetForm()
        End If
    End Sub

    ' Event handler for the button click (assuming you have a button for submission)
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ValidateControls()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Call the function to generate a temporary password
        Dim tempPassword As String = GenerateRandomPassword()

        ' Set the generated temporary password in the TempPassword textbox
        txtTempPassword.Text = tempPassword

        ' Display a message indicating that the password has been generated and set
        MessageBox.Show($"Generated and Set Temporary Password: {tempPassword}", "Temporary Password Generated", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    ' Function to generate a random temporary password
    Private Function GenerateRandomPassword() As String
        ' Define the characters to use in the temporary password
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_=+"

        ' Define the length of the temporary password
        Dim passwordLength As Integer = 8 ' Adjust as needed

        ' Create a StringBuilder to store the temporary password
        Dim tempPasswordBuilder As New System.Text.StringBuilder()

        ' Create a Random object
        Dim rand As New Random()

        ' Generate random characters to create the temporary password
        For i As Integer = 1 To passwordLength
            Dim randomIndex As Integer = rand.Next(0, allowedChars.Length)
            tempPasswordBuilder.Append(allowedChars(randomIndex))
        Next

        ' Return the generated temporary password
        Return tempPasswordBuilder.ToString()

    End Function

    Private Sub ResetForm()
        ' Clear the form controls
        txtName.Clear()
        txtUsername.Clear()
        txtEmail.Clear()
        txtTempPassword.Clear()
        txtContactNumber.Clear()
        txtAddress.Clear()
        cboType.SelectedIndex = -1
        cboLevel.SelectedIndex = -1
        cboStatus.SelectedIndex = -1
        lstVehicleType.ClearSelected()
        lstCurrentlyActive.ClearSelected()

        ' Clear the error provider
        errorProvider.Clear()
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        Me.Hide()
    End Sub

    Private Sub IconPictureBox5_Click(sender As Object, e As EventArgs) Handles IconPictureBox5.Click
        Me.Hide()
    End Sub
End Class