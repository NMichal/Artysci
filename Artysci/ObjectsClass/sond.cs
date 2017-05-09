using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artysci.ObjectsClass
{
    class sond
    {
        public int id { get; set; }
        public string creator_login { get; set; }
        public string question { get; set; }
        public string date_start { get; set; }
        public string date_end { get; set; }


        public override string ToString()
        {
            return string.Format("id: {0}, creator_login: {1}, question: {2}, date_start: {3}, date_end: {4}",
                id, creator_login, question, date_start, date_end);
        }
    }
}
