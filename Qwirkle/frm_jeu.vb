Public Class frm_jeu
    Public tour_joueur As String
    Public I As Integer = 1
    Public nb_joueur As Integer = jeu.getNombreJoueurs
    Public nb_pioche As Integer = 0

    Public score_joueur As Integer = 0
    Public score_tour As Integer = 0
    Public longueur As Integer = 0
    Public comptage As Boolean = 0
    Public direction As Integer = 0
    Public case_remplie As Boolean = 0




    Private Sub frm_jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For X As Integer = 0 To 30
            For Y As Integer = 0 To 30
                Dim grille As New Windows.Forms.PictureBox()
                grille.Location = New Drawing.Point(240 + 27 * X, 27 * Y)
                grille.Size = New Drawing.Size(27, 27)
                grille.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
                grille.Visible = True
                grille.AllowDrop = True
                grille.SizeMode = PictureBoxSizeMode.StretchImage
                grille.Name = "case_" & X & "_" & Y

                Me.Controls.Add(grille)
                AddHandler grille.DragEnter, AddressOf grille_DragEnter
                AddHandler grille.DragDrop, AddressOf grille_DragDrop
            Next
        Next
        pictureboxpioche.Visible = True
        pictureboxpioche.AllowDrop = True
        pictureboxpioche.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        pictureboxpioche.SizeMode = PictureBoxSizeMode.StretchImage
        AddHandler pictureboxpioche.DragEnter, AddressOf pictureboxpioche_DragEnter
        AddHandler pictureboxpioche.DragDrop, AddressOf pictureboxpioche_DragDrop
        lbl_joueur_actuel.Text = "Tour de " & joueur1.getNom  'fonctionne

        'Génération de la pioche - 108 tuiles '
        For count As Byte = 1 To 3
            For color As Byte = 0 To module_jeu.couleur.Length - 1
                For shape As Byte = 0 To forme.Length - 1
                    Dim tuile As New Qwirkle_lib.Tuile(couleur(color), forme(shape))
                    jeu.addTuile(tuile)
                Next
            Next
        Next

        ' Copieur de l'original '
        pioche = jeu.getPioche

        picBox1.Image = addmain(picBox1)
        picBox2.Image = addmain(picBox2)
        picBox3.Image = addmain(picBox3)
        picBox4.Image = addmain(picBox4)
        picBox5.Image = addmain(picBox5)
        picBox6.Image = addmain(picBox6)

        ' Exemple d'importation des ressources '
        'picBox1.Image = Image.FromFile("Ressources\" & test.getForme & test.getCouleur & ".jpg")
        'picBox1.Image = My.Resources.ResourceManager.GetObject(test.getForme & test.getCouleur)

        ' Mise en place des joueurs dans le tableau des score '
        If jeu.getNombreJoueurs = 2 Then
            pannelj3.Visible = False
            pannelj4.Visible = False
        ElseIf jeu.getNombreJoueurs = 3 Then
            pannelj4.Visible = False
        End If

        For i As Byte = 0 To jeu.getNombreJoueurs - 1
            Dim pannelj As TableLayoutPanel = TableLayoutPanel8.Controls("pannelj" & i + 1)
            pannelj.Controls("lbl_j" & i + 1 & "_nom").Text = jeu.getJoueurs(i).getNom
            pannelj.Controls("lbl_j" & i + 1 & "_score").Text = jeu.getJoueurs(i).getScore
        Next

        AddHandler picBox1.MouseHover, AddressOf main_hover
        AddHandler picBox2.MouseHover, AddressOf main_hover
        AddHandler picBox3.MouseHover, AddressOf main_hover
        AddHandler picBox4.MouseHover, AddressOf main_hover
        AddHandler picBox5.MouseHover, AddressOf main_hover
        AddHandler picBox6.MouseHover, AddressOf main_hover

        AddHandler picBox1.MouseMove, AddressOf main_mouseMove
        AddHandler picBox2.MouseMove, AddressOf main_mouseMove
        AddHandler picBox3.MouseMove, AddressOf main_mouseMove
        AddHandler picBox4.MouseMove, AddressOf main_mouseMove
        AddHandler picBox5.MouseMove, AddressOf main_mouseMove
        AddHandler picBox6.MouseMove, AddressOf main_mouseMove

    End Sub

    Private Sub main_mouseMove(sender As Object, e As MouseEventArgs)
        Dim drag As DragDropEffects
        If e.Button = MouseButtons.Left Then
            sender.AllowDrop = False
            drag = sender.DoDragDrop(sender.Image, DragDropEffects.Move)
            sender.AllowDrop = True
        End If
    End Sub

    Private Sub grille_DragEnter(sender As Object, e As DragEventArgs) Handles pictureboxpioche.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub pictureboxpioche_DragEnter(sender As Object, e As DragEventArgs) Handles pictureboxpioche.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Move
            sender.image = Nothing
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pictureboxpioche_DragDrop(sender As Object, e As DragEventArgs) Handles pictureboxpioche.DragDrop

        sender.Image = Nothing
        If picBox1.Image Is e.Data.GetData(DataFormats.Bitmap) Then
            picBox1.Image = Nothing
        End If
        If picBox2.Image Is e.Data.GetData(DataFormats.Bitmap) Then
            picBox2.Image = Nothing
        End If
        If picBox3.Image Is e.Data.GetData(DataFormats.Bitmap) Then
            picBox3.Image = Nothing
        End If
        If picBox4.Image Is e.Data.GetData(DataFormats.Bitmap) Then
            picBox4.Image = Nothing
        End If
        If picBox5.Image Is e.Data.GetData(DataFormats.Bitmap) Then
            picBox5.Image = Nothing
        End If
        If picBox6.Image Is e.Data.GetData(DataFormats.Bitmap) Then
            picBox6.Image = Nothing
        End If
        nb_pioche += 1
        'If nb_pioche <> 0 Then
        '    grille.AllowDrop = False
        'End If


    End Sub
    Private Sub grille_DragDrop(sender As Object, e As DragEventArgs) Handles pictureboxpioche.DragDrop
        If sender.Image Is Nothing Then
            sender.Image = e.Data.GetData(DataFormats.Bitmap)
            If picBox1.Image Is e.Data.GetData(DataFormats.Bitmap) Then
                picBox1.Image = Nothing
            End If
            If picBox2.Image Is e.Data.GetData(DataFormats.Bitmap) Then
                picBox2.Image = Nothing
            End If
            If picBox3.Image Is e.Data.GetData(DataFormats.Bitmap) Then
                picBox3.Image = Nothing
            End If
            If picBox4.Image Is e.Data.GetData(DataFormats.Bitmap) Then
                picBox4.Image = Nothing
            End If
            If picBox5.Image Is e.Data.GetData(DataFormats.Bitmap) Then
                picBox5.Image = Nothing
            End If
            If picBox6.Image Is e.Data.GetData(DataFormats.Bitmap) Then
                picBox6.Image = Nothing
            End If
        End If
    End Sub

    Private Sub btn_confirmer_Click(sender As Object, e As EventArgs) Handles btn_confirmer.MouseClick
        verifMain()
        If I = 1 Then

            tour_joueur = lbl_j1_nom.Text
            If I = jeu.getNombreJoueurs Then
                I = 0
            End If
        End If
        If I = 2 Then
            tour_joueur = lbl_j2_nom.Text
            If I = jeu.getNombreJoueurs Then
                I = 0
            End If
        End If
        If I = 3 Then
            tour_joueur = lbl_j3_nom.Text
            If I = jeu.getNombreJoueurs Then
                I = 0
            End If
        End If
        If I = 4 Then
            tour_joueur = lbl_j4_nom.Text
            If I = jeu.getNombreJoueurs Then
                I = 0
            End If
        End If
        lbl_joueur_actuel.Text = "Tour de " & tour_joueur
        I += 1
        nb_pioche = 0
    End Sub

    Private Sub btn_recommencer_Click(sender As Object, e As EventArgs) Handles btn_recommencer.Click
        Dim validation As DialogResult
        validation = MessageBox.Show("Voulez vous recommencer ?", "Qwirkle", MessageBoxButtons.YesNo)
        If (validation = DialogResult.Yes) Then
            frm_qwirkle_menu.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub main_hover(sender As Object, e As EventArgs)
        sender.Cursor = Cursors.Hand
    End Sub

    Private Sub btn_aide_Click_1(sender As Object, e As EventArgs) Handles btn_aide.Click
        frm_aide.Show()
    End Sub

    Private Sub verifMain()
        If picBox1.Image Is Nothing Then
            picBox1.Image = addmain(picBox1)
        End If
        If picBox2.Image Is Nothing Then
            picBox2.Image = addmain(picBox2)
        End If
        If picBox3.Image Is Nothing Then
            picBox3.Image = addmain(picBox3)
        End If
        If picBox4.Image Is Nothing Then
            picBox4.Image = addmain(picBox4)
        End If
        If picBox5.Image Is Nothing Then
            picBox5.Image = addmain(picBox5)
        End If
        If picBox6.Image Is Nothing Then
            picBox6.Image = addmain(picBox6)
        End If
    End Sub

    Private Sub frm_jeu_menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim validation As DialogResult
        validation = MessageBox.Show("Quitter Qwirkle ?", "Qwirkle", MessageBoxButtons.YesNo)
        If (validation = DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub
End Class