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
            TabMain.BringToFront();
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
            }
            else
                ucSonds.Instance.BringToFront();
        }

        private void ButtonGrupy_Click(object sender, EventArgs e)
        {
            contentPanel.BringToFront();
            if (!contentPanel.Controls.Contains(ucProfiles.Instance))
            {
                contentPanel.Controls.Add(ucProfiles.Instance);
                ucProfiles.Instance.Dock = DockStyle.Fill;
                ucProfiles.Instance.BringToFront();
            }
            else
                ucProfiles.Instance.BringToFront();
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
    }
}
