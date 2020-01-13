

Imports MySql.Data.MySqlClient

Public Class Form1

    Public Function connecter()
        '  Dim Connexion As String = "Server=localhost;Database=gestransfert;Uid=pierrengb;Pwd=pierrengb2014;"
        Dim Connexion As String = "server=127.0.0.1;user id=root;database=prod"
        Dim conn As MySqlConnection = New MySqlConnection

        conn.ConnectionString = Connexion
        conn.Open()
        Return conn
    End Function

    Private Sub Fonds_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim lecteur As MySqlDataReader
            Dim Requete As String
            connecter.Close()
            connecter()
            Requete = "select Code_agence from agence"
            Dim Commande As New MySqlCommand(Requete, connecter)
            lecteur = Commande.ExecuteReader
            Do While lecteur.Read
                ComboBox2.Items.Add(lecteur.GetString("Code_agence"))
            Loop
            connecter.Close()
        End Sub
    'Ensuite il est meêm possible de faire une insertion
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim code, nom, postnom, tel, adr, email, sexe As MySqlParameter
        connecter()
        Dim sql As String
        sql = "INSERT INTO expediteur VALUES (@code, @nom, @postnom, @tel, @adr, @email, @sexe)"

        Dim query As New MySqlCommand(sql, connecter)
        code = New MySqlParameter("@code", TextBox1.Text)
        nom = New MySqlParameter("@nom", TextBox2.Text)
        postnom = New MySqlParameter("@postnom", TextBox3.Text)
        tel = New MySqlParameter("@tel", TextBox4.Text)
        adr = New MySqlParameter("@adr", TextBox5.Text)
        email = New MySqlParameter("@email", TextBox6.Text)
        sexe = New MySqlParameter("@sexe", TextBox7.Text)

        query.Parameters.Add(code)
        query.Parameters.Add(nom)
        query.Parameters.Add(postnom)
        query.Parameters.Add(tel)
        query.Parameters.Add(adr)
        query.Parameters.Add(email)
        query.Parameters.Add(sexe)

        query.ExecuteNonQuery()
        connecter.close()
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
