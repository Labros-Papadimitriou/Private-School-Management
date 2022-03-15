using System;
using System.Collections.Generic;
using ProjectPartB.Core.Entities;

namespace ProjectPartB.HelperClasses.PrintTables
{
    public class PrintCourseTrainerTable
    {
        public static void PrintCourseTrainerTitle()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------ALL TRAINERS PER COURSE--------------");
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void PrintCourseTrainerRows(IEnumerable<Course> courses)
        {
            const int space = -10;
            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{"COURSE:"} {course.Title} - {course.Stream} - {course.Type}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{"",space} {"FIRST NAME",space - 5} {"LAST NAME",space - 5} {"SUBJECT"}");
                Console.ResetColor();
                foreach (var trainer in course.Trainers)
                {
                    Console.WriteLine($"{"TRAINER:",space} {trainer.FirstName,space - 5} {trainer.LastName,space - 5} {trainer.Subject}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}