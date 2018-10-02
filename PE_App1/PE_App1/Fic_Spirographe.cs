using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace PE_App1
{
    public partial class Ecran_Spirographe : Form
    {
        Color Fond, Trait;
        GraphicsPath GraphEnr = null; //Permet d'enregistrer un dessin

        public Ecran_Spirographe()
        {
            InitializeComponent();
            Fond = Color.Teal;
            Trait = Color.Goldenrod;
        }

        private void Btn_Fond_Click(object sender, EventArgs e)
        {
            Dlg_Couleur.Color = Fond;
            if (Dlg_Couleur.ShowDialog() == DialogResult.OK)
            {
                Fond = Dlg_Couleur.Color;
                Invalidate();
            }
        }

        private void Btn_Trait_Click(object sender, EventArgs e)
        {
            Dlg_Couleur.Color = Trait;
            if (Dlg_Couleur.ShowDialog() == DialogResult.OK)
            {
                Trait = Dlg_Couleur.Color;
                Invalidate();
            }
        }

        private void Btn_Go_Click(object sender, EventArgs e)
        {
            int N_Som = TB_Nb_Sommets.Value;
            int N_Den = TB_Densite.Value;
            int N_Pro = 100 - TB_Profondeur.Value;
            GraphEnr = new GraphicsPath();
            Rectangle Zone = new Rectangle(new Point(200, 0), ClientSize);
            Graphics gr = CreateGraphics();
            gr.FillRectangle(new SolidBrush(Fond), Zone);
            int xc = 200 + (ClientSize.Width - 200) / 2; //Calcul du centre horizontal, décalé avec le GroupBox
            int yc = ClientSize.Height / 2; //Calcul du centre vertical
            int Rayon = 9 * Math.Min(ClientSize.Width - 200, ClientSize.Height) / 20; //On prend les diamètres sur 2 et on choisit le plus petit + décalage pour pas être collé aux bords
            float[] sX = new float[N_Som + 1]; //Tableaux pour stocker sommet => Boucle pour dessiner
            float[] sY = new float[N_Som + 1];
            for(int i = 0; i <= N_Som; i++)
            {
                sX[i] = (int)(xc + Rayon * Math.Cos(2 * Math.PI * i / N_Som)); //Calcul sommet suivant
                sY[i] = (int)(yc + Rayon * Math.Sin(2 * Math.PI * i / N_Som));
            }
            while(d(sX[0], sY[0], xc, yc) > Rayon * N_Pro / 100)
            {
                //Dessin
                for(int i = 1; i <= N_Som; i++)
                {
                    gr.DrawLine(new Pen(Trait), sX[i - 1], sY[i - 1], sX[i], sY[i]);
                    GraphEnr.AddLine(sX[i - 1], sY[i - 1], sX[i], sY[i]);
                    Application.DoEvents();
                    Thread.Sleep(15);
                }

                //Calcul
                for(int i = 0; i < N_Som; i++)
                {
                    sX[i] = sX[i] + (sX[1 + i] - sX[i]) / N_Den;
                    sY[i] = sY[i] + (sY[1 + i] - sY[i]) / N_Den;
                }
                sX[N_Som] = sX[0];
                sY[N_Som] = sY[0];
            }
        }

        private void Ecran_Spirographe_Paint(object sender, PaintEventArgs e)
        {
            if (GraphEnr != null)
            {
                Rectangle Zone = new Rectangle(new Point(200, 0), ClientSize); //Taille pour dessiner
                e.Graphics.FillRectangle(new SolidBrush(Fond), Zone); //Fond
                e.Graphics.DrawPath(new Pen(Trait), GraphEnr); //Spinographe (il va le rechercher et l'affiche)
            }
        }

        private double d(double x1, double y1, double x2, double y2) //Calcul distance entre sommet et centre
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        } 
    }
}
