using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artysci
{
    class Database
    {
        public static void ConnectDatabase()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Artysci;User ID=Ankieter;Password=sa";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}
