using System;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
            Metotlar deneme = new Metotlar();
            int x = 3;
            int y = 4;

            int sonuc = deneme.Topla(x, y);
            deneme.ekranaYazdir(sonuc);
            deneme.Arttır(ref x, ref y);
            sonuc = deneme.Topla(x, y);
            deneme.ekranaYazdir(sonuc);
        }

    }
    class Metotlar
    {
        public void Arttır(ref int x, ref int y)
        {
            x += 1;
            y += y;
        }
        public int Topla(int x, int y)
        {
            return (x + y);
        }
        public void ekranaYazdir(int x)
        {
            Console.WriteLine(x);
        }
    }
}