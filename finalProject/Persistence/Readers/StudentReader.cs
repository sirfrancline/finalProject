using finalProject.Persistence.FileSingleAccessControlObjects;
using System;
using System.Collections.Generic;
using System.IO;

namespace finalProject.Persistence.Readers
{
    public class StudentReader
    {
        string fileName = @"TextFiles\student.txt";
        public Dictionary<string, Student> GetStudents()
        {
            var students = new Dictionary<string, Student>();
            lock (LockObjects.StLocker)
            {
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
}