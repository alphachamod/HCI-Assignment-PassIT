Public Class checkout_page
    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        Me.Hide()
    End Sub

    Private Sub IconPictureBox5_Click(sender As Object, e As EventArgs) Handles IconPictureBox5.Click
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        MessageBox.Show("Payment Successfull! Booking Added!")
        Me.Hide()
        lesson_details_parking.Hide()
        lesson_details_intro.Hide()
        lesson_details_start.Hide()
    End Sub
End Class