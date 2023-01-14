using System;
using System.Collections;


namespace koleksiyonlarSoru1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = new int[20];
            Console.WriteLine("{0} Adet Sayısal Değer Giriniz", sayiDizisi.Length);
            int i = 0;
            while (i < sayiDizisi.Length)
            {
                try
                {
                    Console.WriteLine("{0}. değeri girin", i);
                    sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                    i++;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Sayısal Değer Girin");
                }
            }
            
            Array.Sort(sayiDizisi);
            Array.Reverse(sayiDizisi);

            Console.WriteLine("En Büyük 3 değer;");
            int maxToplam=0;
            for ( i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}", sayiDizisi[i]);
                maxToplam = maxToplam+sayiDizisi[i];
            }
            Console.WriteLine("En Büyük 3 değerin ortalaması: {0}", maxToplam/3);

            Array.Reverse(sayiDizisi);
            Console.WriteLine("En Küçük 3 değer;");
            int minToplam=0;
            for ( i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}", sayiDizisi[i]);
                minToplam = minToplam+sayiDizisi[i];
            }
            Console.WriteLine("En Küçük 3 değerin ortalaması: {0}", minToplam/3);
            Console.WriteLine("En Büyük 3 değerin ortalaması ve En Küçük 3 değerin ortalamasının toplamı: {0}", (maxToplam/3)+(minToplam/3));

        }

    }
 
    }


