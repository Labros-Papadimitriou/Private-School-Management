using System;
using System.Collections.Generic;
using ProjectPartB.Core.Entities;

namespace ProjectPartB.HelperClasses.PrintTables
{
    public class PrintCourseStudentTable
    {
        public static void PrintCourseStudentTitle()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------ALL STUDENTS PER COURSE-----------------");
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void PrintCourseStudentRows(IEnumerable<Course> courses)
        {
            const int space = -10;
            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{"COURSE:"} {course.Title} - {course.Stream} - {course.Type}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{"",space} {"FIRST NAME",space - 5} {"LAST NAME",space - 5} {"DATE OF BIRTH"}");
                Console.ResetColor();
                foreach (var student in course.Students)
                {
                    Console.WriteLine($"{"STUDENT:",space} {student.FirstName,space - 5} {student.LastName,space - 5} {student.DateOfBirth.ToShortDateString()}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}