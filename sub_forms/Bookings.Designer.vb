<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bookings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bookings))
        BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        BunifuCards5 = New Bunifu.Framework.UI.BunifuCards()
        BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Label22 = New Label()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Label1 = New Label()
        Label2 = New Label()
        BunifuCards1.SuspendLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BunifuCards1
        ' 
        BunifuCards1.BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        BunifuCards1.BorderRadius = 50
        BunifuCards1.BottomSahddow = False
        BunifuCards1.BottomShadow = False
        BunifuCards1.color = Color.Transparent
        BunifuCards1.Controls.Add(Label2)
        BunifuCards1.Controls.Add(Label1)
        BunifuCards1.Controls.Add(IconPictureBox1)
        BunifuCards1.IndicatorColor = Color.Transparent
        BunifuCards1.LeftSahddow = False
        BunifuCards1.LeftShadow = False
        BunifuCards1.Location = New Point(12, 12)
        BunifuCards1.Name = "BunifuCards1"
        BunifuCards1.RightSahddow = True
        BunifuCards1.RightShadow = True
        BunifuCards1.ShadowDepth = 20
        BunifuCards1.Size = New Size(406, 171)
        BunifuCards1.TabIndex = 0
        ' 
        ' BunifuCards3
        ' 
        BunifuCards3.BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        BunifuCards3.BorderRadius = 50
        BunifuCards3.BottomSahddow = False
        BunifuCards3.BottomShadow = False
        BunifuCards3.color = Color.Transparent
        BunifuCards3.IndicatorColor = Color.Transparent
        BunifuCards3.LeftSahddow = False
        BunifuCards3.LeftShadow = False
        BunifuCards3.Location = New Point(430, 12)
        BunifuCards3.Name = "BunifuCards3"
        BunifuCards3.RightSahddow = True
        BunifuCards3.RightShadow = True
        BunifuCards3.ShadowDepth = 20
        BunifuCards3.Size = New Size(319, 171)
        BunifuCards3.TabIndex = 2
        ' 
        ' BunifuCards4
        ' 
        BunifuCards4.BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        BunifuCards4.BorderRadius = 50
        BunifuCards4.BottomSahddow = False
        BunifuCards4.BottomShadow = False
        BunifuCards4.color = Color.Transparent
        BunifuCards4.IndicatorColor = Color.Transparent
        BunifuCards4.LeftSahddow = False
        BunifuCards4.LeftShadow = False
        BunifuCards4.Location = New Point(759, 12)
        BunifuCards4.Name = "BunifuCards4"
        BunifuCards4.RightSahddow = True
        BunifuCards4.RightShadow = True
        BunifuCards4.ShadowDepth = 20
        BunifuCards4.Size = New Size(310, 171)
        BunifuCards4.TabIndex = 3
        ' 
        ' BunifuCards5
        ' 
        BunifuCards5.BackColor = Color.AliceBlue
        BunifuCards5.BorderRadius = 50
        BunifuCards5.BottomSahddow = False
        BunifuCards5.BottomShadow = False
        BunifuCards5.color = Color.Transparent
        BunifuCards5.IndicatorColor = Color.Transparent
        BunifuCards5.LeftSahddow = False
        BunifuCards5.LeftShadow = False
        BunifuCards5.Location = New Point(1137, 12)
        BunifuCards5.Name = "BunifuCards5"
        BunifuCards5.RightSahddow = True
        BunifuCards5.RightShadow = True
        BunifuCards5.ShadowDepth = 20
        BunifuCards5.Size = New Size(310, 171)
        BunifuCards5.TabIndex = 4
        ' 
        ' BunifuFlatButton1
        ' 
        BunifuFlatButton1.Active = False
        BunifuFlatButton1.Activecolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.BackColor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.BackgroundImageLayout = ImageLayout.Stretch
        BunifuFlatButton1.BorderRadius = 0
        BunifuFlatButton1.ButtonText = "Book Now"
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
        BunifuFlatButton1.Location = New Point(868, 672)
        BunifuFlatButton1.Margin = New Padding(4, 5, 4, 5)
        BunifuFlatButton1.Name = "BunifuFlatButton1"
        BunifuFlatButton1.Normalcolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.OnHovercolor = Color.FromArgb(CByte(36), CByte(129), CByte(77))
        BunifuFlatButton1.OnHoverTextColor = Color.White
        BunifuFlatButton1.selected = False
        BunifuFlatButton1.Size = New Size(200, 92)
        BunifuFlatButton1.TabIndex = 5
        BunifuFlatButton1.Text = "Book Now"
        BunifuFlatButton1.TextAlign = ContentAlignment.MiddleLeft
        BunifuFlatButton1.Textcolor = Color.White
        BunifuFlatButton1.TextFont = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ' 
        ' BunifuCards2
        ' 
        BunifuCards2.BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        BunifuCards2.BorderRadius = 5
        BunifuCards2.BottomSahddow = True
        BunifuCards2.BottomShadow = True
        BunifuCards2.color = Color.Gold
        BunifuCards2.IndicatorColor = Color.Gold
        BunifuCards2.LeftSahddow = False
        BunifuCards2.LeftShadow = False
        BunifuCards2.Location = New Point(12, 287)
        BunifuCards2.Name = "BunifuCards2"
        BunifuCards2.RightSahddow = True
        BunifuCards2.RightShadow = True
        BunifuCards2.ShadowDepth = 20
        BunifuCards2.Size = New Size(826, 477)
        BunifuCards2.TabIndex = 6
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ButtonHighlight
        Label22.Location = New Point(12, 220)
        Label22.Name = "Label22"
        Label22.Size = New Size(137, 38)
        Label22.TabIndex = 10
        Label22.Text = "LESSONS"
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        IconPictureBox1.ForeColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck
        IconPictureBox1.IconColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 65
        IconPictureBox1.Location = New Point(302, 52)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(65, 66)
        IconPictureBox1.TabIndex = 1
        IconPictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        Label1.Location = New Point(42, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 60)
        Label1.TabIndex = 11
        Label1.Text = "01"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(42, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 28)
        Label2.TabIndex = 12
        Label2.Text = "BOOKED LESSONS"
        ' 
        ' Bookings
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(11), CByte(11), CByte(11))
        ClientSize = New Size(1081, 778)
        Controls.Add(Label22)
        Controls.Add(BunifuCards2)
        Controls.Add(BunifuFlatButton1)
        Controls.Add(BunifuCards5)
        Controls.Add(BunifuCards4)
        Controls.Add(BunifuCards3)
        Controls.Add(BunifuCards1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Bookings"
        Text = "Bookings"
        BunifuCards1.ResumeLayout(False)
        BunifuCards1.PerformLayout()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards5 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label22 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
