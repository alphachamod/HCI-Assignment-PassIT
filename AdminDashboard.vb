Imports FontAwesome.Sharp

Public Class AdminDashboard
    Private currentBtn As IconButton

    Private currentChildForm As Form

    'Constructor'
    Public Sub New()

        ' This call is required by the designer.'
        InitializeComponent()

        'Form'
        Me.Text = String.Empty
        Me.ControlBox = True
        ' Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

    End Sub

    'Methods'
    Private Sub ActivateButton(senderBtn As Object)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(255, 255, 255)
            currentBtn.ForeColor = Color.Black
            currentBtn.IconColor = Color.Black
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage




        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 40, 51)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
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


        CurrentLabel.Text = "Home"
    End Sub

    Private Sub main_interface_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btn_profile_Click(sender As Object, e As EventArgs) Handles btn_profile.Click
        ActivateButton(sender)
        OpenChildForm(adminOverview)
    End Sub

    Private Sub btn_book_Click(sender As Object, e As EventArgs) Handles btn_book.Click
        ActivateButton(sender)
        OpenChildForm(adminStudents)
    End Sub

    Private Sub btn_lessons_Click(sender As Object, e As EventArgs) Handles btn_lessons.Click
        ActivateButton(sender)
        OpenChildForm(adminLessons)
    End Sub

    Private Sub btn_instructors_Click(sender As Object, e As EventArgs) Handles btn_instructors.Click
        ActivateButton(sender)
        OpenChildForm(adminTimetable)
    End Sub

    Private Sub btn_passplus_Click(sender As Object, e As EventArgs) Handles btn_passplus.Click
        ActivateButton(sender)
        OpenChildForm(adminStaff)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
        OpenChildForm(adminOverview)
    End Sub



    Private Sub IconPictureBox6_Click(sender As Object, e As EventArgs) Handles IconPictureBox6.Click
        OpenChildForm(Settings)
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        ActivateButton(sender)
        OpenChildForm(adminVehicle)
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        OpenChildForm(adminOverview)
    End Sub
End Class