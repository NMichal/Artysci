﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Artysci.ObjectsClass;
using System.Diagnostics;

namespace Artysci.Forms
{
    public partial class SondControl : UserControl
    {
        List<MaterialSkin.Controls.MaterialRadioButton> odp = new List<MaterialSkin.Controls.MaterialRadioButton>();
        int choicesCount;
        public SondControl() {
            InitializeComponent();
            CloseControl();
        }

        public SondControl(string SondName, string questionString, List<sondChoice> choices)//string odp1, string odp2, string odp3, string odp4)
        {
            InitializeComponent();
            choicesCount = choices.Count;
            //rText = "ala";
            // r.Visible = false;
            Odp1.Visible = false;
            Odp2.Visible = false;
            Odp3.Visible = false;
            Odp4.Visible = false;
            odp.Add(Odp1);
            odp.Add(Odp2);
            odp.Add(Odp3);
            odp.Add(Odp4);
         
            LabelName.Text = SondName;
            LabelQuestion.Text = questionString;
            for (int i = 0; i < choices.Count; i++)
            {
                odp[i].Text = choices[i].answer;
                //odp[i].Visible = true;
            }

            //CloseControl();
        }

        private void PanelTitle_Click(object sender, EventArgs e)
        {
            if ((string)this.Tag == "Open")
            {
                CloseControl();
                this.Tag = "Closed";
            }
            else if ((string)this.Tag == "Closed")
            {
                OpenControl();
                this.Tag = "Open";
            }
        }

        public void CloseControl() {
            LabelQuestion.Visible = ButtonSend.Visible = false;
            for (int i = 0; i < choicesCount; i++)
            {
                odp[i].Visible = false;
            }

        }

        public void  OpenControl() {

            LabelQuestion.Visible = ButtonSend.Visible = true;
            for (int i = 0; i < choicesCount; i++)
            {
                odp[i].Visible = true;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
