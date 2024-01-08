Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class RoundedTextBox
    Inherits TextBox

    Private Const WM_PAINT As Integer = &HF

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
    End Function

    Private Sub SetRoundRectRegion()
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(0, 0, 20, 20, 180, 90)
        path.AddArc(Me.Width - 20, 0, 20, 20, -90, 90)
        path.AddArc(Me.Width - 20, Me.Height - 20, 20, 20, 0, 90)
        path.AddArc(0, Me.Height - 20, 20, 20, 90, 90)
        Me.Region = New Region(path)
    End Sub

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        SetRoundRectRegion()
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        SetRoundRectRegion()
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        If m.Msg = WM_PAINT Then
            Using g As Graphics = Graphics.FromHwnd(Handle)
                g.Clear(BackColor)
            End Using
        End If
    End Sub
End Class
