Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class Form1

    Inherits System.Windows.Forms.Form

    Private buttonPanel As New Panel
    Private WithEvents positionDataGridView As New DataGridView
    Private WithEvents Module1dgv As New DataGridView
    Private WithEvents Module2dgv As New DataGridView
    Private WithEvents Module3dgv As New DataGridView
    Private WithEvents Module4dgv As New DataGridView
    Private WithEvents Module5dgv As New DataGridView
    Private WithEvents Module6dgv As New DataGridView
    Private WithEvents Module7dgv As New DataGridView
    Private WithEvents Module8dgv As New DataGridView
    Private WithEvents addNewRowButton As New Button
    Private WithEvents deleteRowButton As New Button
    Private Sub Form1_Load(ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles MyBase.Load

        '  SetupLayout()
        SetupPositionDataGridView()
        ' Dgv1()
        SetupModule1dgv()
        SetupModule2dgv()
        SetupModule3dgv()
        SetupModule4dgv()
        SetupModule5dgv()
        SetupModule6dgv()
        SetupModule7dgv()
        SetupModule8dgv()
        ComboBox2.Items.Add("")
        ComboBox2.Items.Add("Module1dgv")
        ComboBox2.Items.Add("Module2dgv")
        ComboBox2.Items.Add("Module3dgv")
        ComboBox2.Items.Add("Module4dgv")
        ComboBox2.Items.Add("Module5dgv")
        ComboBox2.Items.Add("Module6dgv")
        ComboBox2.Items.Add("Module7dgv")
        ComboBox2.Items.Add("Module8dgv")

        ' ComboBox2.Items.Add("")
        ' ComboBox2.Items.Add("Module 1")
        ' ComboBox2.Items.Add("Module 2")
        ' ComboBox2.Items.Add("Module 3")
        ' ComboBox2.Items.Add("Module 4")

        '  PopulateDataGridView()

    End Sub
    Private Sub SetupPositionDataGridView()

        Me.positionDataGridView.Location = New Point(24, 50)
        '   Me.positionDataGridView.Size = New Size(800, 200)
        '  positionDataGridView.CaptionText = "Microsoft DataGrid Control"
        '   Me.Size = New Size(1033, 150)

        Dim style As FontStyle = FontStyle.Bold
        Me.components = New System.ComponentModel.Container()
        Me.Panel9.Controls.Add(positionDataGridView)

        positionDataGridView.ColumnCount = 45
        With positionDataGridView.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(positionDataGridView.Font, FontStyle.Bold)
            .Font = New Font(New FontFamily("Arial"), 7, style)
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With positionDataGridView
            .Name = "positionDataGridView"
            .Location = New Point(8, 8)
            .Size = New Size(800, 800)
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .RowHeadersVisible = False
            .BorderStyle = BorderStyle.FixedSingle
            .Columns(0).Name = "0"
            .Columns(1).Name = "1"
            .Columns(2).Name = "2"
            .Columns(3).Name = "3"
            .Columns(4).Name = "5"
            .Columns(5).Name = "6"
            .Columns(6).Name = "7"
            .Columns(7).Name = "8"
            .Columns(8).Name = "9"
            .Columns(9).Name = "10"
            .Columns(10).Name = "11"
            .Columns(11).Name = "12"
            .Columns(12).Name = "13"
            .Columns(13).Name = "14"
            .Columns(14).Name = "15"
            .Columns(15).Name = "16"
            .Columns(16).Name = "17"
            .Columns(17).Name = "18"
            .Columns(18).Name = "19"
            .Columns(19).Name = "20"
            .Columns(20).Name = "21"
            .Columns(21).Name = "22"
            .Columns(22).Name = "23"
            .Columns(23).Name = "24"
            .Columns(24).Name = "25"
            .Columns(25).Name = "26"
            .Columns(26).Name = "27"
            .Columns(27).Name = "28"
            .Columns(28).Name = "29"
            .Columns(29).Name = "30"
            .Columns(30).Name = "31"
            .Columns(31).Name = "32"
            .Columns(32).Name = "33"
            .Columns(33).Name = "34"
            .Columns(34).Name = "35"
            .Columns(35).Name = "36"
            .Columns(36).Name = "37"
            .Columns(37).Name = "38"
            .Columns(38).Name = "39"
            .Columns(39).Name = "40"
            .Columns(40).Name = "41"
            .Columns(41).Name = "42"
            .Columns(42).Name = "43"
            .Columns(43).Name = "44"
            .Columns(44).Name = "45"
            .Rows.Add()
            '  .Columns(4).DefaultCellStyle.Font =
            '    New Font(Me.positionDataGridView.DefaultCellStyle.Font, FontStyle.Italic)

            '   .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            .MultiSelect = False
            .Dock = DockStyle.Top

        End With
    End Sub
    Private Sub SetupModule1dgv()

        Dim style As FontStyle = FontStyle.Bold
        Me.components = New System.ComponentModel.Container()
        ' Me.Controls.Add(Module1dgv)
        Me.Panel1.Controls.Add(Module1dgv)
        '  Module1dgv.RowCount = 45
        ' Module1dgv.ColumnCount = 4
        With Module1dgv.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(Module1dgv.Font, FontStyle.Bold)
            .Font = New Font(New FontFamily("Arial"), 6, style)
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With Module1dgv()
            .Name = "Module1dgv"
            .Location = New Point(25, 200)
            .Size = New Size(227, 150)
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .RowHeadersVisible = False

            ' .Columns(0).Name = "num"


            .MultiSelect = False
            .Dock = DockStyle.Top

        End With

    End Sub
    Private Sub SetupModule2dgv()

        Dim style As FontStyle = FontStyle.Bold
        Me.components = New System.ComponentModel.Container()
        ' Me.Controls.Add(Module2dgv)
        Me.Panel2.Controls.Add(Module2dgv)
        ' Module2dgv.RowCount = 45
        '  Module2dgv.ColumnCount = 4
        With Module2dgv.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(Module2dgv.Font, FontStyle.Bold)
            .Font = New Font(New FontFamily("Arial"), 7, style)
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With Module2dgv()
            .Name = "Module2dgv"
            .Location = New Point(225, 400)
            .Size = New Size(227, 150)
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .RowHeadersVisible = False

            .MultiSelect = False
            .Dock = DockStyle.Top
        End With

    End Sub
    Private Sub SetupModule3dgv()

        Dim style As FontStyle = FontStyle.Bold
        Me.components = New System.ComponentModel.Container()
        '  Me.Controls.Add(Module3dgv)
        Me.Panel3.Controls.Add(Module3dgv)
        '  Module3dgv.RowCount = 45
        '  Module3dgv.ColumnCount = 4
        With Module3dgv.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(Module3dgv.Font, FontStyle.Bold)
            .Font = New Font(New FontFamily("Arial"), 7, style)
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With Module3dgv()
            .Name = "Module3dgv"
            .Location = New Point(225, 400)
            .Size = New Size(227, 150)
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .RowHeadersVisible = False

            .MultiSelect = False
            .Dock = DockStyle.Top
        End With

    End Sub
    Private Sub SetupModule4dgv()

        Dim style As FontStyle = FontStyle.Bold
        Me.components = New System.ComponentModel.Container()
        ' Me.Controls.Add(Module4dgv)
        Me.Panel4.Controls.Add(Module4dgv)
        '   Module4dgv.RowCount = 45
        '   Module4dgv.ColumnCount = 4
        With Module4dgv.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(Module4dgv.Font, FontStyle.Bold)
            .Font = New Font(New FontFamily("Arial"), 7, style)
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With Module4dgv()
            .Name = "Module4dgv"
            .Location = New Point(225, 400)
            .Size = New Size(227, 150)
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .RowHeadersVisible = False

            .MultiSelect = False
            .Dock = DockStyle.Top
        End With

    End Sub
    Private Sub SetupModule5dgv()

        Dim style As FontStyle = FontStyle.Bold
        Me.components = New System.ComponentModel.Container()
        '  Me.Controls.Add(Module5dgv)
        Me.Panel5.Controls.Add(Module5dgv)
        '  Module5dgv.RowCount = 45
        '  Module5dgv.ColumnCount = 4
        With Module5dgv.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(Module5dgv.Font, FontStyle.Bold)
            .Font = New Font(New FontFamily("Arial"), 7, style)
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With Module5dgv()
            .Name = "Module5dgv"
            .Location = New Point(225, 400)
            .Size = New Size(227, 150)
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .RowHeadersVisible = False

            .MultiSelect = False
            .Dock = DockStyle.Top
        End With

    End Sub
    Private Sub SetupModule6dgv()

        Dim style As FontStyle = FontStyle.Bold
        Me.components = New System.ComponentModel.Container()
        'Me.Controls.Add(Module6dgv)
        Me.Panel6.Controls.Add(Module6dgv)
        '  Module6dgv.RowCount = 45
        '  Module6dgv.ColumnCount = 4
        With Module6dgv.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(Module6dgv.Font, FontStyle.Bold)
            .Font = New Font(New FontFamily("Arial"), 7, style)
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With Module6dgv()
            .Name = "Module6dgv"
            .Location = New Point(225, 400)
            .Size = New Size(227, 150)
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .RowHeadersVisible = False

            .MultiSelect = False
            .Dock = DockStyle.Top
        End With

    End Sub
    Private Sub SetupModule7dgv()

        Dim style As FontStyle = FontStyle.Bold
        Me.components = New System.ComponentModel.Container()
        '  Me.Controls.Add(Module7dgv)
        Me.Panel7.Controls.Add(Module7dgv)
        '   Module7dgv.RowCount = 45
        '   Module7dgv.ColumnCount = 4
        With Module7dgv.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(Module7dgv.Font, FontStyle.Bold)
            .Font = New Font(New FontFamily("Arial"), 7, style)
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With Module7dgv()
            .Name = "Module7dgv"
            .Location = New Point(225, 400)
            .Size = New Size(227, 150)
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .RowHeadersVisible = False

            .MultiSelect = False
            .Dock = DockStyle.Top
        End With

    End Sub
    Private Sub SetupModule8dgv()

        Dim style As FontStyle = FontStyle.Bold
        Me.components = New System.ComponentModel.Container()
        '  Me.Controls.Add(Module8dgv)
        Me.Panel8.Controls.Add(Module8dgv)
        '  Module8dgv.RowCount = 45
        '  Module8dgv.ColumnCount = 4
        With Module8dgv.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(Module8dgv.Font, FontStyle.Bold)
            .Font = New Font(New FontFamily("Arial"), 7, style)
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        With Module8dgv()
            .Name = "Module8dgv"
            .Location = New Point(225, 400)
            .Size = New Size(227, 150)
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .RowHeadersVisible = False

            .MultiSelect = False
            .Dock = DockStyle.Top
        End With

    End Sub
    Public Sub positionDataGridView_Click(sender As Object, e As EventArgs) Handles positionDataGridView.Click

        '    Dim i As Integer
        '   i = positionDataGridView.cel.select
        '  Dim CellChange As String = positionDataGridView.Rows(0).Cells(i).Value

        '  positionDataGridView.Rows(0).Cells(j).Style.BackColor = Color.Green


    End Sub
    Private Sub Dgv1()

        Dim conStr As String = "server=127.0.0.1;user id=root;database=prod"
        Dim Con As New MySqlConnection(conStr)
        Dim obj As MySqlCommand
        Dim nomtable As String = txt_nomTable.Text
        Dim strSQL As String
        '  Dim dt As New DataTable
        Try
            If Not Con Is Nothing Then Con.Close()
            Con = New MySqlConnection(conStr)
            Con.Open()

            obj = Con.CreateCommand()
            ' Try

            strSQL = "SELECT num, mach, pos, part, qty FROM " & nomtable & " "

            Dim Search As New MySqlDataAdapter(strSQL, Con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, nomtable)

            Module1dgv.DataSource = ds.Tables(nomtable)

            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Con.Close()
            Exit Sub
        End Try
        Try

        Catch ex As Exception

        End Try

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                        DGV1
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim i As Integer = (Module1dgv.Rows.Count - 1)
        Do While (i >= 0)
            i = (i - 1)
            For Each dr1 As DataGridViewRow In Module1dgv.Rows
                If dr1.Cells("mach").Value = "Nxt1" Then
                    Module1dgv.Rows.Remove(dr1)
                End If
            Next
        Loop
        Dim j As Integer = (Module1dgv.Rows.Count - 1)
        Do While (j >= 0)
            j = (j - 1)
            For Each dr1 As DataGridViewRow In Module1dgv.Rows
                If dr1.Cells("pos").Value = 2 Then
                    Module1dgv.Rows.Remove(dr1)
                End If
            Next
        Loop
        Dim k As Integer = (Module1dgv.Rows.Count - 1)
        Do While (k >= 0)
            k = (k - 1)
            For Each dr1 As DataGridViewRow In Module1dgv.Rows
                If dr1.Cells("pos").Value = 3 Then
                    Module1dgv.Rows.Remove(dr1)
                End If
            Next
        Loop
        Dim l As Integer = (Module1dgv.Rows.Count - 1)
        Do While (l >= 0)
            l = (l - 1)
            For Each dr1 As DataGridViewRow In Module1dgv.Rows
                If dr1.Cells("pos").Value = 4 Then
                    Module1dgv.Rows.Remove(dr1)
                End If
            Next
        Loop

        For intI = Module1dgv.Rows.Count - 1 To 0 Step -1
            For intJ = intI - 1 To 0 Step -1
                If Module1dgv.Rows(intI).Cells(1).Value = Module1dgv.Rows(intJ).Cells(1).Value AndAlso Module1dgv.Rows(intI).Cells(3).Value = Module1dgv.Rows(intJ).Cells(3).Value Then
                    Module1dgv.Rows.RemoveAt(intI)
                    Exit For
                End If
            Next
        Next
        Module1dgv.Sort(Module1dgv.Columns(3), System.ComponentModel.ListSortDirection.Ascending)
        Dim Somme As Integer


        For X As Integer = 0 To Module1dgv.Rows.Count - 1
            Somme += Module1dgv.Rows(X).Cells(4).Value
        Next X
        txt_M1Cps.Text = Somme

        Module1dgv.Columns(0).Width = 70
        ' .Columns(1).Name = "mach"
        Module1dgv.Columns(1).Width = 35
        ' .Columns(2).Name = "pos"
        Module1dgv.Columns(2).Width = 25
        ' .Columns(3).Name = "part"
        Module1dgv.Columns(3).Width = 25
        Module1dgv.Columns(4).Width = 25

        txt_M1tps.Text = Somme / (37500 / 3600)

    End Sub
    Private Sub Dgv2()

        Dim conStr As String = "server=127.0.0.1;user id=root;database=prod"
        Dim Con As New MySqlConnection(conStr)
        Dim obj As MySqlCommand
        Dim nomtable As String = txt_nomTable.Text
        Dim strSQL As String
        Dim dt As New DataTable
        If Not Con Is Nothing Then Con.Close()
        Try
            Con = New MySqlConnection(conStr)
            Con.Open()

            obj = Con.CreateCommand()
            '   Try

            strSQL = "SELECT num, mach, pos, part, qty FROM " & nomtable & " "

            Dim Search As New MySqlDataAdapter(strSQL, Con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, nomtable)

            Module2dgv.DataSource = ds.Tables(nomtable)

            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Con.Close()
            Exit Sub
        End Try
        Try

        Catch ex As Exception

        End Try

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim i1 As Integer = (Module2dgv.Rows.Count - 1)
        Do While (i1 >= 0)
            i1 = (i1 - 1)
            For Each dr2 As DataGridViewRow In Module2dgv.Rows
                If dr2.Cells("mach").Value = "Nxt1" Then
                    Module2dgv.Rows.Remove(dr2)
                End If
            Next
        Loop
        Dim j1 As Integer = (Module2dgv.Rows.Count - 1)
        Do While (j1 >= 0)
            j1 = (j1 - 1)
            For Each dr2 As DataGridViewRow In Module2dgv.Rows
                If dr2.Cells("pos").Value = 1 Then
                    Module2dgv.Rows.Remove(dr2)
                End If
            Next
        Loop
        Dim k1 As Integer = (Module2dgv.Rows.Count - 1)
        Do While (k1 >= 0)
            k1 = (k1 - 1)
            For Each dr2 As DataGridViewRow In Module2dgv.Rows
                If dr2.Cells("pos").Value = 3 Then
                    Module2dgv.Rows.Remove(dr2)
                End If
            Next
        Loop
        Dim l1 As Integer = (Module2dgv.Rows.Count - 1)
        Do While (l1 >= 0)
            l1 = (l1 - 1)
            For Each dr2 As DataGridViewRow In Module2dgv.Rows
                If dr2.Cells("pos").Value = 4 Then
                    Module2dgv.Rows.Remove(dr2)
                End If
            Next
        Loop

        For intI1 = Module2dgv.Rows.Count - 1 To 0 Step -1
            For intJ1 = intI1 - 1 To 0 Step -1
                If Module2dgv.Rows(intI1).Cells(1).Value = Module2dgv.Rows(intJ1).Cells(1).Value AndAlso Module2dgv.Rows(intI1).Cells(3).Value = Module2dgv.Rows(intJ1).Cells(3).Value Then
                    Module2dgv.Rows.RemoveAt(intI1)
                    Exit For
                End If
            Next
        Next
        Module2dgv.Sort(Module2dgv.Columns(3), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Private Sub Dgv3()

        Dim conStr As String = "server=127.0.0.1;user id=root;database=prod"
        Dim Con As New MySqlConnection(conStr)
        Dim obj As MySqlCommand
        Dim nomtable As String = txt_nomTable.Text
        Dim strSQL As String
        Dim dt As New DataTable
        If Not Con Is Nothing Then Con.Close()
        Try
            Con = New MySqlConnection(conStr)
            Con.Open()

            obj = Con.CreateCommand()
            ' Try

            strSQL = "SELECT num, mach, pos, part, qty FROM " & nomtable & " "

            Dim Search As New MySqlDataAdapter(strSQL, Con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, nomtable)

            Module3dgv.DataSource = ds.Tables(nomtable)

            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Con.Close()
            Exit Sub
        End Try
        Try

        Catch ex As Exception

        End Try

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim i2 As Integer = (Module3dgv.Rows.Count - 1)
        Do While (i2 >= 0)
            i2 = (i2 - 1)
            For Each dr As DataGridViewRow In Module3dgv.Rows
                If dr.Cells("mach").Value = "Nxt1" Then
                    Module3dgv.Rows.Remove(dr)
                End If
            Next
        Loop
        Dim j2 As Integer = (Module3dgv.Rows.Count - 1)
        Do While (j2 >= 0)
            j2 = (j2 - 1)
            For Each dr As DataGridViewRow In Module3dgv.Rows
                If dr.Cells("pos").Value = 1 Then
                    Module3dgv.Rows.Remove(dr)
                End If
            Next
        Loop
        Dim k2 As Integer = (Module3dgv.Rows.Count - 1)
        Do While (k2 >= 0)
            k2 = (k2 - 1)
            For Each dr As DataGridViewRow In Module3dgv.Rows
                If dr.Cells("pos").Value = 2 Then
                    Module3dgv.Rows.Remove(dr)
                End If
            Next
        Loop
        Dim l2 As Integer = (Module3dgv.Rows.Count - 1)
        Do While (l2 >= 0)
            l2 = (l2 - 1)
            For Each dr As DataGridViewRow In Module3dgv.Rows
                If dr.Cells("pos").Value = 4 Then
                    Module3dgv.Rows.Remove(dr)
                End If
            Next
        Loop

        For intI2 = Module3dgv.Rows.Count - 1 To 0 Step -1
            For intJ2 = intI2 - 1 To 0 Step -1
                If Module3dgv.Rows(intI2).Cells(1).Value = Module3dgv.Rows(intJ2).Cells(1).Value AndAlso Module3dgv.Rows(intI2).Cells(3).Value = Module3dgv.Rows(intJ2).Cells(3).Value Then
                    Module3dgv.Rows.RemoveAt(intI2)
                    Exit For
                End If
            Next
        Next
        Module3dgv.Sort(Module3dgv.Columns(3), System.ComponentModel.ListSortDirection.Ascending)

    End Sub
    Private Sub Dgv4()

        Dim conStr As String = "server=127.0.0.1;user id=root;database=prod"
        Dim Con As New MySqlConnection(conStr)
        Dim obj As MySqlCommand
        Dim nomtable As String = txt_nomTable.Text
        Dim strSQL As String
        Dim dt As New DataTable
        If Not Con Is Nothing Then Con.Close()
        Try
            Con = New MySqlConnection(conStr)
            Con.Open()

            obj = Con.CreateCommand()
            '  Try

            strSQL = "SELECT num, mach, pos, part, qty FROM " & nomtable & " "

            Dim Search As New MySqlDataAdapter(strSQL, Con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, nomtable)

            Module4dgv.DataSource = ds.Tables(nomtable)

            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Con.Close()
            Exit Sub
        End Try
        Try

        Catch ex As Exception

        End Try

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim i3 As Integer = (Module4dgv.Rows.Count - 1)
        Do While (i3 >= 0)
            i3 = (i3 - 1)
            For Each dr As DataGridViewRow In Module4dgv.Rows
                If dr.Cells("mach").Value = "Nxt1" Then
                    Module4dgv.Rows.Remove(dr)
                End If
            Next
        Loop
        Dim j3 As Integer = (Module4dgv.Rows.Count - 1)
        Do While (j3 >= 0)
            j3 = (j3 - 1)
            For Each dr As DataGridViewRow In Module4dgv.Rows
                If dr.Cells("pos").Value = 1 Then
                    Module4dgv.Rows.Remove(dr)
                End If
            Next
        Loop
        Dim k3 As Integer = (Module4dgv.Rows.Count - 1)
        Do While (k3 >= 0)
            k3 = (k3 - 1)
            For Each dr As DataGridViewRow In Module4dgv.Rows
                If dr.Cells("pos").Value = 2 Then
                    Module4dgv.Rows.Remove(dr)
                End If
            Next
        Loop
        Dim l3 As Integer = (Module4dgv.Rows.Count - 1)
        Do While (l3 >= 0)
            l3 = (l3 - 1)
            For Each dr As DataGridViewRow In Module4dgv.Rows
                If dr.Cells("pos").Value = 3 Then
                    Module4dgv.Rows.Remove(dr)
                End If
            Next
        Loop

        For intI3 = Module4dgv.Rows.Count - 1 To 0 Step -1
            For intJ3 = intI3 - 1 To 0 Step -1
                If Module4dgv.Rows(intI3).Cells(1).Value = Module4dgv.Rows(intJ3).Cells(1).Value AndAlso Module4dgv.Rows(intI3).Cells(3).Value = Module4dgv.Rows(intJ3).Cells(3).Value Then
                    Module4dgv.Rows.RemoveAt(intI3)
                    Exit For
                End If
            Next
        Next
        Module4dgv.Sort(Module4dgv.Columns(3), System.ComponentModel.ListSortDirection.Ascending)

    End Sub
    Private Sub Dgv5()

        Dim conStr As String = "server=127.0.0.1;user id=root;database=prod"
        Dim Con As New MySqlConnection(conStr)
        Dim obj As MySqlCommand
        Dim nomtable As String = txt_nomTable.Text
        Dim strSQL As String
        Dim dt As New DataTable
        If Not Con Is Nothing Then Con.Close()
        Try
            Con = New MySqlConnection(conStr)
            Con.Open()

            obj = Con.CreateCommand()
            '  Try

            strSQL = "SELECT num, mach, pos, part, qty FROM " & nomtable & " "

            Dim Search As New MySqlDataAdapter(strSQL, Con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, nomtable)

            Module5dgv.DataSource = ds.Tables(nomtable)

            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Con.Close()
            Exit Sub
        End Try
        Try

        Catch ex As Exception

        End Try

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim i4 As Integer = (Module5dgv.Rows.Count - 1)
        Do While (i4 >= 0)
            i4 = (i4 - 1)
            For Each dr As DataGridViewRow In Module5dgv.Rows
                If dr.Cells("mach").Value = "Nxt3" Then
                    Module5dgv.Rows.Remove(dr)
                End If
            Next
        Loop
        Dim j4 As Integer = (Module5dgv.Rows.Count - 1)
        Do While (j4 >= 0)
            j4 = (j4 - 1)
            For Each dr As DataGridViewRow In Module5dgv.Rows
                If dr.Cells("pos").Value = 2 Then
                    Module5dgv.Rows.Remove(dr)
                End If
            Next
        Loop
        Dim k4 As Integer = (Module5dgv.Rows.Count - 1)
        Do While (k4 >= 0)
            k4 = (k4 - 1)
            For Each dr As DataGridViewRow In Module5dgv.Rows
                If dr.Cells("pos").Value = 3 Then
                    Module5dgv.Rows.Remove(dr)
                End If
            Next
        Loop
        Dim l4 As Integer = (Module5dgv.Rows.Count - 1)
        Do While (l4 >= 0)
            l4 = (l4 - 1)
            For Each dr As DataGridViewRow In Module5dgv.Rows
                If dr.Cells("pos").Value = 4 Then
                    Module5dgv.Rows.Remove(dr)
                End If
            Next
        Loop

        For intI4 = Module5dgv.Rows.Count - 1 To 0 Step -1
            For intJ4 = intI4 - 1 To 0 Step -1
                If Module5dgv.Rows(intI4).Cells(1).Value = Module5dgv.Rows(intJ4).Cells(1).Value AndAlso Module5dgv.Rows(intI4).Cells(3).Value = Module5dgv.Rows(intJ4).Cells(3).Value Then
                    Module5dgv.Rows.RemoveAt(intI4)
                    Exit For
                End If
            Next
        Next
        Module5dgv.Sort(Module5dgv.Columns(3), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Private Sub Dgv6()

        Dim conStr As String = "server=127.0.0.1;user id=root;database=prod"
        Dim Con As New MySqlConnection(conStr)
        Dim obj As MySqlCommand
        Dim nomtable As String = txt_nomTable.Text
        Dim strSQL As String
        Dim dt As New DataTable
        If Not Con Is Nothing Then Con.Close()
        Try
            Con = New MySqlConnection(conStr)
            Con.Open()

            obj = Con.CreateCommand()
            '  Try

            strSQL = "SELECT num, mach, pos, part, qty FROM " & nomtable & " "

            Dim Search As New MySqlDataAdapter(strSQL, Con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, nomtable)

            Module6dgv.DataSource = ds.Tables(nomtable)

            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Con.Close()
            Exit Sub
        End Try
        Try

        Catch ex As Exception

        End Try

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim i5 As Integer = (Module6dgv.Rows.Count - 1)
        Do While (i5 >= 0)
            i5 = (i5 - 1)
            For Each dr As DataGridViewRow In Module6dgv.Rows
                If dr.Cells("mach").Value = "Nxt3" Then
                    Module6dgv.Rows.Remove(dr)
                End If
            Next
        Loop
        Dim j5 As Integer = (Module6dgv.Rows.Count - 1)
        Do While (j5 >= 0)
            j5 = (j5 - 1)
            For Each dr As DataGridViewRow In Module6dgv.Rows
                If dr.Cells("pos").Value = 1 Then
                    Module6dgv.Rows.Remove(dr)
                End If
            Next
        Loop
        Dim k5 As Integer = (Module6dgv.Rows.Count - 1)
        Do While (k5 >= 0)
            k5 = (k5 - 1)
            For Each dr As DataGridViewRow In Module6dgv.Rows
                If dr.Cells("pos").Value = 3 Then
                    Module6dgv.Rows.Remove(dr)
                End If
            Next
        Loop
        Dim l5 As Integer = (Module6dgv.Rows.Count - 1)
        Do While (l5 >= 0)
            l5 = (l5 - 1)
            For Each dr As DataGridViewRow In Module6dgv.Rows
                If dr.Cells("pos").Value = 4 Then
                    Module6dgv.Rows.Remove(dr)
                End If
            Next
        Loop

        For intI5 = Module6dgv.Rows.Count - 1 To 0 Step -1
            For intJ5 = intI5 - 1 To 0 Step -1
                If Module6dgv.Rows(intI5).Cells(1).Value = Module6dgv.Rows(intJ5).Cells(1).Value AndAlso Module6dgv.Rows(intI5).Cells(3).Value = Module6dgv.Rows(intJ5).Cells(3).Value Then
                    Module6dgv.Rows.RemoveAt(intI5)
                    Exit For
                End If
            Next
        Next
        Module6dgv.Sort(Module6dgv.Columns(3), System.ComponentModel.ListSortDirection.Ascending)

    End Sub
    Private Sub Dgv7()

        Dim conStr As String = "server=127.0.0.1;user id=root;database=prod"
        Dim Con As New MySqlConnection(conStr)
        Dim obj As MySqlCommand
        Dim nomtable As String = txt_nomTable.Text
        Dim strSQL As String
        Dim dt As New DataTable
        If Not Con Is Nothing Then Con.Close()
        Try
            Con = New MySqlConnection(conStr)
            Con.Open()

            obj = Con.CreateCommand()
            '  Try

            strSQL = "SELECT num, mach, pos, part, qty FROM " & nomtable & " "

            Dim Search As New MySqlDataAdapter(strSQL, Con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, nomtable)

            Module7dgv.DataSource = ds.Tables(nomtable)

            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Con.Close()
            Exit Sub
        End Try
        Try

        Catch ex As Exception

        End Try

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim i6 As Integer = (Module7dgv.Rows.Count - 1)
        Do While (i6 >= 0)
            i6 = (i6 - 1)
            For Each dr As DataGridViewRow In Module7dgv.Rows
                If dr.Cells("mach").Value = "Nxt3" Then
                    Module7dgv.Rows.Remove(dr)
                End If
            Next
        Loop
        Dim j6 As Integer = (Module7dgv.Rows.Count - 1)
        Do While (j6 >= 0)
            j6 = (j6 - 1)
            For Each dr As DataGridViewRow In Module7dgv.Rows
                If dr.Cells("pos").Value = 1 Then
                    Module7dgv.Rows.Remove(dr)
                End If
            Next
        Loop
        Dim k6 As Integer = (Module7dgv.Rows.Count - 1)
        Do While (k6 >= 0)
            k6 = (k6 - 1)
            For Each dr As DataGridViewRow In Module7dgv.Rows
                If dr.Cells("pos").Value = 2 Then
                    Module7dgv.Rows.Remove(dr)
                End If
            Next
        Loop
        Dim l6 As Integer = (Module7dgv.Rows.Count - 1)
        Do While (l6 >= 0)
            l6 = (l6 - 1)
            For Each dr As DataGridViewRow In Module7dgv.Rows
                If dr.Cells("pos").Value = 4 Then
                    Module7dgv.Rows.Remove(dr)
                End If
            Next
        Loop

        For intI6 = Module7dgv.Rows.Count - 1 To 0 Step -1
            For intJ6 = intI6 - 1 To 0 Step -1
                If Module7dgv.Rows(intI6).Cells(1).Value = Module7dgv.Rows(intJ6).Cells(1).Value AndAlso Module7dgv.Rows(intI6).Cells(3).Value = Module7dgv.Rows(intJ6).Cells(3).Value Then
                    Module7dgv.Rows.RemoveAt(intI6)
                    Exit For
                End If
            Next
        Next
        Module7dgv.Sort(Module7dgv.Columns(3), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Private Sub Dgv8()

        Dim conStr As String = "server=127.0.0.1;user id=root;database=prod"
        Dim Con As New MySqlConnection(conStr)
        Dim obj As MySqlCommand
        Dim nomtable As String = txt_nomTable.Text
        Dim strSQL As String
        Dim dt As New DataTable
        If Not Con Is Nothing Then Con.Close()
        Try
            Con = New MySqlConnection(conStr)
            Con.Open()

            obj = Con.CreateCommand()
            '  Try

            strSQL = "SELECT num, mach, pos, part, qty FROM " & nomtable & " "

            Dim Search As New MySqlDataAdapter(strSQL, Con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, nomtable)

            Module8dgv.DataSource = ds.Tables(nomtable)

            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Con.Close()
            Exit Sub
        End Try
        Try

        Catch ex As Exception

        End Try

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim i7 As Integer = (Module8dgv.Rows.Count - 1)
        Do While (i7 >= 0)
            i7 = (i7 - 1)
            For Each dr As DataGridViewRow In Module8dgv.Rows
                If dr.Cells("mach").Value = "Nxt3" Then
                    Module8dgv.Rows.Remove(dr)
                End If
            Next
        Loop

        Dim j7 As Integer = (Module8dgv.Rows.Count - 1)
        Do While (j7 >= 0)
            j7 = (j7 - 1)
            For Each dr As DataGridViewRow In Module8dgv.Rows
                If dr.Cells("pos").Value = 1 Then
                    Module8dgv.Rows.Remove(dr)
                End If
            Next
        Loop
        Dim k7 As Integer = (Module8dgv.Rows.Count - 1)
        Do While (k7 >= 0)
            k7 = (k7 - 1)
            For Each dr As DataGridViewRow In Module8dgv.Rows
                If dr.Cells("pos").Value = 2 Then
                    Module8dgv.Rows.Remove(dr)
                End If
            Next
        Loop
        Dim l7 As Integer = (Module8dgv.Rows.Count - 1)
        Do While (l7 >= 0)
            l7 = (l7 - 1)
            For Each dr As DataGridViewRow In Module8dgv.Rows
                If dr.Cells("pos").Value = 3 Then
                    Module8dgv.Rows.Remove(dr)
                End If
            Next
        Loop

        For intI7 = Module8dgv.Rows.Count - 1 To 0 Step -1
            For intJ7 = intI7 - 1 To 0 Step -1
                If Module8dgv.Rows(intI7).Cells(1).Value = Module8dgv.Rows(intJ7).Cells(1).Value AndAlso Module8dgv.Rows(intI7).Cells(3).Value = Module8dgv.Rows(intJ7).Cells(3).Value Then
                    Module8dgv.Rows.RemoveAt(intI7)
                    Exit For
                End If
            Next
        Next
        Module8dgv.Sort(Module8dgv.Columns(3), System.ComponentModel.ListSortDirection.Ascending)

    End Sub
    Private Sub btn_Import_form2_Click(sender As Object, e As EventArgs) Handles btn_Import_form2.Click
        Dim frm As New Form2
        frm.Show(Form2)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dgv1()
        Dgv2()
        Dgv3()
        Dgv4()
        Dgv5()
        Dgv6()
        Dgv7()
        Dgv8()


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If ComboBox2.Text & ComboBox2.Text <> " " Then


            positionDataGridView.Rows.Clear()

            Dim ligne1 As Integer = (Me.Module1dgv.Rows.Count - 1)
            Dim ligne2 As Integer = (Me.Module2dgv.Rows.Count - 1)
            Dim ligne3 As Integer = (Me.Module3dgv.Rows.Count - 1)
            Dim ligne4 As Integer = (Me.Module4dgv.Rows.Count - 1)
            Dim ligne5 As Integer = (Me.Module5dgv.Rows.Count - 1)
            Dim ligne6 As Integer = (Me.Module6dgv.Rows.Count - 1)
            Dim ligne7 As Integer = (Me.Module7dgv.Rows.Count - 1)
            Dim ligne8 As Integer = (Me.Module8dgv.Rows.Count - 1)
            If Module1dgv.Name = ComboBox2.Text Then
                For dr1 = 0 To ligne1 - 1
                    Dim Val1 As Integer = Module1dgv(3, dr1).Value - 1
                    '  Dim CellChange As String = positionDataGridView.Rows(0).Cells(Val1).Value
                    positionDataGridView.Rows(0).Cells(Val1).Style.BackColor = Color.Green
                Next

            End If

            If Module2dgv.Name = ComboBox2.Text Then
                For dr2 = 0 To ligne2 - 1
                    Dim Val2 As Integer = Module2dgv(3, dr2).Value - 1
                    '  Dim CellChange As String = positionDataGridView.Rows(0).Cells(Val2).Value
                    positionDataGridView.Rows(0).Cells(Val2).Style.BackColor = Color.Green
                Next
            End If

            If Module3dgv.Name = ComboBox2.Text Then
                For dr3 = 0 To ligne3 - 1
                    Dim Val3 As Integer = Module3dgv(3, dr3).Value - 1
                    '    Dim CellChange As String = positionDataGridView.Rows(0).Cells(Val3).Value
                    positionDataGridView.Rows(0).Cells(Val3).Style.BackColor = Color.Green
                Next
            End If

            If Module4dgv.Name = ComboBox2.Text Then
                For dr4 = 0 To ligne4 - 1
                    Dim Val4 As Integer = Module4dgv(3, dr4).Value - 1
                    '     Dim CellChange As String = positionDataGridView.Rows(0).Cells(Val4).Value
                    positionDataGridView.Rows(0).Cells(Val4).Style.BackColor = Color.Green
                Next
            End If

            If Module5dgv.Name = ComboBox2.Text Then
                For dr5 = 0 To ligne5 - 1
                    Dim Val5 As Integer = Module5dgv(3, dr5).Value - 1
                    '     Dim CellChange As String = positionDataGridView.Rows(0).Cells(Val5).Value
                    positionDataGridView.Rows(0).Cells(Val5).Style.BackColor = Color.Green
                Next
            End If

            If Module6dgv.Name = ComboBox2.Text Then
                For dr6 = 0 To ligne6 - 1
                    Dim Val6 As Integer = Module6dgv(3, dr6).Value - 1
                    '      Dim CellChange As String = positionDataGridView.Rows(0).Cells(Val6).Value
                    positionDataGridView.Rows(0).Cells(Val6).Style.BackColor = Color.Green
                Next
            End If

            If Module7dgv.Name = ComboBox2.Text Then
                For dr7 = 0 To ligne7 - 1
                    Dim Val7 As Integer = Module7dgv(3, dr7).Value - 1
                    '         Dim CellChange As String = positionDataGridView.Rows(0).Cells(Val7).Value
                    positionDataGridView.Rows(0).Cells(Val7).Style.BackColor = Color.Green
                Next
            End If

            If Module8dgv.Name = ComboBox2.Text Then
                For dr8 = 0 To ligne8 - 1
                    Dim Val8 As Integer = Module8dgv(3, dr8).Value - 1
                    '          Dim CellChange As String = positionDataGridView.Rows(0).Cells(Val8).Value
                    positionDataGridView.Rows(0).Cells(Val8).Style.BackColor = Color.Green
                Next
            End If
        End If

    End Sub


    Private Sub Rafrechir_Click(sender As Object, e As EventArgs) Handles Rafrechir.Click

    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm As New Form3
        '  Dim frm1 As New Form5
        frm.Show(Form3)
        '  frm1.Show(Form3)
    End Sub



End Class