Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class FormAjoutPays

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        Dim cmd As SqlCommand
        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "INSERT INTO PAYS (CodePays, Libpays) VALUES ('" & txtCodePays.Text & "',  '" & txtNomPays.Text & "')"

        cmd.ExecuteNonQuery()
        cnn.Close()
        MsgBox("Le pays à été ajouté avec succès à la base de données.")

        txtCodePays.Text = ""
        txtNomPays.Text = ""
    End Sub

    Private Sub FormAjoutPays_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        FormAjoutEntreprise.Show()
    End Sub
End Class