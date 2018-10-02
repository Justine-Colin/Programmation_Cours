namespace PE_App1
{
    partial class Ecran_Clavier_Souris
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
            this.Lbl_Clavier = new System.Windows.Forms.Label();
            this.Btn_RAZ = new System.Windows.Forms.Button();
            this.Btn_Quitter = new System.Windows.Forms.Button();
            this.LB_Clavier = new System.Windows.Forms.ListBox();
            this.Lbl_Gauche = new System.Windows.Forms.Label();
            this.TB_Gauche = new System.Windows.Forms.TextBox();
            this.Pnl_Pos_Souris = new System.Windows.Forms.Panel();
            this.Lbl_PosY = new System.Windows.Forms.Label();
            this.Lbl_PosX = new System.Windows.Forms.Label();
            this.Lbl_Droite = new System.Windows.Forms.Label();
            this.TB_Droite = new System.Windows.Forms.TextBox();
            this.TB_PosX = new System.Windows.Forms.TextBox();
            this.TB_PosY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Clavier
            // 
            this.Lbl_Clavier.AutoSize = true;
            this.Lbl_Clavier.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Clavier.Name = "Lbl_Clavier";
            this.Lbl_Clavier.Size = new System.Drawing.Size(103, 17);
            this.Lbl_Clavier.TabIndex = 0;
            this.Lbl_Clavier.Text = "Suivi du clavier";
            // 
            // Btn_RAZ
            // 
            this.Btn_RAZ.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_RAZ.Location = new System.Drawing.Point(12, 237);
            this.Btn_RAZ.Name = "Btn_RAZ";
            this.Btn_RAZ.Size = new System.Drawing.Size(122, 32);
            this.Btn_RAZ.TabIndex = 1;
            this.Btn_RAZ.Text = "Remise à zéro";
            this.Btn_RAZ.UseVisualStyleBackColor = false;
            this.Btn_RAZ.Click += new System.EventHandler(this.Btn_RAZ_Click);
            // 
            // Btn_Quitter
            // 
            this.Btn_Quitter.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Quitter.Location = new System.Drawing.Point(140, 237);
            this.Btn_Quitter.Name = "Btn_Quitter";
            this.Btn_Quitter.Size = new System.Drawing.Size(75, 32);
            this.Btn_Quitter.TabIndex = 2;
            this.Btn_Quitter.Text = "Quitter";
            this.Btn_Quitter.UseVisualStyleBackColor = false;
            this.Btn_Quitter.Click += new System.EventHandler(this.Btn_Quitter_Click);
            // 
            // LB_Clavier
            // 
            this.LB_Clavier.BackColor = System.Drawing.Color.Goldenrod;
            this.LB_Clavier.FormattingEnabled = true;
            this.LB_Clavier.ItemHeight = 16;
            this.LB_Clavier.Location = new System.Drawing.Point(15, 29);
            this.LB_Clavier.Name = "LB_Clavier";
            this.LB_Clavier.Size = new System.Drawing.Size(199, 196);
            this.LB_Clavier.TabIndex = 3;
            // 
            // Lbl_Gauche
            // 
            this.Lbl_Gauche.AutoSize = true;
            this.Lbl_Gauche.Location = new System.Drawing.Point(226, 9);
            this.Lbl_Gauche.Name = "Lbl_Gauche";
            this.Lbl_Gauche.Size = new System.Drawing.Size(68, 17);
            this.Lbl_Gauche.TabIndex = 4;
            this.Lbl_Gauche.Text = "A gauche";
            // 
            // TB_Gauche
            // 
            this.TB_Gauche.BackColor = System.Drawing.Color.Goldenrod;
            this.TB_Gauche.Location = new System.Drawing.Point(224, 29);
            this.TB_Gauche.Name = "TB_Gauche";
            this.TB_Gauche.ReadOnly = true;
            this.TB_Gauche.Size = new System.Drawing.Size(76, 22);
            this.TB_Gauche.TabIndex = 5;
            this.TB_Gauche.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pnl_Pos_Souris
            // 
            this.Pnl_Pos_Souris.BackColor = System.Drawing.Color.Goldenrod;
            this.Pnl_Pos_Souris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Pos_Souris.Location = new System.Drawing.Point(224, 60);
            this.Pnl_Pos_Souris.Name = "Pnl_Pos_Souris";
            this.Pnl_Pos_Souris.Size = new System.Drawing.Size(399, 208);
            this.Pnl_Pos_Souris.TabIndex = 6;
            this.Pnl_Pos_Souris.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_Pos_Souris_MouseDown);
            this.Pnl_Pos_Souris.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pnl_Pos_Souris_MouseMove);
            // 
            // Lbl_PosY
            // 
            this.Lbl_PosY.AutoSize = true;
            this.Lbl_PosY.Location = new System.Drawing.Point(539, 9);
            this.Lbl_PosY.Name = "Lbl_PosY";
            this.Lbl_PosY.Size = new System.Drawing.Size(72, 17);
            this.Lbl_PosY.TabIndex = 10;
            this.Lbl_PosY.Text = "Ordonnée";
            // 
            // Lbl_PosX
            // 
            this.Lbl_PosX.AutoSize = true;
            this.Lbl_PosX.Location = new System.Drawing.Point(457, 9);
            this.Lbl_PosX.Name = "Lbl_PosX";
            this.Lbl_PosX.Size = new System.Drawing.Size(64, 17);
            this.Lbl_PosX.TabIndex = 11;
            this.Lbl_PosX.Text = "Abscisse";
            // 
            // Lbl_Droite
            // 
            this.Lbl_Droite.AutoSize = true;
            this.Lbl_Droite.Location = new System.Drawing.Point(303, 9);
            this.Lbl_Droite.Name = "Lbl_Droite";
            this.Lbl_Droite.Size = new System.Drawing.Size(57, 17);
            this.Lbl_Droite.TabIndex = 12;
            this.Lbl_Droite.Text = "A droite";
            // 
            // TB_Droite
            // 
            this.TB_Droite.BackColor = System.Drawing.Color.Goldenrod;
            this.TB_Droite.Location = new System.Drawing.Point(306, 29);
            this.TB_Droite.Name = "TB_Droite";
            this.TB_Droite.ReadOnly = true;
            this.TB_Droite.Size = new System.Drawing.Size(76, 22);
            this.TB_Droite.TabIndex = 13;
            this.TB_Droite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_PosX
            // 
            this.TB_PosX.BackColor = System.Drawing.Color.Goldenrod;
            this.TB_PosX.Location = new System.Drawing.Point(460, 29);
            this.TB_PosX.Name = "TB_PosX";
            this.TB_PosX.ReadOnly = true;
            this.TB_PosX.Size = new System.Drawing.Size(76, 22);
            this.TB_PosX.TabIndex = 14;
            this.TB_PosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TB_PosY
            // 
            this.TB_PosY.BackColor = System.Drawing.Color.Goldenrod;
            this.TB_PosY.Location = new System.Drawing.Point(542, 29);
            this.TB_PosY.Name = "TB_PosY";
            this.TB_PosY.ReadOnly = true;
            this.TB_PosY.Size = new System.Drawing.Size(76, 22);
            this.TB_PosY.TabIndex = 15;
            this.TB_PosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Ecran_Clavier_Souris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(630, 281);
            this.Controls.Add(this.TB_PosY);
            this.Controls.Add(this.TB_PosX);
            this.Controls.Add(this.TB_Droite);
            this.Controls.Add(this.Lbl_Droite);
            this.Controls.Add(this.Lbl_PosX);
            this.Controls.Add(this.Lbl_PosY);
            this.Controls.Add(this.Pnl_Pos_Souris);
            this.Controls.Add(this.TB_Gauche);
            this.Controls.Add(this.Lbl_Gauche);
            this.Controls.Add(this.LB_Clavier);
            this.Controls.Add(this.Btn_Quitter);
            this.Controls.Add(this.Btn_RAZ);
            this.Controls.Add(this.Lbl_Clavier);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ecran_Clavier_Souris";
            this.Text = "Suivi du clavier et de la souris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ecran_Clavier_Souris_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ecran_Clavier_Souris_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Ecran_Clavier_Souris_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Clavier;
        private System.Windows.Forms.Button Btn_RAZ;
        private System.Windows.Forms.Button Btn_Quitter;
        private System.Windows.Forms.ListBox LB_Clavier;
        private System.Windows.Forms.Label Lbl_Gauche;
        private System.Windows.Forms.TextBox TB_Gauche;
        private System.Windows.Forms.Panel Pnl_Pos_Souris;
        private System.Windows.Forms.Label Lbl_PosY;
        private System.Windows.Forms.Label Lbl_PosX;
        private System.Windows.Forms.Label Lbl_Droite;
        private System.Windows.Forms.TextBox TB_Droite;
        private System.Windows.Forms.TextBox TB_PosX;
        private System.Windows.Forms.TextBox TB_PosY;
    }
}