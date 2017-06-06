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
    public partial class FormNewAnnouncement : MaterialForm
    {
        private usersTab user;
        private List<Profile> profileList = new List<Profile>();
        public FormNewAnnouncement(usersTab newUser)
        {
            user = newUser;
            InitializeComponent();
            getUserProfiles();
          
        }

        private void getUserProfiles()
        {
            List<ProfileLogin> profilesLogin = Database.getAllUserProfiles(user);
            foreach (ProfileLogin item in profilesLogin)
            {
                profileList.Add(Database.getProfile(item.id_profile));
                comboBoxProfile.Items.Add(profileList[profileList.Count - 1].name);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (!isFormCorrect()) CustomMessageBox.Show("Błąd", "Nie poprawnie wypełniony formularz");
            else addAnoun();
        }


        private bool isFormCorrect()
        {
            if (TextBoxName.Text.Length < 1) return false;
            if (ComboBoxTypeAnoun.Text == "") return false;
            if (comboBoxProfile.Text == "") return false;
            if (TextBoxTypeLooking.Text.Length < 1) return false;
            if (TextBoxCity.Text.Length < 1) return false;
            if (TextBoxDescription.Text.Length < 1) return false;

            return true;
        }

        /// <summary>
        /// Metoda dodajaca ogloszenie
        /// </summary>
        private void addAnoun()
        {
            Announ newAnnoun = new Announ();
            newAnnoun.login_user = user.login;
            newAnnoun.title = TextBoxName.Text;
            newAnnoun.type_anoun = ComboBoxTypeAnoun.Text;
            newAnnoun.type_looking = TextBoxTypeLooking.Text;
            newAnnoun.descr = TextBoxDescription.Text;
            newAnnoun.date = DatePicker.Text.ToString();
            newAnnoun.town = TextBoxCity.Text;

            for (int i = 0; i < profileList.Count; i++)
            {
                if (profileList[i].name == comboBoxProfile.Text)
                {
                    newAnnoun.profile_id = profileList[i].id;
                    break;
                }
            }

            Debug.WriteLine(newAnnoun.ToString());

            Database.addAnnon(newAnnoun);
            CustomMessageBox.Show("Sukces", "Ogłoszenie dodano do bazy");
            this.Close();
        }
    }
}
