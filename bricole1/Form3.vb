Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
'Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Imports System

Public Class Form3

    Private rectGrille As Rectangle
    ' Private cpsGrille As Rectangle
    Private Sub Mapanel()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

        '-------------------coords winform(origine top, left) ----------
        Me.Text = "Coords Panel :" & Me.Panel1.Location.X.ToString & " , " & Me.Panel1.Location.Y.ToString
        Me.Font = New Font("tahoma", 12)

        '-------------------coords panel (origine centre panel ) ----------
        rectGrille = New Rectangle(0, 0, 0, 0)
        '  cpsGrille = New Rectangle(0, 0, 0, 0)
        ' Me.Panel1.Dock = DockStyle.Fill
        '  Me.Panel1.Dock = DockStyle.None

        '-----------------------mets à jour l'affiche sur resizin du form-----------------------
        Me.ResizeRedraw = True
        ' Me.AutoScaleMode = Windows.Forms.AutoScaleMode.Dpi
        '  Panel1.Focus()
        '   Panel1.Invalidate()


    End Sub


    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint


        Dim x1, x2, y1, y2, longeurF, largeurF As Single

        x1 = Val(txt_debut.Text)
        y2 = Val(txt_hauteurPt1.Text)
        x2 = Val(txt_longueur.Text)
        y1 = Val(txt_hauteurPt2.Text)
        longeurF = Val(txt_longeurForm.Text)
        largeurF = Val(txt_longeurForm.Text)


        e.Graphics.Clear(Color.White)
        'rectangle client panel 
        Dim tempRect As Rectangle = Me.Panel1.ClientRectangle
        ' Dim tempRect1 As Rectangle = Me.Panel1.ClientRectangle
        Dim blackPen As New Pen(Color.Black, 3)
        'inflate  veut dire"reduire" les 2 dimensions de -20,-20 ou "dilater" de 20,20  
        tempRect.Inflate(-20, -20)
        rectGrille = tempRect

        'dessine bord rectangulaire de la grille(coords par rapport au form 20,20)
        e.Graphics.DrawRectangle(Pens.Black, rectGrille)



        ' dessine grille de points espace de 15,15 pixels  
        ControlPaint.DrawGrid(e.Graphics, rectGrille, New Size(4.51, 4.51), Color.White)

        'dessine une croix au centre du rectangule de la grille
        Dim penCroix As Pen = New Pen(Color.Brown, 1.0)
        penCroix.EndCap = Drawing2D.LineCap.ArrowAnchor
        penCroix.Alignment = Drawing2D.PenAlignment.Center


        '  tempRect1.Inflate(-200 + longeurF / 2, -200 + largeurF / 2)
        '  cpsGrille = tempRect1
        ' e.Graphics.DrawRectangle(Pens.Black, cpsGrille)
        'ligne horizont.
        e.Graphics.DrawLine(penCroix, New Point(rectGrille.Left, rectGrille.Top + rectGrille.Height / 2), New Point(rectGrille.Left + rectGrille.Width, rectGrille.Top + rectGrille.Height / 2))
        'ligne verticale.
        e.Graphics.DrawLine(penCroix, New Point(rectGrille.Left + rectGrille.Width / 2, rectGrille.Top), New Point(rectGrille.Left + rectGrille.Width / 2, rectGrille.Bottom))


        ' *********************

        'ligne horizont.
        '  e.Graphics.DrawLine(blackPen, New Point(cpsGrille.Left + 200 - largeurF / 2, cpsGrille.Top + 200 - longeurF / 2), New Point(cpsGrille.Left + 200 -))
        'ligne verticale.
        '   e.Graphics.DrawLine(blackPen, New Point(cpsGrille.Left + cpsGrille.Width / 2, cpsGrille.Top), New Point(cpsGrille.Left + cpsGrille.Width / 2, cpsGrille.Bottom))


        ' *********************


        penCroix.Dispose()
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.Dpi

        'Récupération des valeurs des Textbox en Single

        'Placement d'une ligne test
        '  If txt_debut.Text <> "" Then
        ' e.Graphics.DrawLine(blackPen, New Point(x1, y2), New Point(x2, y1))
        ' End If

        ' If txt_largeurForm.Text <> "" Then

        ' e.Graphics.DrawLine(blackPen, New Point(200, 200), New Point(200, -longeurF))
        '    e.Graphics.cpsGrille(blackPen, New Point(200 - largeurF, 200 - longeurF), New Point(-largeurF + 200, -largeurF + 200))

        '  End If
        '   If txt_longeurForm.Text <> "" Then
        '      e.Graphics.DrawLine(blackPen, New Point(200, 200), New Point(-longeurF + 200, -longeurF + 200))

        'e.Graphics.DrawLine(blackPen, New Point(200, 200), New Point(-largeurF, 200))
        '  End If


    End Sub
    '"tracke"  position du cursor sur panel
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        Dim x1, x2 As Single
        x1 = Val(e.Location.X) / 3.9
        x2 = Val(e.Location.Y) / 3.9
        'Me.Text = "Coords Panel :" & e.Location.X.ToString & " , " & e.Location.Y.ToString
        Me.Text = "Coords Panel :" & x1.ToString & " , " & x2.ToString
        'Me.Text = Me.Text & " Coords Grid :" & (e.Location.X - rectGrille.Top - rectGrille.Width / 2).ToString & " , " & (e.Location.Y - rectGrille.Top - rectGrille.Height / 2).ToString
        Me.Text = Me.Text & " Coords Grid :" & (x1 - rectGrille.Top - rectGrille.Width / 2).ToString & " , " & (x2 - rectGrille.Top - rectGrille.Height / 2).ToString
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
        Dim x1, x2, y1, y2 As Single

        txt_debut.Text = x1
        txt_hauteurPt2.Text = x2
        txt_longueur.Text = y1
        txt_hauteurPt1.Text = y2
        ' Create coordinates of points that define line.
        'Dim x1 As Single = 240.0F
        ' Dim y1 As Single = 234.0F
        '  Dim x2 As Single = 0.0F
        '  Dim y2 As Single = 0.0F

        ' Draw line to screen.
        e.Graphics.DrawLine(blackPen, x1, y1, x2, y2)
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '  Mapanel()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Mapanel()

        Panel1.Parent.Refresh()
    End Sub
End Class