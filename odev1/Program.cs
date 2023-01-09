using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorular odev = new Sorular();

            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            // odev.soru1();
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            odev.soru2();
        }


    }
    class Sorular
    {
        public void soru1()
        {
            Metodlar metod = new Metodlar();
            int n = metod.degerOkuma(out n);
            int m = 2;
            int[] x = new int[n];
            if (metod.sayiPozitifMi(n) == true) { metod.diziOlusturma(out x, n); }
            else metod.degerOkuma(out n);
            metod.kalansizBolunenleriEkranaYazdirma(x, m);
        }
        public void soru2()
        {
            Metodlar metod = new Metodlar();
            int n = metod.degerOkuma(out n);
            int m = metod.degerOkuma(out m);
            int[] x = new int[n];
            if (metod.sayiPozitifMi(n) == true)
            {
                if (
                metod.sayiPozitifMi(m) == true) { metod.diziOlusturma(out x, n); }
                else metod.degerOkuma(out m);
            }
            else metod.degerOkuma(out n);

            metod.kalansizBolunenleriEkranaYazdirma(x, m);
        }

    }
}

class Metodlar
{
    public int degerOkuma(out int n)
    {
        Console.WriteLine("pozitif bir sayı girin ");
        n = Convert.ToInt32(Console.ReadLine());
        return n;
    }
    public bool sayiPozitifMi(int n)
    {
        if (n > 0)
        {
            return true;
        }
        else
            return false;
    }

    public object diziOlusturma(out int[] x, int n)
    {
        x = new int[n];
        for (int i = 0; i < x.Length; i++)
        {
            Console.Write("Lütfen {0}. pozitif sayıyı girin:", i + 1);
            x[i] = Convert.ToInt32(Console.ReadLine());
        }
        return x;
    }
    public void kalansizBolunenleriEkranaYazdirma(int[] x,int m)
    {
        Console.WriteLine("Sonuç");
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] % m == 0 && x[i] > 0)
            {
                Console.WriteLine(x[i]);
            }
        }
    }
}
