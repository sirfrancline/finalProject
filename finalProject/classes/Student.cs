using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    public class Student : Person
    {
        public string Course { get; set; }

        public Student() : base()
        {

        }
        public Student(string id, string fname, string surname, string course) : base(fname, surname, id)
        {
            this.Course = course;
        }

        public override void Display()
        {
            Console.WriteLine(IdNumber + " " + FirstName + " " + Surname + " " + Course);
        }

        /* public void ReportTransaction()
         {

         } */
    }
}

