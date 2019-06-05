
Public Class frm_nouvelle_partie
    Private Sub frm_nouvelle_partie_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim validation As DialogResult
        validation = MessageBox.Show("Quitter Qwirkle ?", "Qwirkle", MessageBoxButtons.YesNo)
        If (validation = DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Me.Hide()
        frm_qwirkle_menu.Size = Me.Size
        frm_qwirkle_menu.Show()
    End Sub

    Private Sub frm_nouvelle_partie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = frm_qwirkle_menu.Size
    End Sub

    Private Sub btn_2joueurs_Click(sender As Object, e As EventArgs) Handles btn_2joueurs.Click
        jeu.setNombreJoueurs(2)
        Me.Hide()
        frm_CreationJoueurs.Size = Me.Size
        frm_CreationJoueurs.Show()
    End Sub

    Private Sub btn_3joueurs_Click(sender As Object, e As EventArgs) Handles btn_3joueurs.Click
        jeu.setNombreJoueurs(3)
        Me.Hide()
        frm_CreationJoueurs.Size = Me.Size
        frm_CreationJoueurs.Show()
    End Sub

    Private Sub btn_4joueurs_Click(sender As Object, e As EventArgs) Handles btn_4joueurs.Click
        jeu.setNombreJoueurs(4)
        Me.Hide()
        frm_CreationJoueurs.Size = Me.Size
        frm_CreationJoueurs.Show()
    End Sub

End Class