using finalProject.Persistence.FileSingleAccessControlObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject.Persistence.Writers
{
    public class StaffWriter
    {

        public Dictionary<string, Staff> GetStuffMembers(string fileName)
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

    }
}
