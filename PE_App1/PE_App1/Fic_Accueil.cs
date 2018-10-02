using System;
using System.Drawing;
using System.Windows.Forms;

namespace PE_App1
{
    public partial class Ecran_Accueil : Form
    {
        
        bool Change = false;
        public Ecran_Accueil()
        {
            InitializeComponent();
        }
        

        private void Btn_Pousser_Click(object sender, EventArgs e)
        {
            if (!Change)
            {
                this.LblTitre.Font = new Font("Tahoma", 12, FontStyle.Bold);
                this.PB_Image_Depart.Image = Properties.Resources._4ed0m9imb3zz;
            }
            else
            {
                this.LblTitre.Font = new Font("Monotype Corsiva", 22);
                this.PB_Image_Depart.Image = Properties.Resources.Assassins_Creed_Origins;
            }
            Change = !Change;
        }

        private void Btn_Entrer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
