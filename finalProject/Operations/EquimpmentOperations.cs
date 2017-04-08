using finalProject.Persistence.Readers;
using finalProject.Reports;
using System;
using System.Collections.Generic;
using System.IO;

namespace finalProject
{
    public class EquimpmentOperations
    {
        private Dictionary<string, Equimpment> _equipmentList;

        public Dictionary<string, Equimpment> EquipmentList { get { return _equipmentList; } }
        private string _prompt;

        public void Start()
        {
            var reader = new EquipmentReader();
            _equipmentList = reader.GetAllEquipment();
        }

        

        public void DeleteEquipment()
        {
            Console.Write("Enter Equipment ID : ");
            var id = Console.ReadLine();

            if (_equipmentList.ContainsKey(id))
            {
                _equipmentList.Remove(id);
                Console.WriteLine("Equipment Removed");
                // save that to flat file
            }
            else
            {
                Console.WriteLine($"Cannot find this id:{id}");
            }
        }

        private void DisplayEquipmentMenu()
        {
            Console.WriteLine("****Equipment******");
            Console.WriteLine("\t1. View");
            Console.WriteLine("\t2. Add");
            Console.WriteLine("\t3. Delete");
            Console.WriteLine("\t4. Update");
            Console.WriteLine("\t5. Report");
            Console.WriteLine("\t6. Exit ");
        }

        private void AddEquipment()
        {
            Console.Write("Enter ID: ");
            var id = Console.ReadLine();
            Console.Write("Enter Type : ");
            var type = Console.ReadLine();
            Console.Write("Enter Max Rental Days: ");
            var reantal = Console.ReadLine();
            Console.Write("Enter Description: ");
            var descritpion = Console.ReadLine();

            var newequipment = new Equimpment
            {
                Description = descritpion,
                ID = id,
                MaxRentalDays = int.Parse(reantal),
                Type = type
            };

            _equipmentList.Add(newequipment.ID, newequipment);
        }

        public void HandleMenuItems()
        {
            Console.Clear();
            DisplayEquipmentMenu();
            var optionEquipment = Helpers.GetIntegerOptionFromUser(1, 6);

            switch (optionEquipment)
            {
                case 1:
                    Console.WriteLine("******Equipment List*******");
                    foreach (var e in _equipmentList)
                    {
                        Console.WriteLine($"{e.Value.ID} {e.Value.Type} {e.Value.MaxRentalDays} {e.Value.Description}");
                    }

                    Console.WriteLine("(enter)");
                    Console.ReadLine();
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
                    EquipmentReport();
                    break;

                case 6:
                    //exit
                    break;
            }
        }

        private void EquipmentReport()
        {
            Console.WriteLine("Provide equpment id:");
            var id = Console.ReadLine();
            if (_equipmentList.ContainsKey(id))
            {
                DisplayReport(id);

            }
            else {
                Console.WriteLine("Please check id...");
                
            }

            Console.WriteLine("(enter)");
            Console.ReadLine();
        }

        private void DisplayReport(string id)
        {
            var reportGenerator = new EquipmentReport();
            var report = reportGenerator.GetEquipmentUsage(id);

            foreach (var item in report)
            {
                Console.WriteLine("*******");
                Console.WriteLine($"{item.Borrower.FirstName} {item.Borrower.Surname} {item.Borrower.Course}");
                Console.WriteLine($"{item.Lender.FirstName} {item.Lender.Surname}");
                Console.WriteLine($"{item.LineEntry.IsReturned} {item.LineEntry.IssueDate} {item.LineEntry.ReturnDate} {item.LineEntry.ReturnedDate}" );
                Console.WriteLine("*******");
                Console.WriteLine("");
            }


        }

        private void UpdateEquipment()
        {
            Console.Write("Enter Equipment ID : ");
            var idGotFromUser = Console.ReadLine();

            //check if we have id
            var exists = _equipmentList.ContainsKey(idGotFromUser);
            if (exists)
            {
                var device = _equipmentList[idGotFromUser];
                _prompt = "Provide new walue, ENTER for no change:";

                UpdateType(idGotFromUser);
                UpdateRental(idGotFromUser);
                UpdateDescription(idGotFromUser);
            }
            else
            {
                Console.WriteLine($"Cannot find item with ID:{idGotFromUser}");
            }
        }

        private void UpdateDescription(string idGotFromUser)
        {
            Console.Write("Enter Description: ");
            var descritpion = Console.ReadLine();

            
        }

        private void UpdateRental(string idGotFromUser)
        {
            Console.Write("Enter Max Rental Days : ");
            var reantal = Helpers.GetIntegerOptionFromUser(1, 10);


        }

        private void UpdateType(string idGotFromUser)
        {
            Console.WriteLine($"Current type: {_equipmentList[idGotFromUser].Type}");
            Console.WriteLine(_prompt);
            var type = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(type))
                _equipmentList[idGotFromUser].Type = type;
        }
    }
}