using System;
using System.Collections;


namespace koleksiyonlarSoru1
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodlar metod = new Metodlar();
            ArrayList ilkListe = new ArrayList();
            metod.listeyeEkle(ilkListe);

            ArrayList asalListe = new ArrayList();
            ArrayList asalOlmayanListe = new ArrayList();
            foreach (uint item in ilkListe)
            {
                if (metod.Asalmi(item) == true)
                {
                    asalListe.Add(item);
                }
                else if (metod.Asalmi(item) == false)
                {
                    asalOlmayanListe.Add(item);
                }
            }

            uint toplam = 0;
            asalListe.Sort();
            asalListe.Reverse();
            Console.WriteLine("_____________asal değerler__________________");
            foreach (uint item in asalListe)
            {
                Console.WriteLine(item);
                toplam = toplam+item;
            }
            Console.WriteLine("asal değerlerin bulunduğu dizinin uzunluğu: {0}", asalListe.Count);
            Console.WriteLine("asal değerlerin bulunduğu dizinin ortalaması: {0}", toplam/asalListe.Count);

            toplam=0;
            asalOlmayanListe.Sort();
            asalOlmayanListe.Reverse();
            Console.WriteLine("_____________asal olmayan değerler____________");
            foreach (uint item in asalOlmayanListe)
            {
                Console.WriteLine(item);
                toplam = toplam+item;
            }
            Console.WriteLine("asal olmayan değerlerin bulunduğu dizinin uzunluğu: {0}", asalOlmayanListe.Count);
            Console.WriteLine("asal olmayan değerlerin bulunduğu dizinin ortalamsı: {0}", toplam/asalOlmayanListe.Count);

        

        }

    }


    class Metodlar
    {
        public ArrayList listeyeEkle(ArrayList ilk)
        {
            Console.WriteLine("20 Adet Pozitif Değer Giriniz");
            int i = 1;
            while (i <= 20)
            {
                try
                {
                    Console.WriteLine("{0}. değeri girin", i);
                    uint deger = Convert.ToUInt32(Console.ReadLine());
                    ilk.Add(deger);
                    i++;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Pozitif Sayısal Değer Girin");
                }
            }
            return ilk;
        }


        public bool Asalmi(uint sayi)
        {
            int i;
            for (i = 2; i <= sayi - 1; i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }
            if (i == sayi)
            {
                return true;
            }
            return false;
        }
 
    }
}

