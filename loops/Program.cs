using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine(i);
                if (i==7)
                break;
            }
        }
    }
}
