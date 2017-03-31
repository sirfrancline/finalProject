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

            var collegeHelpDesk = new CollegeEquipmentControl();

            while(true)

            {

                collegeHelpDesk.EntryPoint();

            }
        }
    }
}
