using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace PE_App1
{
    public partial class Ecran_Liste : Form
    {
        #region Déclaration
        [DllImport("user32.dll", EntryPoint = "SendMessage")] //Charge librairies pas gérées par compilateur
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam); //extern pour truc externe au programme
        const int LB_Lire = 0x0199; //Hexa pour lecture => variable
        const int LB_Ecrire = 0x019A; //Hexa pour écriture => variable
        private string Nom_Fichier = "";
        #endregion

        public Ecran_Liste()
        {
            InitializeComponent();
        }

        private void Activer(bool L_Detail)
        {
            LB_personnes.Enabled = !L_Detail; //LB = ListBox
            Btn_Ouvrir.Enabled = Btn_Enregistrer.Enabled = Btn_Ajouter.Enabled = Btn_Supprimer.Enabled = !L_Detail;
            GB_Details.Enabled = L_Detail;
            if (L_Detail)
            {
                TB_Nom.Text = ""; //TB = TextBox
                CB_Qualite.SelectedIndex = 0; //CB = ComboBox
                CB_Qualite.Focus();
            }
            else
                LB_personnes.Focus();
        }

        private void Btn_Confirmer_Click(object sender, EventArgs e)
        {
            int n = LB_personnes.Items.Add(TB_Nom.Text + " (" + CB_Qualite.Text + ")"); //n = place dans la liste
            SendMessage(LB_personnes.Handle, LB_Ecrire, n, LB_personnes.Items.Count); //SendMessage : info cachée
            Activer(false);
        }

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
            Activer(false);
        }

        private void Btn_Ouvrir_Click(object sender, EventArgs e)
        {
            if (Nom_Fichier != "")
                Dlg_Ouvrir.FileName = Nom_Fichier; //Boite de dialogue pour ouvrir fichier (native w10)
            Dlg_Ouvrir.Filter = "Fichiers|*.txt|Tous fichiers|*.*";
            if (Dlg_Ouvrir.ShowDialog() == DialogResult.OK)
            {
                LB_personnes.Items.Clear();
                Nom_Fichier = Dlg_Ouvrir.FileName;
                StreamReader sr = new StreamReader(Nom_Fichier);
                string Lecture;            
                while((Lecture=sr.ReadLine()) != null)
                {
                    string[] tab = Lecture.Split('#'); //Diviser en 2 pour valeurs cachées
                    int n = LB_personnes.Items.Add(tab[0]);
                    SendMessage(LB_personnes.Handle, LB_Ecrire, n, int.Parse(tab[1])); //Réencodage de la valeur cachée depuis 2ème valeur du split
                }
                sr.Close();
                Lbl_Fichier.Text = Nom_Fichier.Substring(1 + Nom_Fichier.LastIndexOf('\\'));
            }
        }

        private void Btn_Enregistrer_Click(object sender, EventArgs e)
        {
            if (Dlg_Enregistrer.ShowDialog() == DialogResult.OK)
            {
                int n;
                StreamWriter sw = new StreamWriter(Dlg_Enregistrer.FileName);
                Nom_Fichier = Dlg_Enregistrer.FileName;
                for (int i = 0; i < LB_personnes.Items.Count; i++)
                {
                    n = SendMessage(LB_personnes.Handle, LB_Lire, i, 0);
                    sw.WriteLine(LB_personnes.Items[i] + "#" + n); //Enregistrement info cachée avec
                }                 
                sw.Close(); 
                Lbl_Fichier.Text = Nom_Fichier.Substring(1 + Nom_Fichier.LastIndexOf('\\'));
            }
        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            int nItem = LB_personnes.SelectedIndex;
            if (nItem >= 0)
            {
                int n = SendMessage(LB_personnes.Handle, LB_Lire, nItem, 0);
                LB_personnes.Items.RemoveAt(nItem);
                for (int i=0; i<LB_personnes.Items.Count; i++)
                {
                    int m = SendMessage(LB_personnes.Handle, LB_Lire, i, 0);
                    if (m > n)
                        SendMessage(LB_personnes.Handle, LB_Ecrire, i, --m); //Change valeur cachée
                }
            }        
            else
                MessageBox.Show("Aucune personne sélectionnée");
        }

        private void LB_personnes_DoubleClick(object sender, EventArgs e)
        {
            if(LB_personnes.SelectedIndex >= 0) //Montre valeurs cachées
            {
                int n = SendMessage(LB_personnes.Handle, LB_Lire, LB_personnes.SelectedIndex, 0);
                MessageBox.Show(LB_personnes.Text + " en position " + (1 + LB_personnes.SelectedIndex) + " (tri), " + n.ToString() + " (encodage)");
            }              
        }
    }
}
