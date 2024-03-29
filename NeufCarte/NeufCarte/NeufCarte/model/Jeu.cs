﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeufCarte.model
{
    public interface IJeu
    {
        List<IJoueur> ListJoueurs { get; set; }
        IPaquet lePaquet { get; set; }
        Couleur atout { get; set; }
        ITourJeu tourJeu { get; set; }

        //Boolean auSuivant { get; set; }

        ITourJeu ProchainTour(ICarte carteSelected);
        ITourJeu ProchainTour();
        ITourJeu ProchainTour(int carteSelectedIndex);

        IJoueur JoueurActuel { get; }
    }

    public class Jeu : IJeu
    {
        public List<IJoueur> ListJoueurs { get; set; }
        public IPaquet lePaquet { get; set; }
        public Couleur atout { get; set; }
        public ITourJeu tourJeu { get; set; }

        //public Boolean auSuivant { get; set; }

        private int indexJoueurActuel;

        private const int leveeMilieu = 4;

        private static Random rand = new Random();

        public IJoueur JoueurActuel { get; private set; }

        public Jeu(int nombreDeJoueur, string nomJoueurHumain)
        {
            //On crée les joueurs
            ListJoueurs = new List<IJoueur>();
            for (int i = 1; i <= nombreDeJoueur; i++)
            {
                Joueur joueur;
                if (i == nombreDeJoueur)
                {
                    joueur = new Joueur(nomJoueurHumain);
                }
                else
                {
                    joueur = new Joueur();
                }
                ListJoueurs.Add(joueur);
            }

            // melange la liste de joueur, le joueur en position 0 commencera
            //PremierJoueurRandom();

            //on distribu les cartes aux joueurs après avoir brassé le paquet
            debutManche();

            indexJoueurActuel = 0;
            JoueurActuel = ListJoueurs[indexJoueurActuel];
        }

        public void PremierJoueurRandom()
        {
            for (int i = 0; i < 20; i++)
            {
                int min = 0, max = ListJoueurs.Count, pos1 = rand.Next(min, max), pos2 = rand.Next(min, max);
                IJoueur j1 = ListJoueurs[pos1];
                IJoueur j2 = ListJoueurs[pos2];
                IJoueur tempon = j1;
                ListJoueurs[pos1] = j2;
                ListJoueurs[pos2] = tempon;
            }
        }

        public void debutManche()
        {
            lePaquet = new Paquet();
            lePaquet.BrasserPaquet();
            distributionCarte();
            changerAtout();
        }

        public void finManche()
        {
            foreach (IJoueur j in ListJoueurs)
            {
                j.Pointage += leveeMilieu - j.Levees;
                if (j.Pointage <= 0)
                {
                    //win! (graphique)
                    Console.WriteLine("You win");
                    MessageBox.Show("You win!");
                }
            }
        }

        public void distributionCarte()
        {
            int total = 13;
            for (int i = 1; i <= total; i++)
            {
                foreach (IJoueur j in ListJoueurs)
                {
                    j.Main.Add(lePaquet.DistribuerCarte());
                }
            }
        }

        public void changerAtout()
        {
            /*if (atout == null)
                atout = Couleur.Coeur;
            else */
            if (atout == Couleur.Trefle)
                //atout = null;
                atout = Couleur.Coeur;
            else
                atout = (Couleur)((int)atout + 1);
        }

        public void prochaineLevee()
        {
            IJoueur plusFort = tourJeu.JoueurPlusHaut;
            foreach (IJoueur j in ListJoueurs)
            {
                if (plusFort.Equals(j.Nom))
                {
                    indexJoueurActuel = ListJoueurs.IndexOf(j);
                }
            }
            JoueurActuel = ListJoueurs[indexJoueurActuel];
            JoueurActuel.Levees++;
            tourJeu = new TourJeu(null, Couleur.Coeur, null, null);
        }

        /** Jouer un tour par le joueur humain.
         * 
         * Retourne null si ce n'est pas au tour du joueur de jouer.
         */
        public ITourJeu ProchainTour(ICarte carteSelected)
        {
            if (JoueurActuel.IsAutomate)
            {
                tourJeu = null;
            }
            else
            {
                bool plusFort = false;
                bool menteur = false;
                if (tourJeu.PremierJoueur != null)
                {
                    if (carteSelected.Couleur.Equals(tourJeu.CouleurCarte))
                    {
                        if (carteSelected.Valeur > tourJeu.CartePlusHaute.Valeur)
                        {
                            plusFort = true;
                        }
                    }
                    else
                    {
                        foreach (ICarte carte in JoueurActuel.Main)
                        {
                            if (carte.Couleur.Equals(tourJeu.CouleurCarte))
                            {
                                menteur = true;
                            }
                        }
                        if (carteSelected.Couleur.Equals(atout))
                        {
                            if (carteSelected.Valeur > tourJeu.CartePlusHaute.Valeur)
                            {
                                plusFort = true;
                            }
                        }
                        else
                        {
                            foreach (ICarte carte in JoueurActuel.Main)
                            {
                                if (carte.Couleur.Equals(atout))
                                {
                                    menteur = true;
                                }
                            }
                        }
                    }
                }
                else
                {
                    plusFort = true;
                }
                if (menteur)
                {
                    //erreur
                    return null;

                }
                else if (plusFort)
                {
                    tourJeu = JoueurActuel.Jouer(tourJeu, JoueurActuel, carteSelected);
                    setProchainJoueur();
                }
                else
                {
                    setProchainJoueur();
                }

            }
            return tourJeu;
        }

        /** Jouer un tour par un automate.
         *  
         *  Retourne null si c'est plutôt au tour du joueur humain de jouer.
         */
        public ITourJeu ProchainTour()
        {
            if (!JoueurActuel.IsAutomate)
            {
                return null;
            }
            ICarte carteSelect;
            if (tourJeu.PremierJoueur == null)
            {
                int randInd = rand.Next(0, JoueurActuel.Main.Count);
                carteSelect = JoueurActuel.Main[randInd];
            }
            else
            {
                List<ICarte> possibleMain = new List<ICarte>();
                foreach (ICarte carte in JoueurActuel.Main)
                {
                    if (carte.Couleur.Equals(tourJeu.CouleurCarte))
                    {
                        possibleMain.Add(carte);
                    }
                }
                if (possibleMain.Count == 0)
                {
                    foreach (ICarte carte in JoueurActuel.Main)
                    {
                        if (carte.Couleur.Equals(atout))
                        {
                            possibleMain.Add(carte);
                        }
                    }
                }
                if (possibleMain.Count == 0)
                {
                    int randInd = rand.Next(0, JoueurActuel.Main.Count);
                    carteSelect = JoueurActuel.Main[randInd];
                }
                else
                {
                    int randInd = rand.Next(0, possibleMain.Count);
                    carteSelect = possibleMain[randInd];
                }
            }
            return tourJeu;
        }


        /** Jouer un tour par le joueur humain.
         * 
         * Retourne null si ce n'est pas au tour du joueur de jouer.
         */
        public ITourJeu ProchainTour(int carteSelectedIndex)
        {
            ICarte carteSelected = JoueurActuel.Main[carteSelectedIndex];
            return ProchainTour(carteSelected);
        }

        private void setProchainJoueur()
        {
            if (indexJoueurActuel == ListJoueurs.Count - 1)
            {
                indexJoueurActuel = 0;
            }
            else
            {
                indexJoueurActuel += 1;
            }
            if (ListJoueurs[indexJoueurActuel].Equals(tourJeu.PremierJoueur))
            {
                prochaineLevee();
            }
            else
            {
                JoueurActuel = ListJoueurs[indexJoueurActuel];
            }
        }
    }
}
