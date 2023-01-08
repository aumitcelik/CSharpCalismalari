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
            deneme.Arttır(ref x, ref y);
            deneme.Topla(x, y, out sonuc);
            deneme.ekranaYazdir(sonuc);

            //Extension 
            Console.WriteLine(x.IsEventNumber());
            //Rekürsif+Extension
            Console.WriteLine(1.FibonacciSerisi());
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

        //Metot Overloading 
        public int Topla(int a, int b, out int toplam)// out değişkeninin bir ilk değeri olmak zorunda değildir. 
        {
            toplam = a + b;
            return toplam;
        }

        public void ekranaYazdir(int x)
        {
            Console.WriteLine(x);
        }


    }

    //Extension 
    public static class MyExtensionClass
    {
        public static bool IsEventNumber(this int value)
        {
            if (value % 2 == 0)
                return true;
            else
                return false;
        }

        public static int FibonacciSerisi(this int sayi)
        {
            return sayi == 0 ? 0 : sayi == 1 ? 1 : FibonacciSerisi(sayi - 1) + FibonacciSerisi(sayi - 2);
        }

    }
}