using Artysci.ObjectsClass;
using MaterialSkin.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artysci.Forms
{
    public partial class FormLogins : MaterialForm
    {
        public FormLogins()
        {
            InitializeComponent();
            #if (DEBUG)
            {
                LoginTextBox.Text = "admin";
                PasswordTextBox.Text = "admin";
            }
            #endif
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            usersTab user = Database.getUserInfo(LoginTextBox.Text);

            if (PasswordTextBox.Text == user.password)
            {
                var mainForm = new FormMenu();
                mainForm.Show();
                this.Visible = false;

            }
            else
            {
                CustomMessageBox.Show("Błąd", "Niepoprawne hasło");
            }
     
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
        }
    }
}
