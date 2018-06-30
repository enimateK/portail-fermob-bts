Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class formTypeEnt


    Private Sub btnAjoutTypeEnt_Click_1(sender As Object, e As EventArgs) Handles btnAjoutTypeEnt.Click
        Me.Close()
        FormAjoutTypeEntreprise.Show()
    End Sub

    Private Sub btnSupprTypeEnt_Click_1(sender As Object, e As EventArgs) Handles btnSupprTypeEnt.Click
        Me.Close()
        FormSupprTypeEntr.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        FormEntr.Show()
    End Sub

    Private Sub formTypeEnt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class