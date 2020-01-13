
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
'Imports MySql.Data.MySqlClient




'Inherits System.Windows.Forms.Form

Public Class Form1

    Private Sub CreatePointsAndSizes(ByVal e As PaintEventArgs)

        ' Create the starting point.
        Dim startPoint As New Point(subtractButton.Size)

        ' Use the addition operator to get the end point.
        Dim endPoint As Point = Point.op_Addition(startPoint,
        New Size(140, 150))

        ' Draw a line between the points.
        e.Graphics.DrawLine(SystemPens.Highlight, startPoint, endPoint)

        ' Convert the starting point to a size and compare it to the
        ' subtractButton size.  
        Dim buttonSize As Size = Point.op_Explicit(startPoint)
        If (Size.op_Equality(buttonSize, subtractButton.Size)) Then

            ' If the sizes are equal, tell the user.
            e.Graphics.DrawString("The sizes are equal.",
            New Font(Me.Font, FontStyle.Italic),
            Brushes.Indigo, 10.0F, 65.0F)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreatePointsAndSizes(e)
    End Sub
End Class