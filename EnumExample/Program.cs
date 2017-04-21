using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek day1 = DayOfWeek.Monday;
            Console.WriteLine(day1 + " " + (int)day1);
            int a = 5;
            Console.WriteLine((DayOfWeek)a);
            Print(day1);

            Console.WriteLine();
            PrintAllEnumValues();

        }

        static void Print(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Friday:
                    Console.WriteLine("youhooww");
                    break;
                default:
                    Console.WriteLine("nnooo");
                    break;
            }
        }
        static void PrintAllEnumValues()
        {
            string[] enumNames = Enum.GetNames(typeof(DayOfWeek));
            for (int i = 0; i < enumNames.Length; i++)
            {
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), enumNames[i]);
                Console.WriteLine(enumNames[i] + " " + day + " " + (int)day);
            }

        }

    }
}
