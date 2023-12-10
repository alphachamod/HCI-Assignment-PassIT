Imports FontAwesome.Sharp
Public Class main_interface


    Private currentBtn As IconButton

    Private currentChildForm As Form

    'Constructor'
    Public Sub New()

        ' This call is required by the designer.'
        InitializeComponent()

        'Form'
        Me.Text = String.Empty
        Me.ControlBox = True
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

    End Sub

    'Methods'
    Private Sub ActivateButton(senderBtn As Object)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(245, 127, 23)

            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            'current Form icon'
            Current_Icon.IconChar = currentBtn.IconChar


        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(241, 196, 15)
            currentBtn.ForeColor = Color.Black
            currentBtn.IconColor = Color.Black
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleCenter
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only form'

        ' If currentChildForm IsNot Nothing Then

        'currentChildForm.Close()
        ' End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        sub_form.Controls.Add(childForm)
        sub_form.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        CurrentLabel.Text = childForm.Text.ToUpper

    End Sub

    Private Sub Reset()
        DisableButton()

        Current_Icon.IconChar = IconChar.Home
        Current_Icon.IconColor = Color.FromArgb(245, 127, 23)
        CurrentLabel.Text = "Home"
    End Sub

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

    Private Sub btn_profile_Click(sender As Object, e As EventArgs) Handles btn_profile.Click
        ActivateButton(sender)
        OpenChildForm(Profile)
    End Sub

    Private Sub btn_book_Click(sender As Object, e As EventArgs) Handles btn_book.Click
        ActivateButton(sender)
        OpenChildForm(Bookings)
    End Sub

    Private Sub btn_lessons_Click(sender As Object, e As EventArgs) Handles btn_lessons.Click
        ActivateButton(sender)
        OpenChildForm(Lessons)
    End Sub

    Private Sub btn_instructors_Click(sender As Object, e As EventArgs) Handles btn_instructors.Click
        ActivateButton(sender)
        OpenChildForm(Instructors)
    End Sub

    Private Sub btn_passplus_Click(sender As Object, e As EventArgs) Handles btn_passplus.Click
        ActivateButton(sender)
        OpenChildForm(Passplus)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        OpenChildForm(Contact)
    End Sub

    Private Sub IconPictureBox6_Click(sender As Object, e As EventArgs) Handles IconPictureBox6.Click
        OpenChildForm(Settings)
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Application.Exit()
    End Sub
End Class