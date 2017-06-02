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

namespace Artysci.Forms
{
    public partial class FormMenu : MaterialForm
    {
        public FormMenu()
        {
            InitializeComponent();
            SetCustomStyle();
        }

        private void SetCustomStyle() {
            ButtonGrupy.AutoSize = false;
            ButtonOgloszenia.AutoSize = false;
            ButtonSondy.AutoSize = false;

            ButtonOgloszenia.Size = new Size(98, 40);
            ButtonSondy.Size = new Size(98, 40);
            ButtonGrupy.Size = new Size(98, 40);
        }
    }
}
