namespace PE_App1
{
    partial class Ecran_Carnaval
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
            this.Btn_Texte = new System.Windows.Forms.Button();
            this.Btn_Geometrique = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Texte
            // 
            this.Btn_Texte.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Texte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Texte.Location = new System.Drawing.Point(10, 10);
            this.Btn_Texte.Name = "Btn_Texte";
            this.Btn_Texte.Size = new System.Drawing.Size(324, 48);
            this.Btn_Texte.TabIndex = 0;
            this.Btn_Texte.Text = " ";
            this.Btn_Texte.UseVisualStyleBackColor = false;
            this.Btn_Texte.Click += new System.EventHandler(this.Btn_Texte_Click);
            // 
            // Btn_Geometrique
            // 
            this.Btn_Geometrique.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Geometrique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Geometrique.Location = new System.Drawing.Point(10, 72);
            this.Btn_Geometrique.Name = "Btn_Geometrique";
            this.Btn_Geometrique.Size = new System.Drawing.Size(324, 48);
            this.Btn_Geometrique.TabIndex = 1;
            this.Btn_Geometrique.Text = " ";
            this.Btn_Geometrique.UseVisualStyleBackColor = false;
            this.Btn_Geometrique.Click += new System.EventHandler(this.Btn_Geometrique_Click);
            // 
            // Ecran_Carnaval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(342, 353);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Geometrique);
            this.Controls.Add(this.Btn_Texte);
            this.Name = "Ecran_Carnaval";
            this.Text = "C\'est la fête, c\'est la fête...";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Ecran_Carnaval_Paint);
            this.Resize += new System.EventHandler(this.Ecran_Carnaval_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Texte;
        private System.Windows.Forms.Button Btn_Geometrique;
    }
}