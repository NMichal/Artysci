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
    public partial class AnnounControl : UserControl
    {
        public AnnounControl()
        {
            InitializeComponent();
            CloseControl(); 
        }

        public AnnounControl(string name, string lookingFor, string lookingForSpecific, string city, string date, string description)
        {
            InitializeComponent();
            LabelName.Text = name;
            LabelLookFor.Text = lookingFor;
            LabelLookForSpecific.Text = lookingForSpecific;
            LabelCity.Text = city;
            LabelDate.Text = date;
            TextBoxDecription.Text = description;

            CloseControl();
        }

        private void LabelName_Click(object sender, EventArgs e)
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
            LabelLookFor.Visible = LabelCity.Visible = LabelDate.Visible = LabelLookForSpecific.Visible = TextBoxDecription.Visible
                = materialLabel1.Visible = materialLabel3.Visible = materialLabel5.Visible = materialLabel7.Visible = materialLabel9.Visible = materialFlatButton1.Visible = false;
        }
        public void OpenControl() {
            LabelLookFor.Visible = LabelCity.Visible = LabelDate.Visible = LabelLookForSpecific.Visible = TextBoxDecription.Visible
                = materialLabel1.Visible = materialLabel3.Visible = materialLabel5.Visible = materialLabel7.Visible = materialLabel9.Visible = materialFlatButton1.Visible = true;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
