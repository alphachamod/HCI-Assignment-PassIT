Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        MessageBox.Show("Login Success!")
        Me.Hide()
        main_interface.Show()
    End Sub
End Class
