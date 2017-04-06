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
            list.Add(item.IdNumber,item);
            Save(list, true);

        }

        private void Save(Dictionary<string, Staff> list, bool isAppend = false)
        {
            lock (LockObjects.StaffLocker)
            {
                using (var file = new StreamWriter(_fileName, isAppend)) //false  => overwrite
                {
                    foreach (var item in list)
                    {
                        var line = $"{item.RentalId},{item.EmployeeId},{item.EquipmentID},{item.IsReturned},{item.IssueDate},{item.ReturnDate } {item.StudentId},{item.ReturnedDate}";

                        file.WriteLine(line);
                    }
                }
            }
        }

        public void Edit(Staff item)
        {
            var list = _reader.GetAllStuffMembers();

        }

        public void Delete(Staff item)
        {
            var list = _reader.GetAllStuffMembers();

        }

    }
}
