using finalProject.Persistence.FileSingleAccessControlObjects;
using finalProject.Persistence.Readers;
using System;
using System.Collections.Generic;
using System.IO;

namespace finalProject.Persistence.Writers
{
    public class StudentWriter
    {



        private StudentReader reader = new StudentReader();

        string _fileName = @"TextFiles\student.txt";

        public StudentWriter()
        {

        }

        

        private void save(Dictionary<string, student> list, bool isAppend = false)
        {
            lock (LockObjects.EqLocker)
            {
                using (var file = new StreamWriter(_fileName, isAppend)) //false  => overwrite
                {
                    foreach (var item in list)
                    {
                        var line = $"{item.Value.ID},{item.Value.Type},{item.Value.MaxRentalDays},{item.Value.Description}";
                        file.WriteLine(line);
                    }
                }
            }
        }
        
    }
}