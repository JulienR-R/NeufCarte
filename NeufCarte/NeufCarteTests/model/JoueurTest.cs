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
    public class JoueurTest
    {
        [TestMethod()]
        public void JoueurPasNomTest()
        {
            Joueur joueur = new Joueur();
            Assert.IsTrue(joueur.IsAutomate);
            Assert.IsTrue(joueur.Nom.StartsWith("autoPlayer"));
            Assert.IsTrue(joueur.Main.Count == 0);
        }
        [TestMethod()]
        public void JoueurNomTest()
        {
            Joueur bob = new Joueur("bob");
            Assert.IsFalse(bob.IsAutomate);
            Assert.AreEqual("bob", bob.Nom);
            Assert.IsTrue(bob.Main.Count == 0);
        }


        [TestMethod()]
        public void ToStringTest()
        {
            Joueur bob = new Joueur("bob");
            Assert.AreEqual("bob", bob.ToString());
        }

        [TestMethod()]
        public void PremierCoupJouer()
        {
            ITourJeu tourJeu = new TourJeu(null, Couleur.Coeur, null, null);
            Carte AsCarreau = new Carte(Valeur.As, Couleur.Carreau);
            Joueur joueur = new Joueur();
            joueur.Main.Add(AsCarreau);
            ITourJeu jouer = joueur.Jouer(tourJeu, joueur, AsCarreau);
            Assert.AreEqual(tourJeu.PremierJoueur, jouer.PremierJoueur);
            Assert.AreEqual(tourJeu.CouleurCarte, jouer.CouleurCarte);
            Assert.AreEqual(tourJeu.CartePlusHaute, jouer.CartePlusHaute);
            Assert.AreEqual(tourJeu.JoueurPlusHaut, jouer.JoueurPlusHaut);
        }

        [TestMethod()]
        public void SecondCoupJouer()
        {
            Carte AsTrefle = new Carte(Valeur.As, Couleur.Trefle);
            Joueur joueur1 = new Joueur();
            joueur1.Main.Add(AsTrefle);
            ITourJeu tourJeu = new TourJeu(joueur1, AsTrefle.Couleur, AsTrefle, joueur1);
            Carte AsCarreau = new Carte(Valeur.As, Couleur.Carreau);
            Joueur joueur2 = new Joueur();
            joueur2.Main.Add(AsCarreau);
            ITourJeu jouer = joueur2.Jouer(tourJeu, joueur2, AsCarreau);
            Assert.AreNotEqual(tourJeu.PremierJoueur, jouer.PremierJoueur);
            Assert.AreNotEqual(tourJeu.CouleurCarte, jouer.CouleurCarte);
            Assert.AreNotEqual(tourJeu.CartePlusHaute, jouer.CartePlusHaute);
            Assert.AreNotEqual(tourJeu.JoueurPlusHaut, jouer.JoueurPlusHaut);
        }
    }

    class JoueurAvecMain : IJoueur
    {
        private List<ICarte> _main;
        public JoueurAvecMain(List<ICarte> cartes)
        {
            _main = cartes;
        }
        public string Nom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<ICarte> Main { get => _main; set => throw new NotImplementedException(); }
        public bool IsAutomate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Livres { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Levees { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Pointage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ITourJeu Jouer(ITourJeu tourJeu, IJoueur joueur, ICarte carteJouee)
        {
            throw new NotImplementedException();
        }
    }


    /*class JeuAvecLac : IJeu
    {

        private IPaquet _lac;

        public JeuAvecLac(ICarte carte)
        {
            _lac = new PaquetDistribueMemeCarte(carte);
        }

        public List<IJoueur> ListJoueurs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IPaquet Lac { get => _lac; set => throw new NotImplementedException(); }

        public IJoueur ProchainJoueur => throw new NotImplementedException();

        public IJeu ProchainTour(IJoueur joueurSelected, ICarte carteSelected)
        {
            throw new NotImplementedException();
        }

        public IJeu ProchainTour()
        {
            throw new NotImplementedException();
        }

        public IJeu ProchainTour(IJoueur joueurSelected, int carteSelectedIndex)
        {
            throw new NotImplementedException();
        }


        private class PaquetDistribueMemeCarte : IPaquet
        {
            private ICarte _carte;
            public PaquetDistribueMemeCarte(ICarte carte)
            {
                _carte = carte;
            }

            public List<ICarte> ListCartes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void BrasserPaquet()
            {
                throw new NotImplementedException();
            }

            public ICarte DistribuerCarte()
            {
                return _carte;
            }
        }
    }*/
}
