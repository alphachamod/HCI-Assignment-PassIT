Imports System.Diagnostics.Metrics

Public Class date_time

    Private errorProvider As New ErrorProvider()
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click


        ' Validate the date
        If bookingdate.Value = DateTime.MinValue Then
            ' Display error message for null expiry date
            errorProvider.SetError(bookingdate, "Booking Date is required.")
        ElseIf bookingdate.Value < DateTime.Now Then
            ' Display error message for expired card
            MessageBox.Show("Please Select a valid date", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        ' Check if the required textboxes are empty
        If bookingtime.SelectedItem Is Nothing Then
            ' Display error message for Time
            errorProvider.SetError(bookingtime, "Time is required.")
            bookingtime.Focus()
        End If



        ' Check if any error messages are displayed
        If errorProvider.GetError(bookingdate) <> "" OrElse
            errorProvider.GetError(bookingtime) <> "" Then

            ' Display an error message if any of the required fields are empty
            MessageBox.Show("Please check again the required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Display success message if all required fields are filled
            MessageBox.Show("Redirecting to Checkout", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            checkout_page.Show()
        End If

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        Me.Hide()
    End Sub

    Private Sub IconPictureBox5_Click(sender As Object, e As EventArgs) Handles IconPictureBox5.Click
        Me.Hide()
    End Sub
End Class