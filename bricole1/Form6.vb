
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
'Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Imports System

Public Class Form6

    Private rectGrille As Rectangle
    Private Sub Mapanel()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

        '-------------------coords winform(origine top, left) ----------
        Me.Text = "Coords Panel :" & Me.Panel1.Location.X.ToString & " , " & Me.Panel1.Location.Y.ToString
        Me.Font = New Font("tahoma", 12)

        '-------------------coords panel (origine centre panel ) ----------
        rectGrille = New Rectangle(0, 0, 0, 0)

        ' Me.Panel1.Dock = DockStyle.Fill
        Me.Panel1.Dock = DockStyle.None

        '-----------------------mets à jour l'affiche sur resizin du form-----------------------
        Me.ResizeRedraw = True
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.Dpi
        '  Panel1.Focus()
        '   Panel1.Invalidate()


    End Sub



    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        e.Graphics.Clear(Color.White)
        'rectangle client panel 
        Dim tempRect As Rectangle = Me.Panel1.ClientRectangle

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
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.Dpi

        Dim Value, Value1 As Integer

        Value = Val(TextBox1.Text)
        Value1 = Val(TextBox2.Text)


        Dim blackPen As New Pen(Color.Black, 3)
        '  Dim x1, x2, y1, y2 As Single

        ' Form5.TextBox1.Text = Value
        ' Form5.TextBox2.Text = Value1
        '   Value = Val(Form5.TextBox1.Text)
        '  Value1 = Val(Form5.TextBox2.Text)
        '   Form5.TextBox3.Text = y1
        '  Form5.TextBox4.Text = y2

        e.Graphics.DrawLine(blackPen, New Point(Value), New Point(Value1))



    End Sub
    '"tracke"  position du cursor sur panel
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove

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
        Dim x1, x2, y1, y2 As Single

        TextBox1.Text = x1
        TextBox2.Text = x2
        TextBox3.Text = y1
        TextBox4.Text = y2
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
        Dim Panel1 As New Panel

        ' Mapanel()
        '  Form6.Panel1.Parent.Refresh()
    End Sub
End Class