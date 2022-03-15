using System;
using System.Collections.Generic;
using ProjectPartB.Core.Entities;

namespace ProjectPartB.HelperClasses.PrintTables
{
    public class PrintCourseAssignmentTable
    {
        public static void PrintCourseAssignmentTitle()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------------------ALL ASSIGNMENTS PER COURSE-------------------------------");
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void PrintCourseAssignmentRows(IEnumerable<Course> courses)
        {
            const int space = -25;
            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{"COURSE:"} {course.Title} - {course.Stream} - {course.Type}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{"",space + 10} {"TITLE",space} {"DESCRIPTION",space - 5} {"SUB DATE TIME"}");
                Console.ResetColor();
                foreach (var assignment in course.Assignments)
                {
                    Console.WriteLine($"{"ASSIGNMENT:",space + 10} {assignment.Title,space} {assignment.Description,space - 5} {assignment.SubDateTime.ToShortDateString()}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}