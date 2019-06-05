
Module module_jeu

    Public jeu As New Qwirkle_lib.Jeu()

    Public joueur1 As Qwirkle_lib.Joueur
    Public joueur2 As Qwirkle_lib.Joueur
    Public joueur3 As Qwirkle_lib.Joueur
    Public joueur4 As Qwirkle_lib.Joueur

    Public couleur() As String = {"Bleu", "Jaune", "Orange", "Rouge", "Vert", "Violet"}
    Public forme() As String = {"Carre", "Croix", "Etoile", "Losange", "Rond", "Trefle"}

    Dim randomizer As Random = New Random

    Public Function addmain(ByVal pb As PictureBox) As Image
        Dim form As String = forme(randomizer.Next(6))
        Dim color As String = couleur(randomizer.Next(6))
        Dim tuile As New Qwirkle_lib.Tuile(color, form)
        tuile.setCouleur(color)
        tuile.setForme(form)
        jeu.removeTuile(tuile)
        Dim obj As String = (form & color)
        Dim img As Image = My.Resources.ResourceManager.GetObject(obj)
        Return img
    End Function

End Module
