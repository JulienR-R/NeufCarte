namespace NeufCarte
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_turn = new System.Windows.Forms.Label();
            this.lbl_atout = new System.Windows.Forms.Label();
            this.lbl_ptsTitle = new System.Windows.Forms.Label();
            this.listBox_pts = new System.Windows.Forms.ListBox();
            this.pictureBox_player = new System.Windows.Forms.PictureBox();
            this.listBox_cards = new System.Windows.Forms.ListBox();
            this.lbl_cardsTitle = new System.Windows.Forms.Label();
            this.lbl_playerName = new System.Windows.Forms.Label();
            this.btn_sort = new System.Windows.Forms.Button();
            this.lbl_leveeTitle = new System.Windows.Forms.Label();
            this.lbl_levee = new System.Windows.Forms.Label();
            this.lbl_npc1 = new System.Windows.Forms.Label();
            this.pictureBox_npc1 = new System.Windows.Forms.PictureBox();
            this.lbl_leveeNPC1Title = new System.Windows.Forms.Label();
            this.lbl_leveeNPC1 = new System.Windows.Forms.Label();
            this.lbl_leveeNPC3 = new System.Windows.Forms.Label();
            this.lbl_leveeNPC3Title = new System.Windows.Forms.Label();
            this.pictureBox_npc3 = new System.Windows.Forms.PictureBox();
            this.lbl_npc3 = new System.Windows.Forms.Label();
            this.lbl_cartesNPC1 = new System.Windows.Forms.Label();
            this.lbl_cartesNPC3 = new System.Windows.Forms.Label();
            this.lbl_cartesNPC2 = new System.Windows.Forms.Label();
            this.lbl_leveeNPC2 = new System.Windows.Forms.Label();
            this.lbl_leveeNPC2Title = new System.Windows.Forms.Label();
            this.pictureBox_npc2 = new System.Windows.Forms.PictureBox();
            this.lbl_npc2 = new System.Windows.Forms.Label();
            this.lbl_cardNPC1 = new System.Windows.Forms.Label();
            this.lbl_cardPlayer = new System.Windows.Forms.Label();
            this.lbl_cardNPC3 = new System.Windows.Forms.Label();
            this.lbl_cardNPC2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_npc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_npc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_npc2)).BeginInit();
            // 
            // lbl_turn
            // 
            this.lbl_turn.AutoSize = true;
            this.lbl_turn.Location = new System.Drawing.Point(68, 44);
            this.lbl_turn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_turn.Name = "lbl_turn";
            this.lbl_turn.Size = new System.Drawing.Size(46, 17);
            this.lbl_turn.TabIndex = 0;
            this.lbl_turn.Text = "Tour: ";
            // 
            // lbl_atout
            // 
            this.lbl_atout.AutoSize = true;
            this.lbl_atout.Location = new System.Drawing.Point(68, 74);
            this.lbl_atout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_atout.Name = "lbl_atout";
            this.lbl_atout.Size = new System.Drawing.Size(45, 17);
            this.lbl_atout.TabIndex = 1;
            this.lbl_atout.Text = "Atout;";
            // 
            // lbl_ptsTitle
            // 
            this.lbl_ptsTitle.AutoSize = true;
            this.lbl_ptsTitle.Location = new System.Drawing.Point(1060, 44);
            this.lbl_ptsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ptsTitle.Name = "lbl_ptsTitle";
            this.lbl_ptsTitle.Size = new System.Drawing.Size(64, 17);
            this.lbl_ptsTitle.TabIndex = 2;
            this.lbl_ptsTitle.Text = "Pointage";
            // 
            // listBox_pts
            // 
            this.listBox_pts.FormattingEnabled = true;
            this.listBox_pts.ItemHeight = 16;
            this.listBox_pts.Location = new System.Drawing.Point(1064, 74);
            this.listBox_pts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_pts.Name = "listBox_pts";
            this.listBox_pts.Size = new System.Drawing.Size(159, 116);
            this.listBox_pts.TabIndex = 3;
            // 
            // pictureBox_player
            // 
            this.pictureBox_player.Location = new System.Drawing.Point(369, 630);
            this.pictureBox_player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_player.Name = "pictureBox_player";
            this.pictureBox_player.Size = new System.Drawing.Size(127, 117);
            this.pictureBox_player.TabIndex = 4;
            this.pictureBox_player.TabStop = false;
            // 
            // listBox_cards
            // 
            this.listBox_cards.FormattingEnabled = true;
            this.listBox_cards.ItemHeight = 16;
            this.listBox_cards.Location = new System.Drawing.Point(525, 630);
            this.listBox_cards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_cards.Name = "listBox_cards";
            this.listBox_cards.Size = new System.Drawing.Size(379, 116);
            this.listBox_cards.TabIndex = 5;
            this.listBox_cards.DoubleClick += new System.EventHandler(this.listBox_cards_DoubleClick);
            // 
            // lbl_cardsTitle
            // 
            this.lbl_cardsTitle.AutoSize = true;
            this.lbl_cardsTitle.Location = new System.Drawing.Point(521, 593);
            this.lbl_cardsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cardsTitle.Name = "lbl_cardsTitle";
            this.lbl_cardsTitle.Size = new System.Drawing.Size(49, 17);
            this.lbl_cardsTitle.TabIndex = 6;
            this.lbl_cardsTitle.Text = "Cartes";
            // 
            // lbl_playerName
            // 
            this.lbl_playerName.AutoSize = true;
            this.lbl_playerName.Location = new System.Drawing.Point(365, 592);
            this.lbl_playerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_playerName.Name = "lbl_playerName";
            this.lbl_playerName.Size = new System.Drawing.Size(80, 17);
            this.lbl_playerName.TabIndex = 7;
            this.lbl_playerName.Text = "Nom player";
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(936, 666);
            this.btn_sort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(100, 28);
            this.btn_sort.TabIndex = 8;
            this.btn_sort.Text = "Trier la main";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // lbl_leveeTitle
            // 
            this.lbl_leveeTitle.AutoSize = true;
            this.lbl_leveeTitle.Location = new System.Drawing.Point(1064, 593);
            this.lbl_leveeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_leveeTitle.Name = "lbl_leveeTitle";
            this.lbl_leveeTitle.Size = new System.Drawing.Size(54, 17);
            this.lbl_leveeTitle.TabIndex = 9;
            this.lbl_leveeTitle.Text = "Levées";
            // 
            // lbl_levee
            // 
            this.lbl_levee.AutoSize = true;
            this.lbl_levee.Location = new System.Drawing.Point(1064, 630);
            this.lbl_levee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_levee.Name = "lbl_levee";
            this.lbl_levee.Size = new System.Drawing.Size(16, 17);
            this.lbl_levee.TabIndex = 10;
            this.lbl_levee.Text = "0";
            // 
            // lbl_npc1
            // 
            this.lbl_npc1.AutoSize = true;
            this.lbl_npc1.Location = new System.Drawing.Point(72, 241);
            this.lbl_npc1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_npc1.Name = "lbl_npc1";
            this.lbl_npc1.Size = new System.Drawing.Size(91, 17);
            this.lbl_npc1.TabIndex = 11;
            this.lbl_npc1.Text = "NPC 1 NAME";
            // 
            // pictureBox_npc1
            // 
            this.pictureBox_npc1.Location = new System.Drawing.Point(72, 279);
            this.pictureBox_npc1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_npc1.Name = "pictureBox_npc1";
            this.pictureBox_npc1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox_npc1.TabIndex = 12;
            this.pictureBox_npc1.TabStop = false;
            // 
            // lbl_leveeNPC1Title
            // 
            this.lbl_leveeNPC1Title.AutoSize = true;
            this.lbl_leveeNPC1Title.Location = new System.Drawing.Point(72, 380);
            this.lbl_leveeNPC1Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_leveeNPC1Title.Name = "lbl_leveeNPC1Title";
            this.lbl_leveeNPC1Title.Size = new System.Drawing.Size(54, 17);
            this.lbl_leveeNPC1Title.TabIndex = 13;
            this.lbl_leveeNPC1Title.Text = "Levées";
            // 
            // lbl_leveeNPC1
            // 
            this.lbl_leveeNPC1.AutoSize = true;
            this.lbl_leveeNPC1.Location = new System.Drawing.Point(136, 380);
            this.lbl_leveeNPC1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_leveeNPC1.Name = "lbl_leveeNPC1";
            this.lbl_leveeNPC1.Size = new System.Drawing.Size(16, 17);
            this.lbl_leveeNPC1.TabIndex = 14;
            this.lbl_leveeNPC1.Text = "0";
            // 
            // lbl_leveeNPC3
            // 
            this.lbl_leveeNPC3.AutoSize = true;
            this.lbl_leveeNPC3.Location = new System.Drawing.Point(1128, 380);
            this.lbl_leveeNPC3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_leveeNPC3.Name = "lbl_leveeNPC3";
            this.lbl_leveeNPC3.Size = new System.Drawing.Size(16, 17);
            this.lbl_leveeNPC3.TabIndex = 18;
            this.lbl_leveeNPC3.Text = "0";
            // 
            // lbl_leveeNPC3Title
            // 
            this.lbl_leveeNPC3Title.AutoSize = true;
            this.lbl_leveeNPC3Title.Location = new System.Drawing.Point(1064, 380);
            this.lbl_leveeNPC3Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_leveeNPC3Title.Name = "lbl_leveeNPC3Title";
            this.lbl_leveeNPC3Title.Size = new System.Drawing.Size(54, 17);
            this.lbl_leveeNPC3Title.TabIndex = 17;
            this.lbl_leveeNPC3Title.Text = "Levées";
            // 
            // pictureBox_npc3
            // 
            this.pictureBox_npc3.Location = new System.Drawing.Point(1064, 279);
            this.pictureBox_npc3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_npc3.Name = "pictureBox_npc3";
            this.pictureBox_npc3.Size = new System.Drawing.Size(100, 92);
            this.pictureBox_npc3.TabIndex = 16;
            this.pictureBox_npc3.TabStop = false;
            // 
            // lbl_npc3
            // 
            this.lbl_npc3.AutoSize = true;
            this.lbl_npc3.Location = new System.Drawing.Point(1064, 241);
            this.lbl_npc3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_npc3.Name = "lbl_npc3";
            this.lbl_npc3.Size = new System.Drawing.Size(91, 17);
            this.lbl_npc3.TabIndex = 15;
            this.lbl_npc3.Text = "NPC 3 NAME";
            // 
            // lbl_cartesNPC1
            // 
            this.lbl_cartesNPC1.AutoSize = true;
            this.lbl_cartesNPC1.Location = new System.Drawing.Point(208, 279);
            this.lbl_cartesNPC1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cartesNPC1.Name = "lbl_cartesNPC1";
            this.lbl_cartesNPC1.Size = new System.Drawing.Size(65, 17);
            this.lbl_cartesNPC1.TabIndex = 19;
            this.lbl_cartesNPC1.Text = "Cartes: 0";
            // 
            // lbl_cartesNPC3
            // 
            this.lbl_cartesNPC3.AutoSize = true;
            this.lbl_cartesNPC3.Location = new System.Drawing.Point(1172, 279);
            this.lbl_cartesNPC3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cartesNPC3.Name = "lbl_cartesNPC3";
            this.lbl_cartesNPC3.Size = new System.Drawing.Size(65, 17);
            this.lbl_cartesNPC3.TabIndex = 20;
            this.lbl_cartesNPC3.Text = "Cartes: 0";
            // 
            // lbl_cartesNPC2
            // 
            this.lbl_cartesNPC2.AutoSize = true;
            this.lbl_cartesNPC2.Location = new System.Drawing.Point(713, 74);
            this.lbl_cartesNPC2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cartesNPC2.Name = "lbl_cartesNPC2";
            this.lbl_cartesNPC2.Size = new System.Drawing.Size(65, 17);
            this.lbl_cartesNPC2.TabIndex = 25;
            this.lbl_cartesNPC2.Text = "Cartes: 0";
            // 
            // lbl_leveeNPC2
            // 
            this.lbl_leveeNPC2.AutoSize = true;
            this.lbl_leveeNPC2.Location = new System.Drawing.Point(669, 175);
            this.lbl_leveeNPC2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_leveeNPC2.Name = "lbl_leveeNPC2";
            this.lbl_leveeNPC2.Size = new System.Drawing.Size(16, 17);
            this.lbl_leveeNPC2.TabIndex = 24;
            this.lbl_leveeNPC2.Text = "0";
            // 
            // lbl_leveeNPC2Title
            // 
            this.lbl_leveeNPC2Title.AutoSize = true;
            this.lbl_leveeNPC2Title.Location = new System.Drawing.Point(605, 175);
            this.lbl_leveeNPC2Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_leveeNPC2Title.Name = "lbl_leveeNPC2Title";
            this.lbl_leveeNPC2Title.Size = new System.Drawing.Size(54, 17);
            this.lbl_leveeNPC2Title.TabIndex = 23;
            this.lbl_leveeNPC2Title.Text = "Levées";
            // 
            // pictureBox_npc2
            // 
            this.pictureBox_npc2.Location = new System.Drawing.Point(605, 74);
            this.pictureBox_npc2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_npc2.Name = "pictureBox_npc2";
            this.pictureBox_npc2.Size = new System.Drawing.Size(100, 92);
            this.pictureBox_npc2.TabIndex = 22;
            this.pictureBox_npc2.TabStop = false;
            // 
            // lbl_npc2
            // 
            this.lbl_npc2.AutoSize = true;
            this.lbl_npc2.Location = new System.Drawing.Point(605, 36);
            this.lbl_npc2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_npc2.Name = "lbl_npc2";
            this.lbl_npc2.Size = new System.Drawing.Size(91, 17);
            this.lbl_npc2.TabIndex = 21;
            this.lbl_npc2.Text = "NPC 2 NAME";
            // 
            // pictureBox_cardNPC1
            // 
            this.lbl_cardNPC1.Location = new System.Drawing.Point(433, 325);
            this.lbl_cardNPC1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_cardNPC1.Name = "pictureBox_cardNPC1";
            this.lbl_cardNPC1.Size = new System.Drawing.Size(100, 123);
            this.lbl_cardNPC1.TabIndex = 26;
            this.lbl_cardNPC1.TabStop = false;
            // 
            // pictureBox_cardPlayer
            // 
            this.lbl_cardPlayer.Location = new System.Drawing.Point(625, 460);
            this.lbl_cardPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_cardPlayer.Name = "pictureBox_cardPlayer";
            this.lbl_cardPlayer.Size = new System.Drawing.Size(100, 123);
            this.lbl_cardPlayer.TabIndex = 27;
            this.lbl_cardPlayer.TabStop = false;
            // 
            // pictureBox_cardNPC3
            // 
            this.lbl_cardNPC3.Location = new System.Drawing.Point(824, 325);
            this.lbl_cardNPC3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_cardNPC3.Name = "pictureBox_cardNPC3";
            this.lbl_cardNPC3.Size = new System.Drawing.Size(100, 123);
            this.lbl_cardNPC3.TabIndex = 28;
            this.lbl_cardNPC3.TabStop = false;
            // 
            // pictureBox_cardNPC2
            // 
            this.lbl_cardNPC2.Location = new System.Drawing.Point(625, 222);
            this.lbl_cardNPC2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_cardNPC2.Name = "pictureBox_cardNPC2";
            this.lbl_cardNPC2.Size = new System.Drawing.Size(100, 123);
            this.lbl_cardNPC2.TabIndex = 29;
            this.lbl_cardNPC2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1345, 783);
            this.Controls.Add(this.lbl_cardNPC2);
            this.Controls.Add(this.lbl_cardNPC3);
            this.Controls.Add(this.lbl_cardPlayer);
            this.Controls.Add(this.lbl_cardNPC1);
            this.Controls.Add(this.lbl_cartesNPC2);
            this.Controls.Add(this.lbl_leveeNPC2);
            this.Controls.Add(this.lbl_leveeNPC2Title);
            this.Controls.Add(this.pictureBox_npc2);
            this.Controls.Add(this.lbl_npc2);
            this.Controls.Add(this.lbl_cartesNPC3);
            this.Controls.Add(this.lbl_cartesNPC1);
            this.Controls.Add(this.lbl_leveeNPC3);
            this.Controls.Add(this.lbl_leveeNPC3Title);
            this.Controls.Add(this.pictureBox_npc3);
            this.Controls.Add(this.lbl_npc3);
            this.Controls.Add(this.lbl_leveeNPC1);
            this.Controls.Add(this.lbl_leveeNPC1Title);
            this.Controls.Add(this.pictureBox_npc1);
            this.Controls.Add(this.lbl_npc1);
            this.Controls.Add(this.lbl_levee);
            this.Controls.Add(this.lbl_leveeTitle);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.lbl_playerName);
            this.Controls.Add(this.lbl_cardsTitle);
            this.Controls.Add(this.listBox_cards);
            this.Controls.Add(this.pictureBox_player);
            this.Controls.Add(this.listBox_pts);
            this.Controls.Add(this.lbl_ptsTitle);
            this.Controls.Add(this.lbl_atout);
            this.Controls.Add(this.lbl_turn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Le jeu du Neuf";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_npc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_npc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_npc2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_turn;
        private System.Windows.Forms.Label lbl_atout;
        private System.Windows.Forms.Label lbl_ptsTitle;
        private System.Windows.Forms.ListBox listBox_pts;
        private System.Windows.Forms.PictureBox pictureBox_player;
        private System.Windows.Forms.ListBox listBox_cards;
        private System.Windows.Forms.Label lbl_cardsTitle;
        private System.Windows.Forms.Label lbl_playerName;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Label lbl_leveeTitle;
        private System.Windows.Forms.Label lbl_levee;
        private System.Windows.Forms.Label lbl_npc1;
        private System.Windows.Forms.PictureBox pictureBox_npc1;
        private System.Windows.Forms.Label lbl_leveeNPC1Title;
        private System.Windows.Forms.Label lbl_leveeNPC1;
        private System.Windows.Forms.Label lbl_leveeNPC3;
        private System.Windows.Forms.Label lbl_leveeNPC3Title;
        private System.Windows.Forms.PictureBox pictureBox_npc3;
        private System.Windows.Forms.Label lbl_npc3;
        private System.Windows.Forms.Label lbl_cartesNPC1;
        private System.Windows.Forms.Label lbl_cartesNPC3;
        private System.Windows.Forms.Label lbl_cartesNPC2;
        private System.Windows.Forms.Label lbl_leveeNPC2;
        private System.Windows.Forms.Label lbl_leveeNPC2Title;
        private System.Windows.Forms.PictureBox pictureBox_npc2;
        private System.Windows.Forms.Label lbl_npc2;
        private System.Windows.Forms.Label lbl_cardNPC1;
        private System.Windows.Forms.Label lbl_cardPlayer;
        private System.Windows.Forms.Label lbl_cardNPC3;
        private System.Windows.Forms.Label lbl_cardNPC2;
    }
}