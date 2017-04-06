using finalProject.Persistence.FileSingleAccessControlObjects;
using finalProject.Persistence.Readers;
using System.Collections.Generic;
using System.IO;

namespace finalProject.Persistence.Writers
{
    public class EquipmentWriter
    {
        private EquipmentReader reader = new EquipmentReader();
        
        string _fileName = @"TextFiles\equipment.txt";

        public EquipmentWriter()
        {
            
        }

        public void Add(student item)
        {
            var list = reader.GetAllEquipment();
            list.Add(item.ID, item);
            Save(list, true);
        }

        public void Edit(student item)
        {
            var list = reader.GetAllEquipment();
            if (list.ContainsKey(item.ID))
            {
                list[item.ID] = item; // replace full item in dictionary
                Save(list);
            }
        }

        public void Delete(student item)
        {
            var list = reader.GetAllEquipment();
            if (list.ContainsKey(item.ID))
            {
                list.Remove(item.ID);
                Save(list);
            }
        }

        private void Save(Dictionary<string, student> list, bool isAppend = false)
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