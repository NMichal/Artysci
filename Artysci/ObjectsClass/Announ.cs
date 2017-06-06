using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artysci.ObjectsClass
{
    class Announ
    {
        public int id { get; set; }
        public string login_user { get; set; }
        public string title { get; set; }
        public string town { get; set; }
        public int profile_id { get; set; }
        public string date { get; set; }
        public string descr { get; set; }
        public string type_anoun { get; set; }
        public string type_looking { get; set; }

        public override string ToString()
        {
            return string.Format("id: {0}, login_user: {1}, profile_id: {2}, date: {3}, descr: {4}, type_anoun: {5}, type_looking: {6}, town: {7}, title: {8}",
                id, login_user, profile_id, date, descr, type_anoun, type_looking, town, title);
        }
    }
}
