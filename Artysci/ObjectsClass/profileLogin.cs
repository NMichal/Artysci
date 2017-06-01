using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artysci.ObjectsClass
{
    class ProfileLogin
    {
        public int id_profile { get; set; }
        public string login_user { get; set; }

        public override string ToString()
        {
            return string.Format("id: {0), login_user: {1}", id_profile, login_user);
        }
    }
}
