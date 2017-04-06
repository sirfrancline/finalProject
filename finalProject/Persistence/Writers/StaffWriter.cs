using finalProject.Persistence.FileSingleAccessControlObjects;
using finalProject.Persistence.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject.Persistence.Writers
{
    public class StaffWriter
    {
        private StaffReader reader = new StaffReader();

        string _fileName = @"TextFiles\staff.txt";

        public StaffWriter()
        {

        }

    }
}
