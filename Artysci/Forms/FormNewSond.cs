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
    public partial class FormNewSond : MaterialForm
    {
        private usersTab user;
        int value;
        List<MaterialLabel> answerLabels = new List<MaterialLabel>();
        List<MaterialSingleLineTextField> textFields = new List<MaterialSingleLineTextField>();
        public FormNewSond(usersTab newUser)
        {
            InitializeComponent();
            answerLabels.Add(LabelAnswer1);
            answerLabels.Add(LabelAnswer2);
            answerLabels.Add(LabelAnswer3);
            answerLabels.Add(LabelAnswer4);


            textFields.Add(TextFieldAnswer1);
            textFields.Add(TextFieldAnswer2);
            textFields.Add(TextFieldAnswer3);
            textFields.Add(TextFieldAnswer4);

            user = newUser;

            SetVisible();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SetVisible();   
        }

        private void SetVisible() {
            value = (int)numericUpDown1.Value;
            for (int i = 0; i < textFields.Count(); i++)
            {
                if (i < value)
                {
                    answerLabels[i].Visible = true;
                    textFields[i].Visible = true;
                }
                else
                {
                    answerLabels[i].Visible = false;
                    textFields[i].Visible = false;
                    textFields[i].Text = "";
                }
            }
        }

        private bool isFormCorrect()
        {
            if (TextFieldQuestion.Text.Length < 1) return false;
            for (int i = 0; i < value; i++)
            {
                if (textFields[i].Text.Length < 1) return false;
            }

            return true;
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (!isFormCorrect()) CustomMessageBox.Show("Błąd", "Nie poprawnie wypełniony formularz");
            else addSond();
        }

        private void addSond()
        {
            List<sondChoice> answers = new List<sondChoice>();
            sond sonda = new sond();
            sonda.question = TextFieldQuestion.Text;
            sonda.date_start = DateTime.Today.Date.ToString();
            sonda.date_end = DateTime.Today.AddDays(7).Date.ToString();
            sonda.creator_login = user.login;

            for (int i = 0; i < value; i++)
            {
                answers.Add(new sondChoice
                {
                    answer = textFields[i].Text
                });
            }
            Debug.WriteLine(sonda.ToString());
            foreach (sondChoice item in answers)
            {
                Debug.WriteLine(item.ToString());
            }
            Database.AddSond(sonda, answers);
            
        }
    }
}
