
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

        'Dim pioche_recupere = jeu.getPioche
        'Dim taille As Integer = pioche_recupere.Count
        'Dim nb As Integer
        'While jeu.m_pioche(nb) Is Nothing                  ajouter nothing --------------
        '    nb = randomizer.Next(taille)
        'End While
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




    'Public Function addmain() As Qwirkle_lib.Tuile
    '    Dim pioche_recupere = jeu.getPioche

    '    Dim taille As Integer = pioche_recupere.Count
    '    Dim nb As Integer
    '    While jeu.m_pioche(nb) Is Nothing
    '        nb = randomizer.Next(taille)
    '    End While
    '    Dim tuile As Qwirkle_lib.Tuile = pioche_recupere(nb)
    '    jeu.removeTuile(tuile)
    '    Return tuile
    'End Function

    'Public Function addmain() As String
    '    Dim Form = forme(randomizer.Next(6))
    '    Dim color = couleur(randomizer.Next(6))
    '    Dim tuil As String = (Form & color)
    '    Return tuil
    'End Function


    'Public Function setbox(ByVal pb As PictureBox) As Image
    '    Dim img As Image = My.Resources.ResourceManager.GetObject(addmain())
    '    Return img
    'End Function



    'Public Function addmain() As Image
    '    Dim Form = forme(randomizer.Next(6))
    '    Dim color = couleur(randomizer.Next(6))
    '    Dim img As Image = My.Resources.ResourceManager.GetObject(Form & color)
    '    Return img
    'End Function


End Module
