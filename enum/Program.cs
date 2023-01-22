using System;

namespace enumDefault
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Gunler.Pazar);
        Console.WriteLine((int)Gunler.Pazartesi);

        int sıcaklık = 10;

        if (sıcaklık <= (int)HavaDurumu.Normal)
            Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
        else if (sıcaklık >= (int)HavaDurumu.Sıcak)
            Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün.");
        else if (sıcaklık >= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.CokSıcak)
            Console.WriteLine("Hadi dışarıya çıkalım!");

    }
}

enum Gunler
{
    Pazartesi,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soguk = -15,
    Normal = 5,
    Sıcak = 25,
    CokSıcak = 30
}
}
