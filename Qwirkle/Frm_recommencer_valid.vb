Public Class Frm_recommencer_valid
    Private Sub Button_OUI_Click(sender As Object, e As EventArgs) Handles Button_OUI.Click
        frm_nouvelle_partie.Show()
        frm_jeu.Close()
        Close()
    End Sub

    Private Sub Button_NON_Click(sender As Object, e As EventArgs) Handles Button_NON.Click
        Close()
    End Sub
End Class