using System.Collections;

namespace arrayList;
class Program
{
    static void Main(string[] args)
    {
        //System.Collections namespace

        ArrayList liste = new ArrayList();

        // liste.Add("Ali");
        liste.Add(2);
        // liste.Add(true);
        // liste.Add('A');

        //içerisindeki verilere erişim
        // Console.WriteLine(liste[1]);
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //AddRange
        Console.WriteLine("***************** Add Range **************");
        //string[] renkler = {"kırmızı", "mor", "sarı", "yeşil"};
        List<int> sayilar = new List<int>(){1,8,3,7,8,4,2,9,92,5};
        //liste.AddRange(renkler);
        liste.AddRange(sayilar);

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //Sort
        Console.WriteLine("******* Sort *******");
        
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        liste.Sort();

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }


        //Binary Search
        Console.WriteLine("**************** Binary Search *************");
        Console.WriteLine(liste.BinarySearch(9));

        //Reverse
        Console.WriteLine("**************** Reverse *************");
        liste.Reverse();
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //Clear
        Console.WriteLine("**************** Clear *************");
        liste.Clear();

        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }
    }
}