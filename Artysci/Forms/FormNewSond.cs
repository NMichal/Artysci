﻿using MaterialSkin.Controls;
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
    public partial class FormNewSond : MaterialForm
    {
        List<MaterialLabel> answerLabels = new List<MaterialLabel>();
        List<MaterialSingleLineTextField> textFields = new List<MaterialSingleLineTextField>();
        public FormNewSond()
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

            SetVisible();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SetVisible();   
        }

        private void SetVisible() {
            int value = (int)numericUpDown1.Value;
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
    }
}