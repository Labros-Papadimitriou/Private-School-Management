using System;
using System.Collections.Generic;
using ProjectPartB.Core.Entities;

namespace ProjectPartB.HelperClasses.PrintTables
{
    public class PrintStudentsToReturnAssignmentsTable
    {
        public static void PrintStudentsToReturnAssignmentsRows(IEnumerable<Assignment> assignments, List<int> calendarWeek, out int count)
        {
            count = 0;
            foreach (var assignment in assignments)
            {
                foreach (var d in calendarWeek)
                {
                    if (assignment.SubDateTime.DayOfYear == d)
                    {
                        count++;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"--------------------ALL STUDENTS WHO NEED TO SUB {assignment.Title}-------------------");
                        Console.WriteLine();
                        Console.ResetColor();
                        if (assignment.Course is null) break;
                        foreach (var student in assignment.Course.Students)
                        {
                            Console.WriteLine($"This week {student.FirstName} {student.LastName} needs to Sub his assignment with Title: {assignment.Title}");
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}