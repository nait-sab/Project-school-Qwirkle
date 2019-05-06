Public Class frm_qwirkle_menu
    Private Sub btn_nouvelle_partie_MouseHover(sender As Object, e As EventArgs) Handles btn_nouvelle_partie.MouseHover
        btn_nouvelle_partie.Cursor = Cursors.Hand
    End Sub

    Private Sub btn_nouvelle_partie_MouseClick(sender As Object, e As MouseEventArgs) Handles btn_nouvelle_partie.MouseClick
        frm_nouvelle_partie.Show()
        Me.Hide()
    End Sub

    Private Sub frm_qwirkle_menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim validation As DialogResult
        validation = MessageBox.Show("Quitter Qwirkle ?", "Qwirkle", MessageBoxButtons.YesNo)
        If (validation = DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub
End Class
