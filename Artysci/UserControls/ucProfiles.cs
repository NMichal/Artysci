using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artysci.UserControls
{
    public partial class ucProfiles : UserControl
    {
        private static ucProfiles _instance;

        public static ucProfiles Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucProfiles();
                return _instance;
            }
        }
        public ucProfiles()
        {
            InitializeComponent();
        }

        ///Wykonywany w momencie otwarcia strony 'Prifle'.
        ///Pobiera wszystkie profile z bazy i wyświetla je w ListView.
        private void ucProfiles_Load(object sender, EventArgs e)
        {
            List<ObjectsClass.Profile> profiles_tab = Database.getAllProfiles();

            if (profiles_tab.Count == 0)
            {
                ListViewItem lvi = new ListViewItem("Brak ogłoszeń w systemie.");
                lvi.SubItems.Add("Brak ogłoszeń w systemie.");
                lvi.SubItems.Add("Brak ogłoszeń w systemie.");
                lvi.SubItems.Add("Brak ogłoszeń w systemie.");
                lvi.SubItems.Add("Brak ogłoszeń w systemie.");
                listView1.Items.Add(lvi);
            }

            for (int i = 0; i < profiles_tab.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(profiles_tab[i].name);
                lvi.SubItems.Add("Tu będzie typ");  //Typy są INT więc trzeba zmienić jak inty będą coś reprezentować.
                lvi.SubItems.Add(profiles_tab[i].genre);
                lvi.SubItems.Add(profiles_tab[i].descr);
                listView1.Items.Add(lvi);
            }
        }
    }
}
