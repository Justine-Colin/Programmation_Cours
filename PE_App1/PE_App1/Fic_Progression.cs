using System;
using System.Windows.Forms;

namespace PE_App1
{
    public partial class Ecran_Progression : Form
    {
        public Ecran_Progression()
        {
            InitializeComponent();
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Executer_Click(object sender, EventArgs e)
        {
            int i, j, pas;
            Cursor Curseur = Cursor;
            Random delai = new Random();
            Cursor = Cursors.WaitCursor;
            Btn_Executer.Enabled = Btn_Quitter.Enabled = false;
            PrB_Principale.Value = 0;
            for(i = 1; i <= 8; i++)
            {
                PrB_Secondaire.Value = 0;
                pas = 5 + 9 * delai.Next(20);
                for(j = 1; j <= 20; j++)
                {
                    PrB_Secondaire.Value = j * 5;
                    System.Threading.Thread.Sleep(pas);
                }
                PrB_Principale.Value = i * 100 / 8;
            }
            Btn_Executer.Enabled = Btn_Quitter.Enabled = true;
            Cursor = Curseur;
        }
    }
}
