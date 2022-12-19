using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 5;
            int y = 6;

            y = y + 2;
            y += 2;

            x = x * 4;
            x *= 4;

            bool isTrue = true;
            bool isFalse = false;

            if (isTrue && isFalse)
            {
                Console.WriteLine("is not working.");
            }

            if (isTrue || isFalse)
            {
                Console.WriteLine("working");
            }

            if (isTrue && !isFalse)
            {
                Console.WriteLine("working");
            }

            int number1 = 10;
            int number2 = 20;
            bool result = number1 != number2;
            Console.WriteLine(result);


            int a = 35;
            int b = 7;
            int result2 = a / b;
            Console.WriteLine(result2);

            int c = a % 4;
            Console.WriteLine(c);
        }
    }
}