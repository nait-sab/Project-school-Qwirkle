using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwirkle_lib
{
    public class Tuile
    {
        private int m_position_y;
        private int m_position_x;
        private static int m_id;
        private string m_forme;
        private string m_couleur;

        public Tuile(string couleur, string forme)
        {
            this.m_position_x = 0;
            this.m_position_y = 0;
            this.m_forme = forme;
            this.m_couleur = couleur;
        }

        public string getCouleur() { return this.m_couleur; }
        public string getForme() { return this.m_forme; }
    }
}
