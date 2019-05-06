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
            Assert.AreEqual(null, jeu.getMainVisible());
            Assert.AreEqual(null, jeu.getPioche());
            Assert.AreEqual(null, jeu.getJoueurs());
        }
    }
}
