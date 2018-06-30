Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FormAjoutContact


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Etablir la connexion avec la BDD '
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        ' Mettre en place une requête SQL : une commande 
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        Dim Entreprise As Integer
        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "SELECT IdEntreprise FROM ENTREPRISE WHERE RaisonSociale = '" & SelectEntreprise.Text & "' "

        JeuEnr = cmd.ExecuteReader()
        JeuEnr.Read()

        Entreprise = JeuEnr.GetValue(0)

        cnn.Close()

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "INSERT INTO CONTACT (Titre, NomContact, PrenomContact, MailContact, TelInterneContact, TelPortable, IdEntreprise) VALUES ('" & cboTitre.Text & "',  '" & txtNomContact.Text & "',  '" & txtPrenomContact.Text & "',  '" & txtMailContact.Text & "', '" & txtNumIntern.Text & "', '" & txtNumeroDePortable.Text & "', '" & Entreprise & "')"


        cmd.ExecuteNonQuery()

        'Fermer la connexion 
        cnn.Close()

        MsgBox("Le contact à été ajouté avec succès à la base de données.")

        txtMailContact.Text = ""
        txtNomContact.Text = ""
        txtNumeroDePortable.Text = ""
        txtNumIntern.Text = ""
        txtPrenomContact.Text = ""
        cboTitre.Text = ""
        SelectEntreprise.Text = ""


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        ' Mettre en place une requête SQL : une commande 
        Dim cmd As SqlCommand

        cmd = New SqlCommand()
        cmd.Connection = cnn
        Dim JeuEnr As SqlDataReader
        cmd.CommandText = "Select RaisonSociale from ENTREPRISE"

        JeuEnr = cmd.ExecuteReader()
        While JeuEnr.Read()
            SelectEntreprise.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()
        cnn.Close()

        cboTitre.Items.Add("M")
        cboTitre.Items.Add("Mme")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormAjoutEntreprise.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        formContact.Show()
    End Sub
End Class
