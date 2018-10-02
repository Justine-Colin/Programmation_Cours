namespace PE_App1
{
    partial class Ecran_BDD1
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
            this.LB_Contenu = new System.Windows.Forms.ListBox();
            this.BTN_Charger = new System.Windows.Forms.Button();
            this.TB_Prenom = new System.Windows.Forms.TextBox();
            this.BTN_Sauver = new System.Windows.Forms.Button();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.TB_Sup = new System.Windows.Forms.TextBox();
            this.Btn_Supprimer = new System.Windows.Forms.Button();
            this.Btn_Compter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Contenu
            // 
            this.LB_Contenu.BackColor = System.Drawing.Color.Goldenrod;
            this.LB_Contenu.FormattingEnabled = true;
            this.LB_Contenu.ItemHeight = 16;
            this.LB_Contenu.Location = new System.Drawing.Point(12, 12);
            this.LB_Contenu.Name = "LB_Contenu";
            this.LB_Contenu.Size = new System.Drawing.Size(776, 228);
            this.LB_Contenu.TabIndex = 0;
            // 
            // BTN_Charger
            // 
            this.BTN_Charger.BackColor = System.Drawing.Color.Goldenrod;
            this.BTN_Charger.Location = new System.Drawing.Point(12, 246);
            this.BTN_Charger.Name = "BTN_Charger";
            this.BTN_Charger.Size = new System.Drawing.Size(776, 40);
            this.BTN_Charger.TabIndex = 1;
            this.BTN_Charger.Text = "Charger";
            this.BTN_Charger.UseVisualStyleBackColor = false;
            this.BTN_Charger.Click += new System.EventHandler(this.BTN_Charger_Click);
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.BackColor = System.Drawing.Color.Goldenrod;
            this.TB_Prenom.Location = new System.Drawing.Point(12, 292);
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.Size = new System.Drawing.Size(490, 22);
            this.TB_Prenom.TabIndex = 2;
            // 
            // BTN_Sauver
            // 
            this.BTN_Sauver.BackColor = System.Drawing.Color.Goldenrod;
            this.BTN_Sauver.Location = new System.Drawing.Point(508, 292);
            this.BTN_Sauver.Name = "BTN_Sauver";
            this.BTN_Sauver.Size = new System.Drawing.Size(280, 50);
            this.BTN_Sauver.TabIndex = 4;
            this.BTN_Sauver.Text = "Sauver";
            this.BTN_Sauver.UseVisualStyleBackColor = false;
            this.BTN_Sauver.Click += new System.EventHandler(this.BTN_Sauver_Click);
            // 
            // TB_Nom
            // 
            this.TB_Nom.BackColor = System.Drawing.Color.Goldenrod;
            this.TB_Nom.Location = new System.Drawing.Point(12, 320);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(490, 22);
            this.TB_Nom.TabIndex = 5;
            // 
            // TB_Sup
            // 
            this.TB_Sup.BackColor = System.Drawing.Color.Goldenrod;
            this.TB_Sup.Location = new System.Drawing.Point(12, 368);
            this.TB_Sup.Name = "TB_Sup";
            this.TB_Sup.Size = new System.Drawing.Size(490, 22);
            this.TB_Sup.TabIndex = 7;
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Supprimer.Location = new System.Drawing.Point(508, 363);
            this.Btn_Supprimer.Name = "Btn_Supprimer";
            this.Btn_Supprimer.Size = new System.Drawing.Size(280, 32);
            this.Btn_Supprimer.TabIndex = 6;
            this.Btn_Supprimer.Text = "Supprimer";
            this.Btn_Supprimer.UseVisualStyleBackColor = false;
            this.Btn_Supprimer.Click += new System.EventHandler(this.Btn_Supprimer_Click);
            // 
            // Btn_Compter
            // 
            this.Btn_Compter.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Compter.Location = new System.Drawing.Point(12, 410);
            this.Btn_Compter.Name = "Btn_Compter";
            this.Btn_Compter.Size = new System.Drawing.Size(776, 40);
            this.Btn_Compter.TabIndex = 8;
            this.Btn_Compter.Text = "Compter";
            this.Btn_Compter.UseVisualStyleBackColor = false;
            this.Btn_Compter.Click += new System.EventHandler(this.Btn_Compter_Click);
            // 
            // Ecran_BDD1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.Btn_Compter);
            this.Controls.Add(this.TB_Sup);
            this.Controls.Add(this.Btn_Supprimer);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.BTN_Sauver);
            this.Controls.Add(this.TB_Prenom);
            this.Controls.Add(this.BTN_Charger);
            this.Controls.Add(this.LB_Contenu);
            this.Name = "Ecran_BDD1";
            this.Text = "Base de données \"CONSOLE\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Contenu;
        private System.Windows.Forms.Button BTN_Charger;
        private System.Windows.Forms.TextBox TB_Prenom;
        private System.Windows.Forms.Button BTN_Sauver;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.TextBox TB_Sup;
        private System.Windows.Forms.Button Btn_Supprimer;
        private System.Windows.Forms.Button Btn_Compter;
    }
}