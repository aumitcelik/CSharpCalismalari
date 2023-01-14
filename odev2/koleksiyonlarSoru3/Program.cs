using System;
using System.Linq;
namespace koleksiyonlarSoru2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle girin:");
            string input = Console.ReadLine().ToLower(); // cümleyi küçük harfe çeviriyoruz
            string vowels = "euıüaiöo"; // sesli harfler
            char[] vowelsInInput = input.Where(c => vowels.Contains(c)).ToArray(); // sesli harfleri diziye atıyoruz
            Array.Sort(vowelsInInput); // dizi içindeki elemanları alfabetik olarak sıralıyoruz
            Console.WriteLine("Sesli harfler: " + String.Join(", ", vowelsInInput)); // sesli harfleri yazdırıyoruz
        }
    }
}