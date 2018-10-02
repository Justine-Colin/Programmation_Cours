using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PE_App1
{
    public partial class Ecran_BDD1 : Form
    {
        private string S_Ch_Conn = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ..\..\..\perso.mdb;Persist Security Info=True";
        public Ecran_BDD1()
        {
            InitializeComponent();
        }

        private void BTN_Charger_Click(object sender, EventArgs e)
        {
            LB_Contenu.Items.Clear();
            OleDbConnection Conn = new OleDbConnection(S_Ch_Conn);
            Conn.Open();
            OleDbCommand Comm = new OleDbCommand();
            Comm.Connection = Conn;
            Comm.CommandText = "SELECT PRE,NOM FROM Client ORDER BY NOM";
            OleDbDataReader DR = Comm.ExecuteReader();
            while (DR.Read())
                LB_Contenu.Items.Add(DR["PRE"].ToString() + " " + DR["NOM"]);
            DR.Close();
            Conn.Close();
        }

        private void Btn_Compter_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(S_Ch_Conn);
            Conn.Open();
            OleDbCommand Comm = new OleDbCommand();
            Comm.Connection = Conn;
            Comm.CommandText = "SELECT COUNT(NOM) FROM Client";
            int Nb = (int)Comm.ExecuteScalar();
            MessageBox.Show(Nb.ToString() + " enregistrements");
            Conn.Close();
        }

        private void BTN_Sauver_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(S_Ch_Conn);
            Conn.Open();
            OleDbCommand Comm = new OleDbCommand();
            Comm.Connection = Conn;
            Comm.CommandText = "INSERT INTO Client(NOM,PRE) VALUES('" + TB_Nom.Text + "','" + TB_Prenom.Text + "')";
            int Nb = (int)Comm.ExecuteNonQuery();
            MessageBox.Show(Nb.ToString() + " enregistrement(s) effectué(s)");
            Conn.Close();
            BTN_Charger_Click(null, null);
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(S_Ch_Conn);
            Conn.Open();
            OleDbCommand Comm = new OleDbCommand();
            Comm.Connection = Conn;
            Comm.CommandText = "DELETE FROM Client WHERE NOM = '" + TB_Sup.Text + "'";
            int Nb = (int)Comm.ExecuteNonQuery();
            MessageBox.Show(Nb.ToString() + " suppression(s) effectué(s)");
            Conn.Close();
            BTN_Charger_Click(null, null);
        }
    }
}