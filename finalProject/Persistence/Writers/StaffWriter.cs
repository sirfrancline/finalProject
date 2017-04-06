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
        private StaffReader _reader = new StaffReader();

        string _fileName = @"TextFiles\staff.txt";

        public void Add(Staff item)
        {
            var list = _reader.GetAllStuffMembers();

        }

        public void Edit(Staff item)
        {


        }

        public void Delete(Staff item)
        {


        }

    }
}
