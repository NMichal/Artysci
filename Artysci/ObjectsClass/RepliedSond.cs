using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artysci.ObjectsClass
{
    class RepliedSond
    {
        public int id { get; set; }
        public int sond_id { get; set; }
        public string user_login { get; set; }

        public override string ToString()
        {
            return string.Format("id: {0} ,sond_id: {1}, user_login: {2}",
                id,sond_id, user_login);
        }
    }
}
