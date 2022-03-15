using System;
using System.Collections.Generic;
using ProjectPartB.Core.Entities;

namespace ProjectPartB.HelperClasses.PrintTables
{
    public class PrintAssignmentTable
    {
        public static void PrintAssignmentTitle()
        {
            const int space = -35;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------ALL ASSIGNMENTS----------------------------------------------------------");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"TITLE",space}{"DESCRIPTION",space}{"SUB DATE TIME",space + 10}{"ORAL MARK",space + 15}{"TOTAL MARK",space}");
            Console.ResetColor();
        }

        public static void PrintAssignmentRows(IEnumerable<Assignment> assignments)
        {
            const int space = -35;
            foreach (var assignment in assignments)
            {
                Console.WriteLine($"{assignment.Title,space}{assignment.Description,space}{assignment.SubDateTime.ToShortDateString(),space + 10}{assignment.OralMark,space + 15}{assignment.TotalMark,space}");
            }
        }
    }
}