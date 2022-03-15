using System;
using System.Collections.Generic;
using ProjectPartB.Core.Entities;

namespace ProjectPartB.HelperClasses.PrintTables
{
    public class PrintTrainerTable
    {
        public static void PrintTrainerTitle()
        {
            const int space = -25;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------ALL TRAINERS------------------------");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"FIRST NAME",space}{"LAST NAME",space}{"SUBJECT",space}");
            Console.ResetColor();
        }

        public static void PrintTrainerRows(IEnumerable<Trainer> trainers)
        {
            const int space = -25;
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.FirstName,space}{trainer.LastName,space}{trainer.Subject,space}");
            }
        }
    }
}