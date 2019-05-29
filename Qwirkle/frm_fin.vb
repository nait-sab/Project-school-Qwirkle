Public Class frm_fin
    Private Sub frm_fin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Mise en place du tableau '
        If jeu.getNombreJoueurs = 2 Then
            j1_nom.Text = joueur1.getNom
            j1_score.Text = joueur1.getScore
            j2_nom.Text = joueur2.getNom
            j2_score.Text = joueur2.getScore
            j3_nom.Visible = False
            j3_score.Visible = False
            j4_nom.Visible = False
            j4_score.Visible = False
        ElseIf jeu.getNombreJoueurs = 3 Then
            j1_nom.Text = joueur1.getNom
            j1_score.Text = joueur1.getScore
            j2_nom.Text = joueur2.getNom
            j2_score.Text = joueur2.getScore
            j3_nom.Text = joueur3.getNom
            j3_score.Text = joueur3.getScore
            j4_nom.Visible = False
            j4_score.Visible = False
        Else
            j1_nom.Text = joueur1.getNom
            j1_score.Text = joueur1.getScore
            j2_nom.Text = joueur2.getNom
            j2_score.Text = joueur2.getScore
            j3_nom.Text = joueur3.getNom
            j3_score.Text = joueur3.getScore
            j4_nom.Text = joueur4.getNom
            j4_score.Text = joueur4.getScore
        End If

        ' Recherche du plus grand score '
        Dim score As Byte = 0

        If jeu.getNombreJoueurs = 2 Then
            If joueur1.getScore > score Then
                score = joueur1.getScore
            End If
            If joueur2.getScore > score Then
                score = joueur2.getScore
            End If
        ElseIf jeu.getNombreJoueurs = 3 Then
            If joueur1.getScore > score Then
                score = joueur1.getScore
            End If
            If joueur2.getScore > score Then
                score = joueur2.getScore
            End If
            If joueur3.getScore > score Then
                score = joueur3.getScore
            End If
        Else
            If joueur1.getScore > score Then
                score = joueur1.getScore
            End If
            If joueur2.getScore > score Then
                score = joueur2.getScore
            End If
            If joueur3.getScore > score Then
                score = joueur3.getScore
            End If
            If joueur4.getScore > score Then
                score = joueur4.getScore
            End If
        End If

        lbl_gagnant.Text = score.ToString

    End Sub

    Private Sub menubutton_Click(sender As Object, e As EventArgs) Handles menubutton.Click
        Dim validation As DialogResult
        validation = MessageBox.Show("Voulez vous recommencer ?", "Qwirkle", MessageBoxButtons.YesNo)
        If (validation = DialogResult.Yes) Then
            frm_qwirkle_menu.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub quitbutton_Click(sender As Object, e As EventArgs) Handles quitbutton.Click
        Dim validation As DialogResult
        validation = MessageBox.Show("Quitter Qwirkle ?", "Qwirkle", MessageBoxButtons.YesNo)
        If (validation = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub
End Class