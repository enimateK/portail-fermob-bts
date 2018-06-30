Imports Microsoft.VisualBasic
Imports System.Data.SqlClient

Public Class FormVisuAction

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim adapter As SqlDataAdapter
        Dim table As New DataTable


        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB;User ID=SIO1SLAM;Password=pwd1slam")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "SELECT IdAction, DateAction, Commentaire, ARelancer, DateRelance, IdContact, IdTypeAction FROM ACTION"


        adapter = New SqlDataAdapter()
        adapter.SelectCommand = cmd

        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)

        cnn.Close()


        DgvVisuAction.AutoGenerateColumns = True
        DgvVisuAction.ReadOnly = True
        DgvVisuAction.DataSource = table
        DgvVisuAction.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
    End Sub

End Class