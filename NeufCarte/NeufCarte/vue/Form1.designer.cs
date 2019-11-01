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
            this.components = new System.ComponentModel.Container();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentJouerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_npc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_npc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_npc2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_turn
            // 
            this.lbl_turn.AutoSize = true;
            this.lbl_turn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_turn.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turn.ForeColor = System.Drawing.Color.Silver;
            this.lbl_turn.Location = new System.Drawing.Point(12, 36);
            this.lbl_turn.Name = "lbl_turn";
            this.lbl_turn.Size = new System.Drawing.Size(110, 37);
            this.lbl_turn.TabIndex = 0;
            this.lbl_turn.Text = "Tour: 1";
            // 
            // lbl_atout
            // 
            this.lbl_atout.AutoSize = true;
            this.lbl_atout.BackColor = System.Drawing.Color.Transparent;
            this.lbl_atout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_atout.ForeColor = System.Drawing.Color.Silver;
            this.lbl_atout.Location = new System.Drawing.Point(16, 86);
            this.lbl_atout.Name = "lbl_atout";
            this.lbl_atout.Size = new System.Drawing.Size(125, 23);
            this.lbl_atout.TabIndex = 1;
            this.lbl_atout.Text = "Atout: Coeur";
            // 
            // lbl_ptsTitle
            // 
            this.lbl_ptsTitle.AutoSize = true;
            this.lbl_ptsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ptsTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ptsTitle.ForeColor = System.Drawing.Color.Silver;
            this.lbl_ptsTitle.Location = new System.Drawing.Point(794, 41);
            this.lbl_ptsTitle.Name = "lbl_ptsTitle";
            this.lbl_ptsTitle.Size = new System.Drawing.Size(93, 23);
            this.lbl_ptsTitle.TabIndex = 2;
            this.lbl_ptsTitle.Text = "Pointage";
            // 
            // listBox_pts
            // 
            this.listBox_pts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox_pts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_pts.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_pts.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox_pts.FormattingEnabled = true;
            this.listBox_pts.ItemHeight = 16;
            this.listBox_pts.Location = new System.Drawing.Point(798, 67);
            this.listBox_pts.Name = "listBox_pts";
            this.listBox_pts.Size = new System.Drawing.Size(165, 98);
            this.listBox_pts.TabIndex = 3;
            // 
            // pictureBox_player
            // 
            this.pictureBox_player.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_player.Image")));
            this.pictureBox_player.Location = new System.Drawing.Point(277, 512);
            this.pictureBox_player.Name = "pictureBox_player";
            this.pictureBox_player.Size = new System.Drawing.Size(95, 95);
            this.pictureBox_player.TabIndex = 4;
            this.pictureBox_player.TabStop = false;
            // 
            // listBox_cards
            // 
            this.listBox_cards.FormattingEnabled = true;
            this.listBox_cards.Location = new System.Drawing.Point(394, 512);
            this.listBox_cards.Name = "listBox_cards";
            this.listBox_cards.Size = new System.Drawing.Size(285, 95);
            this.listBox_cards.TabIndex = 5;
            // 
            // lbl_cardsTitle
            // 
            this.lbl_cardsTitle.AutoSize = true;
            this.lbl_cardsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cardsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cardsTitle.ForeColor = System.Drawing.Color.Silver;
            this.lbl_cardsTitle.Location = new System.Drawing.Point(391, 493);
            this.lbl_cardsTitle.Name = "lbl_cardsTitle";
            this.lbl_cardsTitle.Size = new System.Drawing.Size(47, 16);
            this.lbl_cardsTitle.TabIndex = 6;
            this.lbl_cardsTitle.Text = "Cartes";
            // 
            // lbl_playerName
            // 
            this.lbl_playerName.AutoSize = true;
            this.lbl_playerName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_playerName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_playerName.Location = new System.Drawing.Point(273, 488);
            this.lbl_playerName.Name = "lbl_playerName";
            this.lbl_playerName.Size = new System.Drawing.Size(99, 21);
            this.lbl_playerName.TabIndex = 7;
            this.lbl_playerName.Text = "Nom player";
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(604, 613);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_sort.TabIndex = 8;
            this.btn_sort.Text = "Trier la main";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // lbl_leveeTitle
            // 
            this.lbl_leveeTitle.AutoSize = true;
            this.lbl_leveeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_leveeTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leveeTitle.ForeColor = System.Drawing.Color.Silver;
            this.lbl_leveeTitle.Location = new System.Drawing.Point(696, 512);
            this.lbl_leveeTitle.Name = "lbl_leveeTitle";
            this.lbl_leveeTitle.Size = new System.Drawing.Size(55, 16);
            this.lbl_leveeTitle.TabIndex = 9;
            this.lbl_leveeTitle.Text = "Levées:";
            // 
            // lbl_levee
            // 
            this.lbl_levee.AutoSize = true;
            this.lbl_levee.BackColor = System.Drawing.Color.Transparent;
            this.lbl_levee.Font = new System.Drawing.Font("Century Gothic", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_levee.ForeColor = System.Drawing.Color.Silver;
            this.lbl_levee.Location = new System.Drawing.Point(696, 537);
            this.lbl_levee.Name = "lbl_levee";
            this.lbl_levee.Size = new System.Drawing.Size(64, 70);
            this.lbl_levee.TabIndex = 10;
            this.lbl_levee.Text = "0";
            // 
            // lbl_npc1
            // 
            this.lbl_npc1.AutoSize = true;
            this.lbl_npc1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_npc1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_npc1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_npc1.Location = new System.Drawing.Point(51, 269);
            this.lbl_npc1.Name = "lbl_npc1";
            this.lbl_npc1.Size = new System.Drawing.Size(86, 17);
            this.lbl_npc1.TabIndex = 11;
            this.lbl_npc1.Text = "Adversaire 1";
            // 
            // pictureBox_npc1
            // 
            this.pictureBox_npc1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_npc1.Image")));
            this.pictureBox_npc1.Location = new System.Drawing.Point(54, 289);
            this.pictureBox_npc1.Name = "pictureBox_npc1";
            this.pictureBox_npc1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox_npc1.TabIndex = 12;
            this.pictureBox_npc1.TabStop = false;
            // 
            // lbl_leveeNPC1Title
            // 
            this.lbl_leveeNPC1Title.AutoSize = true;
            this.lbl_leveeNPC1Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_leveeNPC1Title.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leveeNPC1Title.ForeColor = System.Drawing.Color.Silver;
            this.lbl_leveeNPC1Title.Location = new System.Drawing.Point(135, 311);
            this.lbl_leveeNPC1Title.Name = "lbl_leveeNPC1Title";
            this.lbl_leveeNPC1Title.Size = new System.Drawing.Size(54, 17);
            this.lbl_leveeNPC1Title.TabIndex = 13;
            this.lbl_leveeNPC1Title.Text = "Levées:";
            // 
            // lbl_leveeNPC1
            // 
            this.lbl_leveeNPC1.AutoSize = true;
            this.lbl_leveeNPC1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_leveeNPC1.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leveeNPC1.ForeColor = System.Drawing.Color.Silver;
            this.lbl_leveeNPC1.Location = new System.Drawing.Point(135, 328);
            this.lbl_leveeNPC1.Name = "lbl_leveeNPC1";
            this.lbl_leveeNPC1.Size = new System.Drawing.Size(36, 40);
            this.lbl_leveeNPC1.TabIndex = 14;
            this.lbl_leveeNPC1.Text = "0";
            // 
            // lbl_leveeNPC3
            // 
            this.lbl_leveeNPC3.AutoSize = true;
            this.lbl_leveeNPC3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_leveeNPC3.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leveeNPC3.ForeColor = System.Drawing.Color.Silver;
            this.lbl_leveeNPC3.Location = new System.Drawing.Point(903, 329);
            this.lbl_leveeNPC3.Name = "lbl_leveeNPC3";
            this.lbl_leveeNPC3.Size = new System.Drawing.Size(36, 40);
            this.lbl_leveeNPC3.TabIndex = 18;
            this.lbl_leveeNPC3.Text = "0";
            // 
            // lbl_leveeNPC3Title
            // 
            this.lbl_leveeNPC3Title.AutoSize = true;
            this.lbl_leveeNPC3Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_leveeNPC3Title.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leveeNPC3Title.ForeColor = System.Drawing.Color.Silver;
            this.lbl_leveeNPC3Title.Location = new System.Drawing.Point(903, 311);
            this.lbl_leveeNPC3Title.Name = "lbl_leveeNPC3Title";
            this.lbl_leveeNPC3Title.Size = new System.Drawing.Size(54, 17);
            this.lbl_leveeNPC3Title.TabIndex = 17;
            this.lbl_leveeNPC3Title.Text = "Levées:";
            // 
            // pictureBox_npc3
            // 
            this.pictureBox_npc3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_npc3.BackgroundImage")));
            this.pictureBox_npc3.Location = new System.Drawing.Point(822, 289);
            this.pictureBox_npc3.Name = "pictureBox_npc3";
            this.pictureBox_npc3.Size = new System.Drawing.Size(75, 75);
            this.pictureBox_npc3.TabIndex = 16;
            this.pictureBox_npc3.TabStop = false;
            // 
            // lbl_npc3
            // 
            this.lbl_npc3.AutoSize = true;
            this.lbl_npc3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_npc3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_npc3.ForeColor = System.Drawing.Color.Silver;
            this.lbl_npc3.Location = new System.Drawing.Point(819, 269);
            this.lbl_npc3.Name = "lbl_npc3";
            this.lbl_npc3.Size = new System.Drawing.Size(86, 17);
            this.lbl_npc3.TabIndex = 15;
            this.lbl_npc3.Text = "Adversaire 3";
            // 
            // lbl_cartesNPC1
            // 
            this.lbl_cartesNPC1.AutoSize = true;
            this.lbl_cartesNPC1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cartesNPC1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cartesNPC1.ForeColor = System.Drawing.Color.Silver;
            this.lbl_cartesNPC1.Location = new System.Drawing.Point(135, 289);
            this.lbl_cartesNPC1.Name = "lbl_cartesNPC1";
            this.lbl_cartesNPC1.Size = new System.Drawing.Size(60, 17);
            this.lbl_cartesNPC1.TabIndex = 19;
            this.lbl_cartesNPC1.Text = "Cartes: 0";
            // 
            // lbl_cartesNPC3
            // 
            this.lbl_cartesNPC3.AutoSize = true;
            this.lbl_cartesNPC3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cartesNPC3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cartesNPC3.ForeColor = System.Drawing.Color.Silver;
            this.lbl_cartesNPC3.Location = new System.Drawing.Point(903, 289);
            this.lbl_cartesNPC3.Name = "lbl_cartesNPC3";
            this.lbl_cartesNPC3.Size = new System.Drawing.Size(60, 17);
            this.lbl_cartesNPC3.TabIndex = 20;
            this.lbl_cartesNPC3.Text = "Cartes: 0";
            // 
            // lbl_cartesNPC2
            // 
            this.lbl_cartesNPC2.AutoSize = true;
            this.lbl_cartesNPC2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cartesNPC2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cartesNPC2.ForeColor = System.Drawing.Color.Silver;
            this.lbl_cartesNPC2.Location = new System.Drawing.Point(553, 86);
            this.lbl_cartesNPC2.Name = "lbl_cartesNPC2";
            this.lbl_cartesNPC2.Size = new System.Drawing.Size(60, 17);
            this.lbl_cartesNPC2.TabIndex = 25;
            this.lbl_cartesNPC2.Text = "Cartes: 0";
            // 
            // lbl_leveeNPC2
            // 
            this.lbl_leveeNPC2.AutoSize = true;
            this.lbl_leveeNPC2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_leveeNPC2.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leveeNPC2.ForeColor = System.Drawing.Color.Silver;
            this.lbl_leveeNPC2.Location = new System.Drawing.Point(553, 127);
            this.lbl_leveeNPC2.Name = "lbl_leveeNPC2";
            this.lbl_leveeNPC2.Size = new System.Drawing.Size(36, 40);
            this.lbl_leveeNPC2.TabIndex = 24;
            this.lbl_leveeNPC2.Text = "0";
            // 
            // lbl_leveeNPC2Title
            // 
            this.lbl_leveeNPC2Title.AutoSize = true;
            this.lbl_leveeNPC2Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_leveeNPC2Title.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leveeNPC2Title.ForeColor = System.Drawing.Color.Silver;
            this.lbl_leveeNPC2Title.Location = new System.Drawing.Point(553, 110);
            this.lbl_leveeNPC2Title.Name = "lbl_leveeNPC2Title";
            this.lbl_leveeNPC2Title.Size = new System.Drawing.Size(54, 17);
            this.lbl_leveeNPC2Title.TabIndex = 23;
            this.lbl_leveeNPC2Title.Text = "Levées:";
            // 
            // pictureBox_npc2
            // 
            this.pictureBox_npc2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_npc2.Image")));
            this.pictureBox_npc2.Location = new System.Drawing.Point(472, 86);
            this.pictureBox_npc2.Name = "pictureBox_npc2";
            this.pictureBox_npc2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox_npc2.TabIndex = 22;
            this.pictureBox_npc2.TabStop = false;
            // 
            // lbl_npc2
            // 
            this.lbl_npc2.AutoSize = true;
            this.lbl_npc2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_npc2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_npc2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_npc2.Location = new System.Drawing.Point(469, 66);
            this.lbl_npc2.Name = "lbl_npc2";
            this.lbl_npc2.Size = new System.Drawing.Size(86, 17);
            this.lbl_npc2.TabIndex = 21;
            this.lbl_npc2.Text = "Adversaire 2";
            // 
            // lbl_cardNPC1
            // 
            this.lbl_cardNPC1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cardNPC1.Location = new System.Drawing.Point(325, 264);
            this.lbl_cardNPC1.Name = "lbl_cardNPC1";
            this.lbl_cardNPC1.Size = new System.Drawing.Size(75, 100);
            this.lbl_cardNPC1.TabIndex = 26;
            // 
            // lbl_cardPlayer
            // 
            this.lbl_cardPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cardPlayer.Location = new System.Drawing.Point(469, 374);
            this.lbl_cardPlayer.Name = "lbl_cardPlayer";
            this.lbl_cardPlayer.Size = new System.Drawing.Size(75, 100);
            this.lbl_cardPlayer.TabIndex = 27;
            // 
            // lbl_cardNPC3
            // 
            this.lbl_cardNPC3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cardNPC3.Location = new System.Drawing.Point(618, 264);
            this.lbl_cardNPC3.Name = "lbl_cardNPC3";
            this.lbl_cardNPC3.Size = new System.Drawing.Size(75, 100);
            this.lbl_cardNPC3.TabIndex = 28;
            // 
            // lbl_cardNPC2
            // 
            this.lbl_cardNPC2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cardNPC2.Location = new System.Drawing.Point(469, 180);
            this.lbl_cardNPC2.Name = "lbl_cardNPC2";
            this.lbl_cardNPC2.Size = new System.Drawing.Size(75, 100);
            this.lbl_cardNPC2.TabIndex = 29;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commentJouerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // commentJouerToolStripMenuItem
            // 
            this.commentJouerToolStripMenuItem.Name = "commentJouerToolStripMenuItem";
            this.commentJouerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commentJouerToolStripMenuItem.Text = "Comment jouer";
            this.commentJouerToolStripMenuItem.Click += new System.EventHandler(this.commentJouerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 644);
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
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Le jeu du Neuf";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_npc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_npc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_npc2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commentJouerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}