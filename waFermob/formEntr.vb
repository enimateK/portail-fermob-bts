Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FormEntr

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim adapter As SqlDataAdapter
        Dim table As New DataTable


        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select RaisonSociale as Nom, AdresseRue as Adresse, CodePostal as 'Code Postal', Ville, PAYS.LibPays as Pays, TYPE_ENT.LibTypeEnt as Type  FROM ENTREPRISE, PAYS, TYPE_ENT WHERE TYPE_ENT.IdTypeEnt = ENTREPRISE.IdTypEnt AND PAYS.CodePays = ENTREPRISE.CodePays"


        adapter = New SqlDataAdapter()
        adapter.SelectCommand = cmd

        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)

        cnn.Close()


        dgvVisuEntr.AutoGenerateColumns = True
        dgvVisuEntr.ReadOnly = True

        dgvVisuEntr.DataSource = table
        dgvVisuEntr.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
    End Sub

    Private Sub btnSupprEntr_Click(sender As Object, e As EventArgs) Handles btnSupprEntr.Click
        Me.Close()
        FormSupprEntreprise.Show()
    End Sub


    Private Sub btnPays_Click(sender As Object, e As EventArgs) Handles btnPays.Click
        Me.Close()
        formPays.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        formTypeEnt.Show()
    End Sub

    Private Sub btnAjoutEntr_Click(sender As Object, e As EventArgs) Handles btnAjoutEntr.Click
        Me.Close()
        FormAjoutEntreprise.Show()
    End Sub

    Private Sub btnModifEntr_Click(sender As Object, e As EventArgs) Handles btnModifEntr.Click
        Me.Close()
        FormModifEntreprise.Show()
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
        cmd.CommandText = "Select RaisonSociale as Nom, AdresseRue as Adresse, CodePostal as 'Code Postal', Ville, PAYS.LibPays as Pays, TYPE_ENT.LibTypeEnt as Type  FROM ENTREPRISE, PAYS, TYPE_ENT WHERE TYPE_ENT.IdTypeEnt = ENTREPRISE.IdTypEnt AND PAYS.CodePays = ENTREPRISE.CodePays"


        adapter = New SqlDataAdapter()
        adapter.SelectCommand = cmd

        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)

        cnn.Close()


        dgvVisuEntr.AutoGenerateColumns = True
        dgvVisuEntr.ReadOnly = True

        dgvVisuEntr.DataSource = table
        dgvVisuEntr.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        formContact.Show()
    End Sub
End Class