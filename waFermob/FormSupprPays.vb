Imports Microsoft.VisualBasic
Imports System.Data.SqlClient


Public Class FormSupprPays


    Private Sub FormSuppr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select LibPays FROM PAYS"

        JeuEnr = cmd.ExecuteReader()


        While JeuEnr.Read()
            CboSupprPays.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()

        cnn.Close()

    End Sub

    Private Sub BtnSupprPays_Click(sender As Object, e As EventArgs) Handles BtnSupprPays.Click
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand


        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "DELETE FROM PAYS where LibPays= '" & CboSupprPays.Text & "'"

        cmd.ExecuteNonQuery()

        MsgBox("Le Pays à été supprimée avec succès.")



        cnn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        formPays.Show()
    End Sub
End Class