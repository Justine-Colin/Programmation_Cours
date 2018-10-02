using System;
using System.Windows.Forms;
using System.IO;

namespace PE_App1
{
    public partial class Ecran_Explorateur : Form
    {
        private TreeNode Noeud_Racine;
        public Ecran_Explorateur()
        {
            InitializeComponent();
            SL_Message.Text = "";
            Lire_Disque();
        }

        private void Lire_Disque()
        {
            Cursor = Cursors.WaitCursor;
            SL_Message.Text = "Lecture de l'arborescence";
            Noeud_Racine = new TreeNode("Poste de travail", 0, 0); // On se place dans le poste de travail, arguments derrière = images
            TV_Repertoire.Nodes.Clear();
            TV_Repertoire.Nodes.Add(Noeud_Racine);
            string[] Disques = Environment.GetLogicalDrives(); // On récupère les disques
            foreach (string Disque in Disques)
            {
                TreeNode Noeud_Disque = new TreeNode(Disque, 1, 1);
                Noeud_Racine.Nodes.Add(Noeud_Disque);
                Lire_Repertoire(Disque, Noeud_Disque.Nodes);
            }
            SL_Message.Text = "";
            Cursor = Cursors.Arrow;
        }

        private string Nom_Fichier(string nf)
        {
            return nf.Substring(1 + nf.LastIndexOf('\\'));
        }

        private void TS_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TS_Petites_Icones_Click(object sender, EventArgs e)
        {
            LV_Fichier.View = View.SmallIcon;
        }

        private void TS_Grandes_Icones_Click(object sender, EventArgs e)
        {
            LV_Fichier.View = View.LargeIcon;
        }

        private void TS_Liste_Click(object sender, EventArgs e)
        {
            LV_Fichier.View = View.List;
        }

        private void TS_Detail_Click(object sender, EventArgs e)
        {
            LV_Fichier.View = View.Details;
        }

        private void Lire_Repertoire(string Nom_Disque, TreeNodeCollection Tnc)
        {
            if (Directory.Exists(Nom_Disque))
            {
                try
                {
                    string[] S_Reps = Directory.GetDirectories(Nom_Disque);
                    foreach(string S_Rep in S_Reps)
                    {
                        string S1 = "", S2 = "";
                        S1 = Nom_Fichier(S_Rep);
                        S2 = S1.ToUpper();
                        TreeNode Noeud_Courant;
                        if (S2 == "RECYCLED" || S2 == "RECYCLER" || S1 == "$RECYCLE.BIN")
                            Noeud_Courant = new TreeNode(S1, 4, 4);
                        else
                            Noeud_Courant = new TreeNode(S1, 2, 3);
                        Tnc.Add(Noeud_Courant);
                        //Lire_Repertoire(S_Rep, Noeud_Courant.Nodes);
                    }
                }
                catch(IOException Faute)
                {
                    MessageBox.Show("Problème dans la lecture de répertoire");
                }
            }
        }

        private void TV_Repertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode Noeud_Courant = e.Node;
            if (Noeud_Courant == Noeud_Racine)
            {
                string[] S_Temp = { "Poste de travail", "", "", "" };
                ListViewItem LVI = new ListViewItem(S_Temp, 0);
                LV_Fichier.Items.Add(LVI);
            }
            else
            {
                string S_Rep = Noeud_Courant.FullPath;
                S_Rep = S_Rep.Substring(1 + S_Rep.IndexOf('\\'));
                try
                {
                    LV_Fichier.Items.Clear();
                    if (!Directory.Exists(S_Rep))
                    {
                        string[] S_Temp = { "Non opérationnel", "", "", "" };
                        ListViewItem LVI = new ListViewItem(S_Temp, 0);
                        LV_Fichier.Items.Add(LVI);
                        Cursor = Cursors.Arrow;
                        SL_Message.Text = "";
                        TV_Repertoire.Focus();
                    }
                    else
                        Lire_Fichiers(S_Rep);
                }
                catch (IOException Faute)
                {
                    MessageBox.Show("Erreur d'accès à " + S_Rep + " (" + Faute.Message + ")");
                    Cursor = Cursors.Arrow;
                    SL_Message.Text = "";
                    TV_Repertoire.Focus();
                }
                
            }
        }

        private void Lire_Fichiers(string S_Rep)
        {
            LV_Fichier.Items.Clear();
            SL_Message.Text = "Raffraichissement de " + S_Rep + " en cours";
            Cursor = Cursors.WaitCursor;
            try
            {
                string[] S_Fics = Directory.GetFiles(S_Rep);
                string[] LV_Col = new string[4];
                //LV_Col[0] = Nom fichier, [1] = Taille, [2] = Date création, [3] = Date modif
                SL_Message.Text = "Parcours de " + S_Rep;
                foreach(string S_Fic in S_Fics)
                {
                    if(S_Fic.ToUpper() != "PAGEFILE.SYS")
                    {
                        FileInfo Fi = new FileInfo(S_Fic);
                        LV_Col[0] = Nom_Fichier(S_Fic);
                        if (Fi.Length > 1024*1024)
                            LV_Col[1] = (Fi.Length / (1024 * 1024)).ToString() + "MB";
                        else if (Fi.Length > 1024 * 1024)
                            LV_Col[1] = (Fi.Length / 1024).ToString() + "KB";
                        else
                            LV_Col[1] = Fi.Length.ToString() + "B";
                        LV_Col[2] = Fi.CreationTime.ToString("dd/mm/yyyy");
                        LV_Col[3] = Fi.LastWriteTime.ToString("dd/mm/yyyy");
                        ListViewItem LVI = new ListViewItem(LV_Col, 0);
                        LV_Fichier.Items.Add(LVI);
                    }
                }
            }
            catch(IOException Fot)
            {
                MessageBox.Show("Erreur d'accès à " + S_Rep + " (" + Fot.Message + ")");
            }
            catch
            {
                MessageBox.Show("Erreur d'accès à " + S_Rep);
            }
            finally
            {
                SL_Message.Text = "";
                Cursor = Cursors.Arrow;
            }
        }

    }
}
