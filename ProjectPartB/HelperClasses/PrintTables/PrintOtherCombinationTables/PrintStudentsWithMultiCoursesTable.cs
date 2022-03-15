using System;
using System.Collections.Generic;
using ProjectPartB.Core.Entities;

namespace ProjectPartB.HelperClasses.PrintTables
{
    public class PrintStudentWithMultiCoursesTable
    {
        public static void PrintStudentWithMultiCoursesTitle()
        {
            const int space = -25;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------------------ALL STUDENTS WITH MULTIPLE COURSES-------------------------------");
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void PrintStudentWithMultiCoursesRows(IEnumerable<Student> students)
        {
            const int space = -25;
            foreach (var student in students)
            {
                if (student.Courses.Count > 1)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{"STUDENT:"} {student.FirstName} {student.LastName} - {student.DateOfBirth.ToShortDateString()}");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{"",space + 10} {"TITLE",space} {"DESCRIPTION",space} {"SUB DATE TIME"}");
                    Console.ResetColor();
                    foreach (var course in student.Courses)
                    {
                        Console.WriteLine($"{"Course:",space + 10} {course.Title,space} {course.Stream,space} {course.Type}");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}