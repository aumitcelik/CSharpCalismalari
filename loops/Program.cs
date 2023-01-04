using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine(i);
                if (i == 7)
                    break;
            }
            //while
            int sayac = 1;
            while (sayac <= 5)
            {
                Console.WriteLine(sayac);
                sayac++;
            }
            //ForEach
            int[] sayiDizisi = { 2, 4, 5, 1, 2, 4 };
            int toplam = 0;

            foreach (int i in sayiDizisi)
            {
                toplam += i;
            }
            Console.WriteLine(toplam);
        }
    }
}
