using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    public class Staff : Person
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Staff() : base()
        {

        }
        public Staff(string id, string fname, string lastname, string username, string password) : base(fname, lastname, id)
        {
            this.Username = username;
            this.Password = password;
        }
        public override void Display()
        {
            base.Display();
        }
    }
}
