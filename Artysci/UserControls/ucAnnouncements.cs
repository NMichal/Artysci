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
        private List<Announ> announList;
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
            List<ObjectsClass.Announ> announs_tab = Database.getAnnouns();
            announList = Database.getAnnouns();
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
            aControl = new AnnounControl(announList[index].title, announList[index].type_anoun, announList[index].type_looking, announList[index].town, announList[index].date, announList[index].descr, announList[index].id, user);
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
