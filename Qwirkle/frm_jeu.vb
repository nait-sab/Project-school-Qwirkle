Public Class frm_jeu
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

        lbl_joueur_actuel.Text = "Tour de " & joueur1.getNom

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

        If jeu.getNombreJoueurs > 0 Then
            For distribution As Integer = 1 To 6
                main_joueur1.Add(add_player_tile)
            Next
        End If
        If jeu.getNombreJoueurs > 1 Then
            For distribution As Integer = 1 To 6
                main_joueur2.Add(add_player_tile)
            Next
        End If
        If jeu.getNombreJoueurs > 2 Then
            For distribution As Integer = 1 To 6
                main_joueur3.Add(add_player_tile)
            Next
        End If
        If jeu.getNombreJoueurs > 3 Then
            For distribution As Integer = 1 To 6
                main_joueur4.Add(add_player_tile)
            Next
        End If

        afficher_main(1)

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

        lbl_tuile_restante.Text = "Pioche : " & ((pioche.Count).ToString)

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
        pictureboxpioche.Image = Nothing
        If picBox1.Image Is e.Data.GetData(DataFormats.Bitmap) Then
            picBox1.Image = Nothing
            If jeu.getJoueurActuel = 1 Then
                main_joueur1.RemoveAt(0)
            ElseIf jeu.getJoueurActuel = 2 Then
                main_joueur2.RemoveAt(0)
            ElseIf jeu.getJoueurActuel = 3 Then
                main_joueur3.RemoveAt(0)
            ElseIf jeu.getJoueurActuel = 4 Then
                main_joueur4.RemoveAt(0)
            End If
        ElseIf picBox2.Image Is e.Data.GetData(DataFormats.Bitmap) Then
            picBox2.Image = Nothing
            If jeu.getJoueurActuel = 1 Then
                main_joueur1.RemoveAt(1)
            ElseIf jeu.getJoueurActuel = 2 Then
                main_joueur2.RemoveAt(1)
            ElseIf jeu.getJoueurActuel = 3 Then
                main_joueur3.RemoveAt(1)
            ElseIf jeu.getJoueurActuel = 4 Then
                main_joueur4.RemoveAt(1)
            End If
        ElseIf picBox3.Image Is e.Data.GetData(DataFormats.Bitmap) Then
            picBox3.Image = Nothing
            If jeu.getJoueurActuel = 1 Then
                main_joueur1.RemoveAt(2)
            ElseIf jeu.getJoueurActuel = 2 Then
                main_joueur2.RemoveAt(2)
            ElseIf jeu.getJoueurActuel = 3 Then
                main_joueur3.RemoveAt(2)
            ElseIf jeu.getJoueurActuel = 4 Then
                main_joueur4.RemoveAt(2)
            End If
        ElseIf picBox4.Image Is e.Data.GetData(DataFormats.Bitmap) Then
            picBox4.Image = Nothing
            If jeu.getJoueurActuel = 1 Then
                main_joueur1.RemoveAt(3)
            ElseIf jeu.getJoueurActuel = 2 Then
                main_joueur2.RemoveAt(3)
            ElseIf jeu.getJoueurActuel = 3 Then
                main_joueur3.RemoveAt(3)
            ElseIf jeu.getJoueurActuel = 4 Then
                main_joueur4.RemoveAt(3)
            End If
        ElseIf picBox5.Image Is e.Data.GetData(DataFormats.Bitmap) Then
            picBox5.Image = Nothing
            If jeu.getJoueurActuel = 1 Then
                main_joueur1.RemoveAt(4)
            ElseIf jeu.getJoueurActuel = 2 Then
                main_joueur2.RemoveAt(4)
            ElseIf jeu.getJoueurActuel = 3 Then
                main_joueur3.RemoveAt(4)
            ElseIf jeu.getJoueurActuel = 4 Then
                main_joueur4.RemoveAt(4)
            End If
        ElseIf picBox6.Image Is e.Data.GetData(DataFormats.Bitmap) Then
            picBox6.Image = Nothing
            If jeu.getJoueurActuel = 1 Then
                main_joueur1.RemoveAt(5)
            ElseIf jeu.getJoueurActuel = 2 Then
                main_joueur2.RemoveAt(5)
            ElseIf jeu.getJoueurActuel = 3 Then
                main_joueur3.RemoveAt(5)
            ElseIf jeu.getJoueurActuel = 4 Then
                main_joueur4.RemoveAt(5)
            End If
        End If
    End Sub

    Private Sub grille_DragDrop(sender As Object, e As DragEventArgs)
        If sender.Image Is Nothing Then
            sender.Image = e.Data.GetData(DataFormats.Bitmap)
            If picBox1.Image Is e.Data.GetData(DataFormats.Bitmap) Then
                picBox1.Image = Nothing
                If jeu.getJoueurActuel = 1 Then
                    main_joueur1.RemoveAt(0)
                ElseIf jeu.getJoueurActuel = 2 Then
                    main_joueur2.RemoveAt(0)
                ElseIf jeu.getJoueurActuel = 3 Then
                    main_joueur3.RemoveAt(0)
                ElseIf jeu.getJoueurActuel = 4 Then
                    main_joueur4.RemoveAt(0)
                End If
            ElseIf picBox2.Image Is e.Data.GetData(DataFormats.Bitmap) Then
                picBox2.Image = Nothing
                If jeu.getJoueurActuel = 1 Then
                    main_joueur1.RemoveAt(1)
                ElseIf jeu.getJoueurActuel = 2 Then
                    main_joueur2.RemoveAt(1)
                ElseIf jeu.getJoueurActuel = 3 Then
                    main_joueur3.RemoveAt(1)
                ElseIf jeu.getJoueurActuel = 4 Then
                    main_joueur4.RemoveAt(1)
                End If
            ElseIf picBox3.Image Is e.Data.GetData(DataFormats.Bitmap) Then
                picBox3.Image = Nothing
                If jeu.getJoueurActuel = 1 Then
                    main_joueur1.RemoveAt(2)
                ElseIf jeu.getJoueurActuel = 2 Then
                    main_joueur2.RemoveAt(2)
                ElseIf jeu.getJoueurActuel = 3 Then
                    main_joueur3.RemoveAt(2)
                ElseIf jeu.getJoueurActuel = 4 Then
                    main_joueur4.RemoveAt(2)
                End If
            ElseIf picBox4.Image Is e.Data.GetData(DataFormats.Bitmap) Then
                picBox4.Image = Nothing
                If jeu.getJoueurActuel = 1 Then
                    main_joueur1.RemoveAt(3)
                ElseIf jeu.getJoueurActuel = 2 Then
                    main_joueur2.RemoveAt(3)
                ElseIf jeu.getJoueurActuel = 3 Then
                    main_joueur3.RemoveAt(3)
                ElseIf jeu.getJoueurActuel = 4 Then
                    main_joueur4.RemoveAt(3)
                End If
            ElseIf picBox5.Image Is e.Data.GetData(DataFormats.Bitmap) Then
                picBox5.Image = Nothing
                If jeu.getJoueurActuel = 1 Then
                    main_joueur1.RemoveAt(4)
                ElseIf jeu.getJoueurActuel = 2 Then
                    main_joueur2.RemoveAt(4)
                ElseIf jeu.getJoueurActuel = 3 Then
                    main_joueur3.RemoveAt(4)
                ElseIf jeu.getJoueurActuel = 4 Then
                    main_joueur4.RemoveAt(4)
                End If
            ElseIf picBox6.Image Is e.Data.GetData(DataFormats.Bitmap) Then
                picBox6.Image = Nothing
                If jeu.getJoueurActuel = 1 Then
                    main_joueur1.RemoveAt(5)
                ElseIf jeu.getJoueurActuel = 2 Then
                    main_joueur2.RemoveAt(5)
                ElseIf jeu.getJoueurActuel = 3 Then
                    main_joueur3.RemoveAt(5)
                ElseIf jeu.getJoueurActuel = 4 Then
                    main_joueur4.RemoveAt(5)
                End If
            End If
        End If
    End Sub

    Private Sub btn_confirmer_Click(sender As Object, e As EventArgs) Handles btn_confirmer.MouseClick
        Dim score As Integer
        If jeu.getJoueurActuel = 1 Then
            score = 6 - main_joueur1.Count
            joueur1.modifierScore(score)
            lbl_j1_score.Text = (joueur1.getScore).ToString
        ElseIf jeu.getJoueurActuel = 2 Then
            score = 6 - main_joueur2.Count
            joueur2.modifierScore(score)
            lbl_j2_score.Text = (joueur2.getScore).ToString
        ElseIf jeu.getJoueurActuel = 3 Then
            score = 6 - main_joueur3.Count
            joueur3.modifierScore(score)
            lbl_j3_score.Text = (joueur3.getScore).ToString
        ElseIf jeu.getJoueurActuel = 4 Then
            score = 6 - main_joueur4.Count
            joueur4.modifierScore(score)
            lbl_j4_score.Text = (joueur4.getScore).ToString
        End If
        verifMain(jeu.getJoueurActuel)
        jeu.nouveauTour()
        If jeu.getJoueurActuel = 1 Then
            MessageBox.Show("Tour de " & joueur1.getNom)
            lbl_joueur_actuel.Text = "Tour de " & joueur1.getNom
        ElseIf jeu.getJoueurActuel = 2 Then
            MessageBox.Show("Tour de " & joueur2.getNom)
            lbl_joueur_actuel.Text = "Tour de " & joueur2.getNom
        ElseIf jeu.getJoueurActuel = 3 Then
            MessageBox.Show("Tour de " & joueur3.getNom)
            lbl_joueur_actuel.Text = "Tour de " & joueur3.getNom
        ElseIf jeu.getJoueurActuel = 4 Then
            MessageBox.Show("Tour de " & joueur4.getNom)
            lbl_joueur_actuel.Text = "Tour de " & joueur4.getNom
        End If
        afficher_main(jeu.getJoueurActuel)
        lbl_tuile_restante.Text = "Pioche : " & ((pioche.Count).ToString)
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

    Private Sub verifMain(player As Integer)
        If taille_pioche > 0 Then
            If player = 1 Then
                While main_joueur1.Count < 6
                    main_joueur1.Add(add_player_tile)
                End While
            End If
            If player = 2 Then
                While main_joueur2.Count < 6
                    main_joueur2.Add(add_player_tile)
                End While
            End If
            If player = 3 Then
                While main_joueur3.Count < 6
                    main_joueur3.Add(add_player_tile)
                End While
            End If
            If player = 4 Then
                While main_joueur4.Count < 6
                    main_joueur4.Add(add_player_tile)
                End While
            End If
        End If
    End Sub

    Private Sub frm_jeu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim validation As DialogResult
        validation = MessageBox.Show("Quitter Qwirkle ?", "Qwirkle", MessageBoxButtons.YesNo)
        If (validation = DialogResult.No) Then
            e.Cancel = True
        Else
            Me.Hide()
            e.Cancel = True
            frm_qwirkle_menu.Show()
        End If
    End Sub

    Private Sub afficher_main(player As Integer)
        Dim tuile_a_montrer As Qwirkle_lib.Tuile
        Dim forme As String
        Dim couleur As String
        Dim name As String
        Dim image As Image
        Dim taille As Integer

        If player = 1 Then
            taille = main_joueur1.Count - 1
            For placement As Integer = 0 To taille
                tuile_a_montrer = main_joueur1.Item(placement)
                forme = tuile_a_montrer.getForme
                couleur = tuile_a_montrer.getCouleur
                name = (forme & couleur)
                image = My.Resources.ResourceManager.GetObject(name)
                If placement = 0 Then
                    If (taille + 1) > 0 Then
                        picBox1.Image = image
                    Else
                        picBox1.Image = Nothing
                    End If
                End If
                If placement = 1 Then
                    If (taille + 1) > 1 Then
                        picBox2.Image = image
                    Else
                        picBox2.Image = Nothing
                    End If
                ElseIf placement = 2 Then
                    If (taille + 1) > 2 Then
                        picBox3.Image = image
                    Else
                        picBox3.Image = Nothing
                    End If
                ElseIf placement = 3 Then
                    If (taille + 1) > 3 Then
                        picBox4.Image = image
                    Else
                        picBox4.Image = Nothing
                    End If
                ElseIf placement = 4 Then
                    If (taille + 1) > 4 Then
                        picBox5.Image = image
                    Else
                        picBox5.Image = Nothing
                    End If
                ElseIf placement = 5 Then
                    If (taille + 1) > 5 Then
                        picBox6.Image = image
                    Else
                        picBox6.Image = Nothing
                    End If
                End If
            Next
        End If
        If player = 2 Then
            taille = main_joueur2.Count - 1
            For placement As Integer = 0 To taille
                tuile_a_montrer = main_joueur2.Item(placement)
                forme = tuile_a_montrer.getForme
                couleur = tuile_a_montrer.getCouleur
                name = (forme & couleur)
                image = My.Resources.ResourceManager.GetObject(name)
                If placement = 0 Then
                    picBox1.Image = image
                ElseIf placement = 1 Then
                    picBox2.Image = image
                ElseIf placement = 2 Then
                    picBox3.Image = image
                ElseIf placement = 3 Then
                    picBox4.Image = image
                ElseIf placement = 4 Then
                    picBox5.Image = image
                ElseIf placement = 5 Then
                    picBox6.Image = image
                End If
            Next
        End If
        If player = 3 Then
            taille = main_joueur3.Count - 1
            For placement As Integer = 0 To taille
                tuile_a_montrer = main_joueur3.Item(placement)
                forme = tuile_a_montrer.getForme
                couleur = tuile_a_montrer.getCouleur
                name = (forme & couleur)
                image = My.Resources.ResourceManager.GetObject(name)
                If placement = 0 Then
                    picBox1.Image = image
                ElseIf placement = 1 Then
                    picBox2.Image = image
                ElseIf placement = 2 Then
                    picBox3.Image = image
                ElseIf placement = 3 Then
                    picBox4.Image = image
                ElseIf placement = 4 Then
                    picBox5.Image = image
                ElseIf placement = 5 Then
                    picBox6.Image = image
                End If
            Next
        End If
        If player = 4 Then
            taille = main_joueur4.Count - 1
            For placement As Integer = 0 To taille
                tuile_a_montrer = main_joueur4.Item(placement)
                forme = tuile_a_montrer.getForme
                couleur = tuile_a_montrer.getCouleur
                name = (forme & couleur)
                image = My.Resources.ResourceManager.GetObject(name)
                If placement = 0 Then
                    picBox1.Image = image
                ElseIf placement = 1 Then
                    picBox2.Image = image
                ElseIf placement = 2 Then
                    picBox3.Image = image
                ElseIf placement = 3 Then
                    picBox4.Image = image
                ElseIf placement = 4 Then
                    picBox5.Image = image
                ElseIf placement = 5 Then
                    picBox6.Image = image
                End If
            Next
        End If
    End Sub
End Class