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
using Artysci.UserControls;
using Artysci.ObjectsClass;
using System.Diagnostics;

namespace Artysci.Forms
{
    public partial class FormMenu : MaterialForm
    {
        private usersTab user;
        List<ProfileLogin> profilesLoginsList;
        List<Profile> profilesList;
        List<ProfileControl> profileControls;

        public FormMenu(usersTab newUser)
        {
            InitializeComponent();
            SetCustomStyle();
            user = newUser;
            getUserAnnounces();
            getUserProfiles();
            getUserSonds();
        }

        private void SetCustomStyle() {
            ButtonGrupy.AutoSize = false;
            ButtonOgloszenia.AutoSize = false;
            ButtonSondy.AutoSize = false;

            ButtonOgloszenia.Size = new Size(98, 40);
            ButtonSondy.Size = new Size(98, 40);
            ButtonGrupy.Size = new Size(98, 40);
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(TabMain.SelectedIndex);
            switch (TabMain.SelectedIndex) {
                case 0:
                    Console.WriteLine("Anonse");
                    getUserAnnounces();
                    break;
                case 1:
                    Console.WriteLine("Sondy");
                    getUserSonds();
                    break;
                case 2:
                    Console.WriteLine("Profile");
                    getUserProfiles();
                    break;
            }
            TabMain.BringToFront();
        }

        public void getUserAnnounces()
        {
            List<Announ> annList = new List<Announ>();
            List<AnnounControl>announControls = new List<AnnounControl>();
            foreach (Announ ann in Database.getAnnouns())
            {
                if (ann.login_user == user.login)
                {
                    annList.Add(ann);
                }
            }
            for (int i = 0; i < annList.Count; i++)
            {
                AnnounControl newCtr = new AnnounControl(annList[i].title, annList[i].type_anoun, annList[i].type_looking, annList[i].town, annList[i].date, annList[i].descr, annList[i].id, user);
                newCtr.changeButtonText();
                announControls.Add(newCtr);
                announControls[i].Location = new Point(announControls[i].Location.X, announControls[i].Location.Y + i * 40);
                PanelAnnoun.Controls.Add(announControls[i]);
            }
        }

        public void getUserSonds()
        {
            List<sond> sondList = new List<sond>();
            List<SondControl> sondControls = new List<SondControl>();
            List<sondChoice> SondChoiceList = new List<sondChoice>();
            
            foreach (sond item in Database.GetSonds())
            {
                if (item.creator_login == user.login)
                {
                    sondList.Add(item);
                }
            }
            for (int i = 0; i < sondList.Count; i++)
            {
                SondChoiceList = Database.getSondChoices(sondList[i]);
                sondControls.Add(new SondControl(sondList[i].name, sondList[i].question, SondChoiceList));
                sondControls[i].Location = new Point(sondControls[i].Location.X, sondControls[i].Location.Y + i * 40);
                PanelSonds.Controls.Add(sondControls[i]);
            }

        }

        public void getUserProfiles()
        {
            profileControls = new List<ProfileControl>();
            profilesLoginsList = Database.getAllUserProfiles(user);
            profilesList = new List<Profile>();

            foreach (ProfileLogin profileLogin in profilesLoginsList)
            {
                profilesList.Add(Database.getAllProfiles(profileLogin.id_profile)[0]);
            }
            for (int i = 0; i < profilesList.Count; i++)
            {
                profileControls.Add(new ProfileControl(profilesList[i].name, profilesList[i].type == 1 ? "Organizator" : "Artysta", profilesList[i].genre, profilesList[i].descr));
                profileControls[i].Location = new Point(profileControls[i].Location.X, profileControls[i].Location.Y + i * 40);
                PanelProfiles.Controls.Add(profileControls[i]);
            }

        }

        private void ButtonOgloszenia_Click(object sender, EventArgs e)
        {
            contentPanel.BringToFront();
            if (!contentPanel.Controls.Contains(ucAnnouncements.Instance))
            {
                contentPanel.Controls.Add(ucAnnouncements.Instance);
                ucAnnouncements.Instance.Dock = DockStyle.Fill;
                ucAnnouncements.Instance.BringToFront();
            }
            else
                ucAnnouncements.Instance.BringToFront();
            ucAnnouncements.Instance.setUser(user);
        }

        private void ButtonSondy_Click(object sender, EventArgs e)
        {
            contentPanel.BringToFront();
            if (!contentPanel.Controls.Contains(ucSonds.Instance))
            {
                contentPanel.Controls.Add(ucSonds.Instance);
                ucSonds.Instance.Dock = DockStyle.Fill;
                ucSonds.Instance.BringToFront();
                ucSonds.Instance.update();
            }
            else
            {
                ucSonds.Instance.update();
                ucSonds.Instance.BringToFront();
            }
        }

        private void ButtonGrupy_Click(object sender, EventArgs e)
        {
            contentPanel.BringToFront();
            if (!contentPanel.Controls.Contains(ucProfiles.Instance))
            {
                contentPanel.Controls.Add(ucProfiles.Instance);
                ucProfiles.Instance.Dock = DockStyle.Fill;
                ucProfiles.Instance.BringToFront();
                ucProfiles.Instance.update();
            }
            else
            {
                ucProfiles.Instance.update();
                ucProfiles.Instance.BringToFront();
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        { 
        }


        private void materialLabel4_Click(object sender, EventArgs e)
        {
            var newProfile = new FormNewProfile(user);
            newProfile.Show();
        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {
            var newAnoun = new FormNewAnnouncement(user);
            newAnoun.Show();

        }

        private void TabMain_Click(object sender, EventArgs e)
        {

        }

        public void refreshButton_Click(object sender, EventArgs e)
        {
            getUserAnnounces();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            FormNewSond sond = new FormNewSond(user);
            sond.Show();
        }
    }
}
