Public Class main_interface

    Private Sub main_interface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundButton(btn_profile)
    End Sub
    Private Sub RoundButton(btn As Button)


        Dim radius As New Drawing2D.GraphicsPath
        radius.StartFigure()

        'TOP LEFT
        radius.AddArc(New Rectangle(0, 0, 60, 60), 180, 90)
        radius.AddLine(60, 0, btn.Width - 60, 0)

        'TOP RIGHT
        radius.AddArc(New Rectangle(btn.Width - 60, 0, 60, 60), -90, 90)
        radius.AddLine(btn.Width, 60, btn.Width, btn.Height - 60)

        'BOTTOM RIGHT
        radius.AddArc(New Rectangle(btn.Width - 60, btn.Height - 60, 60, 60), 0, 90)
        radius.AddLine(btn.Width - 60, btn.Height, 60, btn.Height)

        'BOTTOM LEFT
        radius.AddArc(New Rectangle(0, btn.Height - 60, 60, 60), 90, 90)
        radius.CloseFigure()



        btn_profile.Region = New Region(radius)
        btn_book.Region = New Region(radius)
        btn_lessons.Region = New Region(radius)
        btn_passplus.Region = New Region(radius)
        btn_instructors.Region = New Region(radius)
        'btn_faq.Region = New Region(radius)
        'btn_logout.Region = New Region(radius)
        'btn_help.Region = New Region(radius)

    End Sub


End Class