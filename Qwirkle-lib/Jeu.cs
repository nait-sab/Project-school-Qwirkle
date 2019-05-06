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
            this.m_pioche = null;
            this.m_joueurs = null;
        }

        public void creer_partie()
        {

        }
        
        public void menu_principal()
        {

        }

        public void menu_selecton_joueurs()
        {

        }

        public void menu_fin()
        {

        }
    }
}
