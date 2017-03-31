using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
public    class StudentOperations
    {
        Dictionary<string, Student> _studentList;

        public void Start(string fileName)
        {
            _studentList = GetStudents(fileName);
        }

        public void HandleMenuItems()
        {
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
                    foreach (var student in _studentList)
                    {
                        Console.WriteLine($" display student");
                    }
                    break;


                case 2:

                    break;

                case 3:
                    //exit
                    break;
            }
        }

        private Dictionary <string, Student> GetStudents(string fileName)
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

            return students;
        }
    }
}
