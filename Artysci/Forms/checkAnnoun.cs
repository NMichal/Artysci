using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Artysci.ObjectsClass;

namespace Artysci.Forms
{
    public partial class checkAnnoun : MaterialForm
    {
        int id;
        List<appliedAnnoun> app;
        public checkAnnoun(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private void checkAnnoun_Load(object sender, EventArgs e)
        {
            app = new List<appliedAnnoun>();
            app = Database.getAppliedByID(id);

            foreach (appliedAnnoun item in app)
            {
                ListViewItem temp = new ListViewItem(item.user_login);
                temp.SubItems.Add(item.agreed == 0 ? "Nie" : "Tak" );

                appLV.Items.Add(temp);
            }
                       
        }
    }
}
