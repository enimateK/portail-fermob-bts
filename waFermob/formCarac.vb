Public Class formCarac

    Private Sub btnSuppr_Click(sender As Object, e As EventArgs) Handles btnSuppr.Click
        Me.Close()
        formSupprCarac.Show()
    End Sub


    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click
        Me.Close()
        formAjoutCara.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        formProduit.Show()
    End Sub

    Private Sub formCarac_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class