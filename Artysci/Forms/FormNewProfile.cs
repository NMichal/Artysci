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
    public partial class FormNewProfile : MaterialForm
    {
        private usersTab user;
        public FormNewProfile(usersTab newUser)
        {
            InitializeComponent();
            user = newUser;
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private bool isFormCorrect()
        {
            if (TextBoxName.Text.Length < 1) return false;
            if (ComboBoxType.Text == "") return false;
            if (TextBoxGenre.Text.Length < 1) return false;
            if (TextBoxDescription.Text.Length < 1) return false;

            return true;
        }

        private void addProfile()
        {
            Profile newProfile = new Profile()
            {
                name = TextBoxName.Text,
                descr = TextBoxDescription.Text,
                type = ComboBoxType.Text == "Organizator" ? 1 : 2,
                genre = TextBoxGenre.Text
            };

            Database.addProfile(newProfile, user);
            CustomMessageBox.Show("Sukces", "Profil dodano do bazy");
            this.Close();

        }

        private void ButtonMake_Click(object sender, EventArgs e)
        {
            if (!isFormCorrect()) CustomMessageBox.Show("Błąd", "Formularz wypełniony niepoprawnie");
            else addProfile();
        }


    }
}
