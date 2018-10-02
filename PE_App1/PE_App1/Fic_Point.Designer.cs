namespace PE_App1
{
    partial class Ecran_Point
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
            this.Btn_Graph = new System.Windows.Forms.Button();
            this.Btn_Trait = new System.Windows.Forms.Button();
            this.Btn_Fond = new System.Windows.Forms.Button();
            this.Dlg_Couleur = new System.Windows.Forms.ColorDialog();
            this.Pnl_Point = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Btn_Graph
            // 
            this.Btn_Graph.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Graph.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Graph.Location = new System.Drawing.Point(0, 382);
            this.Btn_Graph.Name = "Btn_Graph";
            this.Btn_Graph.Size = new System.Drawing.Size(614, 30);
            this.Btn_Graph.TabIndex = 0;
            this.Btn_Graph.Text = "Générer le graphique";
            this.Btn_Graph.UseVisualStyleBackColor = false;
            this.Btn_Graph.Click += new System.EventHandler(this.Btn_Graph_Click);
            // 
            // Btn_Trait
            // 
            this.Btn_Trait.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Trait.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Trait.Location = new System.Drawing.Point(0, 352);
            this.Btn_Trait.Name = "Btn_Trait";
            this.Btn_Trait.Size = new System.Drawing.Size(614, 30);
            this.Btn_Trait.TabIndex = 2;
            this.Btn_Trait.Text = "Trait";
            this.Btn_Trait.UseVisualStyleBackColor = false;
            this.Btn_Trait.Click += new System.EventHandler(this.Btn_Trait_Click);
            // 
            // Btn_Fond
            // 
            this.Btn_Fond.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_Fond.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Fond.Location = new System.Drawing.Point(0, 322);
            this.Btn_Fond.Name = "Btn_Fond";
            this.Btn_Fond.Size = new System.Drawing.Size(614, 30);
            this.Btn_Fond.TabIndex = 3;
            this.Btn_Fond.Text = "Fond";
            this.Btn_Fond.UseVisualStyleBackColor = false;
            this.Btn_Fond.Click += new System.EventHandler(this.Btn_Fond_Click);
            // 
            // Pnl_Point
            // 
            this.Pnl_Point.BackColor = System.Drawing.Color.Gray;
            this.Pnl_Point.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pnl_Point.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Point.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Point.Name = "Pnl_Point";
            this.Pnl_Point.Size = new System.Drawing.Size(614, 322);
            this.Pnl_Point.TabIndex = 4;
            this.Pnl_Point.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Point_Paint);
            this.Pnl_Point.Resize += new System.EventHandler(this.Pnl_Point_Resize);
            // 
            // Ecran_Point
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(614, 412);
            this.Controls.Add(this.Pnl_Point);
            this.Controls.Add(this.Btn_Fond);
            this.Controls.Add(this.Btn_Trait);
            this.Controls.Add(this.Btn_Graph);
            this.Name = "Ecran_Point";
            this.Text = "Graphique";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Graph;
        private System.Windows.Forms.Button Btn_Trait;
        private System.Windows.Forms.Button Btn_Fond;
        private System.Windows.Forms.ColorDialog Dlg_Couleur;
        private System.Windows.Forms.Panel Pnl_Point;
    }
}