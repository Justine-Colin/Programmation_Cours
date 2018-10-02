using System;
using System.Drawing;
using System.Windows.Forms;

namespace PE_App1
{
    public partial class Ecran_Editeur : Form
    {
        bool lModifie = false;
        string Nom_Fichier = "";
        public Ecran_Editeur()
        {
            InitializeComponent();
        }
        private void EnregistrerFichier()
        {
            if (Nom_Fichier == "")
                if (Dlg_Sauver_Fichier.ShowDialog() == DialogResult.OK)
                    Nom_Fichier = Dlg_Sauver_Fichier.FileName;
            if(Nom_Fichier != "")
            {
                Rtb_Texte.SaveFile(Nom_Fichier);
                lModifie = false;
            }
        }

        private void VerifierSauver()
        {
            if (lModifie)
                if (MessageBox.Show("Enregistrer les modifications ?", "Texte modifié", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    EnregistrerFichier();
        }

        private void MEF_Nouveau_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            Rtb_Texte.Clear();
            Nom_Fichier = "";
            lModifie = false;
            Rtb_Texte.Focus();
        }

        private void MEF_Ouvrir_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            if(Dlg_Ouvrir_Fichier.ShowDialog() == DialogResult.OK)
            {
                Nom_Fichier = Dlg_Ouvrir_Fichier.FileName;
                Rtb_Texte.LoadFile(Nom_Fichier);
            }
            lModifie = false;
        }

        private void MEF_Sauver_Click(object sender, EventArgs e)
        {
            VerifierSauver();
        }

        private void MEF_Quitter_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            Close();
        }

        private void Rtb_Texte_TextChanged(object sender, EventArgs e)
        {
            lModifie = true;
        }

        private void MEE_Couper_Click(object sender, EventArgs e)
        {
            Rtb_Texte.Cut();
        }

        private void MEE_Copier_Click(object sender, EventArgs e)
        {
            Rtb_Texte.Copy();
        }

        private void MEE_Coller_Click(object sender, EventArgs e)
        {
            Rtb_Texte.Paste();
        }

        private void MEFJ_Gauche_Click(object sender, EventArgs e)
        {
            Rtb_Texte.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void MEFJ_Droite_Click(object sender, EventArgs e)
        {
            Rtb_Texte.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void MEFJ_Centre_Click(object sender, EventArgs e)
        {
            Rtb_Texte.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void MEF_Police_Click(object sender, EventArgs e)
        {
            if (Dlg_Police.ShowDialog() == DialogResult.OK)
                Rtb_Texte.SelectionFont = new Font(Dlg_Police.Font, Dlg_Police.Font.Style);
        }

        private void MEFC_Gras_Click(object sender, EventArgs e)
        {
            System.Drawing.Font PoliceActuelle = Rtb_Texte.SelectionFont;
            System.Drawing.FontStyle NouvellePolice;
                NouvellePolice = PoliceActuelle.Style ^ FontStyle.Bold;
            Rtb_Texte.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, NouvellePolice);
        }

        private void MEFC_Italique_Click(object sender, EventArgs e)
        {
            System.Drawing.Font PoliceActuelle = Rtb_Texte.SelectionFont;
            System.Drawing.FontStyle NouvellePolice;
                NouvellePolice = PoliceActuelle.Style ^ FontStyle.Italic;
            Rtb_Texte.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, NouvellePolice);
        }

        private void MEFC_Souligne_Click(object sender, EventArgs e)
        {
            System.Drawing.Font PoliceActuelle = Rtb_Texte.SelectionFont;
            System.Drawing.FontStyle NouvellePolice;
                NouvellePolice = PoliceActuelle.Style ^ FontStyle.Underline;
            Rtb_Texte.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, NouvellePolice);
        }

        private void MEFC_Barre_Click(object sender, EventArgs e)
        {
            System.Drawing.Font PoliceActuelle = Rtb_Texte.SelectionFont;
            System.Drawing.FontStyle NouvellePolice;
                NouvellePolice = PoliceActuelle.Style ^ FontStyle.Strikeout;
            Rtb_Texte.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, NouvellePolice);
        }

        private void Ecran_Editeur_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerifierSauver();
        }

        private void Ecran_Editeur_Shown(object sender, EventArgs e)
        {
            Rtb_Texte.Focus();
        }
    }
}
