Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FormAjoutEntreprise

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        ' Mettre en place une requête SQL : une commande 
        Dim cmd As SqlCommand

        cmd = New SqlCommand()
        cmd.Connection = cnn
        Dim JeuEnr As SqlDataReader
        cmd.CommandText = "Select LibPays from Pays"

        JeuEnr = cmd.ExecuteReader()
        While JeuEnr.Read()
            cboCodePays.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()
        cnn.Close()

        cnn.Open()
        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select LibTypeEnt from Type_Ent"
        JeuEnr = cmd.ExecuteReader()
        While JeuEnr.Read()
            cboIdTypeEnt.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()
        cnn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Etablir la connexion avec la BDD '
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        ' Mettre en place une requête SQL : une commande 
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        Dim Pays As String
        Dim Type As Integer
        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "SELECT CodePays FROM PAYS WHERE LibPays = '" & cboCodePays.Text & "' "

        JeuEnr = cmd.ExecuteReader()
        JeuEnr.Read()

        Pays = JeuEnr.GetValue(0)

        cnn.Close()

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "SELECT IdTypeEnt FROM TYPE_ENT WHERE LibTypeEnt = '" & cboIdTypeEnt.Text & "' "

        JeuEnr = cmd.ExecuteReader()
        JeuEnr.Read()

        Type = JeuEnr.GetValue(0)

        cnn.Close()

        cnn.Open()



        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "INSERT INTO ENTREPRISE (RaisonSociale, AdresseRue, CodePostal, Ville, CodePays,  IdTypEnt) VALUES ('" & txtRaisonSocial.Text & "',  '" & txtAdresseRue.Text & "',  '" & txtCodePostal.Text & "',  '" & txtVille.Text & "', '" & Pays & "', '" & Type & "')"


        cmd.ExecuteNonQuery()

        MsgBox("L'entreprise à été ajouté avec succès à la base de données.")

        'Fermer la connexion 
        cnn.Close()

        txtAdresseRue.Text = ""
        txtCodePostal.Text = ""
        txtRaisonSocial.Text = ""
        txtVille.Text = ""
        cboCodePays.Text = ""
        cboIdTypeEnt.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        FormAjoutPays.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        FormAjoutTypeEntreprise.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        FormAjoutContact.Show()
    End Sub
End Class