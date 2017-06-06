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

namespace Artysci.Forms
{
    public partial class AnnounControl : UserControl
    {
        int id;
        usersTab user;
        public AnnounControl()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(54, 71, 79);
            CloseControl(); 
        }

        public AnnounControl(string name, string lookingFor, string lookingForSpecific, string city, string date, string description, int announid, usersTab newUser)
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(54, 71, 79);
            LabelName.Text = name;
            LabelLookFor.Text = lookingFor;
            LabelLookForSpecific.Text = lookingForSpecific;
            LabelCity.Text = city;
            LabelDate.Text = date;
            TextBoxDecription.Text = description;
            id = announid;
            user = newUser;

            CloseControl();
        }

        private void LabelName_Click(object sender, EventArgs e)
        {
            if ((string)this.Tag == "Open")
            {
                CloseControl();
                this.Tag = "Closed";
            }
            else if ((string)this.Tag == "Closed")
            {
                OpenControl();
                this.Tag = "Open";
            }
        }

        public void CloseControl() {
            LabelLookFor.Visible = LabelCity.Visible = LabelDate.Visible = LabelLookForSpecific.Visible = TextBoxDecription.Visible
                = materialLabel1.Visible = materialLabel3.Visible = materialLabel5.Visible = materialLabel7.Visible = materialLabel9.Visible = ButtonOdpowiedz.Visible = false;
        }
        public void OpenControl() {
            LabelLookFor.Visible = LabelCity.Visible = LabelDate.Visible = LabelLookForSpecific.Visible = TextBoxDecription.Visible
                = materialLabel1.Visible = materialLabel3.Visible = materialLabel5.Visible = materialLabel7.Visible = materialLabel9.Visible = ButtonOdpowiedz.Visible = true;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void ButtonOdpowiedz_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("login " + user.login + " id " + id);
            //sprawdz czy to ja stworzylem
            Announ announ = Database.getAnnounById(id);
            if (announ.login_user == user.login)
            {
                CustomMessageBox.Show("Blad", "Nie możesz się zgłosić do własnego ogłoszenia!");
                return;
            }
            // sprawdz czy juz sie zglosilem
            if (Database.isUserApplied(id, user))
            {
                CustomMessageBox.Show("Blad", "Już zgłosiłeś się do tego ogłoszenia");
                return;
            }

            appliedAnnoun app = new appliedAnnoun() { user_login = user.login, announ_id = id, agreed = 0 };

            Database.addApplyAnnoun(app);
            CustomMessageBox.Show("Sukces", "Odpowiedź zapisana pomyślnie");
        }
    }
}
