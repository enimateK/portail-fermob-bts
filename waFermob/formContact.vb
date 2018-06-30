Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class formContact

    Private Sub formContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim adapter As SqlDataAdapter
        Dim table As New DataTable


        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select Titre, NomContact as Nom, PrenomContact as Prenom, MailContact as Mail, TelInterneContact as 'Téléphone interne', TelPortable as Portable, RaisonSociale as 'Nom de l''entreprise' FROM CONTACT C,ENTREPRISE E WHERE C.idEntreprise = E.idEntreprise"



        adapter = New SqlDataAdapter()
        adapter.SelectCommand = cmd

        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)

        cnn.Close()


        dgvContact.AutoGenerateColumns = True
        dgvContact.ReadOnly = True

        dgvContact.DataSource = table
        dgvContact.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
    End Sub



    Private Sub btnSuppr_Click(sender As Object, e As EventArgs) Handles btnSuppr.Click
        Me.Close()
        FormSupprContact.Show()
    End Sub

    Private Sub btnEntr_Click(sender As Object, e As EventArgs) Handles btnEntr.Click
        Me.Close()
        FormEntr.Show()
    End Sub

    Private Sub btnAction_Click(sender As Object, e As EventArgs) Handles btnAction.Click
        Me.Close()
        formAction.Show()
    End Sub

    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click
        Me.Close()
        FormAjoutContact.Show()
    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        Me.Close()
        FormModifContact.Show()
    End Sub

    Private Sub BtnContactRetour_Click(sender As Object, e As EventArgs) Handles BtnContactRetour.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim adapter As SqlDataAdapter
        Dim table As New DataTable

        'Dim cm As CurrencyManager = DirectCast(BindingContext(dgvContact.DataSource), CurrencyManager)
        'cm.Refresh()

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select Titre, NomContact as Nom, PrenomContact as Prenom, MailContact as Mail, TelInterneContact as 'Téléphone interne', TelPortable as Portable, RaisonSociale as 'Nom de l''entreprise' FROM CONTACT C,ENTREPRISE E WHERE C.idEntreprise = E.idEntreprise"



        adapter = New SqlDataAdapter()
        adapter.SelectCommand = cmd

        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)

        cnn.Close()


        dgvContact.AutoGenerateColumns = True
        dgvContact.ReadOnly = True

        dgvContact.DataSource = table
        dgvContact.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
    End Sub
End Class