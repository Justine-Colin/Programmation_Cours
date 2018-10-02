namespace PE_App1
{
    partial class Ecran_Explorateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ecran_Explorateur));
            this.TS_Commande = new System.Windows.Forms.ToolStrip();
            this.TS_Quitter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.TS_Petites_Icones = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Grandes_Icones = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Liste = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Detail = new System.Windows.Forms.ToolStripMenuItem();
            this.SS_Message = new System.Windows.Forms.StatusStrip();
            this.SL_Message = new System.Windows.Forms.ToolStripStatusLabel();
            this.IL_Vue_Arbre = new System.Windows.Forms.ImageList(this.components);
            this.IL_Vue_Petit = new System.Windows.Forms.ImageList(this.components);
            this.IL_Vue_Grand = new System.Windows.Forms.ImageList(this.components);
            this.TV_Repertoire = new System.Windows.Forms.TreeView();
            this.LV_Fichier = new System.Windows.Forms.ListView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Taille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Creation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TS_Commande.SuspendLayout();
            this.SS_Message.SuspendLayout();
            this.SuspendLayout();
            // 
            // TS_Commande
            // 
            this.TS_Commande.BackColor = System.Drawing.Color.Teal;
            this.TS_Commande.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS_Commande.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Quitter,
            this.toolStripSplitButton1});
            this.TS_Commande.Location = new System.Drawing.Point(0, 0);
            this.TS_Commande.Name = "TS_Commande";
            this.TS_Commande.Size = new System.Drawing.Size(1026, 27);
            this.TS_Commande.TabIndex = 0;
            this.TS_Commande.Text = "toolStrip1";
            // 
            // TS_Quitter
            // 
            this.TS_Quitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TS_Quitter.Image = global::PE_App1.Properties.Resources.doorshut;
            this.TS_Quitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Quitter.Name = "TS_Quitter";
            this.TS_Quitter.Size = new System.Drawing.Size(24, 24);
            this.TS_Quitter.Text = "toolStripButton1";
            this.TS_Quitter.Click += new System.EventHandler(this.TS_Quitter_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Petites_Icones,
            this.TS_Grandes_Icones,
            this.TS_Liste,
            this.TS_Detail});
            this.toolStripSplitButton1.Image = global::PE_App1.Properties.Resources.WETBApparence;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // TS_Petites_Icones
            // 
            this.TS_Petites_Icones.BackColor = System.Drawing.Color.Goldenrod;
            this.TS_Petites_Icones.Name = "TS_Petites_Icones";
            this.TS_Petites_Icones.Size = new System.Drawing.Size(216, 26);
            this.TS_Petites_Icones.Text = "Petites icônes";
            this.TS_Petites_Icones.Click += new System.EventHandler(this.TS_Petites_Icones_Click);
            // 
            // TS_Grandes_Icones
            // 
            this.TS_Grandes_Icones.BackColor = System.Drawing.Color.Teal;
            this.TS_Grandes_Icones.Name = "TS_Grandes_Icones";
            this.TS_Grandes_Icones.Size = new System.Drawing.Size(216, 26);
            this.TS_Grandes_Icones.Text = "Grandes icônes";
            this.TS_Grandes_Icones.Click += new System.EventHandler(this.TS_Grandes_Icones_Click);
            // 
            // TS_Liste
            // 
            this.TS_Liste.BackColor = System.Drawing.Color.Goldenrod;
            this.TS_Liste.Name = "TS_Liste";
            this.TS_Liste.Size = new System.Drawing.Size(216, 26);
            this.TS_Liste.Text = "Liste";
            this.TS_Liste.Click += new System.EventHandler(this.TS_Liste_Click);
            // 
            // TS_Detail
            // 
            this.TS_Detail.BackColor = System.Drawing.Color.Teal;
            this.TS_Detail.Name = "TS_Detail";
            this.TS_Detail.Size = new System.Drawing.Size(216, 26);
            this.TS_Detail.Text = "Détail";
            this.TS_Detail.Click += new System.EventHandler(this.TS_Detail_Click);
            // 
            // SS_Message
            // 
            this.SS_Message.BackColor = System.Drawing.Color.Teal;
            this.SS_Message.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SS_Message.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SL_Message});
            this.SS_Message.Location = new System.Drawing.Point(0, 367);
            this.SS_Message.Name = "SS_Message";
            this.SS_Message.Size = new System.Drawing.Size(1026, 25);
            this.SS_Message.TabIndex = 1;
            this.SS_Message.Text = "statusStrip1";
            // 
            // SL_Message
            // 
            this.SL_Message.Name = "SL_Message";
            this.SL_Message.Size = new System.Drawing.Size(54, 20);
            this.SL_Message.Text = "#####";
            // 
            // IL_Vue_Arbre
            // 
            this.IL_Vue_Arbre.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IL_Vue_Arbre.ImageStream")));
            this.IL_Vue_Arbre.TransparentColor = System.Drawing.Color.Transparent;
            this.IL_Vue_Arbre.Images.SetKeyName(0, "WEOrdi.bmp");
            this.IL_Vue_Arbre.Images.SetKeyName(1, "WEFloppy.bmp");
            this.IL_Vue_Arbre.Images.SetKeyName(2, "WERepertoire.bmp");
            this.IL_Vue_Arbre.Images.SetKeyName(3, "WERepertoireActif.bmp");
            this.IL_Vue_Arbre.Images.SetKeyName(4, "WEPoubelle.bmp");
            // 
            // IL_Vue_Petit
            // 
            this.IL_Vue_Petit.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IL_Vue_Petit.ImageStream")));
            this.IL_Vue_Petit.TransparentColor = System.Drawing.Color.Transparent;
            this.IL_Vue_Petit.Images.SetKeyName(0, "WELVPetiteIcone.bmp");
            // 
            // IL_Vue_Grand
            // 
            this.IL_Vue_Grand.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IL_Vue_Grand.ImageStream")));
            this.IL_Vue_Grand.TransparentColor = System.Drawing.Color.Transparent;
            this.IL_Vue_Grand.Images.SetKeyName(0, "WELVGrandeIcone.bmp");
            // 
            // TV_Repertoire
            // 
            this.TV_Repertoire.BackColor = System.Drawing.Color.Goldenrod;
            this.TV_Repertoire.Dock = System.Windows.Forms.DockStyle.Left;
            this.TV_Repertoire.ImageIndex = 0;
            this.TV_Repertoire.ImageList = this.IL_Vue_Arbre;
            this.TV_Repertoire.Location = new System.Drawing.Point(0, 27);
            this.TV_Repertoire.Name = "TV_Repertoire";
            this.TV_Repertoire.SelectedImageIndex = 0;
            this.TV_Repertoire.Size = new System.Drawing.Size(233, 340);
            this.TV_Repertoire.TabIndex = 2;
            this.TV_Repertoire.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TV_Repertoire_AfterSelect);
            // 
            // LV_Fichier
            // 
            this.LV_Fichier.BackColor = System.Drawing.Color.Goldenrod;
            this.LV_Fichier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Taille,
            this.Creation,
            this.Modification});
            this.LV_Fichier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_Fichier.LargeImageList = this.IL_Vue_Grand;
            this.LV_Fichier.Location = new System.Drawing.Point(233, 27);
            this.LV_Fichier.Name = "LV_Fichier";
            this.LV_Fichier.Size = new System.Drawing.Size(793, 340);
            this.LV_Fichier.SmallImageList = this.IL_Vue_Petit;
            this.LV_Fichier.TabIndex = 3;
            this.LV_Fichier.UseCompatibleStateImageBehavior = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(233, 27);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 340);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            // 
            // Taille
            // 
            this.Taille.Text = "Taille";
            // 
            // Creation
            // 
            this.Creation.Text = "Création";
            // 
            // Modification
            // 
            this.Modification.Text = "Modification";
            // 
            // Ecran_Explorateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1026, 392);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.LV_Fichier);
            this.Controls.Add(this.TV_Repertoire);
            this.Controls.Add(this.SS_Message);
            this.Controls.Add(this.TS_Commande);
            this.Name = "Ecran_Explorateur";
            this.Text = "Explorateur de fichiers";
            this.TS_Commande.ResumeLayout(false);
            this.TS_Commande.PerformLayout();
            this.SS_Message.ResumeLayout(false);
            this.SS_Message.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TS_Commande;
        private System.Windows.Forms.StatusStrip SS_Message;
        private System.Windows.Forms.ImageList IL_Vue_Arbre;
        private System.Windows.Forms.ImageList IL_Vue_Petit;
        private System.Windows.Forms.ImageList IL_Vue_Grand;
        private System.Windows.Forms.ToolStripButton TS_Quitter;
        private System.Windows.Forms.TreeView TV_Repertoire;
        private System.Windows.Forms.ListView LV_Fichier;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem TS_Petites_Icones;
        private System.Windows.Forms.ToolStripMenuItem TS_Grandes_Icones;
        private System.Windows.Forms.ToolStripMenuItem TS_Liste;
        private System.Windows.Forms.ToolStripMenuItem TS_Detail;
        private System.Windows.Forms.ToolStripStatusLabel SL_Message;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Taille;
        private System.Windows.Forms.ColumnHeader Creation;
        private System.Windows.Forms.ColumnHeader Modification;
    }
}