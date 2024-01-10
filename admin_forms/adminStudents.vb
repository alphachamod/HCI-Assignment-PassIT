Public Class adminStudents
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        adminPastStudentList.Show()
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        adminStudentPerformance.Show()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        adminAddStudent.Show()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        adminEditStudent.Show()
    End Sub
End Class