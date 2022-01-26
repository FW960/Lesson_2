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
            WeekDays Office1 = (WeekDays)0b_0011000;
            WeekDays Office2 = (WeekDays)0b_1100000;
            WeekDays Office3 = (WeekDays)0b_0000111;

            WeekDays worksFromThurdayToFriday = WeekDays.Thurday | WeekDays.Friday;
            WeekDays worksFromSaturdayToSunday = WeekDays.Saturday | WeekDays.Sunday;
            WeekDays worksFromMondayToWednesday = WeekDays.Monday | WeekDays.Tuesday | WeekDays.Wednesday;

            WeekDays Office1WorkTime = Office1 & worksFromThurdayToFriday;
            WeekDays Office2WorkTime = Office2 & worksFromSaturdayToSunday;
            WeekDays Office3WorkTime = Office3 & worksFromMondayToWednesday;

            bool isOffice1ReallyWorkFromFridayToThurday = Office1 == Office1WorkTime;
            bool isOffice2ReallyWorkFromSaturdayToSunday = Office2 == Office2WorkTime;
            bool isOffice3ReallyWorkFromMondayyoWednesday = Office3 == Office3WorkTime;

            if (isOffice1ReallyWorkFromFridayToThurday == true)
            {
                Console.WriteLine("Офис 1 работает с четверга по пятницу");
            }
            else
            {
                Console.WriteLine("Офис 1 работает в другое время");
            }
            if (isOffice2ReallyWorkFromSaturdayToSunday == true)
            {
                Console.WriteLine("Офис 2 работает с субботу по воскресенье");
            }
            else
            {
                Console.WriteLine("Офис 2 работает в другое время");
            }
            if (isOffice3ReallyWorkFromMondayyoWednesday == true)
            {
                Console.WriteLine("Офис 3 работает с понедельника по среду");
            }else
            {
                Console.WriteLine("Офис 3 работает в другое время");
            }
;

        }
        [Flags]
        public enum WeekDays
        {
            Monday =    0b_0000001,
            Tuesday =   0b_0000010,
            Wednesday = 0b_0000100,
            Thurday =   0b_0001000,
            Friday =    0b_0010000,
            Saturday =  0b_0100000,
            Sunday =    0b_1000000,
        }

    }


}


