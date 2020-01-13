Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form1



    Private Sub Btn_page_import_Click(sender As Object, e As EventArgs) Handles btn_page_import.Click

        Dim selectedFile As String = String.Empty
        OpenFileDialog1.Title = "Choisissez "
        OpenFileDialog1.Filter = "csv|*.csv"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.InitialDirectory = "G:\Recherche\Chargement prog\"
        OpenFileDialog1.ShowDialog()
        selectedFile = OpenFileDialog1.FileName

        If (selectedFile IsNot Nothing) Then
            TxtBox_Dir.Text = selectedFile
        End If

        Dim dt As New DataTable
        Dim SR As StreamReader = File.OpenText(TxtBox_Dir.Text) '
        Dim newline() As String = SR.ReadLine.Split(";")

        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize

        dt.Columns.AddRange({New DataColumn(newline(0)), New DataColumn(newline(1)), New DataColumn(newline(2)), New DataColumn(newline(3)),
                            New DataColumn(newline(4)), New DataColumn(newline(5)), New DataColumn(newline(6)), New DataColumn(newline(7)),
                            New DataColumn(newline(8)), New DataColumn(newline(9)), New DataColumn(newline(10)), New DataColumn(newline(11)),
                            New DataColumn(newline(12)), New DataColumn(newline(13))})

        While (Not SR.EndOfStream)
            newline = SR.ReadLine.Split(";")
            Dim newrow As DataRow = dt.NewRow

            newrow.ItemArray = {newline(0), newline(1), newline(2), newline(3), newline(4), newline(5), newline(6), newline(7), newline(8), newline(9), newline(10),
                newline(11), newline(12), newline(13)}

            dt.Rows.Add(newrow)

        End While

        DataGridView1.DataSource = dt

    End Sub

    Private Function Connect(ByVal server As String, ByRef user As String, ByRef password As String, ByRef database As String)
        ' Connection string with MySQL Info
        Dim conn As MySqlConnection = New MySqlConnection
        conn.ConnectionString = "server=" + server + ";" _
        & "user id=" + user + ";" _
        & "password=" + password + ";" _
        & "database=" + database + ";"
        Try
            conn.Open()
            Return True
        Catch ex As MySqlException
            Return MsgBox(ex.Message)
        End Try
    End Function

    Public Function connecter()


        Dim Connexion As String = "server=127.0.0.1;user id=root;database=prod" 'Connect Timeout=200
        Dim conn As MySqlConnection = New MySqlConnection
        Try
            conn.ConnectionString = Connexion
            conn.Open()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
        Return conn

    End Function



    Private Sub btn_CreateAndCopy_Click(sender As Object, e As EventArgs) Handles btn_CreateAndCopy.Click


        Dim conStr As String = "server=127.0.0.1;user id=root;database=prod"
        Dim objCon As New MySqlConnection(conStr)
        Dim obj As MySqlCommand
        Dim nomtable As String = txt_nomTable.Text
        Dim strSQL As String

        objCon = New MySqlConnection(conStr)
        objCon.Open()
        obj = objCon.CreateCommand()
        strSQL = "CREATE TABLE " & nomtable & " (id int(4) , mach VARCHAR (25), pos int(4), part int(4), num int(12), feeder VARCHAR (25), type VARCHAR (25), width int(4), feed VARCHAR (25), pitch VARCHAR (25), nbPart int(4), height VARCHAR (25), status VARCHAR (25), qty int(4))" 'NOT NULL
        ' Execute
        obj.CommandText = strSQL

        Try
            obj.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        objCon.Close()
        objCon = Nothing

        For index As Integer = 0 To DataGridView1.RowCount - 2

            Dim connectionString = "server=127.0.0.1;user id=root;database=prod"
            Dim query0 = "insert into " & nomtable & "(Id,Mach,Pos,Part,Num,Feeder,Type,Width,Feed,Pitch,NbPart,Height,Status,Qty) values(@Id,@Mach,@Pos,@Part,@Num,@Feeder,@Type,@Width,@Feed,@Pitch,@NbPart,@Height,@Status,@Qty)"
            Dim connection0 As New MySqlConnection(connectionString)
            Dim command0 As New MySqlCommand(query0, connection0)
            connection0.Close()
            command0.Parameters.AddWithValue("@Id", DataGridView1.Rows(index).Cells(0).Value)
            command0.Parameters.AddWithValue("@Mach", DataGridView1.Rows(index).Cells(1).Value)
            command0.Parameters.AddWithValue("@Pos", DataGridView1.Rows(index).Cells(2).Value)
            command0.Parameters.AddWithValue("@Part", DataGridView1.Rows(index).Cells(3).Value)
            command0.Parameters.AddWithValue("@Num", DataGridView1.Rows(index).Cells(4).Value)
            command0.Parameters.AddWithValue("@Feeder", DataGridView1.Rows(index).Cells(5).Value)
            command0.Parameters.AddWithValue("@Type", DataGridView1.Rows(index).Cells(6).Value)
            command0.Parameters.AddWithValue("@Width", DataGridView1.Rows(index).Cells(7).Value)
            command0.Parameters.AddWithValue("@Feed", DataGridView1.Rows(index).Cells(8).Value)
            command0.Parameters.AddWithValue("@Pitch", DataGridView1.Rows(index).Cells(9).Value)
            command0.Parameters.AddWithValue("@NbPart", DataGridView1.Rows(index).Cells(10).Value)
            command0.Parameters.AddWithValue("@Height", DataGridView1.Rows(index).Cells(11).Value)
            command0.Parameters.AddWithValue("@Status", DataGridView1.Rows(index).Cells(12).Value)
            command0.Parameters.AddWithValue("@Qty", DataGridView1.Rows(index).Cells(13).Value)
            Try
                connection0.Open()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MessageBox.Show(ex.Message)
            End Try
            command0.Connection = connection0
            command0.ExecuteNonQuery()
            connection0.Close()
        Next

    End Sub

    Private Sub btn_form2_Click(sender As Object, e As EventArgs) Handles btn_form2.Click
        Dim frm As New Form2
        frm.Show(Form2)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
