using System;

namespace Homework_P_1_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var months = new MonthsColection();

            months[0] = new MonthData("January", 31);
            months[1] = new MonthData("February", 28);
            months[2] = new MonthData("March", 31);
            months[3] = new MonthData("April", 30);
            months[4] = new MonthData("May", 31);
            months[5] = new MonthData("June", 30);
            months[6] = new MonthData("July", 31);
            months[7] = new MonthData("August", 31);
            months[8] = new MonthData("September", 30);
            months[9] = new MonthData("October", 31);
            months[10] = new MonthData("November", 30);
            months[11] = new MonthData("December", 31);

            Console.Write("Find by month day: ");
            int findByNumOfDays = Convert.ToInt32(Console.ReadLine());

            foreach (MonthData month in months)
            {
                if (month.MonthDays == findByNumOfDays)
                {
                    Console.WriteLine($"Name: {month.MonthName}; Nuber of days: {month.MonthDays}");
                }
            }

            Console.Write("Find by index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Name: {months[index].MonthName}; Nuber of days: {months[index].MonthDays}");
        }
    }
}