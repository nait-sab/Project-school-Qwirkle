Imports System.Text.RegularExpressions

Public Class frm_CreationJoueurs
    Public Function numericverif(input As String) As Boolean 'fonction de verification si le parametre est un entier
        Return Regex.IsMatch(input.Trim, "\A-{0,1}[0-9.]*\Z")
    End Function

    Private Sub frm_CreationJoueurs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim validation As DialogResult
        validation = MessageBox.Show("Quitter Qwirkle ?", "Qwirkle", MessageBoxButtons.YesNo)
        If (validation = DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frm_CreationJoueurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If jeu.getNombreJoueurs() = 2 Then
            pannelj3.Visible = False
            pannelj4.Visible = False

        End If
        If jeu.getNombreJoueurs() = 3 Then
            pannelj4.Visible = False

        End If

        ' Mise a faux des checkbox lors de l initialisation du form
        check_j1.Enabled = False
        check_j2.Enabled = False
        check_j3.Enabled = False
        check_j4.Enabled = False
        boutonvalidation.Enabled = False
    End Sub



    Private Sub boutonvalidation_Click(sender As Object, e As EventArgs) Handles boutonvalidation.Click
        If check_j1.Checked Then
            joueur1.setNom(txt_Joueur1_Nom.Text)
            joueur1.setAge(txt_Joueur1_Age.Text)
        End If
        If check_j1.Checked Then
            joueur1.setNom(txt_Joueur1_Nom.Text)
            joueur1.setAge(txt_Joueur1_Age.Text)
        End If
        If check_j1.Checked Then
            joueur1.setNom(txt_Joueur1_Nom.Text)
            joueur1.setAge(txt_Joueur1_Age.Text)
        End If
        If check_j1.Checked Then
            joueur1.setNom(txt_Joueur1_Nom.Text)
            joueur1.setAge(txt_Joueur1_Age.Text)
        End If
        frm_jeu.Show()
        Me.Hide()
    End Sub

    Private Sub validj1_CheckedChanged(sender As Object, e As EventArgs) Handles check_j1.CheckedChanged, check_j2.CheckedChanged, check_j3.CheckedChanged, check_j4.CheckedChanged
        If jeu.getNombreJoueurs() = 2 Then

            If (check_j1.Checked = True And check_j2.Checked = True) Then
                boutonvalidation.Enabled = True
            Else
                boutonvalidation.Enabled = False
            End If

        End If

        If jeu.getNombreJoueurs() = 3 Then

            If (check_j1.Checked = True And check_j2.Checked = True And check_j3.Checked = True) Then
                boutonvalidation.Enabled = True
            Else
                boutonvalidation.Enabled = False
            End If

        End If


        If jeu.getNombreJoueurs() = 4 Then
            If (check_j1.Checked = True And check_j2.Checked = True And check_j3.Checked = True And check_j4.Checked = True) Then
                boutonvalidation.Enabled = True
            Else
                boutonvalidation.Enabled = False
            End If
        End If

        If check_j1.Checked = True Then
            txt_Joueur1_Nom.Enabled = False
            txt_Joueur1_Age.Enabled = False
        End If

        If check_j2.Checked = True Then
            txt_Joueur2_Nom.Enabled = False
            txt_Joueur2_Age.Enabled = False
        End If

        If check_j3.Checked = True Then
            txt_Joueur3_Nom.Enabled = False
            txt_Joueur3_Age.Enabled = False
        End If

        If check_j4.Checked = True Then
            txt_Joueur4_Nom.Enabled = False
            txt_Joueur4_Age.Enabled = False
        End If
    End Sub

    Private Sub txt_Joueur1_Nom_TextChanged(sender As Object, e As EventArgs) Handles txt_Joueur1_Nom.TextChanged, txt_Joueur1_Age.TextChanged, txt_Joueur2_Nom.TextChanged, txt_Joueur2_Age.TextChanged,
        txt_Joueur3_Nom.TextChanged, txt_Joueur3_Age.TextChanged, txt_Joueur4_Nom.TextChanged, txt_Joueur4_Age.TextChanged

        If (txt_Joueur1_Nom.Text <> "" And txt_Joueur1_Age.Text <> "" And numericverif(txt_Joueur1_Age.Text) = True) Then
            check_j1.Enabled = True
        Else
            check_j1.Enabled = False
        End If



        If (txt_Joueur2_Nom.Text <> "" And txt_Joueur2_Age.Text <> "" And numericverif(txt_Joueur2_Age.Text) = True) Then
            check_j2.Enabled = True
        Else
            check_j2.Enabled = False
        End If


        If (txt_Joueur3_Nom.Text <> "" And txt_Joueur3_Age.Text <> "" And numericverif(txt_Joueur3_Age.Text) = True) Then
            check_j3.Enabled = True
        Else
            check_j3.Enabled = False
        End If


        If (txt_Joueur4_Nom.Text <> "" And txt_Joueur4_Age.Text <> "" And numericverif(txt_Joueur4_Age.Text) = True) Then
            check_j4.Enabled = True
        Else
            check_j4.Enabled = False
        End If







    End Sub

    Private Sub cmd_Retour_Click(sender As Object, e As EventArgs) Handles cmd_Retour.Click
        frm_nouvelle_partie.Show()
        Me.Hide()
    End Sub
End Class