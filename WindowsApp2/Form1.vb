Imports System.Drawing.Drawing2D

Public Class Form1

    Private Sub PanelSF_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim line As Graphics = Me.PanelSF.CreateGraphics
        Dim Pen As New Pen(Color.Black, 2)

        Pen.LineJoin = LineCap.ArrowAnchor
        Pen.EndCap = LineCap.ArrowAnchor

        line.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        line.DrawLine(Pen, 100, 0, 0, 30)
        line.DrawLine(Pen, 100, -5, 100, 60)
        line.DrawLine(Pen, 140, 140, 0, 140)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
