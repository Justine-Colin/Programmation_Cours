namespace PE_App1
{
    partial class Aide
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
            this.Btn_Confirmer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Confirmer
            // 
            this.Btn_Confirmer.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Confirmer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Confirmer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Btn_Confirmer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Btn_Confirmer.ForeColor = System.Drawing.Color.Blue;
            this.Btn_Confirmer.Location = new System.Drawing.Point(250, 341);
            this.Btn_Confirmer.Name = "Btn_Confirmer";
            this.Btn_Confirmer.Size = new System.Drawing.Size(135, 41);
            this.Btn_Confirmer.TabIndex = 0;
            this.Btn_Confirmer.Text = "Confirmer";
            this.Btn_Confirmer.UseVisualStyleBackColor = false;
            this.Btn_Confirmer.Click += new System.EventHandler(this.Btn_Confirmer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 324);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PE_App1.Properties.Resources.AC_Ecran;
            this.pictureBox1.Location = new System.Drawing.Point(17, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 127);
            this.label1.TabIndex = 2;
            this.label1.Text = "Premières Manipulations Version Alpha 1.0.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Copyright Jujuco1996";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 58);
            this.label2.TabIndex = 5;
            this.label2.Text = "Et l\'application se dit qu\'un jour elle deviendra aussi grande que .NET";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Aide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(643, 394);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Confirmer);
            this.Name = "Aide";
            this.Text = "Aide";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Confirmer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}