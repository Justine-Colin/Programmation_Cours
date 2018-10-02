namespace PE_App1
{
    partial class Ecran_Horloge
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
            this.Chronometre = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Chronometre
            // 
            this.Chronometre.Interval = 1000;
            this.Chronometre.Tick += new System.EventHandler(this.Chronometre_Tick);
            // 
            // Ecran_Horloge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(486, 411);
            this.Name = "Ecran_Horloge";
            this.Text = "Fic_Horloge";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Ecran_Horloge_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Chronometre;
    }
}