﻿Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class formSupprCarac

    Private Sub formSupprCarac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()


        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select libCaracteristique from CARACTERISTIQUE"

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



        cnn.Open()


        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "DELETE from CARACTERISTIQUE Where libCaracteristique = '" & cboSuppr.Text & "'"
        cmd.ExecuteNonQuery()

        cnn.Close()
        MsgBox("La caractéristique a été supprimée avec succès.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        formCateg.Show()
    End Sub
End Class