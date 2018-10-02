using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_App1
{
    public partial class Ecran_Principal : Form
    {
        public Ecran_Principal()
        {
            InitializeComponent();
        }

        private void M_Quittez_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void M_NonDefini_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité non implémentée"); //Pop up
        }

        private void Ecran_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Souhaitez-vous réellement quitter ?", "Votre souhait", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //Pop up avec boutons oui/non
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void M_Aide_Click(object sender, EventArgs e)
        {
            Aide Help = new Aide();
            Help.Show();
        }

        private void M_F_Progression_Click(object sender, EventArgs e)
        {
            Ecran_Progression f = new Ecran_Progression();
            f.ShowDialog();
        }

        private void M_F_Liste_Click(object sender, EventArgs e)
        {
            Ecran_Liste f = new Ecran_Liste();
            f.Show();
        }

        private void M_F_Editeur_Click(object sender, EventArgs e)
        {
            Ecran_Editeur f = new Ecran_Editeur();
            f.ShowDialog();
        }

        private void M_F_Horloge_Click(object sender, EventArgs e)
        {
            Ecran_Horloge f = new Ecran_Horloge();
            f.ShowDialog();
        }

        private void SpirographeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ecran_Spirographe f = new Ecran_Spirographe();
            f.ShowDialog();
        }

        private void GraphiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ecran_Point f = new Ecran_Point();
            f.ShowDialog();
        }

        private void Mf_Carnaval_Click(object sender, EventArgs e)
        {
            Ecran_Carnaval f = new Ecran_Carnaval();
            f.ShowDialog();
        }

        private void Mf_Clavier_Souris_Click(object sender, EventArgs e)
        {
            Ecran_Clavier_Souris f = new Ecran_Clavier_Souris();
            f.ShowDialog();
        }

        private void MF_Explorateur_Click(object sender, EventArgs e)
        {
            Ecran_Explorateur f = new Ecran_Explorateur();
            f.ShowDialog();
        }

        private void M_F_BDD1_Click(object sender, EventArgs e)
        {
            Ecran_BDD1 f = new Ecran_BDD1();
            f.ShowDialog();
        }

        private void M_F_BDD2_Click(object sender, EventArgs e)
        {
            Ecran_BDD2 f = new Ecran_BDD2();
            f.ShowDialog();
        }

        private void M_F_BDD3_Click(object sender, EventArgs e)
        {
            Ecran_BDD3 f = new Ecran_BDD3();
            f.ShowDialog();
        }

        private void MF_Philo_Click(object sender, EventArgs e)
        {
            EcranDinerPhilosophes f = new EcranDinerPhilosophes();
            f.ShowDialog();
        }

        private void M_F_Exp_Click(object sender, EventArgs e)
        {
            Ecran_Expressions_Regulières f = new Ecran_Expressions_Regulières();
            f.ShowDialog();
        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ecran_Integrale f = new Ecran_Integrale();
            f.Show();
        }
    }
}
