using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class Booking  
    {
        string EquipmentID { get; set; }
        string StudentId { get; set; }
        string Fname { get; set; }
        string LastName { get; set; }
        DateTime IssueDate { get; set; }
        DateTime ReturnDate { get; set; }

        public Booking(string EId, string SId, string fname, string surname, DateTime issue, DateTime returnDate)
        {
            this.EquipmentID = EId;
            this.StudentId = SId;
            this.Fname = fname;
            this.LastName = surname;
            this.IssueDate = issue;
            this.ReturnDate = returnDate;
        }

        public void Display()
        {
            Console.WriteLine(EquipmentID + " " + StudentId + " " + Fname + " " + LastName + " " + IssueDate + " " + ReturnDate);
        }
    }
}