using System;
using System.Drawing;
using System.Windows.Forms;

namespace PE_App1
{
    public partial class Ecran_Horloge : Form
    {
        public Ecran_Horloge()
        {
            InitializeComponent();
            Chronometre.Start();
        }

        private void Chronometre_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Ecran_Horloge_Paint(object sender, PaintEventArgs e)
        {
            int xcentre = ClientRectangle.Width / 2; //Centre Horizontal (X)
            int ycentre = ClientRectangle.Height / 2; //Centre Vertical (Y)

            int ax = 4 * xcentre / 5; //Longueur horizontale
            int ay = 4 * ycentre / 5; //Longueur verticale


            int x, y; //Position point référence
            for (int i = 0; i < 12; i++)
            {
                x = xcentre + (int)(ax * Math.Cos(i * Math.PI / 6)); //Calcul pour la distance x
                y = ycentre + (int)(ay * Math.Sin(i * Math.PI / 6)); //Calcul pour la distance y
                if (i % 3 == 0) //3-6-9-12h ==> Rouge
                {
                    e.Graphics.DrawEllipse(new Pen(Color.DarkBlue), x, y, 4, 4);
                }
                else //Autres points
                {
                    e.Graphics.DrawEllipse(new Pen(Color.Goldenrod), x, y, 4, 4);

                }
            }
            DateTime heure = DateTime.Now; //Récupérer date
            this.Text = heure.Hour + ":" + heure.Minute + ":" + heure.Second; //Changer nom de la fenêtre
            //affiche l'aiguille des secondes
            x = xcentre + (int)(0.9 * ax * Math.Cos(heure.Second * Math.PI / 30 - Math.PI / 2)); //Attention : calculer float puis cast en int
            y = ycentre + (int)(0.9 * ay * Math.Sin(heure.Second * Math.PI / 30 - Math.PI / 2)); //0.9 : coef taille aiguille
            e.Graphics.DrawLine(new Pen(Color.Black), xcentre, ycentre, x, y);
            //affiche l'aiguille des minutes
            x = xcentre + (int)(0.8 * ax * Math.Cos(heure.Minute * Math.PI / 30 + heure.Second * Math.PI / 1800 - Math.PI / 2));
            y = ycentre + (int)(0.8 * ay * Math.Sin(heure.Minute * Math.PI / 30 + heure.Second * Math.PI / 1800 - Math.PI / 2));
            e.Graphics.DrawLine(new Pen(Color.Black, 3), xcentre, ycentre, x, y);
            //affiche l'aiguille des heures
            x = xcentre + (int)(0.65 * ax * Math.Cos(heure.Hour * Math.PI / 6 + heure.Minute * Math.PI / 360 - Math.PI / 2)); 
            y = ycentre + (int)(0.65 * ay * Math.Sin(heure.Hour * Math.PI / 6 + heure.Minute * Math.PI / 360 - Math.PI / 2));
            e.Graphics.DrawLine(new Pen(Color.Black, 10), xcentre, ycentre, x, y);
        }
    }
}
