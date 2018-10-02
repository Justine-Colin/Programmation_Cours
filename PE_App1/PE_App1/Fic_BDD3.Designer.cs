namespace PE_App1
{
    partial class Ecran_BDD3
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
            this.Btn_Ajout = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Supp = new System.Windows.Forms.Button();
            this.Btn_Conf = new System.Windows.Forms.Button();
            this.Btn_Annu = new System.Windows.Forms.Button();
            this.DTP_Nai = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Nai = new System.Windows.Forms.Label();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.TB_Pre = new System.Windows.Forms.TextBox();
            this.Lbl_Pre = new System.Windows.Forms.Label();
            this.Lbl_Nom = new System.Windows.Forms.Label();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.DGV_Personne = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afficher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Personne)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Ajout
            // 
            this.Btn_Ajout.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Ajout.Location = new System.Drawing.Point(396, 12);
            this.Btn_Ajout.Name = "Btn_Ajout";
            this.Btn_Ajout.Size = new System.Drawing.Size(100, 30);
            this.Btn_Ajout.TabIndex = 0;
            this.Btn_Ajout.Text = "Ajouter";
            this.Btn_Ajout.UseVisualStyleBackColor = false;
            this.Btn_Ajout.Click += new System.EventHandler(this.Btn_Ajout_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Edit.Location = new System.Drawing.Point(396, 48);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(100, 30);
            this.Btn_Edit.TabIndex = 1;
            this.Btn_Edit.Text = "Editer";
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Supp
            // 
            this.Btn_Supp.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Supp.Location = new System.Drawing.Point(396, 84);
            this.Btn_Supp.Name = "Btn_Supp";
            this.Btn_Supp.Size = new System.Drawing.Size(100, 30);
            this.Btn_Supp.TabIndex = 2;
            this.Btn_Supp.Text = "Supprimer";
            this.Btn_Supp.UseVisualStyleBackColor = false;
            this.Btn_Supp.Click += new System.EventHandler(this.Btn_Supp_Click);
            // 
            // Btn_Conf
            // 
            this.Btn_Conf.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Conf.Location = new System.Drawing.Point(396, 372);
            this.Btn_Conf.Name = "Btn_Conf";
            this.Btn_Conf.Size = new System.Drawing.Size(100, 30);
            this.Btn_Conf.TabIndex = 3;
            this.Btn_Conf.Text = "Confirmer";
            this.Btn_Conf.UseVisualStyleBackColor = false;
            this.Btn_Conf.Click += new System.EventHandler(this.Btn_Conf_Click);
            // 
            // Btn_Annu
            // 
            this.Btn_Annu.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Annu.Location = new System.Drawing.Point(396, 408);
            this.Btn_Annu.Name = "Btn_Annu";
            this.Btn_Annu.Size = new System.Drawing.Size(100, 30);
            this.Btn_Annu.TabIndex = 4;
            this.Btn_Annu.Text = "Annuler";
            this.Btn_Annu.UseVisualStyleBackColor = false;
            this.Btn_Annu.Click += new System.EventHandler(this.Btn_Annu_Click);
            // 
            // DTP_Nai
            // 
            this.DTP_Nai.Location = new System.Drawing.Point(12, 408);
            this.DTP_Nai.Name = "DTP_Nai";
            this.DTP_Nai.Size = new System.Drawing.Size(370, 22);
            this.DTP_Nai.TabIndex = 5;
            // 
            // Lbl_Nai
            // 
            this.Lbl_Nai.AutoSize = true;
            this.Lbl_Nai.Location = new System.Drawing.Point(12, 388);
            this.Lbl_Nai.Name = "Lbl_Nai";
            this.Lbl_Nai.Size = new System.Drawing.Size(126, 17);
            this.Lbl_Nai.TabIndex = 6;
            this.Lbl_Nai.Text = "Date de naissance";
            // 
            // TB_Nom
            // 
            this.TB_Nom.BackColor = System.Drawing.Color.Goldenrod;
            this.TB_Nom.Location = new System.Drawing.Point(12, 318);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(370, 22);
            this.TB_Nom.TabIndex = 7;
            // 
            // TB_Pre
            // 
            this.TB_Pre.BackColor = System.Drawing.Color.Goldenrod;
            this.TB_Pre.Location = new System.Drawing.Point(12, 363);
            this.TB_Pre.Name = "TB_Pre";
            this.TB_Pre.Size = new System.Drawing.Size(370, 22);
            this.TB_Pre.TabIndex = 8;
            // 
            // Lbl_Pre
            // 
            this.Lbl_Pre.AutoSize = true;
            this.Lbl_Pre.Location = new System.Drawing.Point(9, 343);
            this.Lbl_Pre.Name = "Lbl_Pre";
            this.Lbl_Pre.Size = new System.Drawing.Size(57, 17);
            this.Lbl_Pre.TabIndex = 9;
            this.Lbl_Pre.Text = "Prenom";
            // 
            // Lbl_Nom
            // 
            this.Lbl_Nom.AutoSize = true;
            this.Lbl_Nom.Location = new System.Drawing.Point(9, 298);
            this.Lbl_Nom.Name = "Lbl_Nom";
            this.Lbl_Nom.Size = new System.Drawing.Size(37, 17);
            this.Lbl_Nom.TabIndex = 10;
            this.Lbl_Nom.Text = "Nom";
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Location = new System.Drawing.Point(9, 253);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(69, 17);
            this.Lbl_ID.TabIndex = 12;
            this.Lbl_ID.Text = "Identifiant";
            // 
            // TB_ID
            // 
            this.TB_ID.BackColor = System.Drawing.Color.Goldenrod;
            this.TB_ID.Location = new System.Drawing.Point(12, 273);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.ReadOnly = true;
            this.TB_ID.Size = new System.Drawing.Size(370, 22);
            this.TB_ID.TabIndex = 11;
            this.TB_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DGV_Personne
            // 
            this.DGV_Personne.AllowUserToAddRows = false;
            this.DGV_Personne.AllowUserToDeleteRows = false;
            this.DGV_Personne.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.DGV_Personne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Personne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Afficher});
            this.DGV_Personne.GridColor = System.Drawing.Color.Teal;
            this.DGV_Personne.Location = new System.Drawing.Point(12, 12);
            this.DGV_Personne.Name = "DGV_Personne";
            this.DGV_Personne.RowHeadersVisible = false;
            this.DGV_Personne.RowTemplate.Height = 24;
            this.DGV_Personne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Personne.Size = new System.Drawing.Size(365, 238);
            this.DGV_Personne.TabIndex = 13;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 400;
            // 
            // Afficher
            // 
            this.Afficher.DataPropertyName = "Afficher";
            this.Afficher.HeaderText = "Nom et prénom";
            this.Afficher.Name = "Afficher";
            this.Afficher.ReadOnly = true;
            this.Afficher.Width = 350;
            // 
            // Ecran_BDD3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.DGV_Personne);
            this.Controls.Add(this.Lbl_ID);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.Lbl_Nom);
            this.Controls.Add(this.Lbl_Pre);
            this.Controls.Add(this.TB_Pre);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.Lbl_Nai);
            this.Controls.Add(this.DTP_Nai);
            this.Controls.Add(this.Btn_Annu);
            this.Controls.Add(this.Btn_Conf);
            this.Controls.Add(this.Btn_Supp);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Ajout);
            this.Name = "Ecran_BDD3";
            this.Text = "Manipulation BD en couches";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Personne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Ajout;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Supp;
        private System.Windows.Forms.Button Btn_Conf;
        private System.Windows.Forms.Button Btn_Annu;
        private System.Windows.Forms.DateTimePicker DTP_Nai;
        private System.Windows.Forms.Label Lbl_Nai;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.TextBox TB_Pre;
        private System.Windows.Forms.Label Lbl_Pre;
        private System.Windows.Forms.Label Lbl_Nom;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.DataGridView DGV_Personne;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afficher;
    }
}