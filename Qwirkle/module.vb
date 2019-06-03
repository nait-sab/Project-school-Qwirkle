Module module_jeu

    Public jeu As New Qwirkle_lib.Jeu()

    Public joueur1 As Qwirkle_lib.Joueur
    Public joueur2 As Qwirkle_lib.Joueur
    Public joueur3 As Qwirkle_lib.Joueur
    Public joueur4 As Qwirkle_lib.Joueur



    Public couleur() As String = {"Bleu", "Jaune", "Orange", "Rouge", "Vert", "Violet"}
    Public forme() As String = {"Carre", "Croix", "Etoile", "Losange", "Rond", "Trefle"}






    Dim randomizer As Random = New Random
    Public Function addmain() As Image
        Dim Form = forme(randomizer.Next(6))
        Dim color = couleur(randomizer.Next(6))
        Dim img As Image = My.Resources.ResourceManager.GetObject(Form & color)
        Return img
    End Function


End Module
