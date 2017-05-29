using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Artysci
{
    public partial class CustomMessageBox : MaterialForm
    {

        public CustomMessageBox(string title, string description)
        {
            InitializeComponent();
            //this.ClientSize = new Size(100, 200);
            this.Text = title;

            MaterialFlatButton button = new MaterialFlatButton() { Text = "OK" };
            MaterialLabel label = new MaterialLabel() { Text = description };

            int padding = 10;
           
            label.SetBounds(padding, 70, description.Length*8, 30);
            //label.AutoSize = true;


            button.DialogResult = DialogResult.OK;
            button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button.AutoSize = false;

            this.ClientSize = new Size(label.Right+padding, label.Bottom+60);

            button.SetBounds(this.Right - 60 - padding, label.Bottom +10, 60, 40);
            this.Controls.AddRange(new Control[] { button, label });
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Sizable = false;
            this.AcceptButton = button;
        }
   
        public static void Show(string title, string description)
        {
            // using construct ensures the resources are freed when form is closed
            using (var form = new CustomMessageBox(title, description))
            {
                form.ShowDialog();
            }
        }
    }
}
