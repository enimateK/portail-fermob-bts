Imports Microsoft.VisualBasic
Imports System.Data.SqlClient


Public Class FormSupprEntreprise


    Private Sub FormSuppr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select RaisonSociale FROM ENTREPRISE"

        JeuEnr = cmd.ExecuteReader()


        While JeuEnr.Read()
            cboSupprEnt.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()

        cnn.Close()

    End Sub



    Private Sub btnSupprEntr_Click(sender As Object, e As EventArgs) Handles btnSupprEntr.Click
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand


        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "DELETE from ENTREPRISE WHERE RaisonSociale= '" & cboSupprEnt.Text & "'"

        cmd.ExecuteNonQuery()

        MsgBox("L'Entreprise à été supprimée avec succès")



        cnn.Close()
    End Sub
End Class



