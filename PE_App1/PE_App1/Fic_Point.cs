using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PE_App1
{
    public partial class Ecran_Point : Form
    {
        Color Fond, Trait;
        GraphicsPath GraphEnr = null; //Permet d'enregistrer un dessin
        GraphicsPath GraphEnr2 = null;
        List<Mon_Point> Liste = null;
        int Nb;

        public Ecran_Point()
        {
            Fond = Color.Teal;
            Trait = Color.Goldenrod;
            InitializeComponent();
        }

        private void Btn_Graph_Click(object sender, EventArgs e)
        {                                        
            //Génération des points
            Liste = new List<Mon_Point>();
            Random Rnd = new Random(); //Pour avoir de l'aléatoire
            int x = 0, y = 0;
            Nb = Rnd.Next(10, 26); // Génère un aléatoire entre [10;26[

            for(int i=0; i<Nb; i++) //Liste de points
            {
                x = x + Rnd.Next(5, 21);
                y = Rnd.Next(1, 202);
                if (y < 101)
                {
                    y = -y;
                }
                else
                {
                    if (y == 101)
                    {
                        y = 0;
                    }
                    else
                        y -= 101;
                }
                Liste.Add(new Mon_Point(x, y));
            }

            Dessiner();
            Pnl_Point.Invalidate();
        }

        private void Btn_Trait_Click(object sender, EventArgs e)
        {
            Dlg_Couleur.Color = Trait;
            if (Dlg_Couleur.ShowDialog() == DialogResult.OK)
            {
                Trait = Dlg_Couleur.Color;
                Pnl_Point.Invalidate();
            }
        }

        private void Btn_Fond_Click(object sender, EventArgs e)
        {
            Dlg_Couleur.Color = Fond;
            if (Dlg_Couleur.ShowDialog() == DialogResult.OK)
            {
                Fond = Dlg_Couleur.Color;
                Pnl_Point.Invalidate();
            }
        }

        private void Pnl_Point_Paint(object sender, PaintEventArgs e)
        {
            if (GraphEnr != null)
            {
                Rectangle Zone = new Rectangle(Pnl_Point.Location, Pnl_Point.Size); //Taille pour dessiner
                e.Graphics.FillRectangle(new SolidBrush(Fond), Zone); //Fond
                e.Graphics.DrawPath(new Pen(Trait), GraphEnr); //Graphique
                e.Graphics.DrawPath(new Pen(Color.FromArgb(Trait.ToArgb() ^ 0xffffff)), GraphEnr2);//Ligne milieu
                //Color.FromArgb(Trait.ToArgb() ^ 0xffffff) permet de trouver la couleur complémentaire à la couleur Trait
            }
        }

        private void Pnl_Point_Resize(object sender, EventArgs e)
        {
            if (Liste != null)
            {
                Dessiner();
            }    
            Pnl_Point.Invalidate();
        }

        private int DeltaY(List<Mon_Point> Liste)
        {
            int max = 0, min = 0;
            foreach (Mon_Point Pt in Liste)
            {
                if(Pt.y > max)
                {
                    max = Pt.y;
                }
                if (Pt.y < min)
                {
                    min = Pt.y;
                }
            }
            return max + Math.Abs(min);
        }

        private void Dessiner()
        {
            //Génération du graphique
            GraphEnr = new GraphicsPath();
            GraphEnr2 = new GraphicsPath();
            Rectangle Zone = new Rectangle(Pnl_Point.Location, Pnl_Point.Size);
            Graphics gr = CreateGraphics();
            gr.FillRectangle(new SolidBrush(Fond), Zone);
            int yc = Pnl_Point.Height / 2; //Calcul du centre vertical => y = 0
            int xd = Pnl_Point.Location.X; //Début du graphique         

            //Adapter le graphique à la fenêtre
            int EcartX = Pnl_Point.Width / Liste[Nb - 1].x;
            int EcartY = Pnl_Point.Height / DeltaY(Liste);

            for (int i = 1; i < Nb; i++)
            {
                Application.DoEvents();
                GraphEnr.AddLine(new Point(Liste[i - 1].x * EcartX + xd, Liste[i - 1].y * EcartY + yc), new Point(Liste[i].x * EcartX + xd, Liste[i - 1].y * EcartY + yc));
                GraphEnr.AddLine(new Point(Liste[i].x * EcartX + xd, Liste[i - 1].y * EcartY + yc), new Point(Liste[i].x * EcartX + xd, Liste[i].y * EcartY + yc));
            }
            GraphEnr2.AddLine(new Point(Liste[0].x * EcartX + xd, yc), new Point(Liste[Nb - 1].x * EcartX + xd, yc));
        }
    }
}
