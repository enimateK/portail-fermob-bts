Public Class formCollec

    Private Sub btnSuppr_Click(sender As Object, e As EventArgs) Handles btnSuppr.Click
        Me.Close()
        formSupprCollec.Show()
    End Sub

    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click
        Me.Close()
        formAjoutCollec.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        formProduit.Show()
    End Sub
End Class