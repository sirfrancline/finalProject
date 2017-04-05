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

        StaffReader _staffReader = new StaffReader();
       RentalReader _rentaReader = new RentalReader();
        StudentReader _studentReader = new StudentReader();


        public List<EquipmentReportViewModel> GetEquipmentUsage(string id) {

            var rentals = _rentaReader.GetRentalsByEquipmentId(id);            
            var staffMembers = _staffReader.GetStuffMembers();
            var students = _studentReader.GetStudents();

            var list = new List<EquipmentReportViewModel>();
            foreach (var item in rentals)
            {
                var lineItem = new EquipmentReportViewModel {
                    LineEntry = item,
                    Lender = staffMembers[item.EmployeeId],
                    Borrower = students[item.StudentId]            
                };

                list.Add(lineItem);
            }

            return list;
        }
    }
}
