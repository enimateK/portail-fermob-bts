Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class FormModifPays

    Private Sub FormModifPays_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select LibPays from PAYS"

        JeuEnr = cmd.ExecuteReader()
        While JeuEnr.Read()

            cboPays.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()
    End Sub

    Private Sub cboPays_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPays.SelectedIndexChanged
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        cmd = New SqlCommand()
        cnn.Open()

        cmd = New SqlCommand()

        Dim CodePays As String
        Dim LibPays As String




        cmd.Connection = cnn

        cmd.CommandText = "Select * FROM PAYS  WHERE LibPays = '" & cboPays.Text & "'"

        JeuEnr = cmd.ExecuteReader()

        JeuEnr.Read()


        CodePays = JeuEnr.GetValue(0)
        LibPays = JeuEnr.GetValue(1)

        JeuEnr.Close()
        cnn.Close()

        txtCodePays.Text = CodePays
        txtLibPays.Text = LibPays

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")
        Dim cmd As SqlCommand
        cmd = New SqlCommand()
        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Update PAYS SET LibPays = '" & txtLibPays.Text & "' WHERE CodePays = '" & txtCodePays.Text & "'"
        cmd.ExecuteNonQuery()

        cnn.Close()
        MsgBox("Le Pays a été modifié avec succès")

        txtCodePays.Text = ""
        txtLibPays.Text = ""
        cboPays.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        formPays.Show()
    End Sub
End Class