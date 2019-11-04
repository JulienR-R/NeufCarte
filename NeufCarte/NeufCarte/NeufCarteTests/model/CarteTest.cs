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
    public class CarteTests
    {

        [TestMethod()]
        public void CarteConstructorTest()
        {
            Valeur expectedValeur = Valeur.Dame;
            Couleur expectedCouleur = Couleur.Carreau;
            Carte actualCarte = new Carte(expectedValeur, expectedCouleur);
            Assert.AreEqual(expectedValeur, actualCarte.Valeur);
            Assert.AreEqual(expectedCouleur, actualCarte.Couleur);
        }

        [TestMethod()]
        public void ToStringValNumeriqueTest()
        {
            Carte carte = new Carte(Valeur.Cinq, Couleur.Coeur);
            string expected = "5 de Coeur";
            string actual = carte.ToString();
            Console.WriteLine($"expect '{expected}' got '{actual}'");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringValHauteTest()
        {
            Carte carte = new Carte(Valeur.Roi, Couleur.Trefle);
            string expected = "Roi de Trefle";
            string actual = carte.ToString();
            Console.WriteLine($"expect '{expected}' got '{actual}'");
            Assert.AreEqual(expected, actual);
        }



        [TestMethod()]
        public void EqualsTest()
        {
            Couleur coul = Couleur.Carreau;
            Valeur val = Valeur.As;
            Carte carte1 = new Carte(val, coul);
            Carte carte2 = new Carte(val, coul);
            Assert.IsTrue(carte1.Equals(carte2));
        }

        [TestMethod()]
        public void EqualsCouleurDoesntMatterTest()
        {
            Carte carte1 = new Carte(Valeur.As, Couleur.Carreau);
            Carte carte2 = new Carte(Valeur.As, Couleur.Coeur);
            Assert.IsTrue(carte1.Equals(carte2));
        }

        [TestMethod()]
        public void EqualsValeurMattersTest()
        {
            Carte carte1 = new Carte(Valeur.Roi, Couleur.Carreau);
            Carte carte2 = new Carte(Valeur.As, Couleur.Carreau);
            Assert.IsFalse(carte1.Equals(carte2));
        }
    }
}