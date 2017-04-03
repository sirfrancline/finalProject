using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    
 
    public class RentalOperations
    {
        private Dictionary<string, Booking> _BookingList;
        public void Start()
        {
           // var booking = new Booking(string EId, string SId, string fname, string surname, DateTime issue, DateTime returnDate);
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
                    break;

                case 5:
                    //exit
                    break;
            }
          









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
            GetRentals(fileName);
        }

        private void GetRentals(string fileName)
        {
            var students = new Dictionary<string, Student>();
            if (File.Exists(fileName))
            {
                using (var studentFile = new StreamReader(fileName))
                {
                    while (!studentFile.EndOfStream)
                    {
                        var line = studentFile.ReadLine();
                        var studentdetails = line.Split(' ');
                        var student = new Student
                        {
                            IdNumber = studentdetails[0],
                            FirstName = studentdetails[1],
                            Surname = studentdetails[2],
                            Course = studentdetails[3]
                        };

                        students.Add(student.IdNumber, student);
                    }
                }
            }
            else
            {
                // we can log error here displap mesage
                Console.WriteLine("files is missing....");
                Console.ReadLine();
            }

            //return students;
        }
    }

    
}