using finalProject.Persistence.FileSingleAccessControlObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace finalProject.Persistence.Readers
{
    public class RentalReader
    {
        public List<Issue> GetRentals(string fileName)
        {
            var rentals = new List<Issue>();
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

                            if (rental.Any()) // ignore emtpy ines
                            {
                                var booking = new Issue
                                {
                                    EmployeeId = rental[0],
                                    EquipmentID = rental[1],
                                    IsReturned = rental[2] == "true",
                                    IssueDate = DateTime.Parse(rental[3]),
                                    ReturnDate = DateTime.Parse(rental[4]),
                                    StudentId = rental[5],
                                    ReturnedDate = DateTime.Parse(rental[6]),
                                };

                                rentals.Add(booking);
                            }
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