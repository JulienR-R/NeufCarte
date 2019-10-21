using System;
using System.Collections.Generic;

namespace NeufCarte.model
{
    public interface ICarte
    {
        Valeur Valeur { get; set; }
        Couleur Couleur { get; set; }
        Boolean Equals(ICarte other);
    }

    public enum Valeur
    {
        As = 1, Deux, Trois, Quatre, Cinq, Six, Sept, Huit, Neuf, Dix, Valet, Dame, Roi
    }

    public enum Couleur
    {
        Coeur, Carreau, Pique, Trefle
    }

    public class Carte : ICarte
    {
        public Valeur Valeur { get; set; }
        public Couleur Couleur { get; set; }

        public Carte(Valeur valeur, Couleur couleur)
        {
            Valeur = valeur;
            Couleur = couleur;
        }

        public override string ToString()
        {
            string val = "";
            int valeur = (int)Valeur;
            val = (valeur > 1 && valeur < 11) ? valeur.ToString() : Valeur.ToString();
            return $"{val} de {Couleur}";
        }


        public Boolean Equals(ICarte other)
        {
            if (Valeur == other.Valeur)
                return true;
            else return false;
        }
    }
}