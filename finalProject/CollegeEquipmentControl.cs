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
            List<Student> studentList = new List<Student>();
            List<Staff> staffList = new List<Staff>();
            List<Equipment> equipmentList = new List<Equipment>();

            studentList = GetStudents();
            staffList = GetStuffMembers();
            equipmentList = GetEquipment();

            Console.Clear();
            DisplayMainMenu();

            var option = (MainProjectOptionEnum)GetIntegerOptionFromUser(1, 6);

            switch (option)
            {
                case MainProjectOptionEnum.Login:

                    break;

                case MainProjectOptionEnum.Staff:
                    int optionStaff;
                    Console.WriteLine("****Staff******");
                    Console.WriteLine("\t1. View");
                    Console.WriteLine("\t2. Add");
                    Console.WriteLine("\t3. Delete");
                    Console.WriteLine("\t4. Update");
                    Console.WriteLine("\t5. Exit ");
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
                    int optionStudent;
                    Console.WriteLine("****Student******");
                    Console.WriteLine("\t1. View");
                    Console.WriteLine("\t2. Account Transaction");
                    Console.WriteLine("\t3. Exit ");
                    optionStudent = Convert.ToInt32(Console.ReadLine());

                    switch (optionStudent)
                    {
                        case 1:
                            Console.WriteLine("******Student List*******");
                            foreach (Student student in studentList)
                            {
                                student.Display();
                            }
                            break;

                        case 2:

                            break;

                        case 3:
                            //exit
                            break;
                    }
                    break;

                case MainProjectOptionEnum.Equipment:

                    DisplayEquipmentMenu();
                    int optionEquipment;
                    optionEquipment = Convert.ToInt32(Console.ReadLine());

                    switch (optionEquipment)
                    {
                        case 1:
                            Console.WriteLine("******Equipment List*******");
                            foreach (Equipment e in equipmentList)
                            {
                                //  e.Display();
                            }
                            break;

                        case 2:
                            AddEquipment(equipmentList);
                            break;

                        case 3:
                            DeleteEquipment(equipmentList);
                            break;

                        case 4:
                            UpdateEquipment(equipmentList);
                            break;

                        case 5:

                            break;

                        case 6:
                            //exit
                            break;
                    }
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

        public int GetIntegerOptionFromUser(int minValue, int maxValues)
        {
            var userInput = Console.ReadLine();
            var retry = true;
            int option;
            //chec user input
            while (retry)
            {
                var parseResult = int.TryParse(userInput, out option);
                if (parseResult)
                {
                    //check min max as inpru is valid
                    if (minValue <= option && option <= maxValues)
                    {
                        retry = false; // return terminate loop
                        return option;
                    }
                }

                Console.WriteLine("Please provide valid input.");
                userInput = Console.ReadLine();
            }

            throw new IndexOutOfRangeException();
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

        private static List<Equipment> GetEquipment()

        {
            var equipmentList = new List<Equipment>();
            if (File.Exists("equipment.txt"))
            {
                using (StreamReader equipmentFile = new StreamReader("equipment.txt"))
                {
                    while (!equipmentFile.EndOfStream)
                    {
                        string equipments = equipmentFile.ReadLine();
                        string[] equipmentdetails = equipments.Split(' ');
                        Equipment equipment = new Equipment();
                        equipment.ID = equipmentdetails[0];
                        equipment.Type = equipmentdetails[1];
                        equipment.MaxRentalDays = int.Parse(equipmentdetails[2]);
                        equipment.Description = equipmentdetails[3];
                        equipmentList.Add(equipment);
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

        private static List<Student> GetStudents()
        {
            var studentList = new List<Student>();
            if (File.Exists("student.txt"))
            {
                using (StreamReader studentFile = new StreamReader("student.txt"))
                {
                    while (!studentFile.EndOfStream)
                    {
                        string studentS = studentFile.ReadLine();
                        string[] studentdetails = studentS.Split(' ');
                        Student student = new Student();
                        student.IdNumber = studentdetails[0];
                        student.FirstName = studentdetails[1];
                        student.Surname = studentdetails[2];
                        student.Course = studentdetails[3];
                        studentList.Add(student);
                    }
                }
            }
            else
            {
                // we can log error here displap mesage
                Console.WriteLine("files is missing....");
                Console.ReadLine();
            }

            return studentList;
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

        public static void AddEquipment(List<Equipment> equipment)
        {
            Console.Write("Enter ID : ");
            string id = Console.ReadLine();
            Console.Write("Enter Type : ");
            string type = Console.ReadLine();
            Console.Write("Enter Max Rental Days : ");
            string reantal = Console.ReadLine();
            Console.Write("Enter Description: ");
            string descritpion = Console.ReadLine();

            Equipment newequipment = new Equipment
            {
                Description = descritpion,
                ID = id,
                MaxRentalDays = int.Parse(reantal),
                Type = type
            };

            equipment.Add(newequipment);
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

        public static void DeleteEquipment(List<Equipment> equipment)
        {
            Console.Write("Enter Equipment ID : ");
            string id = Console.ReadLine();

            foreach (Equipment e in equipment)
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
            else {
                Console.WriteLine($"Cannot find item with ID:{idGotFromUser}");
            }

            //////////////////////////////////////////
            Console.Write("Enter Equipment ID : ");
            string id = Console.ReadLine();
            var prompt = "Enter nw walue, ENTER for no change";

            var device = equipment.FirstOrDefault(a => a.ID == id);

            Console.WriteLine($"Current type: {device.Type}");
            Console.Write(prompt);
            string type = Console.ReadLine();
            Console.Write("Enter Max Rental Days : ");
            string reantal = Console.ReadLine();
            Console.Write("Enter Description: ");
            string descritpion = Console.ReadLine();

            Equipment newequipment = new Equipment
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