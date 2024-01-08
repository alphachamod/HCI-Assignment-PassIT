<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lesson_details_intro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lesson_details_intro))
        TabControl1 = New TabControl()
        TabPage2 = New TabPage()
        Label8 = New Label()
        BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Label9 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Label10 = New Label()
        PictureBox2 = New PictureBox()
        TabPage1 = New TabPage()
        Label11 = New Label()
        Label2 = New Label()
        IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Label27 = New Label()
        TabControl1.SuspendLayout()
        TabPage2.SuspendLayout()
        BunifuCards1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TabPage1.SuspendLayout()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(12, 104)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1056, 460)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(BunifuCards1)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(Label1)
        TabPage2.Controls.Add(Label10)
        TabPage2.Controls.Add(PictureBox2)
        TabPage2.Location = New Point(4, 32)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1048, 424)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Session 1"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(26, 217)
        Label8.Name = "Label8"
        Label8.Size = New Size(233, 31)
        Label8.TabIndex = 90
        Label8.Text = "Instructor Comments"
        ' 
        ' BunifuCards1
        ' 
        BunifuCards1.BackColor = Color.White
        BunifuCards1.BorderRadius = 5
        BunifuCards1.BottomSahddow = True
        BunifuCards1.BottomShadow = True
        BunifuCards1.color = Color.Tomato
        BunifuCards1.Controls.Add(Label9)
        BunifuCards1.IndicatorColor = Color.Tomato
        BunifuCards1.LeftSahddow = False
        BunifuCards1.LeftShadow = False
        BunifuCards1.Location = New Point(98, 261)
        BunifuCards1.Name = "BunifuCards1"
        BunifuCards1.RightSahddow = True
        BunifuCards1.RightShadow = True
        BunifuCards1.ShadowDepth = 20
        BunifuCards1.Size = New Size(885, 122)
        BunifuCards1.TabIndex = 89
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(31, 25)
        Label9.Name = "Label9"
        Label9.Size = New Size(334, 23)
        Label9.TabIndex = 1
        Label9.Text = "Student completed the lesson successfully"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.SpringGreen
        Label7.Location = New Point(782, 142)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 31)
        Label7.TabIndex = 88
        Label7.Text = "100%"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.SpringGreen
        Label6.Location = New Point(782, 108)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 31)
        Label6.TabIndex = 87
        Label6.Text = "100%"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.SpringGreen
        Label5.Location = New Point(782, 72)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 31)
        Label5.TabIndex = 86
        Label5.Text = "100%"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(141, 147)
        Label4.Name = "Label4"
        Label4.Size = New Size(335, 25)
        Label4.TabIndex = 85
        Label4.Text = "2. Learn the purpose of primary controls."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(141, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(300, 25)
        Label3.TabIndex = 84
        Label3.Text = "2. Familiarize with the cockpit layout."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(26, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 31)
        Label1.TabIndex = 83
        Label1.Text = "Sub Lessons"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ButtonHighlight
        Label10.Location = New Point(141, 78)
        Label10.Name = "Label10"
        Label10.Size = New Size(329, 25)
        Label10.TabIndex = 83
        Label10.Text = "1. Understand the basic vehicle controls."
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(246, 179)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(585, 37)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 87
        PictureBox2.TabStop = False
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        TabPage1.Controls.Add(Label11)
        TabPage1.Location = New Point(4, 32)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1048, 424)
        TabPage1.TabIndex = 2
        TabPage1.Text = "Session 2"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ButtonHighlight
        Label11.Location = New Point(371, 185)
        Label11.Name = "Label11"
        Label11.Size = New Size(317, 38)
        Label11.TabIndex = 0
        Label11.Text = "2nd Session Not Needed."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Light", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(12, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(373, 50)
        Label2.TabIndex = 84
        Label2.Text = "Introduction to Driving"
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
        IconPictureBox5.Location = New Point(1018, 39)
        IconPictureBox5.Name = "IconPictureBox5"
        IconPictureBox5.Size = New Size(40, 40)
        IconPictureBox5.TabIndex = 86
        IconPictureBox5.TabStop = False
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Cursor = Cursors.Hand
        Label27.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = SystemColors.ButtonHighlight
        Label27.Location = New Point(899, 42)
        Label27.Name = "Label27"
        Label27.Size = New Size(113, 31)
        Label27.TabIndex = 85
        Label27.Text = "GO BACK"
        ' 
        ' lesson_details_intro
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(35))
        ClientSize = New Size(1080, 576)
        Controls.Add(IconPictureBox5)
        Controls.Add(Label27)
        Controls.Add(Label2)
        Controls.Add(TabControl1)
        Name = "lesson_details_intro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lesson Details"
        TabControl1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        BunifuCards1.ResumeLayout(False)
        BunifuCards1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
End Class
