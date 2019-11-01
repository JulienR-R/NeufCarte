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
    public class TourJeuTest
    {
        [TestMethod()]
        public void ResultatTest()
        {
            Joueur premierJoueur = new Joueur();
            Couleur couleurCarte = Couleur.Carreau;
            Carte cartePlusHaute = new Carte(Valeur.Trois, Couleur.Carreau);
            Joueur joueurPlusHaut = new Joueur();
            TourJeu tourJeu = new TourJeu(premierJoueur,
                                        couleurCarte,
                                        cartePlusHaute,
                                        joueurPlusHaut);
            Assert.AreEqual(premierJoueur, tourJeu.PremierJoueur);
            Assert.AreEqual(couleurCarte, tourJeu.CouleurCarte);
            Assert.AreEqual(cartePlusHaute, tourJeu.CartePlusHaute);
            Assert.AreEqual(joueurPlusHaut, tourJeu.JoueurPlusHaut);
        }
    }
}
