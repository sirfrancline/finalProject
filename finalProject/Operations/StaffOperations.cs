using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace finalProject
{
    public class StaffOperations
    {
      private Dictionary<string, Staff> _staffList;
        private string _prompt;

        public void Start(string fileName)
        {
            _staffList = GetStuffMembers(fileName);
        }

        public void HandleMenuItems()
        {
            int optionStaff;
            DisplayStaffMaintanenceMenu();
            optionStaff = Convert.ToInt32(Console.ReadLine());

            switch (optionStaff)
            {
                case 1:
                    Console.WriteLine("******Staff List*******");
                    foreach (var staff in _staffList)
                        staff.Value.Display();
                    break;

                case 2:
                    AddStaff();
                    break;

                case 3:
                    DeleteStaff();
                    break;

                case 4:
                    UpdateStaff();
                    break;

                case 5:
                    //exit
                    break;
            }
        }

        void AddStaff()
        {
            Console.Write("Enter First Name : ");
            var fname = Console.ReadLine();
            Console.Write("Enter Last Name : ");
            var surname = Console.ReadLine();
            Console.Write("Enter Staff ID : ");
            var id = Console.ReadLine();
            Console.Write("Enter Staff Username : ");
            var usernamestaff = Console.ReadLine();


            // hide emntering passsword by using login helper
            Console.Write("Enter Staff Password : ");
            var passwordstaff = LoginHelper.GetPassword();
            Console.Write(" Confirm Staff Password : ");
            var passwordstaffConfirmation = LoginHelper.GetPassword();

            if (passwordstaff == passwordstaffConfirmation)
            {
                var staffmember = new Staff(id, fname, surname, usernamestaff, passwordstaff);
                _staffList.Add(staffmember.IdNumber, staffmember);
                staffmember.Display();

            }
            else
            {

                Console.WriteLine("password doesn't match");


            }
           

            
        }


        void DeleteStaff()
        {
            Console.Write("Enter Staff ID: ");
            var id = Console.ReadLine();

            if (_staffList.ContainsKey(id))
            {
                _staffList.Remove(id);
                Console.WriteLine("Removed");
                // save that to flat file
            }
            else
            {
                Console.WriteLine($"Cannot find this id:{id}");
            }
        }


       void UpdateStaff()
        {
            Console.WriteLine("Enter Staff ID : ");
            var idGotFromUser = Console.ReadLine();

            //check if we have id
            var exists = _staffList.ContainsKey(idGotFromUser);
            if (exists)
            {
                                var staff = _staffList[idGotFromUser];
                                 _prompt = "Provide new walue, ENTER for no change:";

                                Firstname (idGotFromUser);
                                Surname(idGotFromUser);
                                Username(idGotFromUser);
                                Password(idGotFromUser);
                
                
            }
            else
            {
                Console.WriteLine($"Cannot find item with ID:{idGotFromUser}");
            }
        }


        private Dictionary<string, Staff> GetStuffMembers(string fileName)
        {
            var staffList = new Dictionary<string, Staff>();
            if (File.Exists(fileName))
            {
                using (var staffFile = new StreamReader(fileName))
                {
                    while (!staffFile.EndOfStream)
                    {
                        var staffS = staffFile.ReadLine();
                        var staffdetails = staffS.Split(' ');
                        var staff = new Staff();
                        staff.IdNumber = staffdetails[0];
                        staff.FirstName = staffdetails[1];
                        staff.Surname = staffdetails[2];
                        staff.Username = staffdetails[3];
                        staff.Password = staffdetails[4];
                        staffList.Add(staff.IdNumber, staff);
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


        private static void DisplayStaffMaintanenceMenu()
        {
            Console.WriteLine("****Staff******");
            Console.WriteLine("\t1. View");
            Console.WriteLine("\t2. Add");
            Console.WriteLine("\t3. Delete");
            Console.WriteLine("\t4. Update");
            Console.WriteLine("\t5. Exit ");
        }

        public bool IsUserAuthorised()
        {

#if DEBUG
            return true;
#endif

            Console.WriteLine("Please provide login");
            var loginName = Console.ReadLine();
            if (string.IsNullOrEmpty(loginName))
            {
                return false;
            }
            
            Console.WriteLine("Please provide password");
            var password = LoginHelper.GetPassword();
            var authorised = false;

            var user = _staffList.FirstOrDefault(s=>s.Value.Username==loginName);
            if (user.Value!=null)
            {
                authorised = _staffList[user.Value.IdNumber].Password == password;
            }

            return authorised;

        }

        private void Firstname(string idGotFromUser)
        {
            Console.Write("Enter  firstname: ");
            var firstName = Console.ReadLine();

            throw new NotImplementedException();
        }
        private void Surname(string idGotFromUser)
        {
            Console.Write("Enter  Surname: ");
            var surName = Console.ReadLine();

            throw new NotImplementedException();
        }
        private void Username(string idGotFromUser)
        {
            Console.Write("Enter  new username: ");
            var userName = Console.ReadLine();

            throw new NotImplementedException();
        }
        private void Password(string idGotFromUser)
        {
            Console.Write("Enter  new password: ");
            var newPassword = Console.ReadLine();
           throw new NotImplementedException();
        }
    }
}