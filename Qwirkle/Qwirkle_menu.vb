Public Class frm_qwirkle_menu
    Private Sub btn_quitter_MouseHover(sender As Object, e As EventArgs) Handles btn_quitter.MouseHover
        'Passer le curseur en main lors du survol'
        btn_quitter.Cursor = Cursors.Hand
    End Sub

    Private Sub btn_quitter_MouseClick(sender As Object, e As MouseEventArgs) Handles btn_quitter.MouseClick
        'Bouton CUSTOM pour quitter en attendant de trouver  '
        'une solution pour que le contenu du jeu / fenêtre   '
        'soit responsive selon la taille de la fenêtre du jeu'
        'ensuite on vire sa et remet la bordure normale de la'
        'fenetre sauf si ce custom plaît ?                   '
        Dim validation As DialogResult
        validation = MessageBox.Show("Quitter Qwirkle ?", "Qwirkle", MessageBoxButtons.YesNo)
        If (validation = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub
End Class
