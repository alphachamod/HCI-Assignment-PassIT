Public Class Form1

    ' Dummy credentials
    Private Const CorrectUsername As String = "chamod"
    Private Const CorrectPassword As String = "chamod"

    Private errorProvider As New ErrorProvider()

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Clear previous error messages
        errorProvider.Clear()

        Dim enteredUsername As String = txtUsername.Text
        Dim enteredPassword As String = txtPassword.Text

        ' Validate that both username and password are not null or empty
        If String.IsNullOrEmpty(enteredUsername) Then
            errorProvider.SetError(txtUsername, "Please enter a username.")
            Return
        End If

        If String.IsNullOrEmpty(enteredPassword) Then
            errorProvider.SetError(txtPassword, "Please enter a password.")
            Return
        End If

        ' Continue with validation
        If ValidateCredentials(enteredUsername, enteredPassword) Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Navigate to the next form or perform other actions upon successful login
            Me.Hide()
            main_interface.Show()
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateCredentials(username As String, password As String) As Boolean
        ' Replace this logic with your actual validation logic
        Return username = CorrectUsername AndAlso password = CorrectPassword
    End Function
End Class
