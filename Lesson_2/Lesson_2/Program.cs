using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца без пробелов:");
            string nameOfMonthInString = Console.ReadLine();
            if (nameOfMonthInString == "1" || nameOfMonthInString == "2" || nameOfMonthInString == "3" || nameOfMonthInString == "4" || nameOfMonthInString == "5" || nameOfMonthInString == "6" || nameOfMonthInString == "7" || nameOfMonthInString == "8" || nameOfMonthInString == "9" || nameOfMonthInString == "10" || nameOfMonthInString == "11" || nameOfMonthInString == "12")
            {
            int Month = Convert.ToInt32(nameOfMonthInString);
            bool correctMonthName = Month <= 12 && Month >= 1;
            DateTime DateOfMonth = new DateTime(0001, Month, 01);
            Console.WriteLine(DateOfMonth.ToString("MMMM"));
            Console.ReadLine();
            } else
            {
            Console.WriteLine("Введите корректный номер месяца");
            Console.ReadLine();
            }



            
        }
    }
}
