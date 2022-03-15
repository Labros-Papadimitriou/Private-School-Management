using System;
using System.Collections.Generic;
using ProjectPartB.Core.Entities;

namespace ProjectPartB.HelperClasses.PrintTables
{
    public class PrintStudentAssignmentTable
    {
        public static void PrintStudentAssignmentTitle()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------------------ALL ASSIGNMENTS PER STUDENT-------------------------------");
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void PrintStudentAssignmentRows(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(student.FirstName + " " + student.LastName);
                Console.ResetColor();
                foreach (var course in student.Courses)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(course.Title + "|" + course.Stream);
                    Console.ResetColor();
                    foreach (var assignment in course.Assignments)
                    {
                        Console.Write(assignment.Title + ", ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}