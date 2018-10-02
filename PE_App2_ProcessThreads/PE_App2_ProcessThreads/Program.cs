using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace PE_App2_ProcessThreads
{
    class Program
    {
        const int N = 500;
        static int commun = 0;
        static ReaderWriterLock Verrou = new ReaderWriterLock();
        static Mutex AutreVerrou = new Mutex();

        static void a()
        {
            for (int i = 0; i < N; i++)
            {
                //lock (typeof(Program))
                {
                    //Verrou.AcquireWriterLock(-1);
                    AutreVerrou.WaitOne();
                    int n = commun;
                    n++;
                    Console.Write("A{0,-7}", commun);
                    commun = n;
                    //Verrou.ReleaseWriterLock();
                    AutreVerrou.ReleaseMutex();
                }
            }     
        }

        static void b()
        {
            for (int i = 0; i < N; i++)
            {
                //lock (typeof(Program))
                {
                    //Verrou.AcquireWriterLock(-1);
                    AutreVerrou.WaitOne();
                    int n = commun;
                    n++;
                    Console.Write("B{0,-7}", commun);
                    commun = n;
                    //Verrou.ReleaseWriterLock();
                    AutreVerrou.ReleaseMutex();
                }
            }
        }

        static void Main(string[] args)
        {
            if (ExisteInstance())
            {
                Console.WriteLine("Autre instance => Bye !");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lancement des threads");
                Thread ta = new Thread(new ThreadStart(a));
                Thread tb = new Thread(new ThreadStart(b));
                ta.Start();
                tb.Start();
                ta.Join(); //Empêche l'exécution de la suite jusqu'à la fin du processus (ici ta)
                tb.Join();
                Console.WriteLine("\nFin des threads");
                Console.ReadLine();
                #region Partie commentée
                /* Partie Process
                //Console.WriteLine("Ouverture du bloc-note");
                //Process p = Process.Start("notepad");
                Process p = new Process();
                //p.StartInfo.FileName = "notepad";
                p.StartInfo.FileName = "PE_App2_Secondaire.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true; //Change le moyen d'entrée (plus le clavier)
                p.StartInfo.RedirectStandardOutput = true;//Change le moyen de sortie (plus la console du .exe)
                DateTime deb = new DateTime();
                try
                {
                    p.Start();
                    p.StandardInput.WriteLine("Largo");
                    p.StandardInput.WriteLine("Winch");
                    Console.WriteLine("Résultat : {0}", p.StandardOutput.ReadToEnd());
                    deb = p.StartTime;
                    if (!p.HasExited)
                    {
                        p.Kill();
                        p.WaitForExit();
                    }
                    Console.WriteLine("Début : {0}", deb);
                    Console.WriteLine("Fin   : {0}", p.ExitTime);
                    Console.WriteLine("Durée : {0}", p.ExitTime - deb);
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Problème avec PE_App2_Secondaire.exe");
                }*/
                #endregion
            }
        }

        static bool ExisteInstance()
        {
            Process actu = Process.GetCurrentProcess();
            Process[] acti = Process.GetProcesses();
            foreach(Process p in acti)
            
                if (p.Id != actu.Id)
                    if (actu.ProcessName == p.ProcessName)
                        return true;
                return false;             
        }
    }
}
