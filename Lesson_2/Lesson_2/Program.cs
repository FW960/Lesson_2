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
            Console.WriteLine("Введите максимальную температуру за сегодня");
            string max = Console.ReadLine(); float Max = Convert.ToSingle(max);
            Console.WriteLine("Введите минимальную температуру за сегодня");
            string min = Console.ReadLine(); float Min = Convert.ToSingle(min);
            float averageTemp = Max + Min / 2;

            Console.WriteLine("Введите число от 1 до 12");
            string nameOfMonthInString = Console.ReadLine();
            int nameOfMonthInInt = Convert.ToInt32(nameOfMonthInString);
            string nameOfMonth = "";
            switch (nameOfMonthInInt)
            {
                case 1:
                    nameOfMonth = "Январь";
                    break;
                case 2:
                    nameOfMonth = "Февраль";
                    break;
                case 3:
                    nameOfMonth = "Март";
                    break;
                case 4:
                    nameOfMonth = "Апрель";
                    break;
                case 5:
                    nameOfMonth = "Май";
                    break;
                case 6:
                    nameOfMonth = "Июнь";
                    break;
                case 7:
                    nameOfMonth = "Июль";
                    break;
                case 8:
                    nameOfMonth = "Август";
                    break;
                case 9:
                    nameOfMonth = "Сентябрь";
                    break;
                case 10:
                    nameOfMonth = "Октябрь";
                    break;
                case 11:
                    nameOfMonth = "Ноябрь";
                    break;
                case 12:
                    nameOfMonth = "Декабрь";
                    break;
                default:
                    return;
            }
            bool WhenItsHotterInTheWinter = averageTemp > 0;
            if (WhenItsHotterInTheWinter && nameOfMonth == "Декабрь") 
            {
                Console.WriteLine("Дождливая зима");
            }
            else if (WhenItsHotterInTheWinter && nameOfMonth == "Январь") 
            {
                Console.WriteLine("Дождливая зима");
            }
            else if (WhenItsHotterInTheWinter && nameOfMonth == "Февраль")
            {
                Console.WriteLine("Дождливая зима");
            }
            else
            {
                Console.WriteLine($"{nameOfMonth} {averageTemp}C");
            }
        }
    }
}
