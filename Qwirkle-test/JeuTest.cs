using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qwirkle_lib;

namespace Qwirkle_test
{
    [TestClass]
    public class JeuTest
    {
        [TestMethod]
        public void TestConstructeur()
        {
            Jeu jeu = new Jeu();

            Assert.AreEqual(0, jeu.getNombreJoueurs());
            Assert.AreEqual(0, jeu.getJoueurActuel());
        }
        [TestMethod]
        public void TestSetNombreJoueurs()
        {
            Jeu jeu = new Jeu();

            jeu.setNombreJoueurs(2);

            Assert.AreEqual(2, jeu.getNombreJoueurs());
        }
        [TestMethod]
        public void TestNouveauTour()
        {
            Jeu jeu = new Jeu();

            jeu.setNombreJoueurs(2);

            Assert.AreEqual(1, jeu.getJoueurActuel());

            jeu.nouveauTour();

            Assert.AreEqual(2, jeu.getJoueurActuel());
        }
    }
}
