Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class formAjoutCateg



    Private Sub BoutonAjout_Click(sender As Object, e As EventArgs) Handles BoutonAjout.Click

        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")


        cnn.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand
        cmd.Connection = cnn


        cmd.CommandText = "INSERT INTO CATEGORIE(libCategorie) VALUES ('" & TxtLibCateg.Text & "')"

        cmd.ExecuteNonQuery()
        cnn.Close()

        MsgBox("La catégorie à été ajoutée avec succès à la base de données.")

        TxtLibCateg.Text = ""
    End Sub

    Private Sub formAjoutCateg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        formCateg.Show()
    End Sub
End Class