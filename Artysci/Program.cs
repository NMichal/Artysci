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

            //>>>>>>>>>---------------TEST--------------------------------<<<<<<<<<
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

            //insert test
            sond s = new sond() { creator_login = "wstaw", question = "tetst2?", date_end = DateTime.Now.ToString(),
                date_start = DateTime.Now.ToString() };
            Database.AddSond(s);

            //update test
            sond upd = Database.GetSond("where id = 1")[0];
            upd.question = "update test";
            Database.UpdateSond(upd);

            //Delete test
            try
            {
                sond deletesond = Database.GetSond("where id = 3")[0];
                Database.DeleteSond(deletesond);
            }
            catch
            {
                Debug.WriteLine("Brak obiektu");
            }


            //Test userTab
            List<usersTab> userTabAll = Database.GetUsers(); //Test funkcji pobierającej sondy jako liste obiektów
            foreach (usersTab user in userTabAll)
            {
                Debug.WriteLine(user.ToString());
            }

            //>>>>>>>---------------ENDTEST--------------------------------<<<<<<<<<

            Application.Run(new Artysci.Forms.FormLogins());
        }
    }
}
