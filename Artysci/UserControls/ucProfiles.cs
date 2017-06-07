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
            listView1.Columns.Add("Name", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Type", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Genre", 150, HorizontalAlignment.Left);
      

        }
        public void update()
        {
            listView1.Items.Clear();
            profiles = Database.getAllProfiles();
            string profile_type;
            foreach (Profile profile in profiles)
            {
                if (profile.type == 1) profile_type = "Organizator";
                else profile_type = "Artysta";
                ListViewItem profile1 = new ListViewItem(profile.name);
                profile1.SubItems.Add(profile_type.ToString());
                profile1.SubItems.Add(profile.genre.ToString());
                listView1.Items.Add(profile1);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Debug.WriteLine("HALO MATI");
            panel1.Controls.Remove(pControl);
            index = listView1.SelectedIndices[0];
            pControl = new ProfileControl(profiles[index].name, profiles[index].type == 1 ? "Organizator" : "Artysta" , profiles[index].genre, profiles[index].descr);
            pControl.OpenControl(); 
            panel1.Visible = true;
            panel1.Controls.Add(pControl);
        }

        private void ucProfiles_Load(object sender, EventArgs e)
        {

        }
    }
}
