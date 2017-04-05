using finalProject.Persistence.FileSingleAccessControlObjects;
using finalProject.Persistence.Readers;
using System.Collections.Generic;
using System.IO;

namespace finalProject.Persistence.Writers
{
    public class EquipmentWriter
    {
        private EquipmentReader reader = new EquipmentReader();

        private string _fileName;

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="fileName"></param>
        public EquipmentWriter(string fileName)
        {
            _fileName = fileName;
        }

        public void Add(Equipment item)
        {
            var list = reader.GetEquipment(_fileName);
            list.Add(item.ID, item);
            Save(list, true);
        }

        public void Edit(Equipment item)
        {
            var list = reader.GetEquipment(_fileName);
            if (list.ContainsKey(item.ID))
            {
                list[item.ID] = item; // replace full item in dictionary
                Save(list);
            }
        }

        public void Delete(Equipment item)
        {
            var list = reader.GetEquipment(_fileName);
            if (list.ContainsKey(item.ID))
            {
                list.Remove(item.ID);
                Save(list);
            }
        }

        private void Save(Dictionary<string, Equipment> list, bool isAppend = false)
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