using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PE_App1
{
    public partial class Ecran_Carnaval : Form
    {
        public Ecran_Carnaval()
        {
            InitializeComponent();
        }

        private void DefinirZone()
        {
            GraphicsPath Dessin = new GraphicsPath();
            Point[] Pts = new Point[]
            {
                new Point(0,0),
                new Point(0,Size.Height),
                new Point(Size.Width / 4, 4 * Size.Height / 5),
                new Point(Size.Width / 2, Size.Height),
                new Point(3 * Size.Width / 4, 4 * Size.Height / 5),
                new Point(Size.Width, Size.Height),
                new Point(Size.Width, 0)
            };
            Dessin.AddClosedCurve(Pts);
            Region = new Region(Dessin); //Défini ce qui est affiché
        }

        private void DessinerBtnTexte()
        {
            GraphicsPath Gp = new GraphicsPath();
            StringFormat Sf = new StringFormat(StringFormat.GenericDefault);
            Sf.Alignment = StringAlignment.Center;
            Gp.AddString("! Cliquons ensemble !", new FontFamily("Courier New"), (int)FontStyle.Bold, 24, new Point(ClientSize.Width / 2, 0), Sf);
            Btn_Texte.Region = new Region(Gp);
        }

        private void DessinerBtnGeometrique()
        {
            int W = Btn_Geometrique.Size.Width;
            int H = Btn_Geometrique.Size.Height;
            GraphicsPath Gp = new GraphicsPath();
            Gp.AddEllipse(new Rectangle(0, 0, W / 2, H));
            Gp.AddEllipse(new Rectangle(W / 4, H / 2, W / 6, H / 3));
            Gp.AddEllipse(new Rectangle(W / 2, 0, W / 2, H));
            Gp.AddEllipse(new Rectangle(3 * W / 4 - W / 6, H / 2, W / 6, H / 3));
            Btn_Geometrique.Region = new Region(Gp);
        }

        private void Btn_Texte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bien vu, l'aveugle !");
        }

        private void Btn_Geometrique_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rien de plus, l'aveugle !");
        }

        private void Ecran_Carnaval_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Ecran_Carnaval_Paint(object sender, PaintEventArgs e)
        {
            DefinirZone();
            Btn_Texte.Size = new Size(ClientSize.Width - 20, Btn_Texte.Size.Height);
            DessinerBtnTexte();
            Btn_Geometrique.Size = new Size(ClientSize.Width - 20, ClientSize.Height / 4 - 20);
            DessinerBtnGeometrique();
        }
    }
}
