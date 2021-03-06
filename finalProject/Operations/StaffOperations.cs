﻿using finalProject.Persistence.Readers;
using finalProject.Persistence.Writers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace finalProject
{
    public class StaffOperations
    {
        private Dictionary<string, Staff> _staffList;
        private string _prompt;
        private StaffWriter _writer = new StaffWriter();
        private StaffReader _reader;

        public void Start()
        {
            _reader = new StaffReader();
            _staffList = _reader.GetAllStuffMembers();
        }

        public void HandleMenuItems()
        {
            var stayInTheMenu = true;
            while (stayInTheMenu)
            {
                int optionStaff;
                DisplayStaffMaintanenceMenu();
                optionStaff = Helpers.GetIntegerOptionFromUser(1, 5);

                switch (optionStaff)
                {
                    case 1:
                        Console.WriteLine("******Staff List*******");
                        foreach (var staff in _staffList)
                        {
                            staff.Value.Display();
                        }

                        Console.WriteLine("Fil;hed (enter to continue)");
                        Console.ReadLine();

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
                        stayInTheMenu = false;
                        break;
                }
            }
        }

        private void AddStaff()
        {
            Console.Write("Enter First Name : ");
            var fname = Console.ReadLine();
            Console.Write("Enter Last Name : ");
            var surname = Console.ReadLine();
            Console.Write("Enter Staff ID : ");
            var id = Console.ReadLine();
            Console.Write("Enter Staff Username : ");
            var usernamestaff = Console.ReadLine();

            bool test = false;

            while (test != true)

            {
                // hide emntering passsword by using login helper
                Console.Write("Enter Staff Password : ");
                var passwordstaff = LoginHelper.GetPassword();
                Console.Write(" Confirm Staff Password : ");
                var passwordstaffConfirmation = LoginHelper.GetPassword();

                if (passwordstaff == passwordstaffConfirmation)
                {
                    var staffmember = new Staff(id, fname, surname, usernamestaff, passwordstaff);
                    _staffList.Add(staffmember.IdNumber, staffmember);

                    _writer.Add(staffmember);
                    staffmember.Display();
                    test = true;
                    Console.WriteLine("new Staff Member Added");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("password doesn't match");
                    Console.Read();
                    Console.Clear();
                }
            }
        }

        private void DeleteStaff()
        {
            Console.Write("Enter Staff ID: ");
            var id = Console.ReadLine();

            if (_staffList.ContainsKey(id))
            {
                _writer.Delete(_staffList[id]);
                _staffList.Remove(id);

                Console.WriteLine("Removed");
                // save that to flat file
            }
            else
            {
                Console.WriteLine($"Cannot find this id:{id}");
            }
        }

        private void UpdateStaff()
        {
            Console.WriteLine("Enter Staff ID : ");
            var idGotFromUser = Console.ReadLine();

            //check if we have id
            var exists = _staffList.ContainsKey(idGotFromUser);
            if (exists)
            {
                var staff = _staffList[idGotFromUser];
                _prompt = "Provide new walue, ENTER for no change:";

                Firstname(idGotFromUser);
                Surname(idGotFromUser);
                Username(idGotFromUser);
                Password(idGotFromUser);
                _writer.Edit(staff);
            }
            else
            {
                Console.WriteLine($"Cannot find item with ID:{idGotFromUser}");
            }
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
            
            var authorised = _reader.Authorize(loginName, password);

            return authorised;
        }

        

        private void Firstname(string idGotFromUser)
        {

            Console.WriteLine($"{_prompt}: {_staffList[idGotFromUser].FirstName}");
            var userImput = Console.ReadLine();

            if (string.IsNullOrEmpty(userImput))
            {
                return;
            }

            _staffList[idGotFromUser].FirstName = userImput;
        }

        private void Surname(string idGotFromUser)
        {
            Console.Write("Enter  Surname: ");
            var userImput = Console.ReadLine();

            if (string.IsNullOrEmpty(userImput))
            {
                return;
            }

            _staffList[idGotFromUser].Surname = userImput;
        }

        private void Username(string idGotFromUser)
        {
            Console.Write("Enter  new username: ");
            var userImput = Console.ReadLine();

            if (string.IsNullOrEmpty(userImput))
            {
                return;
            }

            _staffList[idGotFromUser].Username = userImput;
        }

        private void Password(string idGotFromUser)
        {
            Console.Write("Enter  new password: ");
            var userImput = Console.ReadLine();

            if (string.IsNullOrEmpty(userImput))
            {
                return;
            }

            _staffList[idGotFromUser].Password = userImput;
        }
    }
}