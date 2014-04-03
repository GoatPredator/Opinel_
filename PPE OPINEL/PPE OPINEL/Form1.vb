Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class Form1
   
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1;Password=SIO1MDP")
        cnn.Open()
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select libCollection From COLLECTION"
        JeuEnr = cmd.ExecuteReader
        While JeuEnr.Read
            cboCollection.Items.Add(JeuEnr.GetValue(1))
        End While
        JeuEnr.Close()
       

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select libGamme From GAMME"
        JeuEnr = cmd.ExecuteReader
        While JeuEnr.Read
            cboGamme.Items.Add(JeuEnr.GetValue(0))
        End While
        JeuEnr.Close()
        cnn.Close()

        cboCollection.Items.Add("Tradition")
        cboCollection.Items.Add("Effillé")
        cboCollection.Items.Add("Cuisine")
        cboCollection.Items.Add("Table")
        cboCollection.Items.Add("Nature")
        cboCollection.Items.Add("Accessoires")
        cboCollection.Items.Add("Séries limitées")
        cboGamme.Items.Add("Couleurs")
        cboGamme.Items.Add("Gravures")
        cboGamme.Items.Add("Chic")
        cboGamme.Items.Add("Luxe")
        cboGamme.Items.Add("Bubinga")
        cboGamme.Items.Add("Eplucheur")
        cboGamme.Items.Add("Tartineur")
        cboGamme.Items.Add("Jardinage")
        cboGamme.Items.Add("Elégand")



    End Sub


    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim connectionString As String
        Dim cnn As SqlConnection

        connectionString = "Data Source=172.30.0.115;Initial Catalog=OPINEL_GestionCo;User ID=SIO1;Password=SIO1MDP"

        cnn = New SqlConnection(connectionString)


        cnn.Open()

        Dim cmd As SqlCommand

        cmd = New SqlCommand()
        cmd.Connection = cnn


        cmd.CommandText = "INSERT INTO COLLECTION (codeCollection,libCollection,descCollection) VALUES ( " & .Text & ", '" & .Text & "',  '" & .Text & "')"

        cmd.ExecuteNonQuery()

        cnn.Close()

    End Sub
End Class
































































