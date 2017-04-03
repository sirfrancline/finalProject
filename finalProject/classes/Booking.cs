using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
     
{
    public class Booking  
    {
      public  string EquipmentID { get; set; }
      public  string StudentId { get; set; }
      public  string EmployeeId { get; set; }
      public  DateTime IssueDate { get; set; }
      public  DateTime ReturnDate { get; set; }
      public bool IsReturned { get; set; }       
        
    }
}


