using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace finalProject
{
    public class RentalOperations
    {
        private List<Booking> _bookingList;
        private EquimpmentOperations _equipmentOperations;

        public RentalOperations(EquimpmentOperations equipmentOperations)
        {
           _equipmentOperations = equipmentOperations;
        }

        public void HandleMenuItems()
        {
            int optionRental;
            DisplayRentalMenu();

            optionRental = Helpers.GetIntegerOptionFromUser(1, 5);
            switch (optionRental)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    DisplayOverdue();
                    break;

                case 5:
                    //exit
                    break;
            }
        }

        private void DisplayOverdue()
        {
            var overDue = _bookingList.Where(a => a.ReturnDate < DateTime.Now).ToList();

            foreach (var item in overDue)
            {
                Console.WriteLine($"item: {item.StudentId}");
            }

            Console.WriteLine("Pres enter to coontinue...");
            Console.ReadLine();
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

        public static void Reserve()

        {
            //if (IsReturned == true)
            //{
            //}
        }

        internal void Start(string fileName)
        {
            _bookingList = GetRentals(fileName);
        }

        private List<Booking> GetRentals(string fileName)
        {
            var rentals = new List<Booking>();
            if (File.Exists(fileName))
            {
                using (var rentalFile = new StreamReader(fileName))
                {
                    while (!rentalFile.EndOfStream)
                    {
                        var line = rentalFile.ReadLine();
                        var rental = line.Split(',');
                        var booking = new Booking
                        {
                            EmployeeId = rental[0],
                            EquipmentID = rental[1],
                            IsReturned = rental[2] == "true",
                            IssueDate = DateTime.Parse(rental[3]),
                            ReturnDate = DateTime.Parse(rental[4]),
                            StudentId = rental[5],
                        };

                        rentals.Add(booking);
                    }
                }
            }
            else
            {
                // we can log error here displap mesage
                Console.WriteLine("files is missing....RentalOperations");
                Console.ReadLine();
            }

            return rentals;
        }
    }
}