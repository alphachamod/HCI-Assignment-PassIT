<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminPastStudentList
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
        ListBox1 = New ListBox()
        VScrollBar1 = New VScrollBar()
        Label3 = New Label()
        IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Label27 = New Label()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Items.AddRange(New Object() {"Ashley Turner - January 8, 2023 - Grade: B", "Ryan Mitchell - February 14, 2023 - Grade: A", "Lauren Carter - March 21, 2023 - Grade: C", "Brandon Foster - April 5, 2023 - Grade: A", "Mia Robinson - May 12, 2023 - Grade: B", "Caleb Parker - June 30, 2023 - Grade: C", "Zoey Adams - July 17, 2023 - Grade: A", "Elijah Wright - August 9, 2023 - Grade: B", "Sophia Lewis - September 4, 2023 - Grade: C", "Daniel White - October 22, 2023 - Grade: B", "Aria Martinez - November 15, 2023 - Grade: A", "Lucas Harrison - December 3, 2023 - Grade: C", "Lily Bennett - January 14, 2023 - Grade: A", "Logan Thompson - February 8, 2023 - Grade: B", "Grace Turner - March 2, 2023 - Grade: C", "Noah Carter - April 12, 2023 - Grade: A", "Ava Foster - May 25, 2023 - Grade: B", "Ethan Robinson - June 7, 2023 - Grade: C", "Olivia Adams - July 19, 2023 - Grade: A", "Mason Wright - August 5, 2023 - Grade: B", "Emma Lewis - September 16, 2023 - Grade: C", "Alexander White - October 10, 2023 - Grade: A", "Chloe Martinez - November 29, 2023 - Grade: B", "Samuel Harrison - December 20, 2023 - Grade: C", "Natalie Bennett - January 3, 2023 - Grade: A", "Jackson Thompson - February 18, 2023 - Grade: B", "Hailey Turner - March 9, 2023 - Grade: C", "Zachary Foster - April 30, 2023 - Grade: A", "Sarah Robinson - May 8, 2023 - Grade: B", "Christopher Carter - June 26, 2023 - Grade: C"})
        ListBox1.Location = New Point(34, 108)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(731, 424)
        ListBox1.TabIndex = 0
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Location = New Point(739, 108)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(26, 424)
        VScrollBar1.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(34, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(288, 62)
        Label3.TabIndex = 16
        Label3.Text = "Past Students"
        ' 
        ' IconPictureBox5
        ' 
        IconPictureBox5.BackColor = Color.Transparent
        IconPictureBox5.Cursor = Cursors.Hand
        IconPictureBox5.ForeColor = Color.DimGray
        IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile
        IconPictureBox5.IconColor = Color.DimGray
        IconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox5.IconSize = 40
        IconPictureBox5.Location = New Point(736, 24)
        IconPictureBox5.Name = "IconPictureBox5"
        IconPictureBox5.Size = New Size(40, 40)
        IconPictureBox5.TabIndex = 64
        IconPictureBox5.TabStop = False
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Cursor = Cursors.Hand
        Label27.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = SystemColors.ActiveCaptionText
        Label27.Location = New Point(619, 25)
        Label27.Name = "Label27"
        Label27.Size = New Size(113, 31)
        Label27.TabIndex = 63
        Label27.Text = "GO BACK"
        ' 
        ' adminPastStudentList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(821, 567)
        Controls.Add(IconPictureBox5)
        Controls.Add(Label27)
        Controls.Add(Label3)
        Controls.Add(VScrollBar1)
        Controls.Add(ListBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "adminPastStudentList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "adminPastStudentList"
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents Label3 As Label
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label27 As Label
End Class
