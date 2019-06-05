using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Qwirkle_lib;

namespace Qwirkle_test
{
    [TestClass]
    public class JoueurTest
    {
        [TestMethod]
        public void TestConstructeur()
        {
            Joueur pierre = new Joueur("Pierre", 12);

            Assert.AreEqual("Pierre", pierre.getNom());
            Assert.AreEqual(12, pierre.getAge());
            Assert.AreEqual(0, pierre.getScore());
            Assert.AreEqual(null, pierre.getMain());
        }
        [TestMethod]
        public void TestSetNom()
        {
            Joueur pierre = new Joueur("Pierre", 12);

            pierre.setNom("louis");

            Assert.AreEqual("louis", pierre.getNom());
        }
        [TestMethod]
        public void TestSetAge()
        {
            Joueur pierre = new Joueur("Pierre", 12);

            pierre.setAge(10);

            Assert.AreEqual(10, pierre.getAge());
        }
        [TestMethod]
        public void TestModifierScore()
        {
            Joueur pierre = new Joueur("Pierre", 12);

            pierre.modifierScore(5);

            Assert.AreEqual(5, pierre.getScore());
        }
    }
}
