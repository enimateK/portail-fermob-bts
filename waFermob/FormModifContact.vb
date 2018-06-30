Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FormModifContact

    Private Sub FormModifContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select NomContact from CONTACT"

        JeuEnr = cmd.ExecuteReader()
        While JeuEnr.Read()

            cboNomContact.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()

        cmd.CommandText = "Select RaisonSociale from ENTREPRISE"

        JeuEnr = cmd.ExecuteReader()


        While JeuEnr.Read()
            cboEntreprise.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()

        cnn.Close()

        cboTitre.Items.Add("M")
        cboTitre.Items.Add("Mme")

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")
        Dim cmd As SqlCommand
        cmd = New SqlCommand()
        Dim JeuEnr As SqlDataReader
        Dim entreprise As Integer
        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select IdEntreprise FROM ENTREPRISE WHERE RaisonSociale ='" & cboEntreprise.Text & " ' "

        JeuEnr = cmd.ExecuteReader()

        JeuEnr.Read()

        entreprise = JeuEnr.GetValue(0)

        cnn.Close()
        cnn.Open()


        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Update CONTACT SET Titre = '" & cboTitre.Text & "', NomContact = '" & txtNomContact.Text & "', PrenomContact = '" & txtPrenomContact.Text & "' , MailContact = '" & txtMail.Text & "' , TelInterneContact = '" & txtTelInterne.Text & "' , TelPortable = '" & txtTelPortable.Text & "' , IdEntreprise = " & entreprise & " WHERE NomContact = '" & cboNomContact.Text & "' AND PrenomContact = '" & cboPrenomContact.Text & "'"
        cmd.ExecuteNonQuery()

        cnn.Close()

        MsgBox("Le contact a été modifié avec succès.")

        txtIdContact.Text = ""
        txtMail.Text = ""
        txtNomContact.Text = ""
        txtPrenomContact.Text = ""
        txtTelInterne.Text = ""
        txtTelPortable.Text = ""
        cboTitre.Text = ""
        cboEntreprise.Text = ""
        cboNomContact.Text = ""
        cboPrenomContact.Text = ""


    End Sub
    Private Sub cboNomContact_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNomContact.SelectedIndexChanged
        cboPrenomContact.Items.Clear()
        cboPrenomContact.Text = ""

        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        cmd = New SqlCommand()
        cnn.Open()

        cmd = New SqlCommand()

        cmd.Connection = cnn

        cmd.CommandText = "Select PrenomContact FROM CONTACT  WHERE NomContact = '" & cboNomContact.Text & " ' "

        JeuEnr = cmd.ExecuteReader()

        While JeuEnr.Read()
            cboPrenomContact.Items.Add(JeuEnr.GetValue(0))
        End While


        JeuEnr.Close()
        cnn.Close()

    End Sub

    Private Sub cboPrenomContact_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPrenomContact.SelectedIndexChanged
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        cmd = New SqlCommand()
        cnn.Open()

        cmd = New SqlCommand()

        Dim Id As Integer
        Dim Titre As String
        Dim Nom As String
        Dim Prenom As String
        Dim Mail As String
        Dim TelInterne As String
        Dim TelPortable As String
        Dim IdEntreprise As Integer
        Dim libEntreprise As String



        cmd.Connection = cnn

        cmd.CommandText = "Select * FROM CONTACT  WHERE NomContact = '" & cboNomContact.Text & " ' and PrenomContact = '" & cboPrenomContact.Text & "'"

        JeuEnr = cmd.ExecuteReader()

        JeuEnr.Read()

        Id = JeuEnr.GetValue(0)
        Titre = JeuEnr.GetValue(1)
        Nom = JeuEnr.GetValue(2)
        Prenom = JeuEnr.GetValue(3)
        Mail = JeuEnr.GetValue(4)
        TelInterne = JeuEnr.GetValue(5)
        TelPortable = JeuEnr.GetValue(6)
        IdEntreprise = JeuEnr.GetValue(7)

        JeuEnr.Close()
        cnn.Close()

        cnn.Open()


        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select RaisonSociale FROM ENTREPRISE WHERE IdEntreprise ='" & IdEntreprise & " ' "

        JeuEnr = cmd.ExecuteReader()

        JeuEnr.Read()

        libEntreprise = JeuEnr.GetValue(0)

        cnn.Close()

        txtIdContact.Text = Id
        cboTitre.Text = Titre
        txtNomContact.Text = Nom
        txtPrenomContact.Text = Prenom
        txtMail.Text = Mail
        txtTelInterne.Text = TelInterne
        txtTelPortable.Text = TelPortable
        cboEntreprise.Text = libEntreprise
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        formContact.Show()
    End Sub
End Class