namespace PE_App1
{
    partial class Ecran_BDD2
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
            this.Lbl_Pre = new System.Windows.Forms.Label();
            this.TB_Pre = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.persoDataSet = new PE_App1.persoDataSet();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.Lbl_Nom = new System.Windows.Forms.Label();
            this.Lbl_Ne = new System.Windows.Forms.Label();
            this.DTP_Ne = new System.Windows.Forms.DateTimePicker();
            this.Btn_Prem = new System.Windows.Forms.Button();
            this.Btn_Suiv = new System.Windows.Forms.Button();
            this.Btn_Prec = new System.Windows.Forms.Button();
            this.Btn_Der = new System.Windows.Forms.Button();
            this.Lbl_Pos = new System.Windows.Forms.Label();
            this.Btn_Ajout = new System.Windows.Forms.Button();
            this.Btn_Suppr = new System.Windows.Forms.Button();
            this.Btn_Modif = new System.Windows.Forms.Button();
            this.Btn_Ann = new System.Windows.Forms.Button();
            this.Btn_Conf = new System.Windows.Forms.Button();
            this.clientTableAdapter = new PE_App1.persoDataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Pre
            // 
            this.Lbl_Pre.AutoSize = true;
            this.Lbl_Pre.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Pre.Name = "Lbl_Pre";
            this.Lbl_Pre.Size = new System.Drawing.Size(57, 17);
            this.Lbl_Pre.TabIndex = 0;
            this.Lbl_Pre.Text = "Prenom";
            // 
            // TB_Pre
            // 
            this.TB_Pre.BackColor = System.Drawing.Color.Goldenrod;
            this.TB_Pre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PRE", true));
            this.TB_Pre.Location = new System.Drawing.Point(12, 29);
            this.TB_Pre.Name = "TB_Pre";
            this.TB_Pre.Size = new System.Drawing.Size(324, 22);
            this.TB_Pre.TabIndex = 1;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.persoDataSet;
            // 
            // persoDataSet
            // 
            this.persoDataSet.DataSetName = "persoDataSet";
            this.persoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TB_Nom
            // 
            this.TB_Nom.BackColor = System.Drawing.Color.Goldenrod;
            this.TB_Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "NOM", true));
            this.TB_Nom.Location = new System.Drawing.Point(12, 79);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(324, 22);
            this.TB_Nom.TabIndex = 3;
            // 
            // Lbl_Nom
            // 
            this.Lbl_Nom.AutoSize = true;
            this.Lbl_Nom.Location = new System.Drawing.Point(12, 59);
            this.Lbl_Nom.Name = "Lbl_Nom";
            this.Lbl_Nom.Size = new System.Drawing.Size(37, 17);
            this.Lbl_Nom.TabIndex = 2;
            this.Lbl_Nom.Text = "Nom";
            // 
            // Lbl_Ne
            // 
            this.Lbl_Ne.AutoSize = true;
            this.Lbl_Ne.Location = new System.Drawing.Point(12, 115);
            this.Lbl_Ne.Name = "Lbl_Ne";
            this.Lbl_Ne.Size = new System.Drawing.Size(134, 17);
            this.Lbl_Ne.TabIndex = 4;
            this.Lbl_Ne.Text = "Date de naissance :";
            // 
            // DTP_Ne
            // 
            this.DTP_Ne.CalendarMonthBackground = System.Drawing.Color.Goldenrod;
            this.DTP_Ne.CalendarTitleBackColor = System.Drawing.Color.Goldenrod;
            this.DTP_Ne.Cursor = System.Windows.Forms.Cursors.Default;
            this.DTP_Ne.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientBindingSource, "NAI", true));
            this.DTP_Ne.Location = new System.Drawing.Point(12, 135);
            this.DTP_Ne.Name = "DTP_Ne";
            this.DTP_Ne.Size = new System.Drawing.Size(324, 22);
            this.DTP_Ne.TabIndex = 5;
            // 
            // Btn_Prem
            // 
            this.Btn_Prem.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Prem.Location = new System.Drawing.Point(15, 168);
            this.Btn_Prem.Name = "Btn_Prem";
            this.Btn_Prem.Size = new System.Drawing.Size(53, 60);
            this.Btn_Prem.TabIndex = 6;
            this.Btn_Prem.Text = "|<";
            this.Btn_Prem.UseVisualStyleBackColor = false;
            this.Btn_Prem.Click += new System.EventHandler(this.Btn_Prem_Click);
            // 
            // Btn_Suiv
            // 
            this.Btn_Suiv.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Suiv.Location = new System.Drawing.Point(224, 168);
            this.Btn_Suiv.Name = "Btn_Suiv";
            this.Btn_Suiv.Size = new System.Drawing.Size(53, 60);
            this.Btn_Suiv.TabIndex = 7;
            this.Btn_Suiv.Text = ">";
            this.Btn_Suiv.UseVisualStyleBackColor = false;
            this.Btn_Suiv.Click += new System.EventHandler(this.Btn_Suiv_Click);
            // 
            // Btn_Prec
            // 
            this.Btn_Prec.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Prec.Location = new System.Drawing.Point(74, 168);
            this.Btn_Prec.Name = "Btn_Prec";
            this.Btn_Prec.Size = new System.Drawing.Size(53, 60);
            this.Btn_Prec.TabIndex = 8;
            this.Btn_Prec.Text = "<";
            this.Btn_Prec.UseVisualStyleBackColor = false;
            this.Btn_Prec.Click += new System.EventHandler(this.Btn_Prec_Click);
            // 
            // Btn_Der
            // 
            this.Btn_Der.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Der.Location = new System.Drawing.Point(283, 168);
            this.Btn_Der.Name = "Btn_Der";
            this.Btn_Der.Size = new System.Drawing.Size(53, 60);
            this.Btn_Der.TabIndex = 9;
            this.Btn_Der.Text = ">|";
            this.Btn_Der.UseVisualStyleBackColor = false;
            this.Btn_Der.Click += new System.EventHandler(this.Btn_Der_Click);
            // 
            // Lbl_Pos
            // 
            this.Lbl_Pos.BackColor = System.Drawing.Color.Goldenrod;
            this.Lbl_Pos.Location = new System.Drawing.Point(133, 172);
            this.Lbl_Pos.Name = "Lbl_Pos";
            this.Lbl_Pos.Size = new System.Drawing.Size(81, 55);
            this.Lbl_Pos.TabIndex = 10;
            this.Lbl_Pos.Text = "p/n";
            this.Lbl_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Ajout
            // 
            this.Btn_Ajout.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Ajout.Location = new System.Drawing.Point(15, 234);
            this.Btn_Ajout.Name = "Btn_Ajout";
            this.Btn_Ajout.Size = new System.Drawing.Size(112, 39);
            this.Btn_Ajout.TabIndex = 11;
            this.Btn_Ajout.Text = "Ajouter";
            this.Btn_Ajout.UseVisualStyleBackColor = false;
            this.Btn_Ajout.Click += new System.EventHandler(this.Btn_Ajout_Click);
            // 
            // Btn_Suppr
            // 
            this.Btn_Suppr.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Suppr.Location = new System.Drawing.Point(225, 234);
            this.Btn_Suppr.Name = "Btn_Suppr";
            this.Btn_Suppr.Size = new System.Drawing.Size(112, 39);
            this.Btn_Suppr.TabIndex = 12;
            this.Btn_Suppr.Text = "Supprimer";
            this.Btn_Suppr.UseVisualStyleBackColor = false;
            this.Btn_Suppr.Click += new System.EventHandler(this.Btn_Suppr_Click);
            // 
            // Btn_Modif
            // 
            this.Btn_Modif.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Modif.Location = new System.Drawing.Point(133, 234);
            this.Btn_Modif.Name = "Btn_Modif";
            this.Btn_Modif.Size = new System.Drawing.Size(86, 39);
            this.Btn_Modif.TabIndex = 13;
            this.Btn_Modif.Text = "Modifier";
            this.Btn_Modif.UseVisualStyleBackColor = false;
            this.Btn_Modif.Click += new System.EventHandler(this.Btn_Modif_Click);
            // 
            // Btn_Ann
            // 
            this.Btn_Ann.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Ann.Location = new System.Drawing.Point(182, 279);
            this.Btn_Ann.Name = "Btn_Ann";
            this.Btn_Ann.Size = new System.Drawing.Size(112, 39);
            this.Btn_Ann.TabIndex = 14;
            this.Btn_Ann.Text = "Annuler";
            this.Btn_Ann.UseVisualStyleBackColor = false;
            this.Btn_Ann.Click += new System.EventHandler(this.Btn_Ann_Click);
            // 
            // Btn_Conf
            // 
            this.Btn_Conf.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Conf.Location = new System.Drawing.Point(64, 279);
            this.Btn_Conf.Name = "Btn_Conf";
            this.Btn_Conf.Size = new System.Drawing.Size(112, 39);
            this.Btn_Conf.TabIndex = 15;
            this.Btn_Conf.Text = "Confirmer";
            this.Btn_Conf.UseVisualStyleBackColor = false;
            this.Btn_Conf.Click += new System.EventHandler(this.Btn_Conf_Click);
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // Ecran_BDD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.Btn_Conf);
            this.Controls.Add(this.Btn_Ann);
            this.Controls.Add(this.Btn_Modif);
            this.Controls.Add(this.Btn_Suppr);
            this.Controls.Add(this.Btn_Ajout);
            this.Controls.Add(this.Lbl_Pos);
            this.Controls.Add(this.Btn_Der);
            this.Controls.Add(this.Btn_Prec);
            this.Controls.Add(this.Btn_Suiv);
            this.Controls.Add(this.Btn_Prem);
            this.Controls.Add(this.DTP_Ne);
            this.Controls.Add(this.Lbl_Ne);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.Lbl_Nom);
            this.Controls.Add(this.TB_Pre);
            this.Controls.Add(this.Lbl_Pre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Ecran_BDD2";
            this.Text = "1";
            this.Load += new System.EventHandler(this.Ecran_BDD2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Pre;
        private System.Windows.Forms.TextBox TB_Pre;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.Label Lbl_Nom;
        private System.Windows.Forms.Label Lbl_Ne;
        private System.Windows.Forms.DateTimePicker DTP_Ne;
        private System.Windows.Forms.Button Btn_Prem;
        private System.Windows.Forms.Button Btn_Suiv;
        private System.Windows.Forms.Button Btn_Prec;
        private System.Windows.Forms.Button Btn_Der;
        private System.Windows.Forms.Label Lbl_Pos;
        private System.Windows.Forms.Button Btn_Ajout;
        private System.Windows.Forms.Button Btn_Suppr;
        private System.Windows.Forms.Button Btn_Modif;
        private System.Windows.Forms.Button Btn_Ann;
        private System.Windows.Forms.Button Btn_Conf;
        private persoDataSet persoDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private persoDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
    }
}