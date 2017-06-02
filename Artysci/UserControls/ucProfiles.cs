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
    public partial class ucProfiles : UserControl
    {
        private static ucProfiles _instance;

        public static ucProfiles Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucProfiles();
                return _instance;
            }
        }
        public ucProfiles()
        {
            InitializeComponent();
        }
    }
}
