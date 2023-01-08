using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodlar odev = new Metodlar();
            
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            odev.soru1();
        }


    }
    class Metodlar
    {
        public void soru1()
        {
            Console.WriteLine("pozitif bir sayı girin ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                int[] x = new int[n];
                for (int i = 0; i < x.Length; i++)
                {
                    Console.Write("Lütfen {0}. pozitif sayıyı girin:", i + 1);
                    x[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Çift Sayılar");
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] % 2 == 0 && x[i] > 0)
                    {
                        Console.WriteLine(x[i]);
                    }
                }
            }
            else
                soru1();
        }
    }
}