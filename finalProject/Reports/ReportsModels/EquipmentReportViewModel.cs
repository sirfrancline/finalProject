using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject.Reports.ReportsModels
{
    public class EquipmentReportViewModel
    {
        public Student Borrower { get; set; }
        public Staff Lender { get; set; }
        public Issue LineEntry { get; set; }
    }
}
