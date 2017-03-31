using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace finalProject
{
    class Program
    {

        static void Main(string[] args)
        {
            var _staffOperations = new StaffOperations();
            _staffOperations.Start("staff.txt");

            if (_staffOperations.IsUserAuthorised())
            {
                var collegeHelpDesk = new CollegeEquipmentControl();
                while (true)
                    {
                    collegeHelpDesk.EntryPoint();
                }
            }
            else
            {
                Console.WriteLine($"Bad user/password");
            }
        }
    }
}
