using System;
using System.Windows.Forms;

namespace PE_App1
{
    public partial class Ecran_BDD2 : Form
    {
        public Ecran_BDD2()
        {
            InitializeComponent();
            clientBindingSource.PositionChanged += new EventHandler(Bouger_Client);
            Activer_Nav(true);
        }

        private void Bouger_Client(object sender, EventArgs e)
        {
            Bouger();
        }

        private void Btn_Ann_Click(object sender, EventArgs e)
        {
            clientBindingSource.CancelEdit();
            Activer_Nav(true);
        }

        private void Btn_Prec_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position--;
        }

        private void Btn_Suiv_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position++;
        }

        private void Btn_Der_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position = clientBindingSource.Count - 1;
        }

        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew();
            Activer_Nav(false);
        }

        private void Btn_Modif_Click(object sender, EventArgs e)
        {
            Activer_Nav(false);
        }

        private void Btn_Suppr_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Souhaitez-vous supprimer cet enregistrement ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clientBindingSource.RemoveAt(clientBindingSource.Position);
                Valider_Modif();
            }
        }

        private void Btn_Conf_Click(object sender, EventArgs e)
        {
            clientBindingSource.EndEdit();
            if (persoDataSet.HasChanges()) Valider_Modif();
            else MessageBox.Show("Aucune modification");
            Activer_Nav(true);
        }

        private void Btn_Prem_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position = 0;
        }

        private void Ecran_BDD2_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'persoDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.persoDataSet.Client);
            //string s = Program.PA.ChConnBD;
            Bouger();
            Activer_Nav(clientBindingSource.Count > 0);
        }

        private void Activer_Nav(bool lActi)
        {
           // Btn_Prem.Enabled = Btn_Prec.Enabled = Btn_Suiv.Enabled = Btn_Der.Enabled = lActi;
            Btn_Ajout.Enabled = Btn_Modif.Enabled = Btn_Suppr.Enabled = !lActi;
            TB_Pre.Enabled = TB_Nom.Enabled = DTP_Ne.Enabled = !lActi;
            Btn_Conf.Enabled = Btn_Ann.Enabled = !lActi;
        }

        private void Bouger()
        {
            Btn_Prec.Enabled = Btn_Prem.Enabled = Btn_Suiv.Enabled = Btn_Der.Enabled = true;
            if (clientBindingSource.Position == 0)
                Btn_Prec.Enabled = Btn_Prem.Enabled = false;
            if (clientBindingSource.Position == clientBindingSource.Count - 1)
                Btn_Suiv.Enabled = Btn_Der.Enabled = false;
            Lbl_Pos.Text = (1 + clientBindingSource.Position).ToString() + "/" + clientBindingSource.Count.ToString();
            //if (clientBindingSource.Count == 0)
            //    Btn_Suppr.Enabled = Btn_Modif.Enabled = false;
            //else
            //    Btn_Suppr.Enabled = Btn_Modif.Enabled = true;
            Btn_Suppr.Enabled = Btn_Modif.Enabled = (clientBindingSource.Count > 0);
        }

        private void Valider_Modif()
        {
            try
            {
                MessageBox.Show(clientTableAdapter.Update(persoDataSet.Client).ToString() + " mise(s) à jour effectuée(s)");
            }
            catch { MessageBox.Show("Echec de la mise à jour"); }
        }
    }
}
