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
    public partial class ProfileControl : UserControl
    {
        public ProfileControl() {
            InitializeComponent();
            CloseControl();
        }

        public ProfileControl(string ProfileTypeString, string TypeString, string Description)
        {
            InitializeComponent();
            LabelProfileType.Text = ProfileTypeString;
            LabelType.Text = TypeString;
            TextBoxDescription.Text = Description;
            CloseControl();
        }

        private void PanelTitle_Click(object sender, EventArgs e)
        {
            if ((string)this.Tag == "Open")
            {
                CloseControl();
                this.Tag = "Closed";
            }
            else if ((string)this.Tag == "Closed") {
                OpenControl();
                this.Tag = "Open";
            }
        }

        public void CloseControl() {
            LabelOpis.Visible = LabelTworczosc.Visible = LabelTyp.Visible = LabelOpis.Visible = LabelOpis.Visible = LabelProfileType.Visible = LabelType.Visible = TextBoxDescription.Visible = false;
        }

        public void OpenControl() {
            LabelOpis.Visible = LabelTworczosc.Visible = LabelTyp.Visible = LabelOpis.Visible = LabelOpis.Visible = LabelProfileType.Visible = LabelType.Visible = TextBoxDescription.Visible = true;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
