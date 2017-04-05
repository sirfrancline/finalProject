using finalProject.Persistence.FileSingleAccessControlObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject.Persistence.Readers
{
    public class RentalReader
    {


        public List<Booking> GetRentals(string fileName)
        {
            var rentals = new List<Booking>();
            lock (LockObjects.RentalLocker)
            {

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
}
