Imports Microsoft.VisualBasic
Imports System.Data.SqlClient


Public Class FormSupprTypeEntr


    Private Sub FormSuppr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select LibTypeEnt from TYPE_ENT"

        JeuEnr = cmd.ExecuteReader()

        'Récupérer les enregistrements : insertion dans la combobox
        While JeuEnr.Read()
            CboSupprTypeEntr.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()

        cnn.Close()

    End Sub


    Private Sub BtnSupprTypeEntr_Click(sender As Object, e As EventArgs) Handles BtnSupprTypeEntr.Click
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand


        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "DELETE from TYPE_ENT WHERE LibTypeEnt='" & CboSupprTypeEntr.Text & "' "

        cmd.ExecuteNonQuery()

        MsgBox("Le type à été supprimée avec succès.")



        cnn.Close()


        Dim JeuEnr As SqlDataReader

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select LibTypeEnt from TYPE_ENT"

        JeuEnr = cmd.ExecuteReader()

        'Récupérer les enregistrements : insertion dans la combobox
        While JeuEnr.Read()
            CboSupprTypeEntr.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()

        cnn.Close()

        CboSupprTypeEntr.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        formTypeEnt.Show()
    End Sub
End Class