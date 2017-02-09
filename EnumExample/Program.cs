using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class MyClass
    {
        public static void Display(WeekDays d)
        {
            switch(d)
            {
                case WeekDays.Monday:
                    Console.WriteLine("This is first day of the week");
                    break;
                case WeekDays.Tuesday:
                    Console.WriteLine("This is second day of the week");
                    break;
                case WeekDays.Wednesday:
                    Console.WriteLine("This is third day of the week");
                    break;
                case WeekDays.Thursday:
                    Console.WriteLine("This is fourth day of the week");
                    break;
                case WeekDays.Friday:
                    Console.WriteLine("This is fifth day of the week");
                    break;
                case WeekDays.Saturday:
                    Console.WriteLine("This is sixth day of the week");
                    break;
                case WeekDays.Sunday:
                    Console.WriteLine("This is seventh day of the week");
                    break;
                default:
                    Console.WriteLine("you choose wrong day");
                    break;
            }
        }
    }
 
     
    class Program
    {
        static void Main(string[] args)
        {

            WeekDays day = WeekDays.Thursday;
            MyClass.Display(day);
            Console.ReadLine();
        }
    }
}
            
