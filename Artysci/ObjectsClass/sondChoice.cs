using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artysci.ObjectsClass
{
    public class sondChoice
    {
        public int id { get; set; }
        public int sond_id { get; set; }
        public string answer { get; set; }

        public override string ToString()
        {
            return string.Format("id: {0}, sond_id: {1}, answer: {2}",
                id, sond_id, answer);
        }
    }
}
