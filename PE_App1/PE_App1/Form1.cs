using System;
using System.Windows.Forms;

namespace PE_App1
{
    public partial class Aide : Form
    {
        public Aide()
        {
            InitializeComponent();
        }

        private void Btn_Confirmer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
