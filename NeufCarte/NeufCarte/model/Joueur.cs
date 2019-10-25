﻿using System;
using System.Collections.Generic;

namespace NeufCarte.model
{
    public interface IJoueur
    {
        String Nom { get; set; }

        List<ICarte> Main { get; set; }

        Boolean IsAutomate { get; set; }

        ITourJeu Jouer(ITourJeu tourJeu, IJoueur joueur, ICarte carteJouee);

        int Levees { get; set; }

        int Pointage { get; set; }
    }

    public class Joueur : IJoueur
    {
        public String Nom { get; set; }

        public List<ICarte> Main { get; set; }

        public Boolean IsAutomate { get; set; }
        public int Levees { get; set; }
        public int Pointage { get; set; }

        private static int clone;

        public Joueur(string nom)
        {
            Nom = nom;
            Main = new List<ICarte>();
            IsAutomate = false;
            Pointage = 9;
        }

        //joueur automate
        public Joueur()
        {
            clone++;
            Nom = "autoPlayer" + clone;
            Main = new List<ICarte>();
            IsAutomate = true;
            Pointage = 9;
        }

        public Boolean Equals(IJoueur other)
        {
            if (Nom == other.Nom)
                return true;
            else return false;
        }

        public override string ToString()
        {
            return Nom;
        }

        public ITourJeu Jouer(ITourJeu tourJeu, IJoueur joueur, ICarte carteJouee)
        {
            IJoueur premierJoueur = tourJeu.PremierJoueur;
            Couleur couleurCarte = tourJeu.CouleurCarte;
            ICarte cartePlusHaute = tourJeu.CartePlusHaute;
            IJoueur joueurPlusHaut = tourJeu.JoueurPlusHaut;
            if (tourJeu.PremierJoueur == null)
            {
                premierJoueur = joueur;
                couleurCarte = carteJouee.Couleur;
                cartePlusHaute = carteJouee;
                joueurPlusHaut = joueur;
            }
            else
            {
                if(carteJouee.Couleur.Equals(tourJeu.CouleurCarte))
                {
                    if (carteJouee.Valeur > tourJeu.CartePlusHaute.Valeur)
                    {
                        cartePlusHaute = carteJouee;
                        joueurPlusHaut = joueur;
                    }
                }else{
                    bool menteur = false;
                    foreach (ICarte carte in joueur.Main)
                    {
                        if (carte.Couleur.Equals(couleurCarte))
                        {
                            menteur = true;
                            break;
                        }
                    }
                    if (menteur)
                    {
                        //erreur
                    }
                    else
                    {
                        if (carteJouee.Couleur.Equals(atout))
                        {
                            if (carteJouee.Valeur > tourJeu.CartePlusHaute.Valeur)
                            {
                                cartePlusHaute = carteJouee;
                                joueurPlusHaut = joueur;
                            }
                        }
                        else
                        {
                            bool menteur2 = false;
                            foreach (ICarte carte in joueur.Main)
                            {
                                if (carte.Couleur.Equals(atout))
                                {
                                    menteur2 = true;
                                    break;
                                }
                            }
                            if (menteur2)
                            {
                                //erreur
                            }
                        }
                    }
                }
            }
            ITourJeu resultat = new TourJeu(
                    premierJoueur,
                    couleurCarte,
                    carteJouee,
                    joueurPlusHaut);
            return resultat;
        }
    }
}
