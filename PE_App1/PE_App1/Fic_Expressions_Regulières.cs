using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PE_App1
{
    public partial class Ecran_Expressions_Regulières : Form
    {
        public Ecran_Expressions_Regulières()
        {
            InitializeComponent();
        }

        private void Ecran_Expressions_Regulières_Load(object sender, EventArgs e)
        {
            TB_Expression_Reguliere_TextChanged(null, null);
        }

        private void TB_Expression_Reguliere_TextChanged(object sender, EventArgs e)
        {
            if(CB_IsValide.Checked = Validite(TB_Expression_Reguliere.Text))
            {
                CB_IsCorresponding.Checked = Correspondance(TB_Expression_Reguliere.Text, RTB_ATRaiter.Text, CB_CasseSensitive.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
                MettreEnEvidence(TrouverOccurrences(TB_Expression_Reguliere.Text, RTB_ATRaiter.Text, CB_CasseSensitive.Checked ? RegexOptions.None : RegexOptions.IgnoreCase), RTB_ATRaiter);
            }
        }

        private void CB_CasseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            CB_IsCorresponding.Checked = Correspondance(TB_Expression_Reguliere.Text, RTB_ATRaiter.Text, CB_CasseSensitive.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
            MettreEnEvidence(TrouverOccurrences(TB_Expression_Reguliere.Text, RTB_ATRaiter.Text, CB_CasseSensitive.Checked ? RegexOptions.None : RegexOptions.IgnoreCase), RTB_ATRaiter);
        }

        private void CB_Remplacer_CheckedChanged(object sender, EventArgs e)
        {
            if(CB_Remplacer.Checked)
                MessageBox.Show(RemplacerOccurrence(TB_Expression_Reguliere.Text, RTB_ATRaiter.Text, TB_Remplacement.Text, CB_CasseSensitive.Checked ? RegexOptions.None : RegexOptions.IgnoreCase));
            CB_Remplacer.Checked = false;
        }

        private void CB_Separer_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Separer.Checked)
                if (TB_Expression_Reguliere.Text.Trim() != "")
                {
                    string[] tTmp = DecouperOccurrence(TB_Expression_Reguliere.Text, RTB_ATRaiter.Text, CB_CasseSensitive.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
                    foreach (string s in tTmp)
                        MessageBox.Show(s);
                }
                else
                    MessageBox.Show("Renseigner une expression avant de 'découper'");
            CB_Separer.Checked = false;
        }

        private void RTB_ATRaiter_TextChanged(object sender, EventArgs e)
        {
            CB_IsCorresponding.Checked = Correspondance(TB_Expression_Reguliere.Text, RTB_ATRaiter.Text, CB_CasseSensitive.Checked ? RegexOptions.None : RegexOptions.IgnoreCase);
            MettreEnEvidence(TrouverOccurrences(TB_Expression_Reguliere.Text, RTB_ATRaiter.Text, CB_CasseSensitive.Checked ? RegexOptions.None : RegexOptions.IgnoreCase), RTB_ATRaiter);
        }

        private bool Validite(string S_Expression_Reguliere)
        {
            try
            {
                Regex test = new Regex(S_Expression_Reguliere);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Correspondance(string S_Expression_Reguliere, string S_AVerif, RegexOptions RO_Parametre)
        {
            try
            {
                Regex exp = new Regex(S_Expression_Reguliere, RO_Parametre);
                return exp.IsMatch(S_AVerif);
            }
            catch
            {
                return false;
            }
        }

        private Match TrouverOccurrence(string sExpressionReguliere, string sAVerifier, RegexOptions roParametres)
        {
            Regex test = new Regex(sExpressionReguliere, roParametres);
            return test.Match(sAVerifier);
        }

        private MatchCollection TrouverOccurrences(string sExpressionReguliere, string sAVerifier, RegexOptions roParametres)
        {
            Regex test = new Regex(sExpressionReguliere, roParametres);
            return test.Matches(sAVerifier);
        }

        private void MettreEnEvidence(MatchCollection Occurences, RichTextBox Controle)
        {
            Controle.Select(0, Controle.Text.Length);
            Controle.SelectionBackColor = Color.Transparent;
            foreach (Match Occurence in Occurences)
            {
                Controle.Select(Occurence.Index, Occurence.Length);
                Controle.SelectionBackColor = Color.Silver;
            }
        }

        private string RemplacerOccurrence(string sExpressionReguliere, string sTexteDepart, string sRemplacement, RegexOptions roParametres)
        {
            Regex test = new Regex(sExpressionReguliere, roParametres);
            return test.Replace(sTexteDepart, sRemplacement);
        }

        public string[] DecouperOccurrence(string sExpressionReguliere, string sATraiter, RegexOptions roParametres)
        {
            Regex exp = new Regex(sExpressionReguliere, roParametres);
            return exp.Split(sATraiter);
        }
    }
}
