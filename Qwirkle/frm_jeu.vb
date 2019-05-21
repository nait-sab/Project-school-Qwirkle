Public Class frm_jeu
    Public scorej1 As Integer = 1
    Public scorej2 As Integer = 2
    Public scorej3 As Integer = 3
    Public scorej4 As Integer = 5

    Public nomj1 As String = frm_CreationJoueurs.txt_Joueur1_Nom.Text.ToString
    Public nomj2 As String = frm_CreationJoueurs.txt_Joueur2_Nom.Text.ToString
    Public nomj3 As String = frm_CreationJoueurs.txt_Joueur3_Nom.Text.ToString
    Public nomj4 As String = frm_CreationJoueurs.txt_Joueur4_Nom.Text.ToString

    Private couleur() As String = {"Bleu", "Jaune", "Orange", "Rouge", "Vert", "Violet"}
    Private forme() As String = {"Carre", "Croix", "Etoile", "Losange", "Rond", "Trefle"}
    Private test As New Qwirkle_lib.Tuile(couleur(5), forme(3))

    Private Sub frm_jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pictureboxpioche.AllowDrop = True
        grille_1_1.AllowDrop = True
        'picBox1.Image = Image.FromFile("Ressources\" & test.getForme & test.getCouleur & ".jpg")
        picBox1.Image = My.Resources.ResourceManager.GetObject(test.getForme & test.getCouleur)




        If frm_nouvelle_partie.nbj = 2 Then
            pannelj3.Visible = False
            pannelj4.Visible = False
        End If
        If frm_nouvelle_partie.nbj = 3 Then
            pannelj4.Visible = False
        End If

        'Affichage nom des joueurs
        labnamej1.Text = nomj1
        labnamej2.Text = nomj2
        labnamej3.Text = nomj3
        lanamej4.Text = nomj4


        'affichage joueur actuel
        'labcurrentplayer.Text = /a completer/

        'Affichage picturebox pioche
        'pictureboxpioche.Image = / a completer/




        'Affichage score des joueurs
        labscj1.Text = scorej1.ToString
        labelscj2.Text = scorej2.ToString
        labelscj3.Text = scorej3.ToString
        labelscj4.Text = scorej4.ToString



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
    Private Sub picBox1_Click(sender As Object, e As EventArgs) Handles picBox1.Click
        MsgBox(test.getForme())

    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        frm_fin.Show()
        Me.Hide()
    End Sub
End Class