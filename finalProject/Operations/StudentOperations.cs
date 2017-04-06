using finalProject.Persistence.Readers;
using System;
using System.Collections.Generic;

namespace finalProject
{
    public class StudentOperations
    {
        private Dictionary<string, Student> _studentList;

        public void Start()
        {
            var reader = new StudentReader();
            _studentList = reader.GetAllStudents();
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
                        Console.WriteLine($" display student : {student}");
                    }
                    break;

                case 2:

                    break;

                case 3:
                    //exit
                    break;
            }
        }
    }
}