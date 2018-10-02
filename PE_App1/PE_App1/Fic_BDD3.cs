using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ISET2018_CouClasses;
using ISET2018_Gestion;

namespace PE_App1
{
    public partial class Ecran_BDD3 : Form
    {
        DataTable DT_Personne;
        BindingSource BS_Personne;
        string S_Ch_Conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IS2\Progra\Base_Donnée\BD_Perso.MDF;Integrated Security=True;Connect Timeout=30";
        public Ecran_BDD3()
        {
            InitializeComponent();
            Remplir_DGV();
            if (DGV_Personne.Rows.Count > 0)
            {
                Activer(true);
                DGV_Personne.Rows[0].Selected = true;
            }
            else
                Activer(false);
        }

        private void Activer(bool lNavigation)
        {
            Btn_Ajout.Enabled = Btn_Edit.Enabled = Btn_Supp.Enabled = lNavigation;
            Btn_Conf.Enabled = Btn_Annu.Enabled = !lNavigation;
            DTP_Nai.Enabled = TB_Nom.Enabled = TB_Pre.Enabled = !lNavigation;
            DGV_Personne.Enabled = lNavigation;
            if (lNavigation)
                DGV_Personne.Focus();
            else
                TB_Pre.Focus();
        }

        private void Remplir_DGV()
        {
            DT_Personne = new DataTable();
            DT_Personne.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_Personne.Columns.Add("Afficher");
            List<C_Personne> lTmp = new G_Personne(S_Ch_Conn).Lire("Nom");
            foreach (C_Personne Tmp in lTmp)
                DT_Personne.Rows.Add(Tmp.ID, Tmp.PRE + " " + Tmp.NOM);
            BS_Personne = new BindingSource
            {
                DataSource = DT_Personne
            };
            DGV_Personne.DataSource = BS_Personne;
        }

        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            Activer(false);
            TB_Nom.Text = TB_ID.Text = TB_Pre.Text = "";
            DTP_Nai.Value = DateTime.Today;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if(DGV_Personne.SelectedRows.Count > 0)
            {
                Activer(false);
                TB_ID.Text = DGV_Personne.SelectedRows[0].Cells["ID"].Value.ToString();
                C_Personne Tmp = new G_Personne(S_Ch_Conn).Lire_ID(int.Parse(TB_ID.Text));
                TB_Nom.Text = Tmp.NOM;
                TB_Pre.Text = Tmp.PRE;
                DTP_Nai.Value = (Tmp.NAI == null ? DateTime.Today : (DateTime)Tmp.NAI);
            }           
        }

        private void Btn_Supp_Click(object sender, EventArgs e)
        {
            if (DGV_Personne.SelectedRows.Count > 0)
            {
                int N_ID = (int)DGV_Personne.SelectedRows[0].Cells["ID"].Value;
                new G_Personne(S_Ch_Conn).Supprimer(N_ID);
                BS_Personne.RemoveCurrent();
            }
        }

        private void Btn_Annu_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void Btn_Conf_Click(object sender, EventArgs e)
        {
            if (TB_Nom.Text.Length == 0)
                MessageBox.Show("Veuillez renseigner le nom");
            else
            {
                if (TB_ID.Text == "") //Mode ajout
                {
                    int N_ID = new G_Personne(S_Ch_Conn).Ajouter(TB_Nom.Text, TB_Pre.Text, DTP_Nai.Value);
                    DT_Personne.Rows.Add(N_ID, TB_Pre.Text + "" + TB_Nom.Text);
                }
                else //Mode édition
                {
                    int N_ID = int.Parse(TB_ID.Text);
                    new G_Personne(S_Ch_Conn).Modifier(N_ID, TB_Nom.Text, TB_Pre.Text, DTP_Nai.Value);
                    for(int i = 0; i < DT_Personne.Rows.Count; i++)
                    {
                        if ((int)DT_Personne.Rows[i]["ID"] == N_ID)
                        {
                            DT_Personne.Rows[i]["Afficher"] = TB_Pre.Text + " " + TB_Nom.Text;
                            break;
                        }
                    }
                }
                Activer(true);
            }
            
        }
    }
}
