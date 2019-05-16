﻿Public Class frm_jeu

    Private couleur() As String = {"Bleu", "Jaune", "Orange", "Rouge", "Vert", "Violet"}
    Private forme() As String = {"Carre", "Croix", "Etoile", "Losange", "Rond", "Trefle"}
    Private test As New Qwirkle_lib.Tuile(couleur(5), forme(3))
    Private Sub frm_jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grille_1_1.AllowDrop = True
        'picBox1.Image = Image.FromFile("Ressources\" & test.getForme & test.getCouleur & ".jpg")
        picBox1.Image = My.Resources.ResourceManager.GetObject(test.getForme & test.getCouleur)
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

    Private Sub picBox1_Click(sender As Object, e As EventArgs) Handles picBox1.Click
        MsgBox(test.getForme())
    End Sub
End Class