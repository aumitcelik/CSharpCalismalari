using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}