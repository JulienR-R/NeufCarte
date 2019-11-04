using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeufCarte.model;
using NeufCarte.vue;

namespace NeufCarte.presentation
{
    class MainPresenter
    {
        private readonly IMainForm myMainForm;
        private static string nomJoueur = Menu_Form.playerName;
        Joueur joueur = new Joueur(nomJoueur);
        Jeu jeu = new Jeu(4, nomJoueur);

        public MainPresenter(IMainForm aMainForm)
        {
            myMainForm = aMainForm;
            myMainForm.Load += LoadCards;
            myMainForm.AffAide += AfficherAide;
        }

        private void LoadCards(object sender, EventArgs e)
        {
            List<string> titles = new List<string>();

            //Aller chercher la main du joueur et afficher dans la listBox
            foreach (Joueur j in jeu.ListJoueurs)
            {
                if (!j.IsAutomate)
                {
                    foreach (Carte c in j.Main)
                    {
                        // vueJoueurCourant.PlayerCards = c.ToString();
                        //listBox_cards.Items.Add(c);
                        myMainForm.AddCards(j.Main);
                    }

                    foreach (Joueur player in jeu.ListJoueurs)
                    {
                        if (player.IsAutomate)
                        {
                            int count = jeu.ListJoueurs.Count - 1;
                            for (int i = 0; i <= count; i++)
                            {

                                int nbCartes = jeu.ListJoueurs.ElementAt(i).Main.Count();
                                int levee = jeu.ListJoueurs.ElementAt(i).Levees;

                                //var labels = Controls.Find("lbl_cartesNPC" + i, true);
                                //if (labels.Length > 0)
                                //{
                                //    var label = (Label)labels[0];

                                //    label.Text = "Cartes: " + nbCartes;

                                //}

                                //var labels2 = Controls.Find("lbl_leveeNPC" + i, true);
                                //if (labels2.Length > 0)
                                //{
                                //    var label2 = (Label)labels2[0];

                                //    label2.Text = levee + "";

                                //}

                            }
                            //vueJoueurCourant.OtherPlayers = player.ToString();
                        }

                    }
                }

            }
        }
        private void AfficherAide(object sender, EventArgs e)
        {
            String regles = "Les joueurs débutent le jeu avec 9 points. Le joueur qui arrive à 0 gagne." +
                "\n\nVous devez fournir la sorte qui est demandé, sinon vous pouvez couper avec un atout." +
                "\nSi vous ne pouvez pas couper, vous devez jeter une carte de votre choix." +
                "\n\nL'ordre des atouts est : coeur, carreau, pique, puis trèfle." +
                "\nVous avez besoin de 4 levées pour rester sans bouger (points)." +
                "\n\nVous avez 5 levées vous descendez de 1 point, 3 levées vous montez de 1 point.";
            MessageBox.Show(regles);
        }
    }
}
