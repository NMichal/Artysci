using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Artysci.ObjectsClass;
using System.Diagnostics;
using Artysci.Forms;

namespace Artysci.UserControls
{
    public partial class ucAnnouncements : UserControl
    {
        private static ucAnnouncements _instance;
        private List<Announ> announs_tab = new List<Announ>();
        AnnounControl aControl;
        int index;
        usersTab user;

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


        ///Wykonywany w momencie otwarcia strony 'Ogłoszenia'.
        ///Pobiera ogłoszenia z bazy i wyświetla je w ListView.
        private void ucAnnouncements_Load(object sender, EventArgs e)
        {
             announs_tab = Database.getAnnouns();
            
            for (int i = 0; i < announs_tab.Count; i++)
            {
                if (announs_tab[i].second_login_user != "NULL") announs_tab.RemoveAt(i);
            }
            
                
            
            if (announs_tab.Count == 0)
            {
                ListViewItem lvi = new ListViewItem("Brak ogłoszeń w systemie.");
                lvi.SubItems.Add("Brak ogłoszeń w systemie.");
                lvi.SubItems.Add("Brak ogłoszeń w systemie.");
                lvi.SubItems.Add("Brak ogłoszeń w systemie.");
                lvi.SubItems.Add("Brak ogłoszeń w systemie.");
                listView1.Items.Add(lvi);
            }
            
            for (int i = 0; i < announs_tab.Count; i++)
            {
                if (announs_tab[i].second_login_user != "NULL")
                {
                    announs_tab.RemoveAt(i);
                    continue;
                }
                ListViewItem lvi = new ListViewItem(announs_tab[i].login_user);
                lvi.SubItems.Add(announs_tab[i].type_anoun);
                lvi.SubItems.Add(announs_tab[i].type_looking);
                lvi.SubItems.Add(announs_tab[i].descr);
                lvi.SubItems.Add(announs_tab[i].date);
                listView1.Items.Add(lvi);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            annPanel.Controls.Remove(aControl);
            index = listView1.SelectedIndices[0];
            aControl = new AnnounControl(announs_tab[index].title, announs_tab[index].type_anoun, announs_tab[index].type_looking, announs_tab[index].town, announs_tab[index].date, announs_tab[index].descr, announs_tab[index].id, user);
            aControl.OpenControl();
            annPanel.Visible = true;
            annPanel.Controls.Add(aControl);
        }

        public void setUser(usersTab newUser)
        {
            user = newUser;
        }
    }
}
