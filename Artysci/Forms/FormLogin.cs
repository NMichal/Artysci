using Artysci.ObjectsClass;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            #if (DEBUG)
            {
                loginBox.Text = "admin";
                passwordBox.Text = "admin";
            }
            #endif
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            usersTab user = Database.getUserInfo(loginBox.Text);
            
            if(passwordBox.Text == user.password)
            {
                this.Hide();
                FormMainWindow main = new FormMainWindow(user);
                main.Show();
            }
            else
            {
                MessageBox.Show("Niepoprawne hasło");
            }

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
        }
    }
}
