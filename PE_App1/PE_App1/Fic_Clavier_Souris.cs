using System;
using System.Windows.Forms;

namespace PE_App1
{
    public partial class Ecran_Clavier_Souris : Form
    {
        int N_Gauche, N_Droit; // Nb click btn droit/gauche souris
        public Ecran_Clavier_Souris()
        {
            InitializeComponent();
            Btn_RAZ_Click(null, null); // /!\ si on joue avec le sender ou le e, ne surtout pas mettre null
        }

        private void Btn_RAZ_Click(object sender, EventArgs e) //Sender = bouton
        {
            N_Gauche = N_Droit = 0;
            TB_Gauche.Text = TB_Droite.Text = "0";
        }

        private void Pnl_Pos_Souris_MouseMove(object sender, MouseEventArgs e)
        {
            TB_PosX.Text = e.X.ToString();
            TB_PosY.Text = e.Y.ToString();
        }

        private void Pnl_Pos_Souris_MouseDown(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Left: //si appui btn gauche
                    N_Gauche++;
                    TB_Gauche.Text = N_Gauche.ToString();
                    break;
                case MouseButtons.Right: //si appui btn droit
                    N_Droit++;
                    TB_Droite.Text = N_Droit.ToString();
                    break;
            }                
        }

        private void Ecran_Clavier_Souris_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = "Touche pressée : " + e.KeyChar;
            LB_Clavier.Items.Insert(0, s);
        }

        // /!\ Pour que la fenêtre écoute le clavier, il faut mettre "KeyPreview" à "true" sur les propriétés de la fenêtre
        private void Ecran_Clavier_Souris_KeyDown(object sender, KeyEventArgs e)
        {
            string s = "Touche enfoncée : " + e.KeyCode + ", valeur : " + e.KeyValue;
            LB_Clavier.Items.Insert(0, s);
        }

        private void Ecran_Clavier_Souris_KeyUp(object sender, KeyEventArgs e)
        {
            string s = "Touche relachée : " + e.KeyCode + ", valeur : " + e.KeyValue;
            LB_Clavier.Items.Insert(0, s);
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
