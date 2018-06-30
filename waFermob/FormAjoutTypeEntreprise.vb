Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FormAjoutTypeEntreprise



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        Dim cmd As SqlCommand
        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "INSERT INTO TYPE_ENT (LibTypeEnt) VALUES ('" & txtajout.Text & "')"

        cmd.ExecuteNonQuery()
        cnn.Close()

        MsgBox("Le type d'entreprise a été ajouté avec succès à la base de données.")

        txtajout.Text = ""

    End Sub

    Private Sub FormAjoutTypeEntreprise_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        FormAjoutEntreprise.Show()
    End Sub
End Class