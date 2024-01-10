Imports System.Management
Imports System.Text.RegularExpressions

Public Class adminAddLesson
    ' Create an instance of ErrorProvider
    Dim errorProvider As New ErrorProvider()

    ' Function to validate if a control is empty
    Private Function IsControlEmpty(control As Control) As Boolean
        Return String.IsNullOrWhiteSpace(control.Text)
    End Function


    ' Event handler for validating controls on button click or any other event
    Private Sub ValidateControls()
        ' Clear previous error messages
        errorProvider.Clear()

        ' Validate Name textbox
        If IsControlEmpty(txtName) Then
            errorProvider.SetError(txtName, "Name cannot be empty.")
        End If

        ' Validate Price textbox
        If IsControlEmpty(txtPrice) Then
            errorProvider.SetError(txtPrice, "Price cannot be empty.")
        End If
        ' Validate Desc textbox
        If IsControlEmpty(desc) Then
            errorProvider.SetError(desc, "Description cannot be empty.")
        End If

        ' Validate Type combobox
        If cboType.SelectedIndex = -1 Then
            errorProvider.SetError(cboType, "Please select a type.")
        End If

        ' Validate Level combobox
        If cboLevel.SelectedIndex = -1 Then
            errorProvider.SetError(cboLevel, "Please select a level.")
        End If

        ' Check if any errors occurred
        If errorProvider.GetError(txtName) <> "" OrElse
                errorProvider.GetError(desc) <> "" OrElse
                errorProvider.GetError(txtPrice) <> "" OrElse
                errorProvider.GetError(txtPrice) <> "" OrElse
                errorProvider.GetError(cboType) <> "" OrElse
                errorProvider.GetError(txtPrice) <> "" OrElse
                errorProvider.GetError(cboLevel) <> "" Then
            ' Display a message if there are validation errors
            MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Validation successful, perform further actions or submit data
            MessageBox.Show("Lesson Added Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Reset the form
            ResetForm()
        End If
    End Sub

    ' Event handler for the button click (assuming you have a button for submission)
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ValidateControls()

    End Sub

    Private Sub ResetForm()
        ' Clear the form controls
        txtName.Clear()
        txtPrice.Clear()
        desc.Clear()
        cboType.SelectedIndex = -1
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
End Class