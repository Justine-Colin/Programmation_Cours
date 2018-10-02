namespace PE_App1
{
    partial class Ecran_Editeur
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
            this.M_Editeur = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MEF_Nouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.MEF_Ouvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.MEF_Sauver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MEF_Quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MEE_Couper = new System.Windows.Forms.ToolStripMenuItem();
            this.MEE_Copier = new System.Windows.Forms.ToolStripMenuItem();
            this.MEE_Coller = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MEF_Justifier = new System.Windows.Forms.ToolStripMenuItem();
            this.MEFJ_Gauche = new System.Windows.Forms.ToolStripMenuItem();
            this.MEFJ_Droite = new System.Windows.Forms.ToolStripMenuItem();
            this.MEFJ_Centre = new System.Windows.Forms.ToolStripMenuItem();
            this.MEF_Police = new System.Windows.Forms.ToolStripMenuItem();
            this.MEF_Caractere = new System.Windows.Forms.ToolStripMenuItem();
            this.MEFC_Gras = new System.Windows.Forms.ToolStripMenuItem();
            this.MEFC_Italique = new System.Windows.Forms.ToolStripMenuItem();
            this.MEFC_Souligne = new System.Windows.Forms.ToolStripMenuItem();
            this.MEFC_Barre = new System.Windows.Forms.ToolStripMenuItem();
            this.Dlg_Ouvrir_Fichier = new System.Windows.Forms.OpenFileDialog();
            this.Dlg_Sauver_Fichier = new System.Windows.Forms.SaveFileDialog();
            this.Dlg_Police = new System.Windows.Forms.FontDialog();
            this.P_Barre_Bouton = new System.Windows.Forms.Panel();
            this.Btn_Ouvrir = new System.Windows.Forms.Button();
            this.Btn_Sauver = new System.Windows.Forms.Button();
            this.Btn_Quitter = new System.Windows.Forms.Button();
            this.Btn_Nouveau = new System.Windows.Forms.Button();
            this.Rtb_Texte = new System.Windows.Forms.RichTextBox();
            this.M_Editeur.SuspendLayout();
            this.P_Barre_Bouton.SuspendLayout();
            this.SuspendLayout();
            // 
            // M_Editeur
            // 
            this.M_Editeur.BackColor = System.Drawing.Color.Goldenrod;
            this.M_Editeur.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.M_Editeur.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editerToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.M_Editeur.Location = new System.Drawing.Point(0, 0);
            this.M_Editeur.Name = "M_Editeur";
            this.M_Editeur.Size = new System.Drawing.Size(622, 28);
            this.M_Editeur.TabIndex = 0;
            this.M_Editeur.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MEF_Nouveau,
            this.MEF_Ouvrir,
            this.MEF_Sauver,
            this.toolStripMenuItem1,
            this.MEF_Quitter});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // MEF_Nouveau
            // 
            this.MEF_Nouveau.BackColor = System.Drawing.Color.Teal;
            this.MEF_Nouveau.Image = global::PE_App1.Properties.Resources.filenew;
            this.MEF_Nouveau.Name = "MEF_Nouveau";
            this.MEF_Nouveau.Size = new System.Drawing.Size(181, 26);
            this.MEF_Nouveau.Text = "Nouveau";
            this.MEF_Nouveau.Click += new System.EventHandler(this.MEF_Nouveau_Click);
            // 
            // MEF_Ouvrir
            // 
            this.MEF_Ouvrir.BackColor = System.Drawing.Color.Goldenrod;
            this.MEF_Ouvrir.Image = global::PE_App1.Properties.Resources.fileopen;
            this.MEF_Ouvrir.Name = "MEF_Ouvrir";
            this.MEF_Ouvrir.Size = new System.Drawing.Size(181, 26);
            this.MEF_Ouvrir.Text = "Ouvrir";
            this.MEF_Ouvrir.Click += new System.EventHandler(this.MEF_Ouvrir_Click);
            // 
            // MEF_Sauver
            // 
            this.MEF_Sauver.BackColor = System.Drawing.Color.Teal;
            this.MEF_Sauver.Image = global::PE_App1.Properties.Resources.filesave;
            this.MEF_Sauver.Name = "MEF_Sauver";
            this.MEF_Sauver.Size = new System.Drawing.Size(181, 26);
            this.MEF_Sauver.Text = "Sauver";
            this.MEF_Sauver.Click += new System.EventHandler(this.MEF_Sauver_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // MEF_Quitter
            // 
            this.MEF_Quitter.BackColor = System.Drawing.Color.Goldenrod;
            this.MEF_Quitter.Image = global::PE_App1.Properties.Resources.ICQuitter;
            this.MEF_Quitter.Name = "MEF_Quitter";
            this.MEF_Quitter.Size = new System.Drawing.Size(181, 26);
            this.MEF_Quitter.Text = "Quitter";
            this.MEF_Quitter.Click += new System.EventHandler(this.MEF_Quitter_Click);
            // 
            // editerToolStripMenuItem
            // 
            this.editerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MEE_Couper,
            this.MEE_Copier,
            this.MEE_Coller});
            this.editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            this.editerToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.editerToolStripMenuItem.Text = "Editer";
            // 
            // MEE_Couper
            // 
            this.MEE_Couper.BackColor = System.Drawing.Color.Teal;
            this.MEE_Couper.Image = global::PE_App1.Properties.Resources.cut;
            this.MEE_Couper.Name = "MEE_Couper";
            this.MEE_Couper.Size = new System.Drawing.Size(181, 26);
            this.MEE_Couper.Text = "Couper";
            this.MEE_Couper.Click += new System.EventHandler(this.MEE_Couper_Click);
            // 
            // MEE_Copier
            // 
            this.MEE_Copier.BackColor = System.Drawing.Color.Goldenrod;
            this.MEE_Copier.Name = "MEE_Copier";
            this.MEE_Copier.Size = new System.Drawing.Size(181, 26);
            this.MEE_Copier.Text = "Copier";
            this.MEE_Copier.Click += new System.EventHandler(this.MEE_Copier_Click);
            // 
            // MEE_Coller
            // 
            this.MEE_Coller.BackColor = System.Drawing.Color.Teal;
            this.MEE_Coller.Name = "MEE_Coller";
            this.MEE_Coller.Size = new System.Drawing.Size(181, 26);
            this.MEE_Coller.Text = "Coller";
            this.MEE_Coller.Click += new System.EventHandler(this.MEE_Coller_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MEF_Justifier,
            this.MEF_Police,
            this.MEF_Caractere});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // MEF_Justifier
            // 
            this.MEF_Justifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MEFJ_Gauche,
            this.MEFJ_Droite,
            this.MEFJ_Centre});
            this.MEF_Justifier.Name = "MEF_Justifier";
            this.MEF_Justifier.Size = new System.Drawing.Size(181, 26);
            this.MEF_Justifier.Text = "Justifier";
            // 
            // MEFJ_Gauche
            // 
            this.MEFJ_Gauche.Name = "MEFJ_Gauche";
            this.MEFJ_Gauche.Size = new System.Drawing.Size(133, 26);
            this.MEFJ_Gauche.Text = "Gauche";
            this.MEFJ_Gauche.Click += new System.EventHandler(this.MEFJ_Gauche_Click);
            // 
            // MEFJ_Droite
            // 
            this.MEFJ_Droite.Name = "MEFJ_Droite";
            this.MEFJ_Droite.Size = new System.Drawing.Size(133, 26);
            this.MEFJ_Droite.Text = "Droite";
            this.MEFJ_Droite.Click += new System.EventHandler(this.MEFJ_Droite_Click);
            // 
            // MEFJ_Centre
            // 
            this.MEFJ_Centre.Name = "MEFJ_Centre";
            this.MEFJ_Centre.Size = new System.Drawing.Size(133, 26);
            this.MEFJ_Centre.Text = "Centre";
            this.MEFJ_Centre.Click += new System.EventHandler(this.MEFJ_Centre_Click);
            // 
            // MEF_Police
            // 
            this.MEF_Police.Image = global::PE_App1.Properties.Resources.ICPolice;
            this.MEF_Police.Name = "MEF_Police";
            this.MEF_Police.Size = new System.Drawing.Size(181, 26);
            this.MEF_Police.Text = "Police";
            this.MEF_Police.Click += new System.EventHandler(this.MEF_Police_Click);
            // 
            // MEF_Caractere
            // 
            this.MEF_Caractere.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MEFC_Gras,
            this.MEFC_Italique,
            this.MEFC_Souligne,
            this.MEFC_Barre});
            this.MEF_Caractere.Name = "MEF_Caractere";
            this.MEF_Caractere.Size = new System.Drawing.Size(181, 26);
            this.MEF_Caractere.Text = "Caractère";
            // 
            // MEFC_Gras
            // 
            this.MEFC_Gras.Name = "MEFC_Gras";
            this.MEFC_Gras.Size = new System.Drawing.Size(142, 26);
            this.MEFC_Gras.Text = "Gras";
            this.MEFC_Gras.Click += new System.EventHandler(this.MEFC_Gras_Click);
            // 
            // MEFC_Italique
            // 
            this.MEFC_Italique.Name = "MEFC_Italique";
            this.MEFC_Italique.Size = new System.Drawing.Size(142, 26);
            this.MEFC_Italique.Text = "Italique";
            this.MEFC_Italique.Click += new System.EventHandler(this.MEFC_Italique_Click);
            // 
            // MEFC_Souligne
            // 
            this.MEFC_Souligne.Name = "MEFC_Souligne";
            this.MEFC_Souligne.Size = new System.Drawing.Size(142, 26);
            this.MEFC_Souligne.Text = "Souligné";
            this.MEFC_Souligne.Click += new System.EventHandler(this.MEFC_Souligne_Click);
            // 
            // MEFC_Barre
            // 
            this.MEFC_Barre.Name = "MEFC_Barre";
            this.MEFC_Barre.Size = new System.Drawing.Size(142, 26);
            this.MEFC_Barre.Text = "Barré";
            this.MEFC_Barre.Click += new System.EventHandler(this.MEFC_Barre_Click);
            // 
            // Dlg_Ouvrir_Fichier
            // 
            this.Dlg_Ouvrir_Fichier.FileName = "openFileDialog1";
            this.Dlg_Ouvrir_Fichier.Filter = "Nos fichiers (*.mesdocs)|*.mesdocs|Tous fichiers (*.*)|*.*";
            // 
            // P_Barre_Bouton
            // 
            this.P_Barre_Bouton.Controls.Add(this.Btn_Ouvrir);
            this.P_Barre_Bouton.Controls.Add(this.Btn_Sauver);
            this.P_Barre_Bouton.Controls.Add(this.Btn_Quitter);
            this.P_Barre_Bouton.Controls.Add(this.Btn_Nouveau);
            this.P_Barre_Bouton.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_Barre_Bouton.Location = new System.Drawing.Point(0, 28);
            this.P_Barre_Bouton.Name = "P_Barre_Bouton";
            this.P_Barre_Bouton.Size = new System.Drawing.Size(622, 45);
            this.P_Barre_Bouton.TabIndex = 1;
            // 
            // Btn_Ouvrir
            // 
            this.Btn_Ouvrir.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Ouvrir.BackgroundImage = global::PE_App1.Properties.Resources.ICOuvrir;
            this.Btn_Ouvrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Ouvrir.Location = new System.Drawing.Point(49, 3);
            this.Btn_Ouvrir.Name = "Btn_Ouvrir";
            this.Btn_Ouvrir.Size = new System.Drawing.Size(40, 40);
            this.Btn_Ouvrir.TabIndex = 3;
            this.Btn_Ouvrir.UseVisualStyleBackColor = false;
            this.Btn_Ouvrir.Click += new System.EventHandler(this.MEF_Ouvrir_Click);
            // 
            // Btn_Sauver
            // 
            this.Btn_Sauver.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Sauver.BackgroundImage = global::PE_App1.Properties.Resources.ICSauver;
            this.Btn_Sauver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Sauver.Location = new System.Drawing.Point(95, 3);
            this.Btn_Sauver.Name = "Btn_Sauver";
            this.Btn_Sauver.Size = new System.Drawing.Size(40, 40);
            this.Btn_Sauver.TabIndex = 2;
            this.Btn_Sauver.UseVisualStyleBackColor = false;
            this.Btn_Sauver.Click += new System.EventHandler(this.MEF_Sauver_Click);
            // 
            // Btn_Quitter
            // 
            this.Btn_Quitter.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Quitter.Image = global::PE_App1.Properties.Resources.ICQuitter;
            this.Btn_Quitter.Location = new System.Drawing.Point(141, 3);
            this.Btn_Quitter.Name = "Btn_Quitter";
            this.Btn_Quitter.Size = new System.Drawing.Size(40, 40);
            this.Btn_Quitter.TabIndex = 1;
            this.Btn_Quitter.UseVisualStyleBackColor = false;
            this.Btn_Quitter.Click += new System.EventHandler(this.MEF_Quitter_Click);
            // 
            // Btn_Nouveau
            // 
            this.Btn_Nouveau.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Nouveau.Image = global::PE_App1.Properties.Resources.filenew;
            this.Btn_Nouveau.Location = new System.Drawing.Point(3, 3);
            this.Btn_Nouveau.Name = "Btn_Nouveau";
            this.Btn_Nouveau.Size = new System.Drawing.Size(40, 40);
            this.Btn_Nouveau.TabIndex = 0;
            this.Btn_Nouveau.UseVisualStyleBackColor = false;
            this.Btn_Nouveau.Click += new System.EventHandler(this.MEF_Nouveau_Click);
            // 
            // Rtb_Texte
            // 
            this.Rtb_Texte.BackColor = System.Drawing.SystemColors.Window;
            this.Rtb_Texte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rtb_Texte.Location = new System.Drawing.Point(0, 73);
            this.Rtb_Texte.Name = "Rtb_Texte";
            this.Rtb_Texte.Size = new System.Drawing.Size(622, 269);
            this.Rtb_Texte.TabIndex = 2;
            this.Rtb_Texte.Text = "";
            this.Rtb_Texte.TextChanged += new System.EventHandler(this.Rtb_Texte_TextChanged);
            // 
            // Ecran_Editeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(622, 342);
            this.Controls.Add(this.Rtb_Texte);
            this.Controls.Add(this.P_Barre_Bouton);
            this.Controls.Add(this.M_Editeur);
            this.MainMenuStrip = this.M_Editeur;
            this.Name = "Ecran_Editeur";
            this.Text = "Traitement de texte... En toute modestie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ecran_Editeur_FormClosing);
            this.Shown += new System.EventHandler(this.Ecran_Editeur_Shown);
            this.M_Editeur.ResumeLayout(false);
            this.M_Editeur.PerformLayout();
            this.P_Barre_Bouton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip M_Editeur;
        private System.Windows.Forms.OpenFileDialog Dlg_Ouvrir_Fichier;
        private System.Windows.Forms.SaveFileDialog Dlg_Sauver_Fichier;
        private System.Windows.Forms.FontDialog Dlg_Police;
        private System.Windows.Forms.Panel P_Barre_Bouton;
        private System.Windows.Forms.RichTextBox Rtb_Texte;
        private System.Windows.Forms.Button Btn_Ouvrir;
        private System.Windows.Forms.Button Btn_Sauver;
        private System.Windows.Forms.Button Btn_Quitter;
        private System.Windows.Forms.Button Btn_Nouveau;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MEF_Nouveau;
        private System.Windows.Forms.ToolStripMenuItem MEF_Ouvrir;
        private System.Windows.Forms.ToolStripMenuItem MEF_Sauver;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MEF_Quitter;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MEE_Couper;
        private System.Windows.Forms.ToolStripMenuItem MEE_Copier;
        private System.Windows.Forms.ToolStripMenuItem MEE_Coller;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MEF_Justifier;
        private System.Windows.Forms.ToolStripMenuItem MEF_Police;
        private System.Windows.Forms.ToolStripMenuItem MEF_Caractere;
        private System.Windows.Forms.ToolStripMenuItem MEFJ_Gauche;
        private System.Windows.Forms.ToolStripMenuItem MEFJ_Droite;
        private System.Windows.Forms.ToolStripMenuItem MEFJ_Centre;
        private System.Windows.Forms.ToolStripMenuItem MEFC_Gras;
        private System.Windows.Forms.ToolStripMenuItem MEFC_Italique;
        private System.Windows.Forms.ToolStripMenuItem MEFC_Souligne;
        private System.Windows.Forms.ToolStripMenuItem MEFC_Barre;
    }
}