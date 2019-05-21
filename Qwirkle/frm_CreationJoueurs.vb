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
        If frm_nouvelle_partie.nbj = 2 Then
            pannelj3.Visible = False
            pannelj4.Visible = False

        End If
        If frm_nouvelle_partie.nbj = 3 Then
            pannelj4.Visible = False

        End If






        'mise a faux des checkbox lors de l initialisation du form
        validj1.Enabled = False
        validj2.Enabled = False
        validj3.Enabled = False
        validj4.Enabled = False
        boutonvalidation.Enabled = False



    End Sub



    Private Sub boutonvalidation_Click(sender As Object, e As EventArgs) Handles boutonvalidation.Click
        joueur1.setNom(txt_Joueur1_Nom.Text)
        joueur1.setAge(txt_Joueur1_Age.Text)
        joueur2.setNom(txt_Joueur2_Nom.Text)
        joueur2.setAge(txt_Joueur2_Age.Text)
        joueur3.setNom(txt_Joueur3_Nom.Text)
        joueur3.setAge(txt_Joueur3_Age.Text)
        joueur4.setNom(txt_Joueur4_Nom.Text)
        joueur4.setAge(txt_Joueur4_Age.Text)
        frm_jeu.Show()
        Me.Hide()
    End Sub

    Private Sub validj1_CheckedChanged(sender As Object, e As EventArgs) Handles validj1.CheckedChanged, validj2.CheckedChanged, validj3.CheckedChanged, validj4.CheckedChanged
        If frm_nouvelle_partie.nbj = 2 Then

            If (validj1.Checked = True And validj2.Checked = True) Then
                boutonvalidation.Enabled = True
            Else
                boutonvalidation.Enabled = False
            End If

        End If

        If frm_nouvelle_partie.nbj = 3 Then

            If (validj1.Checked = True And validj2.Checked = True And validj3.Checked = True) Then
                boutonvalidation.Enabled = True
            Else
                boutonvalidation.Enabled = False
            End If

        End If


        If frm_nouvelle_partie.nbj = 4 Then
            If (validj1.Checked = True And validj2.Checked = True And validj3.Checked = True And validj4.Checked = True) Then
                boutonvalidation.Enabled = True
            Else
                boutonvalidation.Enabled = False
            End If
        End If

        If validj1.Checked = True Then
            txt_Joueur1_Nom.Enabled = False
            txt_Joueur1_Age.Enabled = False
        End If

        If validj2.Checked = True Then
            txt_Joueur2_Nom.Enabled = False
            txt_Joueur2_Age.Enabled = False
        End If

        If validj3.Checked = True Then
            txt_Joueur3_Nom.Enabled = False
            txt_Joueur3_Age.Enabled = False
        End If

        If validj4.Checked = True Then
            txt_Joueur4_Nom.Enabled = False
            txt_Joueur4_Age.Enabled = False
        End If
    End Sub

    Private Sub txt_Joueur1_Nom_TextChanged(sender As Object, e As EventArgs) Handles txt_Joueur1_Nom.TextChanged, txt_Joueur1_Age.TextChanged, txt_Joueur2_Nom.TextChanged, txt_Joueur2_Age.TextChanged,
        txt_Joueur3_Nom.TextChanged, txt_Joueur3_Age.TextChanged, txt_Joueur4_Nom.TextChanged, txt_Joueur4_Age.TextChanged

        If (txt_Joueur1_Nom.Text <> "" And txt_Joueur1_Age.Text <> "" And numericverif(txt_Joueur1_Age.Text) = True) Then
            validj1.Enabled = True
        Else
            validj1.Enabled = False
        End If



        If (txt_Joueur2_Nom.Text <> "" And txt_Joueur2_Age.Text <> "" And numericverif(txt_Joueur2_Age.Text) = True) Then
            validj2.Enabled = True
        Else
            validj2.Enabled = False
        End If


        If (txt_Joueur3_Nom.Text <> "" And txt_Joueur3_Age.Text <> "" And numericverif(txt_Joueur3_Age.Text) = True) Then
            validj3.Enabled = True
        Else
            validj3.Enabled = False
        End If


        If (txt_Joueur4_Nom.Text <> "" And txt_Joueur4_Age.Text <> "" And numericverif(txt_Joueur4_Age.Text) = True) Then
            validj4.Enabled = True
        Else
            validj4.Enabled = False
        End If







    End Sub


End Class