Imports MySql.Data.MySqlClient

Public Class VBMySQL
    Dim _Server As Object
    Dim _UserName As Object
    Dim _Password As Object
    Dim _Database As Object
    '  Public Property Server = "xxx.xxx.xxx.xxx"
    ' Public Property UserName = "user"
    '  Public Property Password = "password"
    '  Public Property Database = "db"
    Public Property Server
        Get
            Return _Server
        End Get
        Set
            _Server = Value
        End Set
    End Property
    Public Property UserName
        Get
            Return _UserName
        End Get
        Set
            _UserName = Value
        End Set
    End Property
    Public Property Password
        Get
            Return _Password
        End Get
        Set
            _Password = Value
        End Set
    End Property
    Public Property Database
        Get
            Return _Database
        End Get
        Set
            _Database = Value
        End Set
    End Property

    Public Function GetConnectionString() As String
        Return $"server = {Server};userid={UserName};password{Password};database{Database}"
    End Function
    Public Function Retrieve_Row(SQLStatement As String) As ArrayList
        Dim Result As New ArrayList
        Dim Reader As MySqlDataReader
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand
        Try
            MySQL_Connection.ConnectionString = GetConnectionString()
            MySQL_Command.CommandText = SQLStatement
            MySQL_Command.Connection = MySQL_Connection
            MySQL_Connection.Open()
            Reader = MySQL_Command.ExecuteReader
            While Reader.Read()
                Dim dict As New Dictionary(Of String, Object)
                For count As Integer = 0 To (Reader.FieldCount - 1)
                    dict.Add(Reader.GetName(count), Reader(count))
                Next
                Result.Add(dict)
            End While
            Reader.Close()
            MySQL_Connection.Close()
        Catch ex As Exception
            Console.WriteLine("MySQL retrieve row: " & ex.Message & Err.Number)
        Finally
            MySQL_Connection.Dispose()
            MySQL_Connection = Nothing
            Reader = Nothing
        End Try
        GC.Collect()
        Return Result
    End Function
    Public Function Retrieve_Value(SQLStatement As String) As String
        Dim Result As String
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand
        Try
            MySQL_Connection.ConnectionString = GetConnectionString()
            MySQL_Command.CommandText = SQLStatement
            MySQL_Command.Connection = MySQL_Connection
            MySQL_Connection.Open()
            Result = MySQL_Command.ExecuteScalar()
            MySQL_Connection.Close()
        Catch ex As Exception
            Console.WriteLine("MySQL retrieve value: " & ex.Message & Err.Number)
            Result = Nothing
        Finally
            MySQL_Connection.Dispose()
            MySQL_Connection = Nothing
        End Try
        GC.Collect()
        Return Result
    End Function
    Public Function Retrieve_Table(SQLStatement As String) As DataTable
        Dim table As New DataTable
        Dim Reader As MySqlDataReader
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand
        Try
            MySQL_Connection.ConnectionString = GetConnectionString()
            MySQL_Command.CommandText = SQLStatement
            MySQL_Command.Connection = MySQL_Connection
            MySQL_Connection.Open()
            Reader = MySQL_Command.ExecuteReader
            table.Load(Reader)
            Reader.Close()
            MySQL_Connection.Close()
        Catch ex As Exception
            Console.WriteLine("MySQL retrieve table: " & ex.Message & Err.Number)
            table = Nothing
        Finally
            MySQL_Connection.Dispose()
            MySQL_Connection = Nothing
            Reader = Nothing
        End Try
        GC.Collect()
        Return table
    End Function
    Public Function Insert_Row(SQLStatement As String) As Boolean
        Insert_Row = False
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand
        Try
            MySQL_Connection.ConnectionString = GetConnectionString()
            MySQL_Command.CommandText = SQLStatement
            MySQL_Command.Connection = MySQL_Connection
            MySQL_Connection.Open()
            MySQL_Command.ExecuteNonQuery()
            MySQL_Connection.Close()
            Insert_Row = True
        Catch ex As MySqlException
            Console.WriteLine("MySQL insert: " & ex.Message & Err.Number)
            Insert_Row = False
        Finally
            MySQL_Connection.Dispose()
            MySQL_Connection = Nothing
        End Try
        GC.Collect()
    End Function
    Public Function Delete_Row(SQLStatement As String) As Boolean
        Delete_Row = False
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand
        Try
            MySQL_Connection.ConnectionString = GetConnectionString()
            MySQL_Command.CommandText = SQLStatement
            MySQL_Command.Connection = MySQL_Connection
            MySQL_Connection.Open()
            MySQL_Command.ExecuteNonQuery()
            MySQL_Connection.Close()
            Delete_Row = True
        Catch ex As MySqlException
            Console.WriteLine("MySQL delete: " & ex.Message & Err.Number)
            Delete_Row = False
        Finally
            MySQL_Connection.Dispose()
            MySQL_Connection = Nothing
        End Try
        GC.Collect()
    End Function
End Class