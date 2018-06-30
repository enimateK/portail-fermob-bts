Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class formPays

    Private Sub formPays_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim adapter As SqlDataAdapter
        Dim table As New DataTable


        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select CodePays as Diminutif, LibPays as Pays FROM PAYS"


        adapter = New SqlDataAdapter()
        adapter.SelectCommand = cmd

        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)

        cnn.Close()


        dgvPays.AutoGenerateColumns = True
        dgvPays.ReadOnly = True

        dgvPays.DataSource = table
        dgvPays.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
    End Sub

    Private Sub btnSupprPays_Click(sender As Object, e As EventArgs) Handles btnSupprPays.Click
        Me.Close()
        FormSupprPays.Show()
    End Sub

    Private Sub btnAjoutPays_Click(sender As Object, e As EventArgs) Handles btnAjoutPays.Click
        Me.Close()
        FormAjoutPays.Show()
    End Sub

    Private Sub btnModifPays_Click(sender As Object, e As EventArgs) Handles btnModifPays.Click
        Me.Close()
        FormModifPays.Show()
    End Sub

    Private Sub btnActu_Click(sender As Object, e As EventArgs) Handles btnActu.Click
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim adapter As SqlDataAdapter
        Dim table As New DataTable


        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select CodePays as Diminutif, LibPays as Pays FROM PAYS"


        adapter = New SqlDataAdapter()
        adapter.SelectCommand = cmd

        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)

        cnn.Close()


        dgvPays.AutoGenerateColumns = True
        dgvPays.ReadOnly = True

        dgvPays.DataSource = table
        dgvPays.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        FormEntr.Show()
    End Sub
End Class