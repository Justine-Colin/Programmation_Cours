namespace PE_App1
{
    partial class Ecran_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ecran_Principal));
            this.M_Menu = new System.Windows.Forms.MenuStrip();
            this.M_Fenetre = new System.Windows.Forms.ToolStripMenuItem();
            this.M_F_Liste = new System.Windows.Forms.ToolStripMenuItem();
            this.M_F_Editeur = new System.Windows.Forms.ToolStripMenuItem();
            this.M_F_Horloge = new System.Windows.Forms.ToolStripMenuItem();
            this.spirographeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mf_Graphique = new System.Windows.Forms.ToolStripMenuItem();
            this.Mf_Carnaval = new System.Windows.Forms.ToolStripMenuItem();
            this.Mf_Clavier_Souris = new System.Windows.Forms.ToolStripMenuItem();
            this.MF_Explorateur = new System.Windows.Forms.ToolStripMenuItem();
            this.M_F_BDD1 = new System.Windows.Forms.ToolStripMenuItem();
            this.M_F_BDD2 = new System.Windows.Forms.ToolStripMenuItem();
            this.M_F_BDD3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MF_Philo = new System.Windows.Forms.ToolStripMenuItem();
            this.M_F_Exp = new System.Windows.Forms.ToolStripMenuItem();
            this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.M_Aide = new System.Windows.Forms.ToolStripMenuItem();
            this.M_Quittez = new System.Windows.Forms.ToolStripMenuItem();
            this.frequence1 = new MesControles.Frequence();
            this.boutonColore1 = new MesControles.BoutonColore();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.M_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // M_Menu
            // 
            this.M_Menu.BackColor = System.Drawing.Color.Goldenrod;
            this.M_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.M_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_Fenetre,
            this.M_Aide,
            this.M_Quittez});
            this.M_Menu.Location = new System.Drawing.Point(0, 0);
            this.M_Menu.Name = "M_Menu";
            this.M_Menu.Size = new System.Drawing.Size(741, 28);
            this.M_Menu.TabIndex = 0;
            this.M_Menu.Text = "menuStrip1";
            // 
            // M_Fenetre
            // 
            this.M_Fenetre.BackColor = System.Drawing.Color.Goldenrod;
            this.M_Fenetre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_F_Liste,
            this.M_F_Editeur,
            this.M_F_Horloge,
            this.spirographeToolStripMenuItem,
            this.Mf_Graphique,
            this.Mf_Carnaval,
            this.Mf_Clavier_Souris,
            this.MF_Explorateur,
            this.M_F_BDD1,
            this.M_F_BDD2,
            this.M_F_BDD3,
            this.MF_Philo,
            this.M_F_Exp,
            this.inToolStripMenuItem});
            this.M_Fenetre.Name = "M_Fenetre";
            this.M_Fenetre.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.M_Fenetre.Size = new System.Drawing.Size(76, 24);
            this.M_Fenetre.Text = "Fenêtres";
            // 
            // M_F_Liste
            // 
            this.M_F_Liste.BackColor = System.Drawing.Color.Goldenrod;
            this.M_F_Liste.Name = "M_F_Liste";
            this.M_F_Liste.Size = new System.Drawing.Size(239, 26);
            this.M_F_Liste.Text = "Liste";
            this.M_F_Liste.Click += new System.EventHandler(this.M_F_Liste_Click);
            // 
            // M_F_Editeur
            // 
            this.M_F_Editeur.BackColor = System.Drawing.Color.Teal;
            this.M_F_Editeur.Name = "M_F_Editeur";
            this.M_F_Editeur.Size = new System.Drawing.Size(239, 26);
            this.M_F_Editeur.Text = "Editeur";
            this.M_F_Editeur.Click += new System.EventHandler(this.M_F_Editeur_Click);
            // 
            // M_F_Horloge
            // 
            this.M_F_Horloge.BackColor = System.Drawing.Color.Goldenrod;
            this.M_F_Horloge.Name = "M_F_Horloge";
            this.M_F_Horloge.Size = new System.Drawing.Size(239, 26);
            this.M_F_Horloge.Text = "Horloge";
            this.M_F_Horloge.Click += new System.EventHandler(this.M_F_Horloge_Click);
            // 
            // spirographeToolStripMenuItem
            // 
            this.spirographeToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.spirographeToolStripMenuItem.Name = "spirographeToolStripMenuItem";
            this.spirographeToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.spirographeToolStripMenuItem.Text = "Spirographe";
            this.spirographeToolStripMenuItem.Click += new System.EventHandler(this.SpirographeToolStripMenuItem_Click);
            // 
            // Mf_Graphique
            // 
            this.Mf_Graphique.BackColor = System.Drawing.Color.Goldenrod;
            this.Mf_Graphique.Name = "Mf_Graphique";
            this.Mf_Graphique.Size = new System.Drawing.Size(239, 26);
            this.Mf_Graphique.Text = "Graphique";
            this.Mf_Graphique.Click += new System.EventHandler(this.GraphiqueToolStripMenuItem_Click);
            // 
            // Mf_Carnaval
            // 
            this.Mf_Carnaval.BackColor = System.Drawing.Color.Teal;
            this.Mf_Carnaval.Name = "Mf_Carnaval";
            this.Mf_Carnaval.Size = new System.Drawing.Size(239, 26);
            this.Mf_Carnaval.Text = "Carnaval";
            this.Mf_Carnaval.Click += new System.EventHandler(this.Mf_Carnaval_Click);
            // 
            // Mf_Clavier_Souris
            // 
            this.Mf_Clavier_Souris.BackColor = System.Drawing.Color.Goldenrod;
            this.Mf_Clavier_Souris.Name = "Mf_Clavier_Souris";
            this.Mf_Clavier_Souris.Size = new System.Drawing.Size(239, 26);
            this.Mf_Clavier_Souris.Text = "Clavier - Souris";
            this.Mf_Clavier_Souris.Click += new System.EventHandler(this.Mf_Clavier_Souris_Click);
            // 
            // MF_Explorateur
            // 
            this.MF_Explorateur.BackColor = System.Drawing.Color.Teal;
            this.MF_Explorateur.Name = "MF_Explorateur";
            this.MF_Explorateur.Size = new System.Drawing.Size(239, 26);
            this.MF_Explorateur.Text = "Explorateur";
            this.MF_Explorateur.Click += new System.EventHandler(this.MF_Explorateur_Click);
            // 
            // M_F_BDD1
            // 
            this.M_F_BDD1.BackColor = System.Drawing.Color.Goldenrod;
            this.M_F_BDD1.Name = "M_F_BDD1";
            this.M_F_BDD1.Size = new System.Drawing.Size(239, 26);
            this.M_F_BDD1.Text = "Base de données 1";
            this.M_F_BDD1.Click += new System.EventHandler(this.M_F_BDD1_Click);
            // 
            // M_F_BDD2
            // 
            this.M_F_BDD2.BackColor = System.Drawing.Color.Teal;
            this.M_F_BDD2.Name = "M_F_BDD2";
            this.M_F_BDD2.Size = new System.Drawing.Size(239, 26);
            this.M_F_BDD2.Text = "Base de données 2";
            this.M_F_BDD2.Click += new System.EventHandler(this.M_F_BDD2_Click);
            // 
            // M_F_BDD3
            // 
            this.M_F_BDD3.BackColor = System.Drawing.Color.Goldenrod;
            this.M_F_BDD3.Name = "M_F_BDD3";
            this.M_F_BDD3.Size = new System.Drawing.Size(239, 26);
            this.M_F_BDD3.Text = "Base de données 3";
            this.M_F_BDD3.Click += new System.EventHandler(this.M_F_BDD3_Click);
            // 
            // MF_Philo
            // 
            this.MF_Philo.BackColor = System.Drawing.Color.Teal;
            this.MF_Philo.Name = "MF_Philo";
            this.MF_Philo.Size = new System.Drawing.Size(239, 26);
            this.MF_Philo.Text = "Dinner des philosophes";
            this.MF_Philo.Click += new System.EventHandler(this.MF_Philo_Click);
            // 
            // M_F_Exp
            // 
            this.M_F_Exp.BackColor = System.Drawing.Color.Goldenrod;
            this.M_F_Exp.Name = "M_F_Exp";
            this.M_F_Exp.Size = new System.Drawing.Size(239, 26);
            this.M_F_Exp.Text = "Expressions régulières";
            this.M_F_Exp.Click += new System.EventHandler(this.M_F_Exp_Click);
            // 
            // inToolStripMenuItem
            // 
            this.inToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.inToolStripMenuItem.Name = "inToolStripMenuItem";
            this.inToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.inToolStripMenuItem.Text = "Intégrale";
            this.inToolStripMenuItem.Click += new System.EventHandler(this.inToolStripMenuItem_Click);
            // 
            // M_Aide
            // 
            this.M_Aide.Name = "M_Aide";
            this.M_Aide.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.M_Aide.Size = new System.Drawing.Size(52, 24);
            this.M_Aide.Text = "Aide";
            this.M_Aide.Click += new System.EventHandler(this.M_Aide_Click);
            // 
            // M_Quittez
            // 
            this.M_Quittez.Name = "M_Quittez";
            this.M_Quittez.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.M_Quittez.Size = new System.Drawing.Size(67, 24);
            this.M_Quittez.Text = "Quitter";
            this.M_Quittez.Click += new System.EventHandler(this.M_Quittez_Click);
            // 
            // frequence1
            // 
            this.frequence1.BackColor = System.Drawing.Color.Goldenrod;
            this.frequence1.Entrees.Add(((MesControles.MonPoint)(resources.GetObject("frequence1.Entrees"))));
            this.frequence1.Entrees.Add(((MesControles.MonPoint)(resources.GetObject("frequence1.Entrees1"))));
            this.frequence1.Entrees.Add(((MesControles.MonPoint)(resources.GetObject("frequence1.Entrees2"))));
            this.frequence1.Entrees.Add(((MesControles.MonPoint)(resources.GetObject("frequence1.Entrees3"))));
            this.frequence1.Entrees.Add(((MesControles.MonPoint)(resources.GetObject("frequence1.Entrees4"))));
            this.frequence1.Entrees.Add(((MesControles.MonPoint)(resources.GetObject("frequence1.Entrees5"))));
            this.frequence1.Entrees.Add(((MesControles.MonPoint)(resources.GetObject("frequence1.Entrees6"))));
            this.frequence1.Entrees.Add(((MesControles.MonPoint)(resources.GetObject("frequence1.Entrees7"))));
            this.frequence1.Entrees.Add(((MesControles.MonPoint)(resources.GetObject("frequence1.Entrees8"))));
            this.frequence1.Entrees.Add(((MesControles.MonPoint)(resources.GetObject("frequence1.Entrees9"))));
            this.frequence1.Entrees.Add(((MesControles.MonPoint)(resources.GetObject("frequence1.Entrees10"))));
            this.frequence1.Location = new System.Drawing.Point(374, 42);
            this.frequence1.Name = "frequence1";
            this.frequence1.Size = new System.Drawing.Size(355, 349);
            this.frequence1.TabIndex = 3;
            this.frequence1.Trait = System.Drawing.Color.Black;
            this.frequence1.XMax = 100;
            this.frequence1.XMin = 0;
            this.frequence1.YMax = 100;
            this.frequence1.YMin = 0;
            // 
            // boutonColore1
            // 
            this.boutonColore1.CouleurDroiteBouton = System.Drawing.Color.Goldenrod;
            this.boutonColore1.CouleurGaucheBouton = System.Drawing.Color.Teal;
            this.boutonColore1.Location = new System.Drawing.Point(12, 352);
            this.boutonColore1.Name = "boutonColore1";
            this.boutonColore1.Size = new System.Drawing.Size(344, 45);
            this.boutonColore1.TabIndex = 2;
            this.boutonColore1.Text = "boutonColore1";
            this.boutonColore1.TransparenceDroiteBouton = 200;
            this.boutonColore1.TransparenceGaucheBouton = 200;
            this.boutonColore1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PE_App1.Properties.Resources.Aya;
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Ecran_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(741, 412);
            this.Controls.Add(this.frequence1);
            this.Controls.Add(this.boutonColore1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.M_Menu);
            this.MainMenuStrip = this.M_Menu;
            this.Name = "Ecran_Principal";
            this.Text = "FicPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ecran_Principal_FormClosing);
            this.M_Menu.ResumeLayout(false);
            this.M_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip M_Menu;
        private System.Windows.Forms.ToolStripMenuItem M_Fenetre;
        private System.Windows.Forms.ToolStripMenuItem M_F_Liste;
        private System.Windows.Forms.ToolStripMenuItem M_F_Editeur;
        private System.Windows.Forms.ToolStripMenuItem M_Aide;
        private System.Windows.Forms.ToolStripMenuItem M_Quittez;
        private System.Windows.Forms.ToolStripMenuItem M_F_Horloge;
        private System.Windows.Forms.ToolStripMenuItem spirographeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mf_Graphique;
        private System.Windows.Forms.ToolStripMenuItem Mf_Carnaval;
        private System.Windows.Forms.ToolStripMenuItem Mf_Clavier_Souris;
        private System.Windows.Forms.ToolStripMenuItem MF_Explorateur;
        private System.Windows.Forms.ToolStripMenuItem M_F_BDD1;
        private System.Windows.Forms.ToolStripMenuItem M_F_BDD2;
        private System.Windows.Forms.ToolStripMenuItem M_F_BDD3;
        private System.Windows.Forms.ToolStripMenuItem MF_Philo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MesControles.BoutonColore boutonColore1;
        private MesControles.Frequence frequence1;
        private System.Windows.Forms.ToolStripMenuItem M_F_Exp;
        private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
    }
}