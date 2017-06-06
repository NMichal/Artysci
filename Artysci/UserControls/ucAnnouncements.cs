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
    public partial class ucAnnouncements : UserControl
    {
        private static ucAnnouncements _instance;

        public static ucAnnouncements Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAnnouncements();
                return _instance;
            }
        }
        public ucAnnouncements()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        ///Wykonywany w momencie otwarcia strony 'Ogłoszenia'.
        ///Pobiera ogłoszenia z bazy i wyświetla je w ListView.
        private void ucAnnouncements_Load(object sender, EventArgs e)
        {
            List<ObjectsClass.Announ> announs_tab = Database.getAnnouns();

            if (announs_tab.Count == 0)
            {
                ListViewItem lvi = new ListViewItem("Brak ogłoszeń w systemie.");
                lvi.SubItems.Add("Brak ogłoszeń w systemie.");
                lvi.SubItems.Add("Brak ogłoszeń w systemie.");
                lvi.SubItems.Add("Brak ogłoszeń w systemie.");
                lvi.SubItems.Add("Brak ogłoszeń w systemie.");
                listView1.Items.Add(lvi);
            }

            for(int i=0; i<announs_tab.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(announs_tab[i].login_user);
                lvi.SubItems.Add(announs_tab[i].type_anoun);
                lvi.SubItems.Add(announs_tab[i].type_looking);
                lvi.SubItems.Add(announs_tab[i].descr);
                lvi.SubItems.Add(announs_tab[i].date);
                listView1.Items.Add(lvi);
            }
        }
    }
}
