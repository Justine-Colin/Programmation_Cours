using System;
using System.Windows.Forms;
using System.Configuration;

namespace PE_App1
{
    sealed class ParamApplication : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        public string ChConnBD
        {
            get { return (string)this["csPerso"]; }
            set { this["csPerso"] = value; }
        }
    }
    static class Program
    {
        public static ParamApplication PA = new ParamApplication();
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ecran_Accueil());
            Application.Run(new Ecran_Principal());
        }
    }
}
