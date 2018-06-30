Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class formProduit

    Private Sub formProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim adapter As SqlDataAdapter
        Dim table As New DataTable

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select libelleProduit as Nom, descProduit as Description, PUProduit as Prix, libCategorie as Categorie, nomCollection as Collection FROM PRODUIT P, COLLECTION CO, CATEGORIE CA Where P.idCollection = CO.idCollection And P.idCategorie = CA.idCategorie"

        adapter = New SqlDataAdapter()
        adapter.SelectCommand = cmd

        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)

        cnn.Close()

        dgvProduit.AutoGenerateColumns = True
        dgvProduit.ReadOnly = True
        dgvProduit.DataSource = table
        dgvProduit.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
    End Sub
    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        Me.Close()
        formModifProd.Show()
    End Sub

    Private Sub btnSuppr_Click(sender As Object, e As EventArgs) Handles btnSuppr.Click
        Me.Close()
        formSupprProd.Show()
    End Sub

    Private Sub btnCateg_Click(sender As Object, e As EventArgs) Handles btnCateg.Click
        Me.Close()
        formCateg.Show()
    End Sub

    Private Sub btnCollec_Click(sender As Object, e As EventArgs) Handles btnCollec.Click
        Me.Close()
        formCollec.Show()
    End Sub

    Private Sub btnCarac_Click(sender As Object, e As EventArgs) Handles btnCarac.Click
        Me.Close()
        formCarac.Show()
    End Sub

    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click
        Me.Close()
        formAjoutProduit.Show()
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
        cmd.CommandText = "Select libelleProduit as Nom, descProduit as Description, PUProduit as Prix, libCategorie as Categorie, nomCollection as Collection FROM PRODUIT P, COLLECTION CO, CATEGORIE CA Where P.idCollection = CO.idCollection And P.idCategorie = CA.idCategorie"

        adapter = New SqlDataAdapter()
        adapter.SelectCommand = cmd

        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)

        cnn.Close()

        dgvProduit.AutoGenerateColumns = True
        dgvProduit.ReadOnly = True
        dgvProduit.DataSource = table
        dgvProduit.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
    End Sub

    Private Sub BtnProdRetour_Click(sender As Object, e As EventArgs) Handles BtnProdRetour.Click
        Me.Close()

    End Sub
End Class