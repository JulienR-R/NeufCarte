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
    public class JeuTest
    {
        [TestMethod()]
        public void JeuConstructeurPetitNbJoueurTest()
        {
            int nbJoueurs = 2;
            Jeu jeu = new Jeu(nbJoueurs, "whatever");
            Assert.AreEqual(nbJoueurs, jeu.ListJoueurs.Count);
        }
        [TestMethod()]
        public void JeuConstructeurNbJoueurPlusGrandQue3Test()
        {
            int nbJoueurs = 4;
            Jeu jeu = new Jeu(nbJoueurs, "whatever");
            Assert.AreEqual(nbJoueurs, jeu.ListJoueurs.Count);
        }

        [TestMethod()]
        public void JeuConstructeurCreeUnJoueurHumainTest()
        {
            int nbJoueurs = 4;
            Jeu jeu = new Jeu(nbJoueurs, "whatever");
            int nbJoueursHumain = 0;
            foreach (IJoueur joueur in jeu.ListJoueurs)
            {
                if (!joueur.IsAutomate)
                {
                    nbJoueursHumain++;
                }
            }
            Assert.IsTrue(nbJoueursHumain == 1);
        }

        [TestMethod()]
        public void ProchainTourNoArgsWithHumanPlayerReturnNull()
        {
            Jeu jeu = new Jeu(3, "whatever");
            IJoueur joueurActif = jeu.JoueurActuel;
            for (int i = 0; i < 3 && joueurActif.IsAutomate; i++)
            {
                jeu.ProchainTour();
                joueurActif = jeu.JoueurActuel;
            }
            ITourJeu tourJeu = jeu.ProchainTour();
            Assert.IsNull(tourJeu);
        }

        [TestMethod()]
        public void ProchainTourArgsWithAutomatePlayerReturnNull()
        {
            Jeu jeu = new Jeu(3, "whatever");
            IJoueur joueurActif = jeu.JoueurActuel;
            if (!joueurActif.IsAutomate)
            {
                jeu.ProchainTour(joueurActif.Main[0]);
            }
            ITourJeu tourJeu = jeu.ProchainTour(joueurActif.Main[0]);
            Assert.IsNull(tourJeu);
        }

        [TestMethod()]
        public void ProchainTourIntArgTest()
        {
            Jeu jeu = new Jeu(3, "whatever");
            IJoueur joueurActif = jeu.JoueurActuel;
            for (int i = 0; i < 3 && joueurActif.IsAutomate; i++)
            {
                jeu.ProchainTour();
                joueurActif = jeu.JoueurActuel;
            }
            int indexCard = 0;
            ICarte expectedCard = jeu.JoueurActuel.Main[indexCard];
            ITourJeu tourJeu = jeu.ProchainTour(indexCard);
            Console.WriteLine($"expected card: {expectedCard}");
            Console.WriteLine($"actual card: {tourJeu.CartePlusHaute}");
            Assert.AreEqual(expectedCard, tourJeu.CartePlusHaute);
        }
    }
}
