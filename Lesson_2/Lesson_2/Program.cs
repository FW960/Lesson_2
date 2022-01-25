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
            Console.WriteLine("Введите максимальную температуру за сегодняшний день:");
            string max = Console.ReadLine();
            float Max = Convert.ToSingle(max);
            Console.WriteLine("Введите минимальную температуру за сегодняшний день:");
            string min = Console.ReadLine();
            float Min = Convert.ToSingle(min);
            bool Weather = Max > Min;
            if (Weather == true)
            {
                Console.WriteLine((Max + Min) / 2);
            }
            else return;
            
        }
    }
}
