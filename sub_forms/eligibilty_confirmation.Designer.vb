<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eligibilty_confirmation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(eligibilty_confirmation))
        Label29 = New Label()
        Label1 = New Label()
        BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        CheckedListBox1 = New CheckedListBox()
        IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Label27 = New Label()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label29.ForeColor = SystemColors.ButtonHighlight
        Label29.Location = New Point(30, 73)
        Label29.Name = "Label29"
        Label29.Size = New Size(545, 23)
        Label29.TabIndex = 106
        Label29.Text = "Please tick if you fulfil below conditions which are required to take the test"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Light", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(23, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(278, 54)
        Label1.TabIndex = 105
        Label1.Text = "Eligibility Check"
        ' 
        ' BunifuFlatButton1
        ' 
        BunifuFlatButton1.Active = False
        BunifuFlatButton1.Activecolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.BackColor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.BackgroundImageLayout = ImageLayout.Stretch
        BunifuFlatButton1.BorderRadius = 0
        BunifuFlatButton1.ButtonText = "I Understand and Comtinue"
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
        BunifuFlatButton1.Location = New Point(355, 330)
        BunifuFlatButton1.Margin = New Padding(4, 5, 4, 5)
        BunifuFlatButton1.Name = "BunifuFlatButton1"
        BunifuFlatButton1.Normalcolor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        BunifuFlatButton1.OnHovercolor = Color.FromArgb(CByte(36), CByte(129), CByte(77))
        BunifuFlatButton1.OnHoverTextColor = Color.White
        BunifuFlatButton1.selected = False
        BunifuFlatButton1.Size = New Size(401, 92)
        BunifuFlatButton1.TabIndex = 104
        BunifuFlatButton1.Text = "I Understand and Comtinue"
        BunifuFlatButton1.TextAlign = ContentAlignment.MiddleLeft
        BunifuFlatButton1.Textcolor = Color.White
        BunifuFlatButton1.TextFont = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        CheckedListBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckedListBox1.ForeColor = SystemColors.ButtonHighlight
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"Be at least 15 years and 9 months old", "Be able to read a number plate from 20 metres away", "Have been given permission to live in Great Britain for at least 185 days", "It costs £34 when you apply online"})
        CheckedListBox1.Location = New Point(44, 153)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(712, 149)
        CheckedListBox1.TabIndex = 103
        ' 
        ' IconPictureBox5
        ' 
        IconPictureBox5.BackColor = Color.Transparent
        IconPictureBox5.Cursor = Cursors.Hand
        IconPictureBox5.ForeColor = Color.Gainsboro
        IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile
        IconPictureBox5.IconColor = Color.Gainsboro
        IconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox5.IconSize = 40
        IconPictureBox5.Location = New Point(729, 24)
        IconPictureBox5.Name = "IconPictureBox5"
        IconPictureBox5.Size = New Size(40, 40)
        IconPictureBox5.TabIndex = 108
        IconPictureBox5.TabStop = False
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Cursor = Cursors.Hand
        Label27.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = SystemColors.ButtonHighlight
        Label27.Location = New Point(610, 27)
        Label27.Name = "Label27"
        Label27.Size = New Size(113, 31)
        Label27.TabIndex = 107
        Label27.Text = "GO BACK"
        ' 
        ' eligibilty_confirmation
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        ClientSize = New Size(800, 450)
        Controls.Add(IconPictureBox5)
        Controls.Add(Label27)
        Controls.Add(Label29)
        Controls.Add(Label1)
        Controls.Add(BunifuFlatButton1)
        Controls.Add(CheckedListBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "eligibilty_confirmation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Eligibility Confirmation"
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label29 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label27 As Label
End Class
