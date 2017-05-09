using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Artysci.ObjectsClass;

namespace Artysci
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Database.ConnectDatabase(); //Podłączenie bazy przed wywołaniem jakiejkolwiek formatki
            //---------------TEST--------------------------------
            List<sond> sondAll = Database.GetSond(); //Test funkcji pobierającej sondy jako liste obiektów
            foreach (sond sond in sondAll)
            {
                Debug.WriteLine(sond.ToString());
            }


            List<sond> sondWhere = Database.GetSond("where id in (1,2)");
            foreach (sond sond in sondWhere)
            {
                Debug.WriteLine(sond.ToString());
            }

            //wstawianie test
            sond s = new sond() { creator_login = "wstaw", question = "tetst?", date_end = DateTime.Now.ToString(),
                date_start = DateTime.Now.ToString() };
            Database.AddSond(s);
            
            //---------------TEST--------------------------------
            Application.Run(new Artysci.Forms.FormLogin());
        }
    }
}
