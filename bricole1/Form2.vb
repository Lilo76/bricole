Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Btn_page_import_Click(sender As Object, e As EventArgs) Handles Btn_page_import.Click

        Dim conStr As String = "server=127.0.0.1;user id=root;database=prod"
        Dim Con As New MySqlConnection(conStr)
        Dim obj As MySqlCommand
        Dim nomtable As String = txt_nomTable.Text
        Dim strSQL As String
        If Not Con Is Nothing Then Con.Close()

        '   obj = Con.CreateCommand()
        Con = New MySqlConnection(conStr)
            Con.Open()

        obj = Con.CreateCommand()
        Try
            strSQL = "SELECT * FROM " & nomtable & ""

            Dim Search As New MySqlDataAdapter(strSQL, Con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, nomtable)
            DataGridView1.DataSource = ds.Tables(nomtable)
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Con.Close()
        End Try
        DataGridView1.Sort(DataGridView1.Columns(4), System.ComponentModel.ListSortDirection.Ascending)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim list() As String
        ReDim list(1)
        Dim nb = 1
        Dim dt As New DataTable
        '  Dim strSQL As String
        Dim nomtable As String = txt_nomTable.Text

        DataGridView1.Columns(0).Name = "IdDataGridViewTextBoxColumn"
        DataGridView1.Columns(1).Name = "MachDataGridViewTextBoxColumn"
        DataGridView1.Columns(2).Name = "PosDataGridViewTextBoxColumn"
        DataGridView1.Columns(3).Name = "PartDataGridViewTextBoxColumn"
        DataGridView1.Columns(4).Name = "NumDataGridViewTextBoxColumn"
        DataGridView1.Columns(5).Name = "FeederDataGridViewTextBoxColumn"
        DataGridView1.Columns(6).Name = "TypeDataGridViewTextBoxColumn"
        DataGridView1.Columns(7).Name = "WidthDataGridViewTextBoxColumn"
        DataGridView1.Columns(8).Name = "FeedDataGridViewTextBoxColumn"
        DataGridView1.Columns(9).Name = "PitchDataGridViewTextBoxColumn"
        DataGridView1.Columns(10).Name = "NbPartDataGridViewTextBoxColumn"
        DataGridView1.Columns(11).Name = "HeightDataGridViewTextBoxColumn"
        DataGridView1.Columns(12).Name = "StatusDataGridViewTextBoxColumn"
        DataGridView1.Columns(13).Name = "QtyDataGridViewTextBoxColumn"
        ' strSQL = "CREATE TABLE " & nomtable & " (id int(4) NOT NULL, mach VARCHAR (25), pos int(4), part int(4), num int(12), feeder VARCHAR (25), type VARCHAR (25), width int(4), feed VARCHAR (25), pitch VARCHAR (25), nbPart int(4), height VARCHAR (25), status VARCHAR (25), qty int(4))"
        'premier element du tableau = premier element du DataGirdView
        list(1) = DataGridView1.Item(4, 0).Value.ToString
        For i = 1 To DataGridView1.RowCount - 2
            'si la ligne (i-1) est différente de la ligne (i)
            If DataGridView1.Item(4, i - 1).Value.ToString <> DataGridView1.Item(4, i).Value.ToString Then
                nb = nb + 1
                'je la garde
                ReDim Preserve list(nb)
                'je la stocke
                list(nb) = DataGridView1.Item(4, i).Value.ToString
            End If
        Next
        'j'efface les éléments du tableau

        ' DataGridView1.Rows.Clear()
        'je mets mon nouveau tableau dans mon DataGirdView
        For i = 1 To nb
            '    Form1.DataGridView2.Rows.Add(False, list(i))
        Next
    End Sub
End Class