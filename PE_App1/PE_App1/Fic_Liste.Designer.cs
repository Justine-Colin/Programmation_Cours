namespace PE_App1
{
    partial class Ecran_Liste
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
            this.Lbl_Fichier = new System.Windows.Forms.Label();
            this.LB_personnes = new System.Windows.Forms.ListBox();
            this.Btn_Ouvrir = new System.Windows.Forms.Button();
            this.Btn_Enregistrer = new System.Windows.Forms.Button();
            this.Btn_Supprimer = new System.Windows.Forms.Button();
            this.Btn_Ajouter = new System.Windows.Forms.Button();
            this.GB_Details = new System.Windows.Forms.GroupBox();
            this.Btn_Annuler = new System.Windows.Forms.Button();
            this.Btn_Confirmer = new System.Windows.Forms.Button();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Qualite = new System.Windows.Forms.ComboBox();
            this.Dlg_Ouvrir = new System.Windows.Forms.OpenFileDialog();
            this.Dlg_Enregistrer = new System.Windows.Forms.SaveFileDialog();
            this.GB_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Fichier
            // 
            this.Lbl_Fichier.AutoSize = true;
            this.Lbl_Fichier.Location = new System.Drawing.Point(0, 3);
            this.Lbl_Fichier.Name = "Lbl_Fichier";
            this.Lbl_Fichier.Size = new System.Drawing.Size(99, 17);
            this.Lbl_Fichier.TabIndex = 0;
            this.Lbl_Fichier.Text = "Nom de fichier";
            // 
            // LB_personnes
            // 
            this.LB_personnes.BackColor = System.Drawing.Color.Goldenrod;
            this.LB_personnes.FormattingEnabled = true;
            this.LB_personnes.ItemHeight = 16;
            this.LB_personnes.Location = new System.Drawing.Point(3, 24);
            this.LB_personnes.Name = "LB_personnes";
            this.LB_personnes.Size = new System.Drawing.Size(403, 148);
            this.LB_personnes.Sorted = true;
            this.LB_personnes.TabIndex = 0;
            this.LB_personnes.DoubleClick += new System.EventHandler(this.LB_personnes_DoubleClick);
            // 
            // Btn_Ouvrir
            // 
            this.Btn_Ouvrir.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Ouvrir.Location = new System.Drawing.Point(12, 188);
            this.Btn_Ouvrir.Name = "Btn_Ouvrir";
            this.Btn_Ouvrir.Size = new System.Drawing.Size(120, 30);
            this.Btn_Ouvrir.TabIndex = 1;
            this.Btn_Ouvrir.Text = "Ouvrir";
            this.Btn_Ouvrir.UseVisualStyleBackColor = false;
            this.Btn_Ouvrir.Click += new System.EventHandler(this.Btn_Ouvrir_Click);
            // 
            // Btn_Enregistrer
            // 
            this.Btn_Enregistrer.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Enregistrer.Location = new System.Drawing.Point(12, 239);
            this.Btn_Enregistrer.Name = "Btn_Enregistrer";
            this.Btn_Enregistrer.Size = new System.Drawing.Size(120, 30);
            this.Btn_Enregistrer.TabIndex = 2;
            this.Btn_Enregistrer.Text = "Enregistrer";
            this.Btn_Enregistrer.UseVisualStyleBackColor = false;
            this.Btn_Enregistrer.Click += new System.EventHandler(this.Btn_Enregistrer_Click);
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Supprimer.Location = new System.Drawing.Point(12, 332);
            this.Btn_Supprimer.Name = "Btn_Supprimer";
            this.Btn_Supprimer.Size = new System.Drawing.Size(120, 30);
            this.Btn_Supprimer.TabIndex = 4;
            this.Btn_Supprimer.Text = "Supprimer";
            this.Btn_Supprimer.UseVisualStyleBackColor = false;
            this.Btn_Supprimer.Click += new System.EventHandler(this.Btn_Supprimer_Click);
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Ajouter.Location = new System.Drawing.Point(12, 286);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(120, 30);
            this.Btn_Ajouter.TabIndex = 3;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.UseVisualStyleBackColor = false;
            this.Btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // GB_Details
            // 
            this.GB_Details.Controls.Add(this.Btn_Annuler);
            this.GB_Details.Controls.Add(this.Btn_Confirmer);
            this.GB_Details.Controls.Add(this.TB_Nom);
            this.GB_Details.Controls.Add(this.label2);
            this.GB_Details.Controls.Add(this.CB_Qualite);
            this.GB_Details.Location = new System.Drawing.Point(149, 188);
            this.GB_Details.Name = "GB_Details";
            this.GB_Details.Size = new System.Drawing.Size(257, 177);
            this.GB_Details.TabIndex = 5;
            this.GB_Details.TabStop = false;
            this.GB_Details.Text = "Details Personne";
            // 
            // Btn_Annuler
            // 
            this.Btn_Annuler.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Annuler.Location = new System.Drawing.Point(144, 117);
            this.Btn_Annuler.Name = "Btn_Annuler";
            this.Btn_Annuler.Size = new System.Drawing.Size(107, 36);
            this.Btn_Annuler.TabIndex = 3;
            this.Btn_Annuler.Text = "Annuler";
            this.Btn_Annuler.UseVisualStyleBackColor = false;
            this.Btn_Annuler.Click += new System.EventHandler(this.Btn_Annuler_Click);
            // 
            // Btn_Confirmer
            // 
            this.Btn_Confirmer.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Confirmer.Location = new System.Drawing.Point(10, 117);
            this.Btn_Confirmer.Name = "Btn_Confirmer";
            this.Btn_Confirmer.Size = new System.Drawing.Size(107, 36);
            this.Btn_Confirmer.TabIndex = 2;
            this.Btn_Confirmer.Text = "Confirmer";
            this.Btn_Confirmer.UseVisualStyleBackColor = false;
            this.Btn_Confirmer.Click += new System.EventHandler(this.Btn_Confirmer_Click);
            // 
            // TB_Nom
            // 
            this.TB_Nom.BackColor = System.Drawing.Color.Goldenrod;
            this.TB_Nom.Location = new System.Drawing.Point(10, 72);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(241, 22);
            this.TB_Nom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // CB_Qualite
            // 
            this.CB_Qualite.BackColor = System.Drawing.Color.Goldenrod;
            this.CB_Qualite.FormattingEnabled = true;
            this.CB_Qualite.Items.AddRange(new object[] {
            "Madame",
            "Mademoiselle",
            "Monsieur",
            "Mondamoiseau",
            "Indeterminé"});
            this.CB_Qualite.Location = new System.Drawing.Point(10, 21);
            this.CB_Qualite.Name = "CB_Qualite";
            this.CB_Qualite.Size = new System.Drawing.Size(241, 24);
            this.CB_Qualite.TabIndex = 0;
            // 
            // Dlg_Ouvrir
            // 
            this.Dlg_Ouvrir.FileName = "openFileDialog1";
            // 
            // Ecran_Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(418, 377);
            this.Controls.Add(this.GB_Details);
            this.Controls.Add(this.Btn_Ajouter);
            this.Controls.Add(this.Btn_Supprimer);
            this.Controls.Add(this.Btn_Enregistrer);
            this.Controls.Add(this.Btn_Ouvrir);
            this.Controls.Add(this.LB_personnes);
            this.Controls.Add(this.Lbl_Fichier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ecran_Liste";
            this.Text = "1";
            this.GB_Details.ResumeLayout(false);
            this.GB_Details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Fichier;
        private System.Windows.Forms.ListBox LB_personnes;
        private System.Windows.Forms.Button Btn_Ouvrir;
        private System.Windows.Forms.Button Btn_Enregistrer;
        private System.Windows.Forms.Button Btn_Supprimer;
        private System.Windows.Forms.Button Btn_Ajouter;
        private System.Windows.Forms.GroupBox GB_Details;
        private System.Windows.Forms.Button Btn_Annuler;
        private System.Windows.Forms.Button Btn_Confirmer;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Qualite;
        private System.Windows.Forms.OpenFileDialog Dlg_Ouvrir;
        private System.Windows.Forms.SaveFileDialog Dlg_Enregistrer;
    }
}