using finalProject.Persistence.FileSingleAccessControlObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace finalProject.Persistence.Readers
{
    public class StaffReader
    {
        private string fileName = @"TextFiles\staff.txt";

        public Dictionary<string, Staff> GetAllStuffMembers()
        {
            var staffList = new Dictionary<string, Staff>();
            lock (LockObjects.StaffLocker)
            {
                if (File.Exists(fileName))
                {
                    using (var staffFile = new StreamReader(fileName))
                    {
                        while (!staffFile.EndOfStream)
                        {
                            var staffS = staffFile.ReadLine();
                            if (string.IsNullOrEmpty(staffS))
                            {
                                continue; // just read next line dont throw exceprion
                            }

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
        }

        internal Dictionary<string, Staff> GetStuffMembersByIds(List<string> empIds)
        {
            var stuff = GetAllStuffMembers()                // all records from file
                .Where(a => empIds.Contains(a.Key))      // filter only these that we need
                .ToDictionary(a => a.Key, a => a.Value);     //  convert result to dictionary

            return stuff;
        }

        public bool Authorize(string loginName, string password)
        {
            var staffList = GetAllStuffMembers();
            var authorised = false;
            var user = staffList.FirstOrDefault(s => s.Value.Username == loginName);
            if (user.Value != null)
            {
                authorised = staffList[user.Value.IdNumber].Password == password;
            }

            return authorised;
        }
    }
}