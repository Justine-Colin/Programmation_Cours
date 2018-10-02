namespace PE_App1
{
    partial class Ecran_Integrale
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
            this.LB_Resultat = new System.Windows.Forms.ListBox();
            this.Btn_Polynome = new System.Windows.Forms.Button();
            this.Btn_Cosinus = new System.Windows.Forms.Button();
            this.Lbl_Gauche = new System.Windows.Forms.Label();
            this.Tb_Gauche = new System.Windows.Forms.TextBox();
            this.TB_Intervalle = new System.Windows.Forms.TextBox();
            this.Lbl_Intervalle = new System.Windows.Forms.Label();
            this.TB_Droite = new System.Windows.Forms.TextBox();
            this.Lbl_Droite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_Resultat
            // 
            this.LB_Resultat.FormattingEnabled = true;
            this.LB_Resultat.ItemHeight = 16;
            this.LB_Resultat.Location = new System.Drawing.Point(12, 57);
            this.LB_Resultat.Name = "LB_Resultat";
            this.LB_Resultat.Size = new System.Drawing.Size(393, 260);
            this.LB_Resultat.TabIndex = 0;
            // 
            // Btn_Polynome
            // 
            this.Btn_Polynome.Location = new System.Drawing.Point(12, 323);
            this.Btn_Polynome.Name = "Btn_Polynome";
            this.Btn_Polynome.Size = new System.Drawing.Size(393, 38);
            this.Btn_Polynome.TabIndex = 1;
            this.Btn_Polynome.Text = "Polynôme";
            this.Btn_Polynome.UseVisualStyleBackColor = true;
            this.Btn_Polynome.Click += new System.EventHandler(this.Btn_Polynome_Click);
            // 
            // Btn_Cosinus
            // 
            this.Btn_Cosinus.Location = new System.Drawing.Point(13, 367);
            this.Btn_Cosinus.Name = "Btn_Cosinus";
            this.Btn_Cosinus.Size = new System.Drawing.Size(392, 39);
            this.Btn_Cosinus.TabIndex = 2;
            this.Btn_Cosinus.Text = "Cosinus";
            this.Btn_Cosinus.UseVisualStyleBackColor = true;
            this.Btn_Cosinus.Click += new System.EventHandler(this.Btn_Cosinus_Click);
            // 
            // Lbl_Gauche
            // 
            this.Lbl_Gauche.AutoSize = true;
            this.Lbl_Gauche.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Gauche.Name = "Lbl_Gauche";
            this.Lbl_Gauche.Size = new System.Drawing.Size(58, 17);
            this.Lbl_Gauche.TabIndex = 3;
            this.Lbl_Gauche.Text = "Gauche";
            // 
            // Tb_Gauche
            // 
            this.Tb_Gauche.Location = new System.Drawing.Point(13, 29);
            this.Tb_Gauche.Name = "Tb_Gauche";
            this.Tb_Gauche.Size = new System.Drawing.Size(100, 22);
            this.Tb_Gauche.TabIndex = 4;
            this.Tb_Gauche.Text = "0";
            // 
            // TB_Intervalle
            // 
            this.TB_Intervalle.Location = new System.Drawing.Point(305, 29);
            this.TB_Intervalle.Name = "TB_Intervalle";
            this.TB_Intervalle.Size = new System.Drawing.Size(100, 22);
            this.TB_Intervalle.TabIndex = 6;
            this.TB_Intervalle.Text = "2";
            // 
            // Lbl_Intervalle
            // 
            this.Lbl_Intervalle.AutoSize = true;
            this.Lbl_Intervalle.Location = new System.Drawing.Point(302, 9);
            this.Lbl_Intervalle.Name = "Lbl_Intervalle";
            this.Lbl_Intervalle.Size = new System.Drawing.Size(65, 17);
            this.Lbl_Intervalle.TabIndex = 5;
            this.Lbl_Intervalle.Text = "Intervalle";
            // 
            // TB_Droite
            // 
            this.TB_Droite.Location = new System.Drawing.Point(160, 29);
            this.TB_Droite.Name = "TB_Droite";
            this.TB_Droite.Size = new System.Drawing.Size(100, 22);
            this.TB_Droite.TabIndex = 8;
            this.TB_Droite.Text = "2";
            // 
            // Lbl_Droite
            // 
            this.Lbl_Droite.AutoSize = true;
            this.Lbl_Droite.Location = new System.Drawing.Point(157, 9);
            this.Lbl_Droite.Name = "Lbl_Droite";
            this.Lbl_Droite.Size = new System.Drawing.Size(46, 17);
            this.Lbl_Droite.TabIndex = 7;
            this.Lbl_Droite.Text = "Droite";
            // 
            // Ecran_Integrale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 422);
            this.Controls.Add(this.TB_Droite);
            this.Controls.Add(this.Lbl_Droite);
            this.Controls.Add(this.TB_Intervalle);
            this.Controls.Add(this.Lbl_Intervalle);
            this.Controls.Add(this.Tb_Gauche);
            this.Controls.Add(this.Lbl_Gauche);
            this.Controls.Add(this.Btn_Cosinus);
            this.Controls.Add(this.Btn_Polynome);
            this.Controls.Add(this.LB_Resultat);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ecran_Integrale";
            this.Text = "Calcul d\'intégrale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Resultat;
        private System.Windows.Forms.Button Btn_Polynome;
        private System.Windows.Forms.Button Btn_Cosinus;
        private System.Windows.Forms.Label Lbl_Gauche;
        private System.Windows.Forms.TextBox Tb_Gauche;
        private System.Windows.Forms.TextBox TB_Intervalle;
        private System.Windows.Forms.Label Lbl_Intervalle;
        private System.Windows.Forms.TextBox TB_Droite;
        private System.Windows.Forms.Label Lbl_Droite;
    }
}