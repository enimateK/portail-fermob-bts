Public Class formTypeAction

    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click
        Me.Close()
        FormAjoutTypeAction.Show()
    End Sub

    Private Sub btnSuppr_Click(sender As Object, e As EventArgs) Handles btnSuppr.Click
        Me.Close()
        formSupprTypeAction.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        formAction.Show()
    End Sub

    Private Sub formTypeAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class