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
            Assert.AreEqual(null, pierre.getMain());
        }
    }
}
