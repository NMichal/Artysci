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
using System.Diagnostics;

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
            updateLvANDList();
        }

        private void updateLvANDList()
        {
            appLV.Items.Clear();
            app = new List<appliedAnnoun>();
            app = Database.getAppliedByID(id);

            foreach (appliedAnnoun item in app)
            {
                ListViewItem temp = new ListViewItem(item.user_login);
                temp.SubItems.Add(item.agreed == 0 ? "Nie" : "Tak");

                appLV.Items.Add(temp);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            applyUser();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            deleteApplied();
        }

        private void deleteApplied()
        {
            
            //sprawdz czy ktoś jest zatwierdzony
            bool isApplySome = false;
            foreach (appliedAnnoun item in app)
            {
                if (item.agreed == 1)
                {
                    isApplySome = true;
                }
            }
            if (!isApplySome)
            {
                CustomMessageBox.Show("Blad", "Nikt nie jest zatwierdzony!");
                return;
            }

            Database.setNotAgreed(app[0]);
            updateLvANDList();
            CustomMessageBox.Show("Sukces","Usunięto zatwierdzenie");

        }

        private void appLV_DoubleClick(object sender, EventArgs e)
        {
            applyUser();

        }

        private void applyUser()
        {
            int index = -1;
            try
            { 
                index = appLV.SelectedIndices[0];
            }catch
            {
                CustomMessageBox.Show("Blad", "Musisz wybrać kogoś z listy");
                return;
            }
            //sprawdz czy ktoś jest zatwierdzony
            foreach (appliedAnnoun item in app)
            {
                if (item.agreed == 1)
                {
                    CustomMessageBox.Show("Blad", "Już ktoś jest zatwierdzony");
                    return;
                }
            }

            Database.setAgreed(app[index]);
            updateLvANDList();
            CustomMessageBox.Show("Sukces", "Zatwierdzono użytkownika");
            
        }
    }
}
