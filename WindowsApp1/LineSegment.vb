''' <summary>
''' This line control does a number of things that the one from VB Power Controls
''' </summary>
''' <remarks></remarks>
Public Class LineSegment

#Region "Private Variables"
    Private WithEvents objParent As Control = Nothing
    Private m_dashstyle As Drawing2D.DashStyle = Drawing2D.DashStyle.Solid
    Private intClosestPoint As Int16 = -1
    Private blnHover As Boolean = False
    Private objPen As New Pen(Color.Black)
    Private ptCurrentMousePosition As Point = New Point(0, 0)
#End Region

#Region "Public Properties"

    Private intBorderWidth As Integer
    Public Property BorderWidth() As Integer
        Get
            Return intBorderWidth
        End Get
        Set(ByVal value As Integer)
            intBorderWidth = value
        End Set
    End Property


    Private clrBorderColor As Color
    Public Property BorderColor() As Color
        Get
            Return clrBorderColor
        End Get
        Set(ByVal value As Color)
            clrBorderColor = value
        End Set
    End Property

    Private intBorderWidthHiLite As Integer
    Public Property BorderWidthHiLite() As Integer
        Get
            Return intBorderWidthHiLite
        End Get
        Set(ByVal value As Integer)
            intBorderWidthHiLite = value
        End Set
    End Property


    Private ptStartPoint As Point
    Public Property StartPoint() As Point
        Get
            Return ptStartPoint
        End Get
        Set(ByVal value As Point)
            ptStartPoint = value
            If IsNothing(ptPoints) Then
                ReDim ptPoints(0)
            End If
            If ptPoints.Length > 0 Then
                ptPoints(0) = ptStartPoint
                DrawLines()
            End If
        End Set
    End Property


    Private ptEndPoint As Point
    Public Property EndPoint() As Point
        Get
            Return ptEndPoint
        End Get
        Set(ByVal value As Point)
            ptEndPoint = value
            If IsNothing(ptPoints) Then
                ReDim ptPoints(1)
            End If
            If ptPoints.Length < 2 Then
                ReDim Preserve ptPoints(1)
            End If
            If ptPoints.Length > 1 Then
                ptPoints(Points.Length - 1) = ptEndPoint
                DrawLines()
            End If
        End Set
    End Property


    Private intX1 As Integer
    Public Property X1() As Integer
        Get
            Return intX1
        End Get
        Set(ByVal value As Integer)
            intX1 = value
            If IsNothing(ptPoints) Then
                ReDim ptPoints(0)
            End If
            If ptPoints.Length > 0 Then
                ptPoints(0) = New Point(intX1, intY1)
                DrawLines()
            End If
        End Set
    End Property


    Private intY1 As Integer
    Public Property Y1() As Integer
        Get
            Return intY1
        End Get
        Set(ByVal value As Integer)
            intY1 = value
            If IsNothing(ptPoints) Then
                ReDim ptPoints(0)
            End If
            If ptPoints.Length > 0 Then
                ptPoints(0) = New Point(intX1, intY1)
                DrawLines()
            End If
        End Set
    End Property


    Private intX2 As Integer
    Public Property X2() As Integer
        Get
            Return intX2
        End Get
        Set(ByVal value As Integer)
            intX2 = value
            If IsNothing(ptPoints) Then
                ReDim ptPoints(1)
            End If
            If ptPoints.Length < 2 Then
                ReDim Preserve ptPoints(1)
            End If
            If ptPoints.Length > 0 Then
                ptPoints(Points.Length - 1) = New Point(intX2, intY2)
                DrawLines()
            End If
        End Set
    End Property


    Private intY2 As Integer
    Public Property Y2() As Integer
        Get
            Return intY2
        End Get
        Set(ByVal value As Integer)
            intY2 = value
            If IsNothing(ptPoints) Then
                ReDim ptPoints(1)
            End If
            If ptPoints.Length < 2 Then
                ReDim Preserve ptPoints(1)
            End If
            If ptPoints.Length > 0 Then
                ptPoints(Points.Length - 1) = New Point(intX2, intY2)
                DrawLines()
            End If
        End Set
    End Property

    Private clrBorderColorHiLite As Color
    Public Property BorderColorHiLite() As Color
        Get
            Return clrBorderColorHiLite
        End Get
        Set(ByVal value As Color)
            clrBorderColorHiLite = value
        End Set
    End Property

    Private ptClosestPoint As PointF
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ClosestPoint() As PointF
        Get
            Return ptClosestPoint
        End Get
    End Property

    Private ptPoints(1) As PointF
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Points() As PointF()
        Get
            Return ptPoints
        End Get
        Set(ByVal value As PointF())
            ptPoints = value
            'Me.DrawLines()
        End Set
    End Property
