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

namespace Artysci.Forms
{
    public partial class FormMenu : MaterialForm
    {
        private usersTab user;
        public FormMenu(usersTab newUser)
        {
            InitializeComponent();
            SetCustomStyle();
            user = newUser;
            GenerateAnnounList();
            GenerateProfiles();
            GenerateSondList();
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
                    Console.WriteLine("Sondy");
                    GenerateSondList();
                    break;
                case 1:
                    Console.WriteLine("Profile");
                    GenerateProfiles();
                    break;
                case 2:
                    Console.WriteLine("Anonse");
                    GenerateAnnounList();
                    break;
            }
            TabMain.BringToFront();
        }

        private void GenerateProfiles()
        {
            ProfileControl p1 = new ProfileControl("Malarz Barto","Artysta", "Malarz", "a mauluje se");
            ProfileControl p2 = new ProfileControl("Szef cyrku", "Organizator", "Akrobata", "można robic akrobacja");
            ProfileControl p3 = new ProfileControl("Beka","Artysta", "Dekarz", "klepie dechy");

            p2.Location = new Point(p2.Location.X, p1.Location.Y + 40);
            p3.Location = new Point(p3.Location.X, p2.Location.Y + 40);
            

            PanelProfiles.Controls.Add(p1);
            PanelProfiles.Controls.Add(p2);
            PanelProfiles.Controls.Add(p3);
        }

        private void GenerateAnnounList()
        {
            AnnounControl a1 = new AnnounControl("Nazwa", "osoba", "miesza bigos glowa", "Kato", "jutro", "No");
            AnnounControl a2 = new AnnounControl("Nazwa inna", "osoba", "miesza bigos glowa", "Kato", "jutro", "No");
            AnnounControl a3 = new AnnounControl("Nazwa a tam", "osoba", "miesza bigos glowa", "Kato", "jutro", "No");

            a2.Location = new Point(a2.Location.X, a2.Location.Y + 40);
            a3.Location = new Point(a2.Location.X, a2.Location.Y + 40);

            PanelAnnoun.Controls.Add(a1);
            PanelAnnoun.Controls.Add(a2);
            PanelAnnoun.Controls.Add(a3);
        }

        private void GenerateSondList()
        {

            SondControl s1 = new SondControl("Pierwsa", "pytanie?", "o1", "o2", "o3", "o4");
            SondControl s2 = new SondControl("Druga", "pytanie2?", "o1", "o2", "o3", "o4");
            SondControl s3 = new SondControl("Pierwsa", "pytanie?", "o1", "o2", "o3", "o4");
            SondControl s4 = new SondControl("Druga", "pytanie2?", "o1", "o2", "o3", "o4");
            SondControl s5 = new SondControl("Pierwsa", "pytanie?", "o1", "o2", "o3", "o4");
            SondControl s6 = new SondControl("Druga", "pytanie2?", "o1", "o2", "o3", "o4");

            s2.Location = new Point(s2.Location.X, s1.Location.Y + 40);
            s3.Location = new Point(s2.Location.X, s1.Location.Y + 40 * 2);
            s4.Location = new Point(s2.Location.X, s1.Location.Y + 40 * 3);
            s5.Location = new Point(s2.Location.X, s1.Location.Y + 40 * 4);
            s6.Location = new Point(s2.Location.X, s1.Location.Y + 40 * 5);
            PanelSonds.Controls.Add(s1);
            PanelSonds.Controls.Add(s2);
            PanelSonds.Controls.Add(s3);
            PanelSonds.Controls.Add(s4);
            PanelSonds.Controls.Add(s5);
            PanelSonds.Controls.Add(s6);
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

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            var newSond = new FormNewSond(user);
            newSond.Show();
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
    }
}
