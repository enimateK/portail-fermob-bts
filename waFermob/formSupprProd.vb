Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class formSupprProd

    Private Sub formSupprProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            cboSuppr.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()

        cnn.Close()
    End Sub

    Private Sub btnSuppr_Click(sender As Object, e As EventArgs) Handles btnSuppr.Click

        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")



        Dim cmd As SqlCommand

        Dim JeuEnr As SqlDataReader
        Dim ID As Integer


        cnn.Open()


        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "SELECT idProduit FROM PRODUIT Where libelleProduit = '" & cboSuppr.Text & "'"
        JeuEnr = cmd.ExecuteReader()
        JeuEnr.Read()
        ID = JeuEnr.GetValue(0)
        JeuEnr.Close()

        cmd.CommandText = "DELETE from PRODUIT_CARACTERISTIQUE Where idProduit = " & ID
        cmd.ExecuteNonQuery()


        cmd.CommandText = "DELETE from PRODUIT Where idProduit = '" & IdProdSuppr.Text & "'"
        cmd.ExecuteNonQuery()

        cnn.Close()
        MsgBox("Le produit a été supprimé avec succès.")


    End Sub

    Private Sub cboSuppr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSuppr.SelectedIndexChanged
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        cmd = New SqlCommand()
        cnn.Open()

        cmd = New SqlCommand()

        cmd.Connection = cnn

        cmd.CommandText = "Select IdProduit FROM PRODUIT  WHERE LibelleProduit = '" & cboSuppr.Text & " ' "

        JeuEnr = cmd.ExecuteReader()

        While JeuEnr.Read()
            IdProdSuppr.Text = JeuEnr.GetValue(0)
        End While


        JeuEnr.Close()
        cnn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        formProduit.Show()
    End Sub
End Class