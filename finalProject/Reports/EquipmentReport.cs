using finalProject.Persistence.Readers;
using finalProject.Reports.ReportsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject.Reports
{
public  class EquipmentReport
    {
        /*

            _studentOperations.Start();
            _equipmentOperations.Start(@"TextFiles\equipment.txt");
            _staffOperations.Start(@"TextFiles\staff.txt");
            

         */

        RentalReader _rentaReader = new RentalReader();

        public List<EquipmentReportViewModel> GetEquipmentUsage(string id) {

            var rentals = _rentaReader.GetRentalsByEquipmentId(id);

            var studentIds = rentals.Select(st => st.StudentId).Distinct().ToList();
            var empIds = rentals.Select(st => st.EmployeeId).Distinct().ToList();




            return null;
        }
    }
}
