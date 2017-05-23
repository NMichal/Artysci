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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

     

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == "") errPassLabel.Visible = true;
            else errPassLabel.Visible = false;
            if (loginBox.Text == "") errLoginLabel.Visible = true;
            else errLoginLabel.Visible = false;
            if (repasswordBox.Text == "") errRePassLabel.Visible = true;
            else errRePassLabel.Visible = false;
            if (emailBox.Text == "") errEmailLabel.Visible = true;
            else errEmailLabel.Visible = false;

            if ((passwordBox.Text == repasswordBox.Text) &&
                !errRePassLabel.Visible && !errPassLabel.Visible && !errLoginLabel.Visible)
            {
                if (Database.isLoginAvaible(loginBox.Text))
                {
                    if (Database.addUser(loginBox.Text, passwordBox.Text, emailBox.Text))
                    {
                        MessageBox.Show("Konto zostało założone poprawnie.\nMożesz zalogować się na swoje konto", "Błąd");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Konto nie zostało założone, spróbuj ponownie później", "Błąd");
                    }
                }
                else
                {
                    MessageBox.Show("Podany login jest już zajęty!", "Błąd");
                }
            }
            else if(passwordBox.Text != repasswordBox.Text)
            {
                MessageBox.Show("Podane hasła nie są takie same", "Błąd");
            }
        }
    }
}
