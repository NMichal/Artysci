using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artysci.ObjectsClass
{
    class usersTab
    {
        public string login { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string town { get; set; }
        public int age { get; set; }
        //public ?? image { get; set; } //jakiego typu
        public string state { get; set; }
        public string groups { get; set; }


        public override string ToString()
        {
            return string.Format("login: {0}, password: {1}, email: {2}, name: {3}, surname: {4}, town: {5}, age: {6}, state: {7}, groups: {8}",
                login, password, email, name, surname, town, age, state, groups);
        }
    }
}
