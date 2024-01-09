Imports System.Diagnostics.Metrics
Imports System.Text.RegularExpressions

Public Class ticket

    Private errorProvider As New ErrorProvider()
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click


        ' Clear previous error messages
        errorProvider.Clear()

        ' Perform null validation
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            ' Display error icon and message using ErrorProvider
            errorProvider.SetError(txtName, "Please enter your name.")
            Return
        End If

        If Not IsValidEmail(txtEmail.Text) Then
            ' Display error icon and message using ErrorProvider
            errorProvider.SetError(txtEmail, "Please enter a valid email address.")
            Return
        End If

        If Not IsValidPhoneNumber(txtPhone.Text) Then
            ' Display error icon and message using ErrorProvider
            errorProvider.SetError(txtPhone, "Please enter a valid phone number.")
            Return
        End If

        If cmbLevel.SelectedIndex = -1 Then
            ' Display error icon and message using ErrorProvider
            errorProvider.SetError(cmbLevel, "Please select a level.")
            Return
        End If

        If cmbReason.SelectedIndex = -1 Then
            ' Display error icon and message using ErrorProvider
            errorProvider.SetError(cmbReason, "Please select a reason.")
            Return
        End If

        If String.IsNullOrWhiteSpace(rtbDescribe.Text) Then
            ' Display error icon and message using ErrorProvider
            errorProvider.SetError(rtbDescribe, "Please describe your reason.")
            Return
        End If


        'Display a success message
        'MessageBox.Show("Form submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        contact_success.Show()
        ' Reset the form after submission
        ResetForm()


    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        ' Use a simple regular expression to validate email format
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        ' Explanation: 
        ' ^: Asserts the start of the string.
        ' [a-zA-Z0-9._%+-]+: Matches one or more characters that can be letters, digits, dots, underscores, percent signs, plus signs, or hyphens.
        ' @: Matches the at symbol.
        ' [a-zA-Z0-9.-]+: Matches one or more characters that can be letters, digits, dots, or hyphens.
        ' \.: Escapes the dot to match a literal dot.
        ' [a-zA-Z]{2,}: Matches two or more characters that must be letters.
        ' $: Asserts the end of the string.
        Dim isValid As Boolean = Regex.IsMatch(email, emailPattern)

        ' Display error icon and message using ErrorProvider if email is not valid
        If Not isValid Then
            errorProvider.SetError(txtEmail, "Please enter a valid email address.")
        End If
        Return isValid
    End Function

    Private Function IsValidPhoneNumber(phoneNumber As String) As Boolean
        ' Use a simple regular expression to validate phone number format
        Dim phonePattern As String = "^\d{10}$"
        ' Explanation:
        ' ^: Asserts the start of the string.
        ' \d{10}: Matches exactly 10 digits (0-9).
        ' $: Asserts the end of the string.
        Dim isValid As Boolean = Regex.IsMatch(phoneNumber, phonePattern)

        ' Display error icon and message using ErrorProvider if phone number is not valid
        If Not isValid Then
            errorProvider.SetError(txtPhone, "Please enter a valid phone number.")
        End If

        Return isValid
    End Function
    Private Sub ResetForm()
        ' Clear all input fields
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        cmbLevel.SelectedIndex = -1
        cmbReason.SelectedIndex = -1
        rtbDescribe.Clear()

        ' Clear error messages
        errorProvider.Clear()
    End Sub
    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        ' Allow digits and control keys (backspace, delete)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Display error message using MessageBox
            MessageBox.Show("Only numeric characters are allowed for the phone number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Suppress the character input
            e.Handled = True
        End If
    End Sub
    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        Me.Hide()
    End Sub
    Private Sub IconPictureBox5_Click(sender As Object, e As EventArgs) Handles IconPictureBox5.Click
        Me.Hide()
    End Sub
End Class