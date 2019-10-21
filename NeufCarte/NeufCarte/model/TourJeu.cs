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
        ICarte CartePlusHaute { get; }
        IJoueur JoueurPlusHaut { get; }
    }
    public class TourJeu : ITourJeu
    {
        public IJoueur PremierJoueur { get; }
        public ICarte CartePlusHaute { get; }
        public IJoueur JoueurPlusHaut { get; }

        public TourJeu(IJoueur premierJoueur,
                        ICarte cartePlusHaute,
                        IJoueur joueurPlusHaut)
        {
            PremierJoueur = premierJoueur;
            CartePlusHaute = cartePlusHaute;
            JoueurPlusHaut = joueurPlusHaut;
        }
    }
}
