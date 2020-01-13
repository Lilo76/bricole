Public Class Form2
    Dim d = txtData
    Dim s = txt_server
    Dim p = txtpwd
      Dim u = txtEntryBy
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Dim CreateMySQL As New VBMySQL With {.Database = d, .Server = s, .Password = p, .UserName = u}
        Try
            CreateMySQL.Insert_Row("INSERT INTO `Test_Table`(`entry_by`, `test_data`) VALUES('" & txtEntryBy.Text & "','" & txtData.Text & "')")
        Catch ex As Exception
            Console.WriteLine("Creation error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click
        ReadDataFromDB()
    End Sub
    Private Sub ReadDataFromDB()

        Dim retrieveTable As New DataTable
        Dim RetrieveMySQL As New VBMySQL With {.Database = d, .Server = s, .Password = p, .UserName = u}
        Try
            retrieveTable = RetrieveMySQL.Retrieve_Table("SELECT * FROM `Test_Table`")
            If retrieveTable.CreateDataReader.HasRows = False Then
                Console.WriteLine("No records for table")
            End If
            Dim row As DataRow
            dgTest.Rows.Clear()
            For Each row In retrieveTable.Rows
                dgTest.Rows.Add(row("ID_test"), row("entry_by"), Format(row("entry_date"), "MM-dd-yyyy"), row("test_data"))
            Next
            retrieveTable = Nothing
        Catch ex As Exception
            Console.WriteLine("Retrieve error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgTest_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTest.CellContentClick

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class