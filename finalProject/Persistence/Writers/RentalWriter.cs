using finalProject.Persistence.FileSingleAccessControlObjects;
using finalProject.Persistence.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace finalProject.Persistence.Writers
{
    public class RentalWriter

    {
        private RentalReader _reader = new RentalReader();

        private string _fileName = @"TextFiles\rental.txt";

        public string Add(Issue issue)
        {
            var list = _reader.GetAllRentals();

            issue.RentalId = Guid.NewGuid().ToString();
            list.Add(issue);
            Save(list, true);

            return issue.RentalId;
        }

        public void Delete(Issue item)
        {

            var list = _reader.GetAllRentals();

            list.Remove(item);
            Save(list);
        }

        public void Edit(Issue item)
        {
            var list = _reader.GetAllRentals();

            var tmp = list.First(a => a.RentalId == item.RentalId);
            list.Remove(tmp);

            list.Add(item);
            Save(list);
        }


        private void Save(List<Issue> list, bool isAppend = false)
        {
            lock (LockObjects.RentalLocker)
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
    }
}