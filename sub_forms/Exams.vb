Public Class Exams
    ' Public property to access lblAttempts


    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles applybtn.Click
        eligibilty_confirmation.Show()
        lblAttempts.Text = "Attempted"
    End Sub
End Class