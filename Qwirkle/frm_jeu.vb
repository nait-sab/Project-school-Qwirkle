Public Class frm_jeu

    Public score_joueur As Integer = 0
    Public score_tour As Integer = 0
    Public longueur As Integer = 0
    Public comptage As Boolean = 0
    Public direction As Integer = 0
    Public case_remplie As Boolean = 0

    Private Sub frm_jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For value1 As Integer = 0 To 30
            For value2 As Integer = 0 To 30
                Dim p As New Windows.Forms.PictureBox()
                p.Location = New Drawing.Point(240 + 27 * value1, 27 * value2)
                p.Size = New Drawing.Size(27, 27)
                p.BorderStyle = Windows.Forms.BorderStyle.FixedSingle 'Pour moi, afin de voir qu'elle est là
                p.Visible = True
                p.AllowDrop = True
                p.SizeMode = PictureBoxSizeMode.StretchImage
                Me.Controls.Add(p)
                AddHandler p.DragEnter, AddressOf grille_DragEnter
                AddHandler p.DragDrop, AddressOf grille_DragDrop
            Next
        Next
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

        picBox1.Image = module_jeu.addmain(picBox1)
        picBox2.Image = module_jeu.addmain(picBox2)
        picBox3.Image = module_jeu.addmain(picBox3)
        picBox4.Image = module_jeu.addmain(picBox4)
        picBox5.Image = module_jeu.addmain(picBox5)
        picBox6.Image = module_jeu.addmain(picBox6)

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

    Private Sub grille_DragEnter(sender As Object, e As DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub grille_DragDrop(sender As Object, e As DragEventArgs)

        sender.Image = e.Data.GetData(DataFormats.Bitmap)
    End Sub


    Private Sub btn_aide_Click(sender As Object, e As EventArgs)
        frm_aide.Show()
    End Sub

    Private Sub btn_confirmer_Click(sender As Object, e As EventArgs)

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
        lbl_joueur_actuel.Text = "Tour de " & lbl_j1_nom.Text
    End Sub

    Private Sub btn_recommencer_Click(sender As Object, e As EventArgs)
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
End Class