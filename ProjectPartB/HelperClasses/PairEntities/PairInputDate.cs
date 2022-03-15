using ProjectPartB.Validations;
using System;
using System.Collections.Generic;

namespace ProjectPartB.HelperClasses
{
    public class PairInputDate
    {
        public static List<int> MatchInputDateTime(DateTime choice)
        {
            var weekDay = choice.DayOfWeek;
            var yearDay = choice.DayOfYear;

            List<int> calendarWeek = new List<int>();
            switch (weekDay)
            {
                case DayOfWeek.Monday: calendarWeek.AddRange(new List<int>() { yearDay, yearDay + 1, yearDay + 2, yearDay + 3, yearDay + 4 }); break;
                case DayOfWeek.Tuesday: calendarWeek.AddRange(new List<int>() { yearDay - 1, yearDay, yearDay + 1, yearDay + 2, yearDay + 3 }); break;
                case DayOfWeek.Wednesday: calendarWeek.AddRange(new List<int>() { yearDay - 2, yearDay - 1, yearDay, yearDay + 1, yearDay + 2 }); break;
                case DayOfWeek.Thursday: calendarWeek.AddRange(new List<int>() { yearDay - 3, yearDay - 2, yearDay - 1, yearDay, yearDay + 1 }); break;
                case DayOfWeek.Friday: calendarWeek.AddRange(new List<int>() { yearDay - 4, yearDay - 3, yearDay - 2, yearDay - 1, yearDay }); break;
                case DayOfWeek.Saturday: calendarWeek.AddRange(new List<int>() { yearDay - 5, yearDay - 4, yearDay - 3, yearDay - 2, yearDay - 1 }); break;
                case DayOfWeek.Sunday: calendarWeek.AddRange(new List<int>() { yearDay - 6, yearDay - 5, yearDay - 4, yearDay - 3, yearDay - 2 }); break;
                default: break;
            }
            if (DateTime.IsLeapYear(choice.Year - 1))
            {
                for (int i = 0; i < calendarWeek.Count; i++) { if (calendarWeek[i] <= 0) { calendarWeek[i] += 366; } }
            }
            else
            {
                for (int i = 0; i < calendarWeek.Count; i++) { if (calendarWeek[i] <= 0) { calendarWeek[i] += 365; } }
            }
            return calendarWeek;
        }

        public static DateTime AskInputDate()
        {
            string date;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("IMPORTANT INFO: ");
            Console.WriteLine("Courses start from 11-10-2021 till 11-04-2022");
            Console.ResetColor();
            do
            {
                Console.WriteLine("Enter a date: DD-MM-YYY (ex.25-12-2021)");
                date = Console.ReadLine();
                Console.Clear();
            } while (!Validation.IsProperDate(date));

            DateTime choice = Convert.ToDateTime(date);
            return choice;
        }
    }
}
