<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ticket
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ticket))
        IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Label27 = New Label()
        Label22 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        cmbLevel = New ComboBox()
        cmbReason = New ComboBox()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        rtbDescribe = New RichTextBox()
        Label5 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        btnSubmit = New Bunifu.Framework.UI.BunifuFlatButton()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        Label6 = New Label()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' IconPictureBox5
        ' 
        IconPictureBox5.BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        IconPictureBox5.Cursor = Cursors.Hand
        IconPictureBox5.ForeColor = Color.Gainsboro
        IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile
        IconPictureBox5.IconColor = Color.Gainsboro
        IconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox5.IconSize = 40
        IconPictureBox5.Location = New Point(1012, 31)
        IconPictureBox5.Name = "IconPictureBox5"
        IconPictureBox5.Size = New Size(40, 40)
        IconPictureBox5.TabIndex = 62
        IconPictureBox5.TabStop = False
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Cursor = Cursors.Hand
        Label27.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = SystemColors.ButtonHighlight
        Label27.Location = New Point(893, 34)
        Label27.Name = "Label27"
        Label27.Size = New Size(113, 31)
        Label27.TabIndex = 61
        Label27.Text = "GO BACK"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI Light", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ButtonHighlight
        Label22.Location = New Point(30, 34)
        Label22.Name = "Label22"
        Label22.Size = New Size(306, 60)
        Label22.TabIndex = 63
        Label22.Text = "RAISE A TIKCET"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Light", 10.8F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(110, 179)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 25)
        Label1.TabIndex = 65
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Light", 10.8F)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(110, 239)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 25)
        Label2.TabIndex = 67
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Light", 10.8F)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(113, 360)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 25)
        Label3.TabIndex = 69
        Label3.Text = "Level"
        ' 
        ' cmbLevel
        ' 
        cmbLevel.BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        cmbLevel.ForeColor = SystemColors.Info
        cmbLevel.FormattingEnabled = True
        cmbLevel.Items.AddRange(New Object() {"Introductory", "Standard", "PassPlus"})
        cmbLevel.Location = New Point(115, 388)
        cmbLevel.Name = "cmbLevel"
        cmbLevel.Size = New Size(361, 28)
        cmbLevel.TabIndex = 70
        ' 
        ' cmbReason
        ' 
        cmbReason.BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        cmbReason.ForeColor = SystemColors.Info
        cmbReason.FormattingEnabled = True
        cmbReason.Items.AddRange(New Object() {"General Inquiry", "Technical Support", "Billing and Payment", "Account Assistance", "Product Feedback", "Bug Report", "Partnership Opportunities", "Media and Press Inquiries", "Privacy Concerns", "Accessibility Feedback", "Request for Information", "Marketing and Promotions", "Employment Opportunities", "Website Feedback", "Other"})
        cmbReason.Location = New Point(115, 449)
        cmbReason.Name = "cmbReason"
        cmbReason.Size = New Size(361, 28)
        cmbReason.TabIndex = 72
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Light", 10.8F)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(110, 421)
        Label4.Name = "Label4"
        Label4.Size = New Size(192, 25)
        Label4.TabIndex = 71
        Label4.Text = "Please select the reason"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(523, 207)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 270)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 73
        PictureBox1.TabStop = False
        ' 
        ' rtbDescribe
        ' 
        rtbDescribe.BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        rtbDescribe.ForeColor = SystemColors.ButtonHighlight
        rtbDescribe.Location = New Point(671, 208)
        rtbDescribe.Name = "rtbDescribe"
        rtbDescribe.Size = New Size(361, 277)
        rtbDescribe.TabIndex = 74
        rtbDescribe.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Light", 10.8F)
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(671, 179)
        Label5.Name = "Label5"
        Label5.Size = New Size(199, 25)
        Label5.TabIndex = 75
        Label5.Text = "Describe your Issue Here"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Active = False
        btnSubmit.Activecolor = Color.RoyalBlue
        btnSubmit.BackColor = Color.RoyalBlue
        btnSubmit.BackgroundImageLayout = ImageLayout.Stretch
        btnSubmit.BorderRadius = 7
        btnSubmit.ButtonText = "      Submit Ticket"
        btnSubmit.Cursor = Cursors.Hand
        btnSubmit.DisabledColor = Color.Gray
        btnSubmit.Iconcolor = Color.Transparent
        btnSubmit.Iconimage = CType(resources.GetObject("btnSubmit.Iconimage"), Image)
        btnSubmit.Iconimage_right = Nothing
        btnSubmit.Iconimage_right_Selected = Nothing
        btnSubmit.Iconimage_Selected = Nothing
        btnSubmit.IconMarginLeft = 0
        btnSubmit.IconMarginRight = 0
        btnSubmit.IconRightVisible = True
        btnSubmit.IconRightZoom = 0R
        btnSubmit.IconVisible = True
        btnSubmit.IconZoom = 90R
        btnSubmit.IsTab = False
        btnSubmit.Location = New Point(671, 505)
        btnSubmit.Margin = New Padding(4, 5, 4, 5)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Normalcolor = Color.RoyalBlue
        btnSubmit.OnHovercolor = Color.CornflowerBlue
        btnSubmit.OnHoverTextColor = Color.White
        btnSubmit.selected = False
        btnSubmit.Size = New Size(361, 66)
        btnSubmit.TabIndex = 76
        btnSubmit.Text = "      Submit Ticket"
        btnSubmit.TextAlign = ContentAlignment.MiddleLeft
        btnSubmit.Textcolor = Color.White
        btnSubmit.TextFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        txtName.ForeColor = SystemColors.ButtonHighlight
        txtName.Location = New Point(115, 207)
        txtName.Name = "txtName"
        txtName.Size = New Size(361, 27)
        txtName.TabIndex = 77
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        txtEmail.ForeColor = SystemColors.ButtonHighlight
        txtEmail.Location = New Point(115, 267)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(361, 27)
        txtEmail.TabIndex = 78
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        txtPhone.ForeColor = SystemColors.ButtonHighlight
        txtPhone.Location = New Point(115, 329)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(361, 27)
        txtPhone.TabIndex = 80
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Light", 10.8F)
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(110, 301)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 25)
        Label6.TabIndex = 79
        Label6.Text = "Phone"
        ' 
        ' ticket
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        ClientSize = New Size(1097, 670)
        Controls.Add(txtPhone)
        Controls.Add(Label6)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(btnSubmit)
        Controls.Add(Label5)
        Controls.Add(rtbDescribe)
        Controls.Add(PictureBox1)
        Controls.Add(cmbReason)
        Controls.Add(Label4)
        Controls.Add(cmbLevel)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label22)
        Controls.Add(IconPictureBox5)
        Controls.Add(Label27)
        FormBorderStyle = FormBorderStyle.None
        Name = "ticket"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ticket"
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbLevel As ComboBox
    Friend WithEvents cmbReason As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rtbDescribe As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnSubmit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label6 As Label
End Class
