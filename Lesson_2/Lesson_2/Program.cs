using System;

namespace Lesson_2_Task6
{
    class Program
    {
        [Flags]
        public enum Weekdays
        {
            Понедельник = 0b_0000001,
            Вторник = 0b_0000010,
            Среда = 0b_0000100,
            Четверг = 0b_0001000,
            Пятница = 0b_0010000,
            Суббота = 0b_0100000,
            Воскресенье = 0b_1000000,
        }

        static void Main(string[] args)
        {
            Weekdays WorkingDayOfOffice1 = Weekdays.Понедельник | Weekdays.Вторник;
            Weekdays WorkingDayOfOffice2 = Weekdays.Среда | Weekdays.Четверг;
            Weekdays WorkingDayOfOffice3 = Weekdays.Пятница | Weekdays.Суббота | Weekdays.Воскресенье;
            
            Console.WriteLine("Чтобы узнать дни работы офиса введите его номер:");
            string dayOfWeekName = Console.ReadLine();
            switch (dayOfWeekName)
            {       case "1":
                    Console.WriteLine($"Работа офиса: {WorkingDayOfOffice1}");
                    Console.ReadLine();
                    break;

                    case "2":
                    Console.WriteLine($"Работа офиса: {WorkingDayOfOffice2}");
                    Console.ReadLine();
                    break;

                    case "3":
                    Console.WriteLine($"Работа офиса: {WorkingDayOfOffice3}");
                    Console.ReadLine();
                    break;

                    defalut:
                    Console.WriteLine("Введите корректный номер офиса.");
                    Console.ReadLine();
                    break;
                    }
              
                    


                    




                



            
        }
    }
}

