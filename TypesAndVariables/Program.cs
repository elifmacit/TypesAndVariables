using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("HelloWorld!");
            double number5 = 10.4;
            decimal number6 = 10.4m;

            char character = 'B';
            bool condition = false;
            byte number4 = 255;
            short number3 = 32767;
            int number1 = 2147483647;
            long number2 = 21474836478;
            var number7 = 10;
            number7 = 'B';
            Console.WriteLine("number1 is {0}", number1);
            Console.WriteLine("number2 is {0}", number2);
            Console.WriteLine("number3 is {0}", number3);
            Console.WriteLine("number4 is {0}", number4);
            Console.WriteLine("number5 is {0}", number5);
            Console.WriteLine("number6 is {0}", number6);
            Console.WriteLine("number7 is {0}", number7);
            Console.WriteLine("character is : {0}", (int)character);
            Console.WriteLine((int)Days.Wednesday);
            Console.ReadLine();

        }
    }

    enum Days
    {
        Monday=1,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
        
}
