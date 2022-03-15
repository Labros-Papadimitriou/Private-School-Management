using System;
using System.Collections.Generic;
using ProjectPartB.Core.Entities;

namespace ProjectPartB.HelperClasses.PrintTables
{
    public class PrintCourseTable
    {
        public static void PrintCourseTitle()
        {
            const int space = -20;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------------------------ALL COURSES-----------------------------------------");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"TITLE",space}{"STREAM",space}{"TYPE",space}{"START DATE",space}{"END DATE",space}");
            Console.ResetColor();
        }

        public static void PrintCourseRows(IEnumerable<Course> courses)
        {
            const int space = -20;
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Title,space}{course.Stream,space}{course.Type,space}{course.StartDate.ToShortDateString(),space}{course.EndDate.ToShortDateString(),space}");
            }
        }
    }
}