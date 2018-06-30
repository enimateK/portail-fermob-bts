Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class FormModifEntreprise

    Private Sub cboNomEntreprise_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNomEntreprise.SelectedIndexChanged
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        cmd = New SqlCommand()
        cnn.Open()

        cmd = New SqlCommand()

        Dim IdEntr As Integer
        Dim RaisonSociale As String
        Dim Adresse As String
        Dim CodePostal As Integer
        Dim Ville As String
        Dim IdTypeEntreprise As Integer
        Dim TypeEntreprise As String
        Dim CodePays As String
        Dim Pays As String


        cmd.Connection = cnn

        cmd.CommandText = "Select * FROM ENTREPRISE  WHERE RaisonSociale = '" & cboNomEntreprise.Text & "'"

        JeuEnr = cmd.ExecuteReader()

        JeuEnr.Read()

        IdEntr = JeuEnr.GetValue(0)
        RaisonSociale = JeuEnr.GetValue(1)
        Adresse = JeuEnr.GetValue(2)
        CodePostal = JeuEnr.GetValue(3)
        Ville = JeuEnr.GetValue(4)
        CodePays = JeuEnr.GetValue(5)
        IdTypeEntreprise = JeuEnr.GetValue(6)

        JeuEnr.Close()
        cnn.Close()

        cnn.Open()


        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select LibTypeEnt FROM TYPE_ENT WHERE IdTypeEnt ='" & IdTypeEntreprise & " ' "

        JeuEnr = cmd.ExecuteReader()

        JeuEnr.Read()

        TypeEntreprise = JeuEnr.GetValue(0)

        cnn.Close()

        cnn.Open()


        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select Libpays FROM Pays WHERE CodePays ='" & CodePays & " ' "

        JeuEnr = cmd.ExecuteReader()

        JeuEnr.Read()

        Pays = JeuEnr.GetValue(0)

        cnn.Close()

        txtIdEnt.Text = IdEntr
        txtRaisonSociale.Text = RaisonSociale
        txtAdresse.Text = Adresse
        txtCodePostal.Text = CodePostal
        txtVille.Text = Ville
        cboPays.Text = Pays
        cboTypeEntreprise.Text = TypeEntreprise
    End Sub

    Private Sub FormModifEntreprise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")

        cnn.Open()
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select RaisonSociale from ENTREPRISE"

        JeuEnr = cmd.ExecuteReader()
        While JeuEnr.Read()

            cboNomEntreprise.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()

        cmd.CommandText = "Select Libpays from PAYS"

        JeuEnr = cmd.ExecuteReader()


        While JeuEnr.Read()
            cboPays.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()

        cmd.CommandText = "Select LibTypeEnt from TYPE_ENT"

        JeuEnr = cmd.ExecuteReader()


        While JeuEnr.Read()
            cboTypeEntreprise.Items.Add(JeuEnr.GetValue(0))
        End While

        JeuEnr.Close()


        cnn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnn As SqlConnection

        cnn = New SqlConnection("Data Source=172.30.0.115;Initial Catalog=FERMOB_BD;User ID=slamBD; Password=azerty;")
        Dim cmd As SqlCommand
        Dim JeuEnr As SqlDataReader
        cmd = New SqlCommand()
        Dim Pays As String
        Dim TEntreprise As String

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select CodePays FROM PAYS WHERE LibPays ='" & cboPays.Text & " ' "

        JeuEnr = cmd.ExecuteReader()

        JeuEnr.Read()

        Pays = JeuEnr.GetValue(0)

        cnn.Close()

        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Select IdTypeEnt FROM TYPE_ENT WHERE LibTypeEnt ='" & cboTypeEntreprise.Text & " ' "

        JeuEnr = cmd.ExecuteReader()

        JeuEnr.Read()

        TEntreprise = JeuEnr.GetValue(0)

        cnn.Close()


        cnn.Open()

        cmd = New SqlCommand()
        cmd.Connection = cnn

        cmd.CommandText = "Update ENTREPRISE SET RaisonSociale = '" & txtRaisonSociale.Text & "', AdresseRue = '" & txtAdresse.Text & "', CodePostal = ' " & txtCodePostal.Text & " ' , Ville = ' " & txtVille.Text & " ' , CodePays = '" & Pays & "' , IdTypEnt = '" & TEntreprise & "' WHERE IdEntreprise = '" & txtIdEnt.Text & "'"
        cmd.ExecuteNonQuery()

        cnn.Close()

        MsgBox("L'entreprise a été mofifiée avec succès.")

        txtAdresse.Text = ""
        txtCodePostal.Text = ""
        txtIdEnt.Text = ""
        txtRaisonSociale.Text = ""
        txtVille.Text = ""
        cboNomEntreprise.Text = ""
        cboPays.Text = ""
        cboTypeEntreprise.Text = ""
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        FormEntr.Show()
    End Sub
End Class