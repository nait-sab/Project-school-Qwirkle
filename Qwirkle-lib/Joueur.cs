﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwirkle_lib
{
    public class Joueur
    {
        private string m_nom;
        private int m_age;
        private int m_score;
        private List<Tuile> m_main;

        public Joueur(string nom, int age)
        {
            this.m_nom = nom;
            this.m_age = age;
            this.m_score = 0;
            this.m_main = null;
        }

        // Piloter la main du joueur en lui donnant et prenant
        public void addTuile(Tuile tuile) { this.m_main.Add(tuile); }
        public void removeTuile(Tuile tuile) { this.m_main.Remove(tuile); }

        // Accesors
        public string getNom() { return this.m_nom; }
        public int getAge() { return this.m_age; }
        public int getScore() { return this.m_score; }
        public List<Tuile> getMain() { return this.m_main; }

        // Modifiers
        public void setNom(string nom) { this.m_nom = nom; }
        public void setAge(int age) { this.m_age = age; }
        public void modifierScore(int valeur) { this.m_score += valeur; }
    }
}
