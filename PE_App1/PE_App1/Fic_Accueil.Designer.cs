namespace PE_App1
{
    partial class Ecran_Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Pousser = new System.Windows.Forms.Button();
            this.Btn_Entrer = new System.Windows.Forms.Button();
            this.LblTitre = new System.Windows.Forms.Label();
            this.PB_Image_Depart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image_Depart)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Pousser
            // 
            this.Btn_Pousser.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Pousser.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pousser.Location = new System.Drawing.Point(12, 212);
            this.Btn_Pousser.Name = "Btn_Pousser";
            this.Btn_Pousser.Size = new System.Drawing.Size(120, 40);
            this.Btn_Pousser.TabIndex = 0;
            this.Btn_Pousser.Text = "Poussez";
            this.Btn_Pousser.UseVisualStyleBackColor = false;
            this.Btn_Pousser.Click += new System.EventHandler(this.Btn_Pousser_Click);
            // 
            // Btn_Entrer
            // 
            this.Btn_Entrer.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Entrer.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Entrer.Location = new System.Drawing.Point(168, 212);
            this.Btn_Entrer.Name = "Btn_Entrer";
            this.Btn_Entrer.Size = new System.Drawing.Size(120, 40);
            this.Btn_Entrer.TabIndex = 1;
            this.Btn_Entrer.Text = "Entrez";
            this.Btn_Entrer.UseVisualStyleBackColor = false;
            this.Btn_Entrer.Click += new System.EventHandler(this.Btn_Entrer_Click);
            // 
            // LblTitre
            // 
            this.LblTitre.AutoSize = true;
            this.LblTitre.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitre.Location = new System.Drawing.Point(19, 9);
            this.LblTitre.Name = "LblTitre";
            this.LblTitre.Size = new System.Drawing.Size(263, 46);
            this.LblTitre.TabIndex = 2;
            this.LblTitre.Text = "Découverte de C#";
            // 
            // PB_Image_Depart
            // 
            this.PB_Image_Depart.Image = global::PE_App1.Properties.Resources.Assassins_Creed_Origins;
            this.PB_Image_Depart.Location = new System.Drawing.Point(12, 58);
            this.PB_Image_Depart.Name = "PB_Image_Depart";
            this.PB_Image_Depart.Size = new System.Drawing.Size(276, 147);
            this.PB_Image_Depart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Image_Depart.TabIndex = 3;
            this.PB_Image_Depart.TabStop = false;
            // 
            // Ecran_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(300, 264);
            this.Controls.Add(this.PB_Image_Depart);
            this.Controls.Add(this.LblTitre);
            this.Controls.Add(this.Btn_Entrer);
            this.Controls.Add(this.Btn_Pousser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ecran_Accueil";
            this.Text = "Bienvenue, welcome, ...";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image_Depart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Pousser;
        private System.Windows.Forms.Button Btn_Entrer;
        private System.Windows.Forms.Label LblTitre;
        private System.Windows.Forms.PictureBox PB_Image_Depart;
    }
}

