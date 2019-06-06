
Module module_jeu

    Public jeu As New Qwirkle_lib.Jeu()

    Public joueur1 As Qwirkle_lib.Joueur
    Public joueur2 As Qwirkle_lib.Joueur
    Public joueur3 As Qwirkle_lib.Joueur
    Public joueur4 As Qwirkle_lib.Joueur

    Public couleur() As String = {"Bleu", "Jaune", "Orange", "Rouge", "Vert", "Violet"}
    Public forme() As String = {"Carre", "Croix", "Etoile", "Losange", "Rond", "Trefle"}

    Dim randomizer As Random = New Random
    Public taille_pioche As Integer = 108
    Public pioche As List(Of Qwirkle_lib.Tuile)

    Public Function addmain(ByVal pb As PictureBox) As Image
        ' Nouvelle version car l'ancienne ne supprimer pas réellement l'elèment de la pioche de jeu '
        ' J'ai régler le soucis par un public copieur de la pioche du jeu pour s'en servir une fois '
        ' la génération terminé et on n'utilisera que celle ci jusqu'à la fin '
        Dim tuile_pioche As Integer = randomizer.Next(taille_pioche)
        pioche = jeu.getPioche
        Dim tuile As Qwirkle_lib.Tuile
        tuile = pioche.Item(tuile_pioche)
        Dim form As String = tuile.getForme
        Dim color As String = tuile.getCouleur
        Dim obj As String = (form & color)
        Dim img As Image = My.Resources.ResourceManager.GetObject(obj)
        pioche.RemoveAt(tuile_pioche)
        taille_pioche -= 1
        Return img
    End Function

End Module
