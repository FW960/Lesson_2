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
            Console.WriteLine("Введите целое число:");
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            bool z = ( b % 2 == 0);
            if (z == true)
            {
                Console.WriteLine("Число четное");
            }
            else if (z == false)
            {
                Console.WriteLine("Число нечетное");
            }



        }
    }
}
