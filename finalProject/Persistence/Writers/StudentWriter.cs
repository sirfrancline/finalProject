using finalProject.Persistence.FileSingleAccessControlObjects;
using finalProject.Persistence.Readers;
using System.Collections.Generic;
using System.IO;

namespace finalProject.Persistence.Writers
{
    public class StudentWriter
    {
        private StudentReader _reader = new StudentReader();

        private string _fileName = @"TextFiles\Equimpment.txt";

        public void Add(Student item)
        {
            var list = _reader.GetAllStudents();
            list.Add(item.IdNumber, item);
            Save(list, true);
        }

        public void Edit(Student item)
        {
            var list = _reader.GetAllStudents();
            list[item.IdNumber] = item;
            Save(list);
        }

        public void Delete(Student item)
        {
            var list = _reader.GetAllStudents();
            list.Remove(item.IdNumber);
            Save(list);
        }

                private void Save(Dictionary<string, Student> list, bool isAppend = false)
        {
            lock (LockObjects.StLocker)
            {
                using (var file = new StreamWriter(_fileName, isAppend)) //false  => overwrite
                {
                    foreach (var item in list)
                    {
                        var line = $"{item.Value.IdNumber} {item.Value.FirstName} {item.Value.Surname} {item.Value.Course}";
                        file.WriteLine(line);
                    }
                }
            }
        }
    }
}