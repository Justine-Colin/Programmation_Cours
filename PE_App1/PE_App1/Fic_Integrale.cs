using System;
using System.Windows.Forms;

namespace PE_App1
{
    public partial class Ecran_Integrale : Form
    {
        public Ecran_Integrale()
        {
            InitializeComponent();
        }

        static private double Fct_Polynome(double x)
        { return x * x - 3 * x + 4; }

        static private double Fct_Cosinus(double x)
        { return Math.Cos(x); }

        delegate double Fct_AIntegrer(double a);

        private void Btn_Polynome_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Tb_Gauche.Text, out double a) && double.TryParse(TB_Droite.Text, out double b) && int.TryParse(TB_Intervalle.Text, out int Nb_Int))
            {
                LB_Resultat.Items.Clear();
                Fct_AIntegrer f = new Fct_AIntegrer(Fct_Polynome);
                for (int i = 0; i < 5; i++)
                {
                    LB_Resultat.Items.Add("Nb int = " + Nb_Int + " => " + IntegrationRectangleGauche(f, a, b, Nb_Int));
                    Nb_Int += 2;
                }
            }
            else
                MessageBox.Show("Vérifiez vos entrées");
        }

        private void Btn_Cosinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Tb_Gauche.Text, out double a) && double.TryParse(TB_Droite.Text, out double b) && int.TryParse(TB_Intervalle.Text, out int Nb_Int))
            {
                LB_Resultat.Items.Clear();
                Fct_AIntegrer f = new Fct_AIntegrer(Fct_Cosinus);
                for (int i = 0; i < 5; i++)
                {
                    LB_Resultat.Items.Add("Nb int = " + Nb_Int + " => " + IntegrationRectangleGauche(f, a, b, Nb_Int));
                    Nb_Int += 2;
                }
            }
            else
                MessageBox.Show("Vérifiez vos entrées");
        }

        static double IntegrationRectangleGauche(Fct_AIntegrer f, double BG, double BD, int n)
        {
            double Aire = 0;
            double x = BG;
            double p = (BD - BG / n);
            for (int i = 0; i < n; i++)
            {
                Aire += p * f(x);
                x += p;
            }
            return Aire;
        }
    }
}
