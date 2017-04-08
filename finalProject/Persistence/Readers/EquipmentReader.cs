using finalProject.Persistence.FileSingleAccessControlObjects;
using System;
using System.Collections.Generic;
using System.IO;

namespace finalProject.Persistence.Readers
{
    public class EquipmentReader
    {
        string fileName = @"TextFiles\equipment.txt";
        public Dictionary<string, Equimpment> GetAllEquipment()

        {
            var equipmentList = new Dictionary<string, Equimpment>();

            lock (LockObjects.EqLocker)
            {
                if (File.Exists(fileName))
                {
                    using (var equipmentFile = new StreamReader(fileName))
                    {
                        while (!equipmentFile.EndOfStream)
                        {
                            var equipments = equipmentFile.ReadLine();
                            var equipmentdetails = equipments.Split(',');
                            var equipment = new Equimpment
                            {
                                ID = equipmentdetails[0],
                                Type = equipmentdetails[1],
                                MaxRentalDays = int.Parse(equipmentdetails[2]),
                                Description = equipmentdetails[3]
                            };

                            equipmentList.Add(equipment.ID, equipment);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Equimpment file is missing....");
                    Console.ReadLine();
                }

                return equipmentList;
            }
        }
    }
}