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
    public partial class ucProfiles : UserControl
    {
        private List<Profile> profiles;
        private static ucProfiles _instance;
        private int index;
        ProfileControl pControl = new ProfileControl();

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
            panel1.Visible = false;
            listView1.View = View.Details;
            listView1.Columns.Add("Name", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Type", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Genre", 60, HorizontalAlignment.Left);
            profiles = Database.getAllProfiles();
            foreach (Profile profile in profiles)
            {
                ListViewItem profile1 = new ListViewItem(profile.name);
                profile1.SubItems.Add(profile.type.ToString());
                profile1.SubItems.Add(profile.genre.ToString());
                listView1.Items.Add(profile1);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            panel1.Controls.Remove(pControl);
            //if (listView1.SelectedItems != null)
            index = listView1.SelectedIndices[0];
            pControl = new ProfileControl(profiles[index].type == 1 ? "Organizator" : "Artysta" , profiles[index].genre, profiles[index].descr);
            pControl.OpenControl();
            panel1.Visible = true;
            panel1.Controls.Add(pControl);
           

        }
    }
}
