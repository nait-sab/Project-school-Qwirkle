Public Class frm_jeu

    Public score_joueur As Integer = 0
    Public score_tour As Integer = 0
    Public longueur As Integer = 0
    Public comptage As Boolean = 0
    Public direction As Integer = 0
    Public case_remplie As Boolean = 0
    Public position_X As Integer = 0
    Public position_Y As Integer = 0


    Private couleur() As String = {"Bleu", "Jaune", "Orange", "Rouge", "Vert", "Violet"}
    Private forme() As String = {"Carre", "Croix", "Etoile", "Losange", "Rond", "Trefle"}

    Private Sub frm_jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_tourJoueur.Text = "Tour de " & lbl_j1_nom.Text
        ' Génération de la pioche - 108 tuiles '
        For count As Byte = 1 To 3
            For color As Byte = 0 To couleur.Length - 1
                For shape As Byte = 0 To forme.Length - 1
                    Dim tuile As New Qwirkle_lib.Tuile(couleur(color), forme(shape))
                    jeu.addTuile(tuile)
                Next
            Next
        Next

        grille_1_1.AllowDrop = True
        'picBox1.Image = Image.FromFile("Ressources\" & test.getForme & test.getCouleur & ".jpg")
        'picBox1.Image = My.Resources.ResourceManager.GetObject(test.getForme & test.getCouleur)




        If jeu.getNombreJoueurs() = 2 Then
            pannelj3.Visible = False
            pannelj4.Visible = False
        End If
        If jeu.getNombreJoueurs() = 3 Then
            pannelj4.Visible = False
        End If

        'tests noms
        'joueur1.setNom("chris")
        'joueur2.setNom("Leonie")
        'joueur3.setNom("Charle")
        'joueur4.setNom("Lucie")

        ' Mise en place des joueurs dans le tableau des score '
        lbl_j1_nom.Text = joueur1.getNom()
        lbl_j1_score.Text = joueur1.getScore()
        lbl_j2_nom.Text = joueur2.getNom()
        lbl_j2_score.Text = joueur2.getScore()
        'lbl_j3_nom.Text = joueur3.getNom()
        'lbl_j3_score.Text = joueur3.getScore()
        'lbl_j4_nom.Text = joueur4.getNom()
        'lbl_j4_score.Text = joueur4.getScore()
        For i As Byte = 0 To jeu.getNombreJoueurs - 1
            Dim pannelj As TableLayoutPanel = TableLayoutPanel8.Controls("pannelj" & i + 1)
            pannelj.Controls("lbl_j" & i + 1 & "_nom").Text = jeu.getJoueurs(i).getNom
            pannelj.Controls("lbl_j" & i + 1 & "_score").Text = jeu.getJoueurs(i).getScore
        Next


    End Sub

    Private Sub picColR_MouseMove(sender As Object, e As MouseEventArgs) Handles picBox1.MouseMove
        Dim drag As DragDropEffects
        If e.Button = MouseButtons.Left Then
            picBox1.AllowDrop = False
            drag = picBox1.DoDragDrop(picBox1.Image, DragDropEffects.Move)
            picBox1.AllowDrop = True
        End If
    End Sub

    Private Sub picbox1_DragEnter(sender As Object, e As DragEventArgs) Handles grille_1_1.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub picbox1_DragDrop(sender As Object, e As DragEventArgs) Handles grille_1_1.DragDrop

        grille_1_1.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub


    Private Sub btn_aide_Click(sender As Object, e As EventArgs) Handles btn_aide.Click
        frm_aide.Show()
    End Sub

    Private Sub btn_confirmer_Click(sender As Object, e As EventArgs) Handles btn_confirmer.Click

        score_joueur = lbl_j1_score.Text

        While (comptage = 0)
            While (direction <> 4)
                While (case_remplie = 0)
                    longueur += 1
                End While

            End While

        End While


        score_joueur = score_joueur + score_tour
        lbl_j1_score.Text = score_joueur
        lbl_tourJoueur.Text = "Tour de " & lbl_j2_nom.Text
    End Sub

    Private Sub btn_recommencer_Click(sender As Object, e As EventArgs) Handles btn_recommencer.Click
        Dim validation As DialogResult
        validation = MessageBox.Show("Voulez vous recommencer ?", "Qwirkle", MessageBoxButtons.YesNo)
        If (validation = DialogResult.Yes) Then
            frm_qwirkle_menu.Show()
            Me.Hide()
        End If
    End Sub
End Class