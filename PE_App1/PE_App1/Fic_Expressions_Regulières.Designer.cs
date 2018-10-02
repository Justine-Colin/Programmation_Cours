namespace PE_App1
{
    partial class Ecran_Expressions_Regulières
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ecran_Expressions_Regulières));
            this.Lbl_Expression = new System.Windows.Forms.Label();
            this.TB_Expression_Reguliere = new System.Windows.Forms.TextBox();
            this.CB_IsValide = new System.Windows.Forms.CheckBox();
            this.CB_IsCorresponding = new System.Windows.Forms.CheckBox();
            this.CB_CasseSensitive = new System.Windows.Forms.CheckBox();
            this.CB_Remplacer = new System.Windows.Forms.CheckBox();
            this.CB_Separer = new System.Windows.Forms.CheckBox();
            this.TB_Remplacement = new System.Windows.Forms.TextBox();
            this.Lbl_Remplacement = new System.Windows.Forms.Label();
            this.Lbl_ATraiter = new System.Windows.Forms.Label();
            this.RTB_ATRaiter = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Lbl_Expression
            // 
            this.Lbl_Expression.AutoSize = true;
            this.Lbl_Expression.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Expression.Name = "Lbl_Expression";
            this.Lbl_Expression.Size = new System.Drawing.Size(137, 17);
            this.Lbl_Expression.TabIndex = 0;
            this.Lbl_Expression.Text = "Expression régulière";
            // 
            // TB_Expression_Reguliere
            // 
            this.TB_Expression_Reguliere.BackColor = System.Drawing.Color.Goldenrod;
            this.TB_Expression_Reguliere.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Expression_Reguliere.Location = new System.Drawing.Point(12, 29);
            this.TB_Expression_Reguliere.Name = "TB_Expression_Reguliere";
            this.TB_Expression_Reguliere.Size = new System.Drawing.Size(776, 30);
            this.TB_Expression_Reguliere.TabIndex = 1;
            this.TB_Expression_Reguliere.TextChanged += new System.EventHandler(this.TB_Expression_Reguliere_TextChanged);
            // 
            // CB_IsValide
            // 
            this.CB_IsValide.AutoSize = true;
            this.CB_IsValide.BackColor = System.Drawing.Color.Teal;
            this.CB_IsValide.Enabled = false;
            this.CB_IsValide.Location = new System.Drawing.Point(15, 62);
            this.CB_IsValide.Name = "CB_IsValide";
            this.CB_IsValide.Size = new System.Drawing.Size(69, 21);
            this.CB_IsValide.TabIndex = 2;
            this.CB_IsValide.Text = "Valide";
            this.CB_IsValide.UseVisualStyleBackColor = false;
            // 
            // CB_IsCorresponding
            // 
            this.CB_IsCorresponding.AutoSize = true;
            this.CB_IsCorresponding.BackColor = System.Drawing.Color.Teal;
            this.CB_IsCorresponding.Enabled = false;
            this.CB_IsCorresponding.Location = new System.Drawing.Point(140, 62);
            this.CB_IsCorresponding.Name = "CB_IsCorresponding";
            this.CB_IsCorresponding.Size = new System.Drawing.Size(135, 21);
            this.CB_IsCorresponding.TabIndex = 3;
            this.CB_IsCorresponding.Text = "Correspondance";
            this.CB_IsCorresponding.UseVisualStyleBackColor = false;
            // 
            // CB_CasseSensitive
            // 
            this.CB_CasseSensitive.AutoSize = true;
            this.CB_CasseSensitive.BackColor = System.Drawing.Color.Teal;
            this.CB_CasseSensitive.Location = new System.Drawing.Point(296, 62);
            this.CB_CasseSensitive.Name = "CB_CasseSensitive";
            this.CB_CasseSensitive.Size = new System.Drawing.Size(158, 21);
            this.CB_CasseSensitive.TabIndex = 4;
            this.CB_CasseSensitive.Text = "Respect de la casse";
            this.CB_CasseSensitive.UseVisualStyleBackColor = false;
            this.CB_CasseSensitive.CheckedChanged += new System.EventHandler(this.CB_CasseSensitive_CheckedChanged);
            // 
            // CB_Remplacer
            // 
            this.CB_Remplacer.AutoSize = true;
            this.CB_Remplacer.BackColor = System.Drawing.Color.Teal;
            this.CB_Remplacer.Location = new System.Drawing.Point(15, 89);
            this.CB_Remplacer.Name = "CB_Remplacer";
            this.CB_Remplacer.Size = new System.Drawing.Size(98, 21);
            this.CB_Remplacer.TabIndex = 5;
            this.CB_Remplacer.Text = "Remplacer";
            this.CB_Remplacer.UseVisualStyleBackColor = false;
            this.CB_Remplacer.CheckedChanged += new System.EventHandler(this.CB_Remplacer_CheckedChanged);
            // 
            // CB_Separer
            // 
            this.CB_Separer.AutoSize = true;
            this.CB_Separer.BackColor = System.Drawing.Color.Teal;
            this.CB_Separer.Location = new System.Drawing.Point(140, 89);
            this.CB_Separer.Name = "CB_Separer";
            this.CB_Separer.Size = new System.Drawing.Size(81, 21);
            this.CB_Separer.TabIndex = 6;
            this.CB_Separer.Text = "Séparer";
            this.CB_Separer.UseVisualStyleBackColor = false;
            this.CB_Separer.CheckedChanged += new System.EventHandler(this.CB_Separer_CheckedChanged);
            // 
            // TB_Remplacement
            // 
            this.TB_Remplacement.BackColor = System.Drawing.Color.Goldenrod;
            this.TB_Remplacement.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Remplacement.Location = new System.Drawing.Point(12, 133);
            this.TB_Remplacement.Name = "TB_Remplacement";
            this.TB_Remplacement.Size = new System.Drawing.Size(776, 30);
            this.TB_Remplacement.TabIndex = 8;
            // 
            // Lbl_Remplacement
            // 
            this.Lbl_Remplacement.AutoSize = true;
            this.Lbl_Remplacement.Location = new System.Drawing.Point(12, 113);
            this.Lbl_Remplacement.Name = "Lbl_Remplacement";
            this.Lbl_Remplacement.Size = new System.Drawing.Size(156, 17);
            this.Lbl_Remplacement.TabIndex = 7;
            this.Lbl_Remplacement.Text = "Texte de remplacement";
            // 
            // Lbl_ATraiter
            // 
            this.Lbl_ATraiter.AutoSize = true;
            this.Lbl_ATraiter.Location = new System.Drawing.Point(9, 164);
            this.Lbl_ATraiter.Name = "Lbl_ATraiter";
            this.Lbl_ATraiter.Size = new System.Drawing.Size(96, 17);
            this.Lbl_ATraiter.TabIndex = 9;
            this.Lbl_ATraiter.Text = "Texte à traiter";
            // 
            // RTB_ATRaiter
            // 
            this.RTB_ATRaiter.BackColor = System.Drawing.Color.Goldenrod;
            this.RTB_ATRaiter.Location = new System.Drawing.Point(12, 184);
            this.RTB_ATRaiter.Name = "RTB_ATRaiter";
            this.RTB_ATRaiter.Size = new System.Drawing.Size(776, 254);
            this.RTB_ATRaiter.TabIndex = 10;
            this.RTB_ATRaiter.Text = resources.GetString("RTB_ATRaiter.Text");
            this.RTB_ATRaiter.TextChanged += new System.EventHandler(this.RTB_ATRaiter_TextChanged);
            // 
            // Ecran_Expressions_Regulières
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RTB_ATRaiter);
            this.Controls.Add(this.Lbl_ATraiter);
            this.Controls.Add(this.TB_Remplacement);
            this.Controls.Add(this.Lbl_Remplacement);
            this.Controls.Add(this.CB_Separer);
            this.Controls.Add(this.CB_Remplacer);
            this.Controls.Add(this.CB_CasseSensitive);
            this.Controls.Add(this.CB_IsCorresponding);
            this.Controls.Add(this.CB_IsValide);
            this.Controls.Add(this.TB_Expression_Reguliere);
            this.Controls.Add(this.Lbl_Expression);
            this.Name = "Ecran_Expressions_Regulières";
            this.Text = "Expressions régulières";
            this.Load += new System.EventHandler(this.Ecran_Expressions_Regulières_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Expression;
        private System.Windows.Forms.TextBox TB_Expression_Reguliere;
        private System.Windows.Forms.CheckBox CB_IsValide;
        private System.Windows.Forms.CheckBox CB_IsCorresponding;
        private System.Windows.Forms.CheckBox CB_CasseSensitive;
        private System.Windows.Forms.CheckBox CB_Remplacer;
        private System.Windows.Forms.CheckBox CB_Separer;
        private System.Windows.Forms.TextBox TB_Remplacement;
        private System.Windows.Forms.Label Lbl_Remplacement;
        private System.Windows.Forms.Label Lbl_ATraiter;
        private System.Windows.Forms.RichTextBox RTB_ATRaiter;
    }
}