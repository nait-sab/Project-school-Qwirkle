using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwirkle_lib
{
    public class Jeu
    {
        private int m_nombre_joueurs;
        private int m_joueur_actuel;
        private List<Tuile> m_main_visible;
        private List<Tuile> m_pioche;
        private List<Joueur> m_joueurs;

        public Jeu()
        {
            this.m_nombre_joueurs = 0;
            this.m_joueur_actuel = 0;
            this.m_main_visible = null;
            this.m_joueurs = null;
        }

        // Piloter la pioche en lui donnant et prenant
        public void addTuile(Tuile tuile) { this.m_pioche.Add(tuile); }
        public void removeTuile(Tuile tuile) { this.m_pioche.Remove(tuile); }

        //Accesors
        public int getNombreJoueurs() { return this.m_nombre_joueurs; }
        public int getJoueurActuel() { return this.m_joueur_actuel; }
        public List<Tuile> getMainVisible() { return this.m_main_visible; }
        public List<Tuile> getPioche() { return this.m_pioche; }
        public List<Joueur> getJoueurs() { return this.m_joueurs; }

        public void setNombreJoueurs(int total) { this.m_nombre_joueurs = total; }
    }
}
