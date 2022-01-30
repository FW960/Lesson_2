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


            Console.WriteLine("Введите число от 1 до 12");
            string nameOfMonthInString = Console.ReadLine();
            if (nameOfMonthInString == "1" || nameOfMonthInString == "2" || nameOfMonthInString == "3" || nameOfMonthInString == "4" || nameOfMonthInString == "5" || nameOfMonthInString == "6" || nameOfMonthInString == "7" || nameOfMonthInString == "8" || nameOfMonthInString == "9" || nameOfMonthInString == "10" || nameOfMonthInString == "11" || nameOfMonthInString == "12")
          {     
            int nameOfMonthInInt = Convert.ToInt32(nameOfMonthInString);

            Console.WriteLine("Введите максимальную температуру за сегодня");
            string max = Console.ReadLine(); float Max = Convert.ToSingle(max);

            Console.WriteLine("Введите минимальную температуру за сегодня");
            string min = Console.ReadLine(); float Min = Convert.ToSingle(min);

            float averageTemp = Max + Min / 2;

            DateTime Month = new DateTime(0001,nameOfMonthInInt, 01);
            string b = Month.ToString("MMMM");

            bool WhenItsHotterInTheWinter = averageTemp > 0;

            if (WhenItsHotterInTheWinter && b == "Декабрь") 
            {
                Console.WriteLine("Дождливая зима");
                Console.ReadLine();
            }
            else if (WhenItsHotterInTheWinter && b == "Январь") 
            {
                Console.WriteLine("Дождливая зима");
                Console.ReadLine();
            }
            else if (WhenItsHotterInTheWinter && b == "Февраль")
            {
                Console.WriteLine("Дождливая зима");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{b} {averageTemp}C");
                Console.ReadLine();
            }
          } else
            {
                Console.WriteLine("Введите корректный номер месяца");
                Console.ReadLine();
            }
       }
    }        
}
