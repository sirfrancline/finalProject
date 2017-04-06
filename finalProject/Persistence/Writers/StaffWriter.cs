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
                        var line = $"{item.Value.IdNumber} {item.Value.FirstName} {item.Value.Surname} {item.Value.Username} {item.Value.Password}";
                        file.WriteLine(line);
                    }
                }
            }
        }

        public void Edit(Staff item)
        {
            var list = _reader.GetAllStuffMembers();
            list[item.IdNumber] = item;
            Save(list);
        }

        public void Delete(Staff item)
        {
            var list = _reader.GetAllStuffMembers();
            list.Remove(item.IdNumber);
            Save(list);
        }

    }
}
