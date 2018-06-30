Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class formAjoutProduit


    Private Sub BoutonAjouter_Click(sender As Object, e As EventArgs) Handles BoutonAjouter.Click


        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")


        cnn.Open()
        Dim cmd As SqlCommand
        Dim cmd1 As SqlCommand
        Dim cmd2 As SqlCommand

        cmd = New SqlCommand
        cmd1 = New SqlCommand
        cmd2 = New SqlCommand

        Dim JeuEnr1 As SqlDataReader
        Dim JeuEnr2 As SqlDataReader

        cmd.Connection = cnn
        cmd1.Connection = cnn
        cmd2.Connection = cnn

        ' //récupérer les identifiants correpondants aux choix des combos
        Dim widCollection As Integer
        Dim widCategorie As Integer

        cmd1.CommandText = "Select idCollection from COLLECTION WHERE nomCollection='" & cboCollection.Text & "'"

        JeuEnr1 = cmd1.ExecuteReader()

        JeuEnr1.Read()
        widCollection = JeuEnr1.GetValue(0)
        JeuEnr1.Close()

        cmd2.CommandText = "Select idCategorie from CATEGORIE WHERE libCategorie='" & cboCategorie.Text & "'"
        JeuEnr2 = cmd2.ExecuteReader()

        JeuEnr2.Read()
        widCategorie = JeuEnr2.GetValue(0)

        JeuEnr2.Close()


        '//insérer dans la table

        cmd.CommandText = "INSERT INTO PRODUIT(libelleProduit, descproduit, PUProduit, image, idCollection, idCategorie) VALUES ('" & TxtLibelleProduit.Text & "', '" & TxtDescProduit.Text & "', '" & TxtPUProduit.Text & "',''," & widCollection & "," & widCategorie & " )"

        cmd.ExecuteNonQuery()

        'récupérer l'id du produit insérer max(idProduit)
        Dim jeuEnr As SqlDataReader
        Dim jeuEnr4 As SqlDataReader
        Dim idProduit As Integer
        Dim idCarac As Integer


        cmd.CommandText = " SELECT MAX(idProduit) FROM PRODUIT "
        JeuEnr = cmd.ExecuteReader()

        JeuEnr.Read()
        idProduit = jeuEnr.GetValue(0)

        jeuEnr.Close()

        Dim carac As String

        For Each carac In ChecklistCara.CheckedItems

            'récup id carac
            cmd.CommandText = "SELECT idCaracteristique FROM CARACTERISTIQUE WHERE libCaracteristique = '" & carac & "'"
            JeuEnr4 = cmd.ExecuteReader()
            jeuEnr4.Read()
            idCarac = jeuEnr4.GetValue(0)
            jeuEnr4.Close()
            'insert into PRODUIT_CARACTERISTIQUE (idProduit, idCarac) VALUES(idProduit, idCara)
            cmd.CommandText = "INSERT INTO PRODUIT_CARACTERISTIQUE (idProduit, IdCarac) VALUES(" & idProduit & ", " & idCarac & ")"
            cmd.ExecuteNonQuery()


        Next
        cnn.Close()

        MsgBox("Le produit à été ajouté avec succès à la base de données.")

        TxtDescProduit.Text = ""
        TxtLibelleProduit.Text = ""
        TxtPUProduit.Text = ""
        cboCategorie.Text = ""
        cboCollection.Text = ""

    End Sub


    Private Sub AjouterProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtLibelleProduit.Text = ""
        TxtDescProduit.Text = ""
        TxtPUProduit.Text = ""
        'penser à faire de même pour le champ image

        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")
        cnn.Open()


        Dim cmd As SqlCommand 'decla d'un objet de la classe SqlCommand
        Dim JeuEnr As SqlDataReader


        cmd = New SqlCommand() 'instanciation
        cmd.Connection = cnn 'affectation d'une valeur a un attribut
        cmd.CommandText = "Select DISTINCT libCategorie from CATEGORIE ORDER BY 1"

        JeuEnr = cmd.ExecuteReader()


        While JeuEnr.Read
            cboCategorie.Items.Add(JeuEnr.GetValue(0))

        End While

        JeuEnr.Close() ' On appel la méthode Close 

        cmd = New SqlCommand() 'instanciation
        cmd.Connection = cnn 'affectation d'une valeur a un attribut
        cmd.CommandText = "Select DISTINCT nomCollection from COLLECTION ORDER BY 1"

        JeuEnr = cmd.ExecuteReader()
        While JeuEnr.Read()
            cboCollection.Items.Add(JeuEnr.GetValue(0))

        End While
        JeuEnr.Close()

        cmd = New SqlCommand
        cmd.Connection = cnn

        cmd.CommandText = "SELECT LibCaracteristique FROM CARACTERISTIQUE"
        JeuEnr = cmd.ExecuteReader

        While JeuEnr.Read
            ChecklistCara.Items.Add(JeuEnr.GetValue(0))

        End While

        JeuEnr.Close()

        cnn.Close()

        cnn.Close()



    End Sub

    Private Sub ButtonNouveau_Click(sender As Object, e As EventArgs)
        TxtLibelleProduit.Text = ""
        TxtDescProduit.Text = ""
        TxtPUProduit.Text = ""

    End Sub


    Private Sub ChecklistCara_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChecklistCara.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        formAjoutCollec.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formAjoutCateg.Show()
        Me.Close()
    End Sub

    Private Sub BtnAjoutProdRetour_Click(sender As Object, e As EventArgs) Handles BtnAjoutProdRetour.Click
        formProduit.Show()
        Me.Close()
    End Sub

    Private Sub cboCollection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCollection.SelectedIndexChanged

    End Sub
End Class