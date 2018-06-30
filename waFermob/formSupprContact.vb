Imports Microsoft.VisualBasic
Imports System.Data.SqlClient


Public Class FormSupprContact


    Private Sub FormSuppr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select NomContact from CONTACT"

        JeuEnr = cmd.ExecuteReader()

        'Récupérer les enregistrements : insertion dans cboEmb
        While JeuEnr.Read()
            cboSupprNom.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()

        cnn.Close()

    End Sub

    Private Sub BtnSuppr_Click(sender As Object, e As EventArgs) Handles btnSupprCon.Click
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand


        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "DELETE from CONTACT WHERE PrenomContact='" & cboSupprPrenom.Text & "' And NomContact='" & cboSupprNom.Text & "'"

        cmd.ExecuteNonQuery()

        MsgBox("Le contact à été supprimée avec succès")



        cnn.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSupprNom.SelectedIndexChanged

        cboSupprPrenom.Items.Clear()


        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select PrenomContact from CONTACT Where NomContact ='" & CboSupprNom.Text & "'"

        JeuEnr = cmd.ExecuteReader()

        'Récupérer les enregistrements : insertion dans cboEmb
        While JeuEnr.Read()
            cboSupprPrenom.Items.Add(JeuEnr.GetValue(0))
        End While



        JeuEnr.Close()

        cnn.Close()
        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select PrenomContact from CONTACT Where NomContact ='" & CboSupprNom.Text & "'"

        JeuEnr = cmd.ExecuteReader()

        'Récupérer les enregistrements : insertion dans cboEmb
        JeuEnr.Read()

        cboSupprPrenom.Text = JeuEnr.GetValue(0)

        JeuEnr.Close()

        cnn.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        formContact.Show()
    End Sub
End Class