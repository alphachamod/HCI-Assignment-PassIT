<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class date_time
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(date_time))
        bookingdate = New DateTimePicker()
        Label22 = New Label()
        Label1 = New Label()
        bookingtime = New ComboBox()
        BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Label27 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' bookingdate
        ' 
        bookingdate.Cursor = Cursors.Hand
        bookingdate.Format = DateTimePickerFormat.Short
        bookingdate.Location = New Point(344, 91)
        bookingdate.Name = "bookingdate"
        bookingdate.Size = New Size(151, 27)
        bookingdate.TabIndex = 0
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI Light", 13.8F)
        Label22.ForeColor = SystemColors.ButtonHighlight
        Label22.Location = New Point(96, 89)
        Label22.Name = "Label22"
        Label22.Size = New Size(169, 31)
        Label22.TabIndex = 12
        Label22.Text = "Select your date"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Light", 13.8F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(96, 142)
        Label1.Name = "Label1"
        Label1.Size = New Size(218, 31)
        Label1.TabIndex = 13
        Label1.Text = "Select preferred time"
        ' 
        ' bookingtime
        ' 
        bookingtime.Cursor = Cursors.Hand
        bookingtime.FormattingEnabled = True
        bookingtime.Items.AddRange(New Object() {"08.30 AM", "09.30 AM", "10.30 AM", "11.30 AM", "12.30 PM", "12.45 PM", "01.30 PM", "02.30 PM", "03.30 PM", "04.30 PM", "05.30 PM"})
        bookingtime.Location = New Point(344, 147)
        bookingtime.Name = "bookingtime"
        bookingtime.Size = New Size(151, 28)
        bookingtime.TabIndex = 14
        ' 
        ' BunifuFlatButton1
        ' 
        BunifuFlatButton1.Active = False
        BunifuFlatButton1.Activecolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.BackColor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.BackgroundImageLayout = ImageLayout.Stretch
        BunifuFlatButton1.BorderRadius = 0
        BunifuFlatButton1.ButtonText = "                   Checkout"
        BunifuFlatButton1.DisabledColor = Color.Gray
        BunifuFlatButton1.Iconcolor = Color.Transparent
        BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), Image)
        BunifuFlatButton1.Iconimage_right = Nothing
        BunifuFlatButton1.Iconimage_right_Selected = Nothing
        BunifuFlatButton1.Iconimage_Selected = Nothing
        BunifuFlatButton1.IconMarginLeft = 0
        BunifuFlatButton1.IconMarginRight = 0
        BunifuFlatButton1.IconRightVisible = True
        BunifuFlatButton1.IconRightZoom = 0R
        BunifuFlatButton1.IconVisible = True
        BunifuFlatButton1.IconZoom = 90R
        BunifuFlatButton1.IsTab = False
        BunifuFlatButton1.Location = New Point(88, 198)
        BunifuFlatButton1.Margin = New Padding(4, 5, 4, 5)
        BunifuFlatButton1.Name = "BunifuFlatButton1"
        BunifuFlatButton1.Normalcolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.OnHovercolor = Color.FromArgb(CByte(36), CByte(129), CByte(77))
        BunifuFlatButton1.OnHoverTextColor = Color.White
        BunifuFlatButton1.selected = False
        BunifuFlatButton1.Size = New Size(407, 69)
        BunifuFlatButton1.TabIndex = 15
        BunifuFlatButton1.Text = "                   Checkout"
        BunifuFlatButton1.TextAlign = ContentAlignment.MiddleLeft
        BunifuFlatButton1.Textcolor = Color.White
        BunifuFlatButton1.TextFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        IconPictureBox5.Location = New Point(463, 23)
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
        Label27.Location = New Point(344, 23)
        Label27.Name = "Label27"
        Label27.Size = New Size(113, 31)
        Label27.TabIndex = 61
        Label27.Text = "GO BACK"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' date_time
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        ClientSize = New Size(591, 301)
        Controls.Add(IconPictureBox5)
        Controls.Add(Label27)
        Controls.Add(BunifuFlatButton1)
        Controls.Add(bookingtime)
        Controls.Add(Label1)
        Controls.Add(Label22)
        Controls.Add(bookingdate)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "date_time"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pick Date and Time"
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bookingdate As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bookingtime As ComboBox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
