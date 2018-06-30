Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FormAjoutTypeAction

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        Dim cmd As SqlCommand
        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "INSERT INTO TYPE_ACTION (IdTypeAction,LibTypeAction) VALUES ('" & txtIdTypeAction.Text & "', '" & txtajoutaction.Text & "')"

        cmd.ExecuteNonQuery()
        cnn.Close()

        MsgBox("Le type d'action a été ajouté avec succès à la base de données")

        txtajoutaction.Text = ""
        txtIdTypeAction.Text = ""
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        formTypeAction.Show()
    End Sub

    Private Sub FormAjoutTypeAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class