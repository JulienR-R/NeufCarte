﻿using System;
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
    }
}
