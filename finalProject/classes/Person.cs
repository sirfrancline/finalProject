using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    public class Person
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string IdNumber { get; set; }

        public Person()
        {

        }
        public Person(string fname, string surname, string id)
        {
            this.FirstName = fname;
            this.Surname = surname;
            this.IdNumber = id;
        }

        public virtual void Display()
        {
            Console.WriteLine(IdNumber + " " + FirstName + " " + Surname);
        }

    }


}

