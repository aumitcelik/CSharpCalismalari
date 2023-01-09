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
            // odev.soru2();

            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            // odev.soru3();

            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            odev.soru4();
        }



    }
    class Sorular
    {
        public void soru1()
        {
            Metodlar metod = new Metodlar();
            Sorular soru = new Sorular();
            byte n = metod.pozitifDegerOkuma(out n);
            byte m = 2;
            int[] x = new int[n];
            metod.diziOlusturma(out x, n);
            metod.kalansizBolunenleriEkranaYazdirma(x, m);
        }
        public void soru2()
        {
            Metodlar metod = new Metodlar();
            byte n = metod.pozitifDegerOkuma(out n);
            byte m = metod.pozitifDegerOkuma(out m);
            int[] x = new int[n];
            metod.diziOlusturma(out x, n);
            metod.kalansizBolunenleriEkranaYazdirma(x, m);
        }
        public void soru3()
        {
            Metodlar metod = new Metodlar();
            byte n = metod.pozitifDegerOkuma(out n);
            string[] x = new string[n];
            metod.diziOlusturma(out x, n);
            metod.kelimeYazma(x);
        }
        public void soru4()
        {
            Console.WriteLine("Bir Cümle Yazın");
            string x = Console.ReadLine();
            x = x.ToLower();
            int numberofcharacters = x.Count();
            string letters = "abcçdefgğhıijklmnoöprsştuüvyzxwq";
            int numberofletters = 0;
            for (int i = 0; i < numberofcharacters; i++)
            {
                if (letters.Contains(x[i]))
                {
                    numberofletters++;
                }
            }
            Console.WriteLine("harf sayısı:" + numberofletters);
            string[] kelime = x.Split(' ');
            Console.WriteLine("kelime sayısı: " + kelime.Length);
        }
    }
}

class Metodlar
{
    public byte pozitifDegerOkuma(out byte n)
    {
        Console.WriteLine("pozitif bir sayı girin ");
        n = Convert.ToByte(Console.ReadLine());
        return n;
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
    public object diziOlusturma(out string[] x, int n)
    {
        x = new string[n];
        for (int i = 0; i < x.Length; i++)
        {
            Console.Write("Lütfen {0}. kelimeyi girin:", i + 1);
            x[i] = Console.ReadLine();
        }
        return x;
    }
    public void kalansizBolunenleriEkranaYazdirma(int[] x, Byte m)
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
    public void kelimeYazma(string[] x)
    {
        for (int i = (x.Length - 1); i >= 0; i--)
        {
            Console.WriteLine(x[i]);
        }
    }
}
