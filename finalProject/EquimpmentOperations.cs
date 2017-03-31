using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
public  class EquimpmentOperations
    {
        Dictionary<string, Equipment> equipmentList;

        public void Start(string fileName)
        {
            equipmentList = GetEquipment(fileName);
        }

        private Dictionary<string, Equipment> GetEquipment(string fileName)

        {
            var equipmentList = new Dictionary<string, Equipment>();
            if (File.Exists(fileName))
            {
                using (var equipmentFile = new StreamReader(fileName))
                {
                    while (!equipmentFile.EndOfStream)
                    {
                        var equipments = equipmentFile.ReadLine();
                        var equipmentdetails = equipments.Split(' ');
                        var equipment = new Equipment
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
                Console.WriteLine("files is missing....");
                Console.ReadLine();
            }

            return equipmentList;
        }


        public static void DeleteEquipment(List<Equipment> equipment)
        {
            Console.Write("Enter Equipment ID : ");
            var id = Console.ReadLine();

            foreach (var e in equipment)
            {
                if (e.ID == id)
                {
                    // e.Display();
                    equipment.Remove(e);
                    Console.WriteLine("Equipment Removed");
                    break;
                }
            }
        }


        private static void DisplayEquipmentMenu()
        {
            Console.WriteLine("****Equipment******");
            Console.WriteLine("\t1. View");
            Console.WriteLine("\t2. Add");
            Console.WriteLine("\t3. Delete");
            Console.WriteLine("\t4. Update");
            Console.WriteLine("\t5. Report");
            Console.WriteLine("\t6. Exit ");
        }


        public static void AddEquipment()
        {
            Console.Write("Enter ID : ");
            var id = Console.ReadLine();
            Console.Write("Enter Type : ");
            var type = Console.ReadLine();
            Console.Write("Enter Max Rental Days : ");
            var reantal = Console.ReadLine();
            Console.Write("Enter Description: ");
            var descritpion = Console.ReadLine();

            var newequipment = new Equipment
            {
                Description = descritpion,
                ID = id,
                MaxRentalDays = int.Parse(reantal),
                Type = type
            };

            equipment.Add(newequipment);
        }


        public void HandleMenuItems()
        {
            DisplayEquipmentMenu();
            int optionEquipment;
            optionEquipment = Convert.ToInt32(Console.ReadLine());

            switch (optionEquipment)
            {
                case 1:
                    Console.WriteLine("******Equipment List*******");
                    foreach (var e in equipmentList)
                    {
                        //  e.Display();
                    }
                    break;

                case 2:
                    AddEquipment();
                    break;

                case 3:
                    DeleteEquipment();
                    break;

                case 4:
                    UpdateEquipment();
                    break;

                case 5:

                    break;

                case 6:
                    //exit
                    break;
            }

        }

        public static void UpdateEquipment(List<Equipment> equipment)
        {

            //////////////////////////////////////////

            var devicesDic = new Dictionary<string, Equipment>();
            foreach (var item in equipment)
            {
                devicesDic.Add(item.ID, item);
            }

            //check if we have id
            var idGotFromUser = "abc";
            var exists = devicesDic.ContainsKey(idGotFromUser);
            if (exists)
            {
                devicesDic[idGotFromUser].Type = "newValue";
            }
            else
            {
                Console.WriteLine($"Cannot find item with ID:{idGotFromUser}");
            }

            //////////////////////////////////////////
            Console.Write("Enter Equipment ID : ");
            var id = Console.ReadLine();
            var prompt = "Enter nw walue, ENTER for no change";

            var device = equipment.FirstOrDefault(a => a.ID == id);

            Console.WriteLine($"Current type: {device.Type}");
            Console.Write(prompt);
            var type = Console.ReadLine();
            Console.Write("Enter Max Rental Days : ");
            var reantal = Console.ReadLine();
            Console.Write("Enter Description: ");
            var descritpion = Console.ReadLine();

            var newequipment = new Equipment
            {
                Description = descritpion,
                ID = id,
                MaxRentalDays = int.Parse(reantal),
                Type = type
            };

            equipment.Add(newequipment);
        }
    }
}