#End Region

#Region "Constructors"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.intBorderWidth = 3
        Me.intBorderWidthHiLite = 5
        Me.clrBorderColorHiLite = Color.LightBlue
        Me.clrBorderColor = Color.DarkBlue
    End Sub
#End Region

#Region "Main Functions"
    ''' <summary>
    ''' Adds a new point at the current mouse position
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AddPoint() As Boolean
        Dim blnRetVal As Boolean = True
        Try
            If AddPoint(ptCurrentMousePosition) Then
            Else
                blnRetVal = False
            End If
        Catch ex As Exception
            blnRetVal = False
        End Try
        Return blnRetVal
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ptNewPoint"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AddPoint(ByVal ptNewPoint As Point) As Boolean
        Dim blnRetVal As Boolean = True
        Dim idx As Int16 = 0
        Dim intClosestIndex As Int16 = 0
        Dim sngCurrentAngle As Single = 0
        Dim sngTestAngle As Single = 0
        Dim sngCurrentAngleDist As Single = 0
        Dim sngClosestAngle As Single = 0
        Dim ptPoint1 As PointF = Nothing
        Dim ptPoint2 As PointF = Nothing
        Dim ptsNewPoints() As PointF = Nothing
        Dim blnCandidateFound As Boolean = False

        Try
            'Find the two points that this point is between
            sngClosestAngle = 999
            blnCandidateFound = False
            For idx = 0 To ptPoints.Length - 2
                ptPoint1 = ptPoints(idx)
                ptPoint2 = ptPoints(idx + 1)

                'See if the new point is contained in a rectangle defined by
                'point 1 and point 2
                If Me.IsInRectangle(ptPoint1, ptPoint2, ptNewPoint) Then
                    blnCandidateFound = True
                    'This point is contained by the rectangle.  However, depending on what the line
                    'looks like, it is possible that more than one point is in this rectangle.  We
                    'must also test the slope.

                    'Find the heading between the existing points on this segment
                    sngCurrentAngle = Math.Atan2(ptPoint2.Y - ptPoint1.Y, ptPoint2.X - ptPoint1.X)
                    'Find the heading between point 1 of this segment and the new point
                    sngTestAngle = Math.Atan2(ptNewPoint.Y - ptPoint1.Y, ptNewPoint.X - ptPoint1.X)
                    'Measure how far off it is
                    sngCurrentAngleDist = Math.Abs(sngCurrentAngle - sngTestAngle)
                    'See if it is the closest point we have found so far
                    If sngCurrentAngleDist < sngClosestAngle Then
                        'Keep track of the closest one
                        sngClosestAngle = sngCurrentAngleDist
                        intClosestIndex = idx
                    End If
                End If
            Next

            'Make sure a candidate was found
            If blnCandidateFound = True Then
                'Insert it between those two points
                If Me.AddPoint(ptNewPoint, intClosestIndex) Then
                Else
                    blnRetVal = False
                End If
            End If
        Catch ex As Exception
            blnRetVal = False
        End Try
        Return blnRetVal
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ptNewPoint"></param>
    ''' <param name="intPosition"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AddPoint(ByVal ptNewPoint As Point, ByVal intPosition As Int16) As Boolean
        Dim blnRetVal As Boolean = True
        Dim ptsNewPoints() As PointF = Nothing
        Dim idx As Int16 = 0
        Try
            If intPosition > Points.Length - 1 Then
                blnRetVal = False
                Exit Try
            End If

            'The new point should be between points intClosestPoint and intClosestPoint + 1
            'Create and array to hold the new points
            ReDim ptsNewPoints(ptPoints.Length)

            'Copy all of the points from the old array that are before the new point
            For idx = 0 To intPosition
                ptsNewPoints(idx) = ptPoints(idx)
            Next

            'Add the new point
            ptsNewPoints(intPosition + 1) = ptNewPoint

            'Copy the rest of the elements over form the old array
            For idx = intPosition + 1 To ptPoints.Length - 1
                ptsNewPoints(idx + 1) = ptPoints(idx)
            Next

            'Replace the old array with the new one
            ptPoints = ptsNewPoints.Clone
            Me.DrawLines()
        Catch ex As Exception
            blnRetVal = False
        End Try
        Return blnRetVal
    End Function

    ''' <summary>
    ''' Note that we keep up with the closest point.  So, there is no need to pass it as a parameter.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DeletePoint() As Boolean
        Dim blnRetVal As Boolean = True
        Try
            If Me.DeletePoint(intClosestPoint) Then
            Else
                blnRetVal = False
            End If
        Catch ex As Exception
            blnRetVal = False
        End Try
        Return blnRetVal
    End Function

    ''' <summary>
    ''' Delete the point specified
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DeletePoint(ByVal intPosition As Int16) As Boolean
        Dim blnRetVal As Boolean = True
        Dim ptsNewPoints() As PointF = Nothing
        Dim idx As Int16 = 0
        Dim idxNew As Int16 = 0

        Try
            If intClosestPoint > -1 Then
                'We have to have at least 3 points to delete a segment
                If ptPoints.Length >= 3 Then
                    'Create an array that is one item smaller than the original
                    ReDim ptsNewPoints(ptPoints.Length - 2)
                    idxNew = 0
                    'Copy all of the elements over except for the one that needs to be deleted
                    For idx = 0 To ptPoints.Length - 1
                        If idx <> intPosition Then
                            ptsNewPoints(idxNew) = ptPoints(idx)
                            idxNew = idxNew + 1
                        End If
                    Next
                    'Copy the array with the deleted element back over to the original
                    ptPoints = ptsNewPoints.Clone
                    'Refresh the UI
                    Me.DrawLines()
                End If
            Else
                'Assume the user wants to delete the entire line
            End If
        Catch ex As Exception
            blnRetVal = False
        End Try
        Return blnRetVal
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Refresh()
        MyBase.Refresh()
        Me.DrawLines()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Sub DrawLines()
        Dim Path As New System.Drawing.Drawing2D.GraphicsPath
        Dim idx As Int16 = 0

        Try

            If Not IsNothing(ptPoints) AndAlso ptPoints.Length > 0 Then
                objPen.DashStyle = m_dashstyle

                'draw the line
                Path.AddLines(ptPoints)

                For idx = 0 To Me.ptPoints.Length - 1
                    Path.AddEllipse(CType(Me.ptPoints(idx).X - intBorderWidth / 2, Single), CType(Me.ptPoints(idx).Y - intBorderWidth / 2, Single), intBorderWidth, intBorderWidth)
                Next

                If Me.blnHover = False Then
                    objPen.Width = intBorderWidth
                    objPen.Color = Me.clrBorderColor
                    Me.BackColor = Me.clrBorderColor
                Else
                    objPen.Width = Me.intBorderWidthHiLite
                    objPen.Color = Me.clrBorderColorHiLite
                    Me.BackColor = Me.clrBorderColorHiLite
                End If

                Path.Widen(objPen)

                Me.Region = New Region(Path)
                'Me.Invalidate()
            End If
        Catch ex As Exception
        End Try

    End Sub
#End Region

#Region "Helper Functions"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="X"></param>
    ''' <param name="Y"></param>
    ''' <remarks></remarks>
    Private Sub FindClosestPoint(ByVal X As Integer, ByVal Y As Integer)
        Dim idx As Int16 = 0
        Dim intDist As Int16 = 0
        Dim intClosestDist As Int16 = 9999

        Try
            For idx = 0 To Me.ptPoints.Length - 1
                intDist = Math.Sqrt((Me.ptPoints(idx).X - X) ^ 2 + (Me.ptPoints(idx).Y - Y) ^ 2)
                If intDist < intClosestDist Then
                    intClosestDist = intDist
                    ptClosestPoint = Me.ptPoints(idx)
                    intClosestPoint = idx
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ptPoint1"></param>
    ''' <param name="ptPoint2"></param>
    ''' <param name="ptTestPoint"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function IsInRectangle(ByVal ptPoint1 As PointF, ByVal ptPoint2 As PointF, ByVal ptTestPoint As Point) As Boolean
        Dim blnRetVal As Boolean = True
        Try
            'Defualt to false
            blnRetVal = False
            If ptPoint1.X >= ptTestPoint.X And ptTestPoint.X >= ptPoint2.X Or
               ptPoint1.X <= ptTestPoint.X And ptTestPoint.X <= ptPoint2.X Then
                'The X part is between the other two points

                If ptPoint1.Y >= ptTestPoint.Y And ptTestPoint.Y >= ptPoint2.Y Or
                   ptPoint1.Y <= ptTestPoint.Y And ptTestPoint.Y <= ptPoint2.Y Then
                    'The Y part is between the other two points
                    blnRetVal = True
                End If

            End If
        Catch ex As Exception
            blnRetVal = False
        End Try
        Return blnRetVal
    End Function
#End Region

#Region "Control Events"

    ''' <summary>
    ''' Get a ref to the control's parent so we can resize when the parent does
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Overrides Sub OnParentChanged(ByVal e As System.EventArgs)
        MyBase.OnParentChanged(e)
        objParent = Me.Parent
    End Sub





    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)

        ptCurrentMousePosition = New Point(e.X, e.Y)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.ptPoints(intClosestPoint) = New PointF(e.X, e.Y)
            DrawLines()
            objParent.Invalidate()
        Else
            FindClosestPoint(e.X, e.Y)
        End If

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)

        Dim idx As Int16 = 0
        Dim intDist As Int16 = 0
        Dim intClosestDist As Int16 = 9999

        Try
            If e.Button = Windows.Forms.MouseButtons.Left Then
                FindClosestPoint(e.X, e.Y)
            End If
        Catch ex As Exception

        End Try

    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)

        DrawLines()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
        MyBase.OnMouseEnter(e)
        If Me.blnHover = False Then
            Me.blnHover = True
            Me.DrawLines()
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        If Me.blnHover = True Then
            Me.blnHover = False
            Me.DrawLines()
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Me.DrawLines()
    End Sub
#End Region

#Region "Parent Events"

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub objParent_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles objParent.Paint
        Try
            'e.Graphics.DrawLines(New Pen(Color.Purple, 5), Points)
            'Me.Refresh()
            Me.DrawLines()
            SetControlSize()
            'Me.Invalidate()
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' Get a ref to the control's parent so we can resize when the parent does
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub objParent_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles objParent.Resize
        SetControlSize()
    End Sub

    Private Sub SetControlSize()
        Try
            Me.Top = 0
            Me.Left = 0
            Me.Width = objParent.Width
            Me.Height = objParent.Height
        Catch ex As Exception
        End Try
    End Sub
#End Region
End Class
