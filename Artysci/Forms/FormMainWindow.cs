using Artysci.ObjectsClass;
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
    public partial class FormMainWindow : Form
    {
        usersTab user;

        public FormMainWindow(usersTab userInfo)
        {
            InitializeComponent();
            this.user = userInfo;
        }
    }
}
