namespace PE_App1
{
    partial class Ecran_Spirographe
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
            this.GB_Controle = new System.Windows.Forms.GroupBox();
            this.Btn_Trait = new System.Windows.Forms.Button();
            this.Btn_Fond = new System.Windows.Forms.Button();
            this.Btn_Go = new System.Windows.Forms.Button();
            this.TB_Profondeur = new System.Windows.Forms.TrackBar();
            this.Lbl_Profondeur = new System.Windows.Forms.Label();
            this.TB_Densite = new System.Windows.Forms.TrackBar();
            this.Lbl_Densite = new System.Windows.Forms.Label();
            this.TB_Nb_Sommets = new System.Windows.Forms.TrackBar();
            this.Lbl_Nb_Sommets = new System.Windows.Forms.Label();
            this.Dlg_Couleur = new System.Windows.Forms.ColorDialog();
            this.GB_Controle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Profondeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Densite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Nb_Sommets)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_Controle
            // 
            this.GB_Controle.Controls.Add(this.Btn_Trait);
            this.GB_Controle.Controls.Add(this.Btn_Fond);
            this.GB_Controle.Controls.Add(this.Btn_Go);
            this.GB_Controle.Controls.Add(this.TB_Profondeur);
            this.GB_Controle.Controls.Add(this.Lbl_Profondeur);
            this.GB_Controle.Controls.Add(this.TB_Densite);
            this.GB_Controle.Controls.Add(this.Lbl_Densite);
            this.GB_Controle.Controls.Add(this.TB_Nb_Sommets);
            this.GB_Controle.Controls.Add(this.Lbl_Nb_Sommets);
            this.GB_Controle.Dock = System.Windows.Forms.DockStyle.Left;
            this.GB_Controle.Location = new System.Drawing.Point(0, 0);
            this.GB_Controle.Name = "GB_Controle";
            this.GB_Controle.Size = new System.Drawing.Size(250, 337);
            this.GB_Controle.TabIndex = 0;
            this.GB_Controle.TabStop = false;
            this.GB_Controle.Text = "Controle";
            // 
            // Btn_Trait
            // 
            this.Btn_Trait.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Trait.Image = global::PE_App1.Properties.Resources.ICTrait;
            this.Btn_Trait.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Trait.Location = new System.Drawing.Point(6, 269);
            this.Btn_Trait.Name = "Btn_Trait";
            this.Btn_Trait.Size = new System.Drawing.Size(116, 40);
            this.Btn_Trait.TabIndex = 8;
            this.Btn_Trait.Text = "Trait";
            this.Btn_Trait.UseVisualStyleBackColor = false;
            this.Btn_Trait.Click += new System.EventHandler(this.Btn_Trait_Click);
            // 
            // Btn_Fond
            // 
            this.Btn_Fond.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Fond.Image = global::PE_App1.Properties.Resources.ICFond;
            this.Btn_Fond.Location = new System.Drawing.Point(128, 269);
            this.Btn_Fond.Name = "Btn_Fond";
            this.Btn_Fond.Size = new System.Drawing.Size(116, 40);
            this.Btn_Fond.TabIndex = 7;
            this.Btn_Fond.Text = "Fond";
            this.Btn_Fond.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Fond.UseVisualStyleBackColor = false;
            this.Btn_Fond.Click += new System.EventHandler(this.Btn_Fond_Click);
            // 
            // Btn_Go
            // 
            this.Btn_Go.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Go.Location = new System.Drawing.Point(6, 210);
            this.Btn_Go.Name = "Btn_Go";
            this.Btn_Go.Size = new System.Drawing.Size(238, 40);
            this.Btn_Go.TabIndex = 6;
            this.Btn_Go.Text = "Go";
            this.Btn_Go.UseVisualStyleBackColor = false;
            this.Btn_Go.Click += new System.EventHandler(this.Btn_Go_Click);
            // 
            // TB_Profondeur
            // 
            this.TB_Profondeur.Location = new System.Drawing.Point(6, 159);
            this.TB_Profondeur.Maximum = 80;
            this.TB_Profondeur.Minimum = 20;
            this.TB_Profondeur.Name = "TB_Profondeur";
            this.TB_Profondeur.Size = new System.Drawing.Size(238, 56);
            this.TB_Profondeur.TabIndex = 5;
            this.TB_Profondeur.TickFrequency = 5;
            this.TB_Profondeur.Value = 40;
            // 
            // Lbl_Profondeur
            // 
            this.Lbl_Profondeur.AutoSize = true;
            this.Lbl_Profondeur.Location = new System.Drawing.Point(3, 136);
            this.Lbl_Profondeur.Name = "Lbl_Profondeur";
            this.Lbl_Profondeur.Size = new System.Drawing.Size(214, 17);
            this.Lbl_Profondeur.TabIndex = 4;
            this.Lbl_Profondeur.Text = "Profondeur de dessin ( 20  à 80)";
            // 
            // TB_Densite
            // 
            this.TB_Densite.Location = new System.Drawing.Point(6, 97);
            this.TB_Densite.Maximum = 20;
            this.TB_Densite.Minimum = 5;
            this.TB_Densite.Name = "TB_Densite";
            this.TB_Densite.Size = new System.Drawing.Size(238, 56);
            this.TB_Densite.TabIndex = 3;
            this.TB_Densite.Value = 10;
            // 
            // Lbl_Densite
            // 
            this.Lbl_Densite.AutoSize = true;
            this.Lbl_Densite.Location = new System.Drawing.Point(3, 77);
            this.Lbl_Densite.Name = "Lbl_Densite";
            this.Lbl_Densite.Size = new System.Drawing.Size(175, 17);
            this.Lbl_Densite.TabIndex = 2;
            this.Lbl_Densite.Text = "Densité de dessin (5 à 20)";
            // 
            // TB_Nb_Sommets
            // 
            this.TB_Nb_Sommets.Location = new System.Drawing.Point(6, 38);
            this.TB_Nb_Sommets.Maximum = 8;
            this.TB_Nb_Sommets.Minimum = 3;
            this.TB_Nb_Sommets.Name = "TB_Nb_Sommets";
            this.TB_Nb_Sommets.Size = new System.Drawing.Size(238, 56);
            this.TB_Nb_Sommets.TabIndex = 1;
            this.TB_Nb_Sommets.Value = 5;
            // 
            // Lbl_Nb_Sommets
            // 
            this.Lbl_Nb_Sommets.AutoSize = true;
            this.Lbl_Nb_Sommets.Location = new System.Drawing.Point(6, 18);
            this.Lbl_Nb_Sommets.Name = "Lbl_Nb_Sommets";
            this.Lbl_Nb_Sommets.Size = new System.Drawing.Size(184, 17);
            this.Lbl_Nb_Sommets.TabIndex = 0;
            this.Lbl_Nb_Sommets.Text = "Nombre de sommets (3 à 8)";
            // 
            // Ecran_Spirographe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(590, 337);
            this.Controls.Add(this.GB_Controle);
            this.MinimumSize = new System.Drawing.Size(384, 384);
            this.Name = "Ecran_Spirographe";
            this.Text = "Fic_Spirographe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Ecran_Spirographe_Paint);
            this.GB_Controle.ResumeLayout(false);
            this.GB_Controle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Profondeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Densite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Nb_Sommets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Controle;
        private System.Windows.Forms.Button Btn_Trait;
        private System.Windows.Forms.Button Btn_Fond;
        private System.Windows.Forms.Button Btn_Go;
        private System.Windows.Forms.TrackBar TB_Profondeur;
        private System.Windows.Forms.Label Lbl_Profondeur;
        private System.Windows.Forms.TrackBar TB_Densite;
        private System.Windows.Forms.Label Lbl_Densite;
        private System.Windows.Forms.TrackBar TB_Nb_Sommets;
        private System.Windows.Forms.Label Lbl_Nb_Sommets;
        private System.Windows.Forms.ColorDialog Dlg_Couleur;
    }
}