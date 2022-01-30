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
            Console.WriteLine("Введите номер месяца:");
            string nameOfMonthInString = Console.ReadLine();
            int Month = Convert.ToInt32(nameOfMonthInString);
            bool correctMonthName = Month <= 12 && Month >= 1;
            if (correctMonthName == true)
            {
                DateTime DateOfMonth = new DateTime(0001, Month, 01);
                Console.WriteLine(DateOfMonth.ToString("MMMM"));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Введите корректный номер месяца");
                Console.ReadLine();
                return;
            }
            
        }
    }
}
