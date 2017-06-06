using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artysci.Forms
{
    public partial class SondControl : UserControl
    {

        public SondControl() {
            InitializeComponent();
            CloseControl();
        }

        public SondControl(string SondName, string questionString, string odp1, string odp2, string odp3, string odp4)
        {
            InitializeComponent();
            LabelName.Text = SondName;
            LabelQuestion.Text = questionString;
            Odp1.Text = odp1;
            Odp2.Text = odp2;
            Odp3.Text = odp3;
            Odp4.Text = odp4;
            CloseControl();
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
            LabelQuestion.Visible = Odp1.Visible = Odp2.Visible = Odp3.Visible = Odp4.Visible = ButtonSend.Visible = false;
        }

        public void  OpenControl() {

            LabelQuestion.Visible = Odp1.Visible = Odp2.Visible = Odp3.Visible = Odp4.Visible = ButtonSend.Visible = true;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
