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
using Artysci.Forms;
using System.Diagnostics;

namespace Artysci.UserControls
{
    public partial class ucSonds : UserControl
    {
        List<sond> SondList;
        SondControl sControl;
        int index;
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
            sondPanel.Visible = false;
            listViewSonds.View = View.Details;
            listViewSonds.Columns.Add("Name", 200,HorizontalAlignment.Center);
            listViewSonds.Columns.Add("Login twórcy", 200, HorizontalAlignment.Center);
        }

        public void update()
        {
            listViewSonds.Items.Clear();
            SondList = Database.GetSonds();
            foreach (sond sond in SondList)
            {
                ListViewItem sond1 = new ListViewItem(sond.question);
                sond1.SubItems.Add(sond.creator_login);
                listViewSonds.Items.Add(sond1);
            }

        }

        private void listViewSonds_DoubleClick(object sender, EventArgs e)
        {
            Debug.WriteLine("halo");
            sondPanel.Controls.Remove(sControl);
            index = listViewSonds.SelectedIndices[0];
            sControl = new SondControl("Penis", SondList[index].question, "Lukasz", "Widuch", "Debil", "Nie pozdrawiam");
            sControl.OpenControl();
            sondPanel.Visible = true;
            sondPanel.Controls.Add(sControl);
        }
    }
}
