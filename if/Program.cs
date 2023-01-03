using System;

namespace if_else
{
    class Program
{
    static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;
        string sonuc = time>=6 && time<11 ? "Gunaydin": time<= 18 ? "İyi Günler": "İyi Geceler";
        Console.WriteLine(sonuc);
    }
}
}