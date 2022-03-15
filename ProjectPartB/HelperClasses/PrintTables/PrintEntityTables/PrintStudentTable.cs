using System;
using System.Collections.Generic;
using ProjectPartB.Core.Entities;

namespace ProjectPartB.HelperClasses.PrintTables
{
    public class PrintStudentTable
    {
        public static void PrintStudentTitle()
        {
            const int space = -25;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------------------------------ALL STUDENTS--------------------------------------");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"FIRST NAME",space}{"LAST NAME",space}{"DATE OF BIRTH",space}{"TUITION FEES",space}");
            Console.ResetColor();
        }

        public static void PrintStudentRows(IEnumerable<Student> students)
        {
            const int space = -25;
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName,space}{student.LastName,space}{student.DateOfBirth.ToShortDateString(),space}{student.TuitionFees,space}");
            }
        }
    }
}