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
    public partial class ucAnnouncements : UserControl
    {
        private static ucAnnouncements _instance;

        public static ucAnnouncements Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAnnouncements();
                return _instance;
            }
        }
        public ucAnnouncements()
        {
            InitializeComponent();
        }


    }
}
