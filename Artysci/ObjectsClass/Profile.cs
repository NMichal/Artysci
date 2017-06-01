using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artysci.ObjectsClass
{
    class Profile
    {
        public int id { get; set; }
        public string name { get; set; }
        public string descr { get; set; }
        public string genre { get; set; }
        public string example { get; set; }

        public override string ToString()
        {
            return string.Format("id: {0}, name: {1}, descr: {2}, genre: {3}, example: {4} ", id, name, descr, genre, example);
            
        }

    }
}
