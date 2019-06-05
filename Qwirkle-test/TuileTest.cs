using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Qwirkle_lib;

namespace Qwirkle_test
{
    [TestClass]
    public class TuileTest
    {
        [TestMethod]
        public void TestConstructeur()
        {
            Tuile tuile = new Tuile("Rouge", "Carre");

            Assert.AreEqual("Carre", tuile.getForme());
            Assert.AreEqual("Rouge", tuile.getCouleur());
        }
        [TestMethod]
        public void TestSetForme()
        {
            Tuile tuile = new Tuile("Rouge", "Carre");

            tuile.setForme("Croix");
            Assert.AreEqual("Croix", tuile.getForme());
        }
        [TestMethod]
        public void TestSetCouleur()
        {
            Tuile tuile = new Tuile("Rouge", "Carre");

            tuile.setCouleur("Jaune");
            Assert.AreEqual("Jaune", tuile.getCouleur());
        }
    }
}