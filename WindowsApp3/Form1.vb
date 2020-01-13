Imports System.Drawing.Drawing2D
Imports System
Public Class Form1 : Inherits System.Windows.Forms.Form

    Private rectGrille As Rectangle

    Public Sub New()

        ' Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

        '-------------------coords winform(origine top, left) ----------
        Me.Text = "Coords Panel :" & Me.PanelSF.Location.X.ToString & " , " & Me.PanelSF.Location.Y.ToString
        Me.Font = New Font("tahoma", 12)

        '-------------------coords panel (origine centre panel ) ----------
        rectGrille = New Rectangle(0, 0, 0, 0)

        Me.PanelSF.Dock = DockStyle.Fill

        '-----------------------mets à jour l'affiche sur resizin du form-----------------------
        Me.ResizeRedraw = True

    End Sub

    'dessine un grid sur le panel
    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelSF.Paint
        e.Graphics.Clear(Color.White)
        'rectangle client panel 
        Dim tempRect As Rectangle = Me.PanelSF.ClientRectangle

        'inflate  veut dire"reduire" les 2 dimensions de -20,-20 ou "dilater" de 20,20  
        tempRect.Inflate(-20, -20)
        rectGrille = tempRect
        'dessine bord rectangulaire de la grille(coords par rapport au form 20,20)
        e.Graphics.DrawRectangle(Pens.Black, rectGrille)


        ' dessine grille de points espace de 15,15 pixels  
        ControlPaint.DrawGrid(e.Graphics, rectGrille, New Size(3, 3), Color.White)

        'dessine une croix au centre du rectangule de la grille
        Dim penCroix As Pen = New Pen(Color.Brown, 1.0)
        penCroix.EndCap = Drawing2D.LineCap.ArrowAnchor
        penCroix.Alignment = Drawing2D.PenAlignment.Center

        'ligne horizont.
        e.Graphics.DrawLine(penCroix, New Point(rectGrille.Left, rectGrille.Top + rectGrille.Height / 2), New Point(rectGrille.Left + rectGrille.Width, rectGrille.Top + rectGrille.Height / 2))
        'ligne verticale.
        e.Graphics.DrawLine(penCroix, New Point(rectGrille.Left + rectGrille.Width / 2, rectGrille.Top), New Point(rectGrille.Left + rectGrille.Width / 2, rectGrille.Bottom))

        penCroix.Dispose()
    End Sub
    '"tracke"  position du cursor sur panel
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelSF.MouseMove

        Me.Text = "Coords Panel :" & e.Location.X.ToString & " , " & e.Location.Y.ToString

        Me.Text = Me.Text & " Coords Grid :" & (e.Location.X - rectGrille.Top - rectGrille.Width / 2).ToString & " , " & (e.Location.Y - rectGrille.Top - rectGrille.Height / 2).ToString

    End Sub

    Public Sub DrawLinePointF(ByVal e As PaintEventArgs)

        ' Create pen.
        Dim blackPen As New Pen(Color.Black, 3)

        ' Create points that define line.
        Dim point1 As New PointF(100.0F, 100.0F)
        Dim point2 As New PointF(500.0F, 100.0F)

        ' Draw line to screen.
        e.Graphics.DrawLine(blackPen, point1, point2)
    End Sub

    Public Sub DrawLineInt(ByVal e As PaintEventArgs)

        ' Create pen.
        Dim blackPen As New Pen(Color.Black, 3)

        ' Create coordinates of points that define line.
        Dim x1 As Integer = 100
        Dim y1 As Integer = 100
        Dim x2 As Integer = 500
        Dim y2 As Integer = 100

        ' Draw line to screen.
        e.Graphics.DrawLine(blackPen, x1, y1, x2, y2)
    End Sub

    Public Sub DrawLineFloat(ByVal e As PaintEventArgs)

        ' Create pen.
        Dim blackPen As New Pen(Color.Black, 3)

        ' Create coordinates of points that define line.
        Dim x1 As Single = 100.0F
        Dim y1 As Single = 100.0F
        Dim x2 As Single = 500.0F
        Dim y2 As Single = 100.0F

        ' Draw line to screen.
        e.Graphics.DrawLine(blackPen, x1, y1, x2, y2)
    End Sub
End Class