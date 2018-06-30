Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class formAjoutCollec


    Private Sub BoutonAjout_Click(sender As Object, e As EventArgs) Handles BoutonAjout.Click

        Dim cnn As SqlConnection
        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")


        cnn.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand
        cmd.Connection = cnn


        cmd.CommandText = "INSERT INTO COLLECTION(nomCollection) VALUES ('" & TxtAjoutCollect.Text & "' )"

        cmd.ExecuteNonQuery()
        cnn.Close()

        MsgBox("La collection à été ajoutée avec succès à la base de données.")

        TxtAjoutCollect.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        formCollec.Show()
    End Sub

    Private Sub formAjoutCollec_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class