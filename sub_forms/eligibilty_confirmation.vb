Imports System.Diagnostics
Public Class eligibilty_confirmation

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If AllItemsChecked(CheckedListBox1) Then
            Dim url As String = "https://apply-provisional-driving-licence.service.gov.uk"

            ' Use ProcessStartInfo to specify that the URL is not a file path
            Dim psi As New ProcessStartInfo With {
                .FileName = url,
                .UseShellExecute = True
            }
            MessageBox.Show("You will be redirected to the government website where you will complete the application.", "Redirecting", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Open the URL in the default web browser
            Process.Start(psi)
            Me.Hide()

        Else
            MessageBox.Show("Please check that you meet all the conditions before proceeding")
        End If
    End Sub


    Private Function AllItemsChecked(checkedListBox As CheckedListBox) As Boolean
        For Each itemIndex As Integer In Enumerable.Range(0, checkedListBox.Items.Count)
            If Not checkedListBox.GetItemChecked(itemIndex) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        Me.Hide()
    End Sub

    Private Sub IconPictureBox5_Click(sender As Object, e As EventArgs) Handles IconPictureBox5.Click
        Me.Hide()
    End Sub
End Class