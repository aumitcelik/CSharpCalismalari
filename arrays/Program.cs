using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Ders 
                        Console.Write("Lütfen dizinin eleman sayısını girin");
                        int elemanSayisi = Convert.ToInt32(Console.ReadLine());
                        int[] sayiDizisi = new int[elemanSayisi];
                        int toplam = 0;
                        for (int i = 0; i < sayiDizisi.Length; i++)
                        {
                            Console.Write("Lütfen {0}. sayıyı girin:", i + 1);
                            sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                            toplam += sayiDizisi[i];
                        }
                        double ortalama = toplam / elemanSayisi;
                        Console.WriteLine("Sayıların ortalaması: " + ortalama);
                        Console.ReadLine();
                        */
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine("-------Sırasız Dizi------");
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------Sıralı Dizi------");
            Array.Sort(sayiDizisi);

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }


            //Clear
            Console.WriteLine("-------Array Clear------");

            Array.Clear(sayiDizisi, 4, 3);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //Reverse
            Console.WriteLine("-------Array Reverse------");
            Array.Reverse(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }


            //İndexOf
            Console.WriteLine("-------Array IndexOf------");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 12));


            //Resize
            Console.WriteLine("-------Array Resize------");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 06;

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }



        }
    }
}