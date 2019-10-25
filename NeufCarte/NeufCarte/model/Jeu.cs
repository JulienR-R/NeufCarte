using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeufCarte.model
{
    public interface IJeu
    {
        List<IJoueur> ListJoueurs { get; set; }
        IPaquet lePaquet { get; set; }
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
        public ITourJeu tourJeu { get; set; }

        //public Boolean auSuivant { get; set; }

        private int indexJoueurActuel;

        private Couleur? atout = null;

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
            PremierJoueurRandom();

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
                if(j.Pointage <= 0)
                {
                    //win! (graphique)
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
            if (atout == null)
                atout = Couleur.Coeur;
            else if (atout == Couleur.Trefle)
                atout = null;
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
                tourJeu = JoueurActuel.Jouer(tourJeu, JoueurActuel, carteSelected);
                setProchainJoueur();
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
            IJoueur adversaire = null;
            while (adversaire == null)
            {
                int randInt = rand.Next(0, ListJoueurs.Count);
                if (ListJoueurs[randInt] != JoueurActuel)
                {
                    adversaire = ListJoueurs[randInt];
                }
            }
            int randInd = rand.Next(0, JoueurActuel.Main.Count);
            ICarte carteSelect = JoueurActuel.Main[randInd];
            return ProchainTour(carteSelect);
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
