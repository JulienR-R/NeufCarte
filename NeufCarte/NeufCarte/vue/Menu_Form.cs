using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeufCarte
{
    public partial class Menu_Form : Form
    {

        public static string playerName = "";
        
        public Menu_Form()
        {
            InitializeComponent();
        }

        private void Menu_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerName = textBox_playerName.Text;
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jouerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Les joueurs débutent le jeu avec 9 points. Le joueur qui arrive à 0 gagne." +
                "\n\nVous devez fournir la sorte qui est demandé, sinon vous pouvez couper avec un atout." +
                "\nSi vous ne pouvez pas couper, vous devez jeter une carte de votre choix." +
                "\n\nL'ordre des atouts est : coeur, carreau, pique, puis trèfle." +
                "\nVous avez besoin de 4 levées pour rester sans bouger (points)." +
                "\n\nVous avez 5 levées vous descendez de 1 point, 3 levées vous montez de 1 point.");
        }
    }
}
