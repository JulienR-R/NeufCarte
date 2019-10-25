using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeufCarte.model
{
    public interface ITourJeu
    {
        IJoueur PremierJoueur { get; }
        Couleur CouleurCarte { get; }
        ICarte CartePlusHaute { get; }
        IJoueur JoueurPlusHaut { get; }
    }
    public class TourJeu : ITourJeu
    {
        public IJoueur PremierJoueur { get; }
        public Couleur CouleurCarte { get; }
        public ICarte CartePlusHaute { get; }
        public IJoueur JoueurPlusHaut { get; }

        public TourJeu(IJoueur premierJoueur,
                        Couleur couleurCarte,
                        ICarte cartePlusHaute,
                        IJoueur joueurPlusHaut)
        {
            PremierJoueur = premierJoueur;
            CouleurCarte = couleurCarte;
            CartePlusHaute = cartePlusHaute;
            JoueurPlusHaut = joueurPlusHaut;
        }
    }
}
