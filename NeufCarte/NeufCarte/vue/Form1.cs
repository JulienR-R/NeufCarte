using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeufCarte.model;
using NeufCarte.vue;

namespace NeufCarte
{
    public partial class Form1 : Form
    {
        private readonly IJoueurCourant vueJoueurCourant;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string nomJoueur = Menu_Form.playerName;
            Joueur joueur = new Joueur(nomJoueur);
            lbl_playerName.Text = Menu_Form.playerName;
            Jeu jeu = new Jeu(4, nomJoueur);


                


            //Aller chercher la main du joueur et afficher dans la listBox
            foreach(Joueur j in jeu.ListJoueurs)
            {
                if (!j.IsAutomate)
                {
                    foreach (Carte c in j.Main)
                    {
                       // vueJoueurCourant.PlayerCards = c.ToString();
                        listBox_cards.Items.Add(c);
                    }

                    foreach (Joueur player in jeu.ListJoueurs)
                    {
                        if (player.IsAutomate)
                        {
                            int count = jeu.ListJoueurs.Count -1;
                            for (int i = 0; i <= count; i++)
                            {

                                int nbCartes = jeu.ListJoueurs.ElementAt(i).Main.Count();

                                var labels = Controls.Find("lbl_cartesNPC" + i, true);
                                if(labels.Length > 0)
                                {
                                    var label = (Label)labels[0];

                                    label.Text = "Cartes: " + nbCartes;
                                    
                                }

                            }
                            //vueJoueurCourant.OtherPlayers = player.ToString();
                        }

                    }
                }
                    
            }       

        }

        private void btn_sort_Click(object sender, EventArgs e)
        {


        }
    }
}
