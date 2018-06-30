Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FormAjoutAction

    Private Sub FormAjoutAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCommentaire.Text = ""
        txtDateAction.Text = ""
        txtDateRelance.Text = ""

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



        cmd.CommandText = "Select LibTypeAction from TYPE_ACTION"

        JeuEnr = cmd.ExecuteReader()

        While JeuEnr.Read()
            cboTypeAction.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()
        cnn.Close()

        cboRelance.Items.Add("True")
        cboRelance.Items.Add("False")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        cmd = New SqlCommand()
        cnn.Open()

        cmd = New SqlCommand()

        Dim Id As Integer

        cmd.Connection = cnn

        cmd.CommandText = "Select IdContact FROM CONTACT  WHERE NomContact = '" & cboNomContact.Text & " ' and PrenomContact = '" & cboPrenomContact.Text & "'"

        JeuEnr = cmd.ExecuteReader()

        JeuEnr.Read()


        Id = JeuEnr.GetValue(0)

        JeuEnr.Close()
        cnn.Close()

        txtIdContact.Text = Id





        Dim Entreprise As String
        cmd = New SqlCommand()
        cmd.Connection = cnn

        cnn.Open()

        ' Mettre en place une requête SQL : une commande 


        cmd.CommandText = "SELECT IdTypeAction FROM TYPE_ACTION WHERE LibTypeAction = '" & cboTypeAction.Text & "' "

        JeuEnr = cmd.ExecuteReader()
        JeuEnr.Read()

        Entreprise = JeuEnr.GetValue(0)

        cnn.Close()




        cnn.Open()

        cmd.CommandText = "select cast('" & txtDateAction.Text & "' as datetime) AS MyDate"

        cnn.Close()

        cnn.Open()

        cmd.CommandText = "select cast('" & txtDateRelance.Text & "' as datetime) AS MyDate"

        cnn.Close()



        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "INSERT INTO ACTION (DateAction, Commentaire, ARelancer, DateRelance, IdContact, IdTypeAction) VALUES ('" & txtDateAction.Text & "',  '" & txtCommentaire.Text & "',  '" & cboRelance.Text & "',  '" & txtDateRelance.Text & "', '" & txtIdContact.Text & "', '" & Entreprise & "')"


        cmd.ExecuteNonQuery()

        'Fermer la connexion 
        cnn.Close()

        MsgBox("L'action à été ajoutée avec succès à la base de données.")

        txtCommentaire.Text = ""
        txtDateAction.Text = ""
        txtDateRelance.Text = ""
        cboNomContact.Text = ""
        cboPrenomContact.Text = ""
        cboTypeAction.Text = ""
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

        cmd.CommandText = "Select PrenomContact from CONTACT where NomContact = '" & cboNomContact.Text & "'"

        JeuEnr = cmd.ExecuteReader()
        While JeuEnr.Read()

            cboPrenomContact.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()

        cnn.Close()


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        
        Me.txtDateAction.Text = Me.DateTimePicker1.Text

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Me.txtDateRelance.Text = Me.DateTimePicker2.Text
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        FormAjoutContact.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        FormAjoutTypeAction.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        formAction.Show()
    End Sub
End Class