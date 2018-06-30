Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class formAction

    Private Sub formAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim adapter As SqlDataAdapter
        Dim table As New DataTable


        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT DateAction as Date, Commentaire, ARelancer as 'Relance à effectuer', DateRelance as 'Date de la relance', NomContact as Nom, PrenomContact as Prenom, LibTypeAction as 'Type d''action' FROM ACTION A, TYPE_ACTION TA, CONTACT C Where A.IdContact = C.IdContact And A.IdTypeAction = TA.IdTypeAction"


        adapter = New SqlDataAdapter()
        adapter.SelectCommand = cmd

        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)

        cnn.Close()


        dgvVisuAction.AutoGenerateColumns = True
        dgvVisuAction.ReadOnly = True
        dgvVisuAction.DataSource = table
        dgvVisuAction.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
    End Sub

    Private Sub btnSupprAction_Click(sender As Object, e As EventArgs) Handles btnSupprAction.Click
        Me.Close()
        FormSupprAction.Show()
    End Sub

    Private Sub btnAjoutAction_Click(sender As Object, e As EventArgs) Handles btnAjoutAction.Click
        Me.Close()
        FormAjoutAction.Show()
    End Sub

    Private Sub btnTypeAction_Click(sender As Object, e As EventArgs) Handles btnTypeAction.Click
        Me.Close()
        formTypeAction.Show()
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
        cmd.CommandText = "SELECT DateAction as Date, Commentaire, ARelancer as 'Relance à effectuer', DateRelance as 'Date de la relance', NomContact as Nom, PrenomContact as Prenom, LibTypeAction as 'Type d''action' FROM ACTION A, TYPE_ACTION TA, CONTACT C Where A.IdContact = C.IdContact And A.IdTypeAction = TA.IdTypeAction"


        adapter = New SqlDataAdapter()
        adapter.SelectCommand = cmd

        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)

        cnn.Close()


        dgvVisuAction.AutoGenerateColumns = True
        dgvVisuAction.ReadOnly = True
        dgvVisuAction.DataSource = table
        dgvVisuAction.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
    End Sub

    Private Sub btnModifAction_Click(sender As Object, e As EventArgs) Handles btnModifAction.Click
        Me.Close()
        formModifAction.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        formContact.Show()
    End Sub
End Class