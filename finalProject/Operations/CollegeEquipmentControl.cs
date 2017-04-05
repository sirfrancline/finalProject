using System;

namespace finalProject
{
    internal class CollegeEquipmentControl
    {
        private readonly StudentOperations _studentOperations = new StudentOperations();
        private readonly EquimpmentOperations _equipmentOperations = new EquimpmentOperations();
        private readonly StaffOperations _staffOperations = new StaffOperations();
        private  RentalOperations _rentalOperations ;

        public void EntryPoint()
        {
            Initialise();
            Console.Clear();
            DisplayMainMenu();
            var option = (MainProjectOptionEnum)Helpers.GetIntegerOptionFromUser(1, 5);

            switch (option)
            {
                
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
                    _rentalOperations.HandleMenuItems();
                    break;

                case MainProjectOptionEnum.Exit:
                    //exit
                    break;
            }
        }

        private void Initialise()
        {
            _rentalOperations = new RentalOperations(_equipmentOperations);
            _studentOperations.Start();
            _equipmentOperations.Start(@"TextFiles\equipment.txt");
            _staffOperations.Start(@"TextFiles\staff.txt");
            _rentalOperations.Start();
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