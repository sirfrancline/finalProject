using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace finalProject
{
    internal class CollegeEquipmentControl
    {
        public void EntryPoint()

        {
            
            var studentOperations = new StudentOperations();
            studentOperations.Start("student.txt");

            var  equipmentOperations = new EquimpmentOperations();
            equipmentOperations.Start("equipment.txt");
                


            List<Staff> staffList = new List<Staff>();



            staffList = GetStuffMembers();
            

            Console.Clear();
            DisplayMainMenu();

            var option = (MainProjectOptionEnum)Helpers.GetIntegerOptionFromUser(1, 6);

            switch (option)
            {
                case MainProjectOptionEnum.Login:

                    break;

                case MainProjectOptionEnum.Staff:
                    int optionStaff;
                    DisplayStaffMaintanenceMenu();
                        optionStaff = Convert.ToInt32(Console.ReadLine());

                    switch (optionStaff)
                    {
                        case 1:
                            Console.WriteLine("******Staff List*******");
                            foreach (Staff s in staffList)
                            {
                                s.Display();
                            }
                            break;

                        case 2:
                            AddStaff(staffList);
                            break;

                        case 3:
                            DeleteStaff(staffList);
                            break;

                        case 4:
                            UpdateStaff(staffList);
                            break;

                        case 5:
                            //exit
                            break;
                    }
                    break;

                case MainProjectOptionEnum.Student:
                    studentOperations.HandleMenuItems();
                    break;

                case MainProjectOptionEnum.Equipment:

                    break;

                case MainProjectOptionEnum.Rentals:

                    DisplayRentalMenu();
                    int optionBookings;
                    optionBookings = Convert.ToInt32(Console.ReadLine());

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

      
        private static void DisplayRentalMenu()
        {
            Console.WriteLine("****Booking******");
            Console.WriteLine("\t1. Reserve");
            Console.WriteLine("\t2. Issue");
            Console.WriteLine("\t3. Returns");
            Console.WriteLine("\t4. Overdue Equipment");
            Console.WriteLine("\t5. Exit ");
        }

        private static void DisplayStaffMaintanenceMenu()
        {
            Console.WriteLine("****Staff******");
            Console.WriteLine("\t1. View");
            Console.WriteLine("\t2. Add");
            Console.WriteLine("\t3. Delete");
            Console.WriteLine("\t4. Update");
            Console.WriteLine("\t5. Exit ");
        }

        private static void DisplayMainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("\t1. Login ");
            Console.WriteLine("\t2. Staff");
            Console.WriteLine("\t3. Student");
            Console.WriteLine("\t4. Equipment");
            Console.WriteLine("\t5. Rentals ");
            Console.WriteLine("\t5. Exit ");
            Console.WriteLine("\t Enter An Option");
        }

        

        private static List<Staff> GetStuffMembers()
        {
            var staffList = new List<Staff>();
            if (File.Exists("staff.txt"))
            {
                using (StreamReader staffFile = new StreamReader("staff.txt"))
                {
                    while (!staffFile.EndOfStream)
                    {
                        string staffS = staffFile.ReadLine();
                        string[] staffdetails = staffS.Split(' ');
                        Staff staff = new Staff();
                        staff.IdNumber = staffdetails[0];
                        staff.FirstName = staffdetails[1];
                        staff.Surname = staffdetails[2];
                        staff.Username = staffdetails[3];
                        staff.Password = staffdetails[4];
                        staffList.Add(staff);
                    }
                }
            }
            else
            {
                // missing file,
                Console.WriteLine("files is missing....");
                Console.ReadLine();
            }
            return staffList;
        }

        

        public static bool login(string username, string password, List<Staff> staff)
        {
            foreach (Staff s in staff)
            {
                if (s.Username == username && s.Password == password)
                {
                    Console.WriteLine("Successful Login");
                    return true;
                }
            }

            Console.WriteLine("Invalid login");
            return false;
        }

        public static void AddStaff(List<Staff> staff)
        {
            Console.Write("Enter First Name : ");
            string fname = Console.ReadLine();
            Console.Write("Enter Last Name : ");
            string surname = Console.ReadLine();
            Console.Write("Enter Staff ID : ");
            string id = Console.ReadLine();
            Console.Write("Enter Staff Username : ");
            string usernamestaff = Console.ReadLine();
            Console.Write("Enter Staff Password : ");
            string passwordstaff = Console.ReadLine();

            Staff staffmember = new Staff(id, fname, surname, usernamestaff, passwordstaff);
            staff.Add(staffmember);

            staffmember.Display();
        }


        public static void DeleteStaff(List<Staff> staff)
        {
            Console.Write("Enter Staff ID : ");
            string id = Console.ReadLine();

            foreach (Staff s in staff)
            {
                if (s.IdNumber == id)
                {
                    s.Display();
                    staff.Remove(s);
                    Console.WriteLine("Staff Member Removed");
                    break;
                }
            }
        }


        public static void UpdateStaff(List<Staff> staff)
        {
            Console.Write("Enter Staff ID : ");
            string id = Console.ReadLine();

            foreach (Staff s in staff)
            {
                if (s.IdNumber == id)
                {
                    staff.Remove(s);
                    Console.Write("Enter First Name : ");
                    string fname = Console.ReadLine();
                    Console.Write("Enter Last Name : ");
                    string surname = Console.ReadLine();
                    Console.Write("Enter Staff Username : ");
                    string usernamestaff = Console.ReadLine();
                    Console.Write("Enter Staff Password : ");
                    string passwordstaff = Console.ReadLine();

                    Staff staffmember = new Staff(id, fname, surname, usernamestaff, passwordstaff);
                    staff.Add(staffmember);

                    staffmember.Display();
                    break;
                }
            }
        }

 
    }
}