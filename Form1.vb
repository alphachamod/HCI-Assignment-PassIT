Public Class Form1
    ' ErrorProvider for null validation
    Private errorProvider As New ErrorProvider()

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Clear any previous error messages
        errorProvider.Clear()

        ' Get entered username and password
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Check for null or empty values
        If String.IsNullOrEmpty(username) Then
            errorProvider.SetError(txtUsername, "Username is required.")
            Return
        End If

        If String.IsNullOrEmpty(password) Then
            errorProvider.SetError(txtPassword, "Password is required.")
            Return
        End If

        ' Check for specific username and password combinations
        If username.ToLower() = "chamod" AndAlso password = "chamod" Then
            ' Redirect to main_interface.vb
            Dim mainInterfaceForm As New main_interface()
            mainInterfaceForm.Show()
            Me.Hide()
        ElseIf username.ToLower() = "admin" AndAlso password = "admin" Then
            ' Redirect to adminDashboard.vb
            Dim adminDashboardForm As New AdminDashboard()
            adminDashboardForm.Show()
            Me.Hide()
        Else
            ' Show an error message for invalid credentials
            MessageBox.Show("Invalid username or password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the ErrorProvider settings
        errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
        errorProvider.SetIconAlignment(txtUsername, ErrorIconAlignment.MiddleRight)
        errorProvider.SetIconAlignment(txtPassword, ErrorIconAlignment.MiddleRight)
    End Sub
End Class
