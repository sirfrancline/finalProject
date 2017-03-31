using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace finalProject
{
    internal class CollegeEquipmentControl
    {
        private readonly StudentOperations _studentOperations = new StudentOperations();
        private readonly EquimpmentOperations _equipmentOperations = new EquimpmentOperations();
        private readonly StaffOperations _staffOperations = new StaffOperations();

        public void EntryPoint()
        {
            Initialise();
            Console.Clear();
            DisplayMainMenu();
            var option = (MainProjectOptionEnum)Helpers.GetIntegerOptionFromUser(1, 6);

            switch (option)
            {
                case MainProjectOptionEnum.Login:
                    break;

                case MainProjectOptionEnum.Staff:
                    _staffOperations.HandleMenuItems();        
                    break;

                case MainProjectOptionEnum.Student:
                    _studentOperations.HandleMenuItems();
                    break;

                case MainProjectOptionEnum.Equipment:
                    _equipmentOperations.HandleMenuItems();
                    break;

                case MainProjectOptionEnum.Rentals:
                    DisplayRentalMenu();
                    int optionBookings;
                    optionBookings = Helpers.GetIntegerOptionFromUser(1, 5);
                    switch (optionBookings)
                    {
                        case 1:
                            break;

                        case 2:
                            break;

                        case 3:
                            break;

                        case 4:
                            break;

                        case 5:
                            //exit
                            break;
                    }
                    break;

                case MainProjectOptionEnum.Exit:
                    //exit
                    break;
            }
        }

        private void Initialise()
        {
            _studentOperations.Start("student.txt");
            _equipmentOperations.Start("equipment.txt");
            _staffOperations.Start("staff.txt");
        }


        private static void DisplayRentalMenu()
        {
            Console.WriteLine("****Booking******");
            Console.WriteLine("\t1. Reserve");
            Console.WriteLine("\t2. Issue");
            Console.WriteLine("\t3. Returns");
            Console.WriteLine("\t4. Overdue Equipment");
            Console.WriteLine("\t5. Exit ");
        }


        private static void DisplayMainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("\t1. Staff");
            Console.WriteLine("\t2. Student");
            Console.WriteLine("\t3. Equipment");
            Console.WriteLine("\t4. Rentals ");
            Console.WriteLine("\t5. Exit ");
            Console.WriteLine("\t Enter An Option");
        }
    }
}