using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artysci.UserControls
{
    public partial class ucSonds : UserControl
    {
        private static ucSonds _instance;

        public static ucSonds Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSonds();
                return _instance;
            }
        }
        public ucSonds()
        {
            InitializeComponent();
        }

    
    }
}
