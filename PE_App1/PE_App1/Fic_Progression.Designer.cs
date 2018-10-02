namespace PE_App1
{
    partial class Ecran_Progression
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
            this.label1 = new System.Windows.Forms.Label();
            this.PrB_Secondaire = new System.Windows.Forms.ProgressBar();
            this.PrB_Principale = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Executer = new System.Windows.Forms.Button();
            this.Btn_Quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fichier (virtuel)";
            // 
            // PrB_Secondaire
            // 
            this.PrB_Secondaire.BackColor = System.Drawing.Color.DarkCyan;
            this.PrB_Secondaire.ForeColor = System.Drawing.Color.Goldenrod;
            this.PrB_Secondaire.Location = new System.Drawing.Point(12, 39);
            this.PrB_Secondaire.Name = "PrB_Secondaire";
            this.PrB_Secondaire.Size = new System.Drawing.Size(258, 54);
            this.PrB_Secondaire.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PrB_Secondaire.TabIndex = 2;
            // 
            // PrB_Principale
            // 
            this.PrB_Principale.BackColor = System.Drawing.Color.DarkCyan;
            this.PrB_Principale.ForeColor = System.Drawing.Color.Goldenrod;
            this.PrB_Principale.Location = new System.Drawing.Point(12, 126);
            this.PrB_Principale.Name = "PrB_Principale";
            this.PrB_Principale.Size = new System.Drawing.Size(258, 54);
            this.PrB_Principale.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PrB_Principale.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Copie (virtuel)";
            // 
            // Btn_Executer
            // 
            this.Btn_Executer.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Executer.ForeColor = System.Drawing.Color.Goldenrod;
            this.Btn_Executer.Location = new System.Drawing.Point(12, 209);
            this.Btn_Executer.Name = "Btn_Executer";
            this.Btn_Executer.Size = new System.Drawing.Size(113, 32);
            this.Btn_Executer.TabIndex = 5;
            this.Btn_Executer.Text = "Exécuter";
            this.Btn_Executer.UseVisualStyleBackColor = true;
            this.Btn_Executer.Click += new System.EventHandler(this.Btn_Executer_Click);
            // 
            // Btn_Quitter
            // 
            this.Btn_Quitter.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Quitter.ForeColor = System.Drawing.Color.Goldenrod;
            this.Btn_Quitter.Location = new System.Drawing.Point(157, 209);
            this.Btn_Quitter.Name = "Btn_Quitter";
            this.Btn_Quitter.Size = new System.Drawing.Size(113, 32);
            this.Btn_Quitter.TabIndex = 6;
            this.Btn_Quitter.Text = "Quitter";
            this.Btn_Quitter.UseVisualStyleBackColor = true;
            this.Btn_Quitter.Click += new System.EventHandler(this.Btn_Quitter_Click);
            // 
            // Ecran_Progression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(285, 256);
            this.Controls.Add(this.Btn_Quitter);
            this.Controls.Add(this.Btn_Executer);
            this.Controls.Add(this.PrB_Principale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrB_Secondaire);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ecran_Progression";
            this.Text = "Fic_Progression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar PrB_Secondaire;
        private System.Windows.Forms.ProgressBar PrB_Principale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Executer;
        private System.Windows.Forms.Button Btn_Quitter;
    }
}