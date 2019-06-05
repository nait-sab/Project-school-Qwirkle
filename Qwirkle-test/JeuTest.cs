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
    }
}
