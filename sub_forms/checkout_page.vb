Imports System.Net.NetworkInformation

Public Class checkout_page



    Private Sub txtCardNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles number_cc.KeyPress
        ' Allow only numeric input for the card number
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Only numbers are allowed in the Card Number field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub




    Private Sub cvv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cvv_cc.KeyPress
        ' Allow only numeric input for the card number
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Only numbers are allowed.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private errorProvider As New ErrorProvider()
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        errorProvider.Clear()

        ' Check if the required textboxes are empty
        If String.IsNullOrEmpty(country.Text) Then
            ' Display error message for Country
            errorProvider.SetError(country, "Country is required.")
        End If

        If String.IsNullOrEmpty(addressLine1.Text) Then
            ' Display error message for AddressLine1
            errorProvider.SetError(addressLine1, "Address Line 1 is required.")
        End If

        If String.IsNullOrEmpty(state.Text) Then
            ' Display error message for State
            errorProvider.SetError(state, "State is required.")
        End If

        If String.IsNullOrEmpty(postal_code.Text) Then
            ' Display error message for Postal Code
            errorProvider.SetError(postal_code, "Postal Code is required.")
        End If



        If String.IsNullOrEmpty(name_cc.Text) Then
            ' Display error message for Name on Card
            errorProvider.SetError(name_cc, "Name is required.")
        End If



        If String.IsNullOrEmpty(number_cc.Text) Then
            ' Display error message for Card Number
            errorProvider.SetError(number_cc, "Card Number is required.")
        ElseIf Not IsNumeric(number_cc.Text) OrElse number_cc.Text.Length <> 16 Then
            ' Display error message if Card Number is not numeric or not 16 digits
            errorProvider.SetError(number_cc, "Please enter a valid 16-digit card number.")
        End If


        If String.IsNullOrEmpty(cvv_cc.Text) Then
            ' Display error message for CVV
            errorProvider.SetError(cvv_cc, "CVV is required.")
        End If


        ' Validate expiry date
        If dtpExpiryDate.Value = DateTime.MinValue Then
            ' Display error message for null expiry date
            errorProvider.SetError(dtpExpiryDate, "Expiry Date is required.")
        ElseIf dtpExpiryDate.Value < DateTime.Now Then
            ' Display error message for expired card
            MessageBox.Show("Card has already expired.", "Expired Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        ' Check if any error messages are displayed
        If errorProvider.GetError(country) <> "" OrElse
           errorProvider.GetError(addressLine1) <> "" OrElse
            errorProvider.GetError(postal_code) <> "" OrElse
            errorProvider.GetError(name_cc) <> "" OrElse
            errorProvider.GetError(number_cc) <> "" OrElse
            errorProvider.GetError(cvv_cc) <> "" OrElse
            errorProvider.GetError(dtpExpiryDate) <> "" OrElse
            errorProvider.GetError(state) <> "" Then



            ' Display an error message if any of the required fields are empty
            MessageBox.Show("Please check again the required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Display success message if all required fields are filled
            MessageBox.Show("Payment Successfull! Booking Scheduled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            lesson_details_parking.Hide()
            lesson_details_intro.Hide()
            lesson_details_start.Hide()
        End If


    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        Me.Hide()
    End Sub

    Private Sub IconPictureBox5_Click(sender As Object, e As EventArgs) Handles IconPictureBox5.Click
        Me.Hide()
    End Sub
End Class