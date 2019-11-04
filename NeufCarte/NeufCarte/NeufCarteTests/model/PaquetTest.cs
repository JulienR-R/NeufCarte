using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeufCarte.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeufCarteTests.model
{
    [TestClass()]
    public class PaquetTests
    {
        [TestMethod()]
        public void PaquetTest()
        {
            Paquet paquet = new Paquet();
            Assert.IsTrue(paquet.ListCartes.Count == 52);
        }

        [TestMethod()]
        public void DistribuerCarteEnleveCarteTest()
        {
            Paquet paquet = new Paquet();
            int nombreCarteDansPaquet = paquet.ListCartes.Count;
            paquet.DistribuerCarte();
            Assert.AreEqual(nombreCarteDansPaquet - 1, paquet.ListCartes.Count);
        }

        [TestMethod()]
        public void BrasserPaquetTest()
        {
            Paquet paquet = new Paquet();
            ICarte cartePos1 = paquet.ListCartes[1];
            ICarte cartePos10 = paquet.ListCartes[10];
            paquet.BrasserPaquet();
            Assert.IsTrue(cartePos1 != paquet.ListCartes[1] || cartePos10 != paquet.ListCartes[10]);
        }
    }
}