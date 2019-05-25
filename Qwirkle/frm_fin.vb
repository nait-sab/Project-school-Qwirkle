Public Class frm_fin
    Private Sub frm_fin_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Affichage tableau des scores

        If jeu.getNombreJoueurs() = 2 Then
            pannelj3.Visible = False
            pannelj4.Visible = False
        End If
        If jeu.getNombreJoueurs() = 3 Then
            pannelj4.Visible = False
        End If



        'Affichage nom joueur gagnant
        'If (frm_jeu.scorej1 > frm_jeu.scorej2 And frm_jeu.scorej3 And frm_jeu.scorej4) Then
        '    nomgagnant.Text = frm_jeu.nomj1.ToString
        'End If

        'If (frm_jeu.scorej2 > frm_jeu.scorej1 And frm_jeu.scorej3 And frm_jeu.scorej4) Then
        '    nomgagnant.Text = frm_jeu.nomj2.ToString
        'End If

        'If (frm_jeu.scorej3 > frm_jeu.scorej1 And frm_jeu.scorej2 And frm_jeu.scorej4) Then
        '    nomgagnant.Text = frm_jeu.nomj3.ToString
        'End If

        'If (frm_jeu.scorej4 > frm_jeu.scorej1 And frm_jeu.scorej2 And frm_jeu.scorej3) Then
        '    nomgagnant.Text = frm_jeu.nomj4.ToString
        'End If



        'Affichage nom des joueurs
        'labj1.Text = frm_jeu.nomj1
        'labj2.Text = frm_jeu.nomj2
        'labj3.Text = frm_jeu.nomj3
        'labj4.Text = frm_jeu.nomj4

        ''Affichage score des joueurs
        'labscorej1.Text = frm_jeu.scorej1.ToString
        'labscorej2.Text = frm_jeu.scorej2.ToString
        'labscorej3.Text = frm_jeu.scorej3.ToString
        'labscorej4.Text = frm_jeu.scorej4.ToString




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

    Private Sub TableLayoutPanel6_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel6.Paint

    End Sub
End Class