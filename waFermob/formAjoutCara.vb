Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class formAjoutCara



    Private Sub BoutonAjout_Click(sender As Object, e As EventArgs) Handles btnAjoutCara.Click

        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")


        cnn.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand
        cmd.Connection = cnn


        cmd.CommandText = "INSERT INTO CARACTERISTIQUE(libCaracteristique) VALUES ('" & TxtLibCara.Text & "')"

        cmd.ExecuteNonQuery()
        cnn.Close()

        MsgBox("La caractéristique à été ajoutée avec succès à la base de données.")

        TxtLibCara.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        formCarac.Show()
    End Sub

    Private Sub formAjoutCara_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class