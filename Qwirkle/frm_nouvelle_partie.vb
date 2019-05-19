Public Class frm_nouvelle_partie
    Private Sub frm_nouvelle_partie_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim validation As DialogResult
        validation = MessageBox.Show("Quitter Qwirkle ?", "Qwirkle", MessageBoxButtons.YesNo)
        If (validation = DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub


End Class