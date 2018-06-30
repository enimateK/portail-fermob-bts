Imports Microsoft.VisualBasic
Imports System.Data.SqlClient


Public Class FormSupprAction


    Private Sub FormSupprAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select NomContact from CONTACT"

        JeuEnr = cmd.ExecuteReader()

        'Récupérer les enregistrements : insertion dans cboEmb
        While JeuEnr.Read()
            CboSupprNomContact.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()

        cnn.Close()

    End Sub

    Private Sub CboSupprNomContact_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboSupprNomContact.SelectedIndexChanged

        CboSupprPrenomContact.Items.Clear()


        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select PrenomContact from CONTACT Where NomContact ='" & CboSupprNomContact.Text & "'"

        JeuEnr = cmd.ExecuteReader()

        While JeuEnr.Read()
            CboSupprPrenomContact.Items.Add(JeuEnr.GetValue(0))
        End While



        JeuEnr.Close()

        cnn.Close()
        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select PrenomContact from CONTACT Where NomContact ='" & CboSupprNomContact.Text & "'"

        JeuEnr = cmd.ExecuteReader()


        JeuEnr.Read()

        CboSupprPrenomContact.Text = JeuEnr.GetValue(0)

        JeuEnr.Close()

        cnn.Close()



    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnChoixContact.Click
        Dim cnn As SqlConnection
        Dim cmd As SqlCommand
        Dim adapter As SqlDataAdapter
        Dim table As New DataTable


        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn
        cmd.CommandText = "Select IdAction, DateAction, Commentaire, ARelancer, DateRelance, libTypeAction FROM ACTION A, CONTACT C, TYPE_ACTION TA Where A.IdContact = C.IdContact And A.IdTypeAction = TA.IdTypeAction And NomContact = '" & CboSupprNomContact.Text & "' And PrenomContact = '" & CboSupprPrenomContact.Text & "'"


        adapter = New SqlDataAdapter()
        adapter.SelectCommand = cmd

        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)

        cnn.Close()


        dgvSupprAction.AutoGenerateColumns = True
        dgvSupprAction.ReadOnly = True

        dgvSupprAction.DataSource = table
        dgvSupprAction.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
    End Sub


    Private Sub BtnSupprAction_Click(sender As Object, e As EventArgs) Handles BtnSupprAction.Click
        Dim ObjConnection As New SqlConnection()


        ObjConnection.ConnectionString = "Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;"

        ObjConnection.Open()

        Try

            Dim ObjCommand As New SqlCommand()

            ObjCommand.Connection = ObjConnection



            ObjCommand.CommandText = "delete from ACTION where idAction ='" & Me.dgvSupprAction.CurrentRow.Cells(0).Value & "'"

            ObjCommand.ExecuteNonQuery()

        Finally

            ObjConnection.Close()

        End Try



        Me.dgvSupprAction.Rows.Remove(Me.dgvSupprAction.CurrentRow)


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        formAction.Show()
    End Sub
End Class