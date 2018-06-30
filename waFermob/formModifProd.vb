Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class formModifProd



    Private Sub formModifProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()


        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select libelleProduit from PRODUIT"

        JeuEnr = cmd.ExecuteReader()


        While JeuEnr.Read()
            cboProd.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()
        cmd.CommandText = "Select nomCollection from COLLECTION"

        JeuEnr = cmd.ExecuteReader()


        While JeuEnr.Read()
            cboCollection.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()

        cmd.CommandText = "Select libCATEGORIE from CATEGORIE"

        JeuEnr = cmd.ExecuteReader()


        While JeuEnr.Read()
            cboCateg.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()

        cnn.Close()



    End Sub

    Private Sub btnValid_Click(sender As Object, e As EventArgs) Handles btnValid.Click
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        Dim collection As Integer
        Dim categorie As Integer

        '###########################################
        ' Selection de l'id Collection
        '###########################################

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select idCollection FROM COLLECTION WHERE nomCollection ='" & cboCollection.Text & " ' "

        JeuEnr = cmd.ExecuteReader()

        JeuEnr.Read()

        collection = JeuEnr.GetValue(0)

        cnn.Close()

        '###########################################
        ' Selection de l'id Categorie
        '###########################################

        cnn.Open()


        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select idCategorie FROM CATEGORIE WHERE libCategorie ='" & cboCateg.Text & " ' "

        JeuEnr = cmd.ExecuteReader()

        JeuEnr.Read()

        categorie = JeuEnr.GetValue(0)

        cnn.Close()

        '###########################################
        ' Update du produit
        '###########################################

        cnn.Open()


        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Update PRODUIT SET libelleProduit = '" & txtNom.Text & "', descProduit = '" & txtDesc.Text & "', PUProduit = " & txtPrix.Text & ", idCollection = " & collection & ", idCategorie = " & categorie & " WHERE libelleProduit = '" & cboProd.Text & "'"
        cmd.ExecuteNonQuery()

        cnn.Close()

        txtDesc.Text = ""
        txtNom.Text = ""
        txtPrix.Text = ""
        cboCateg.Text = ""
        cboCollection.Text = ""
        cboProd.Text = ""

    End Sub

    '###############################
    ' Insertion des données à chaque changement de produit
    '###############################


    Private Sub cboProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProd.SelectedIndexChanged
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()


        Dim nom As String
        Dim desc As String
        Dim prix As Integer
        Dim image As String
        Dim col As Integer
        Dim categ As Integer
        Dim collec As String
        Dim categorie As String

        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        cmd = New SqlCommand()

        cmd.Connection = cnn

        cmd.CommandText = "Select * FROM PRODUIT  WHERE libelleProduit = '" & cboProd.Text & " ' "

        JeuEnr = cmd.ExecuteReader()

        JeuEnr.Read()


        nom = JeuEnr.GetValue(1)
        desc = JeuEnr.GetValue(2)
        prix = JeuEnr.GetValue(3)
        image = JeuEnr.GetValue(4)
        col = JeuEnr.GetValue(5)
        categ = JeuEnr.GetValue(6)

        cnn.Close()

        '###############################
        ' Selection de la categorie
        '###############################

        cnn.Open()


        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select libCategorie FROM CATEGORIE WHERE idCategorie ='" & categ & " ' "

        JeuEnr = cmd.ExecuteReader()

        JeuEnr.Read()

        categorie = JeuEnr.GetValue(0)

        cnn.Close()

        '###############################
        ' Selection de la collection
        '###############################

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select nomCollection FROM COLLECTION WHERE idCollection ='" & col & " ' "

        JeuEnr = cmd.ExecuteReader()

        JeuEnr.Read()

        collec = JeuEnr.GetValue(0)

        cnn.Close()

        txtNom.Text = nom
        txtDesc.Text = desc
        txtPrix.Text = prix
        cboCateg.Text = categorie
        cboCollection.Text = collec



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        formProduit.Show()
    End Sub
End Class