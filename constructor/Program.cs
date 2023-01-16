using System;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Söz Dizimi
             class SinifAdi
             {
             [Erişim Belirleyici] [Veri Tipi] OzellikAdi;    
             [Erişim Belirleyici(public private internal protected)] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
                 {
             //Metot Komutları    
                 }   
             }
             Erişim Belirleyiciler
             Public Heryerden Erişilebilir
             Private Sadece Tanımlandığı Sınıf içerisinden erişilebilir
             Internal Sadece Kendi Bulunduğu Proje içerisinde erişilebilir
             Protected Sadece Tanımlandığı sınıfta veya o sınıftan kalıtım alan diğer sınıflardan
            */
            Calisan calisan1 = new Calisan("Ahsen", "Ümit",12345678,"IT");
           /* calisan1.Ad = "Ahsen";
            calisan1.Soyad = "Ümit";
            calisan1.No = 12345678;
            calisan1.Departman = "IT";*/
            calisan1.CalisanBilgileri();
            Console.WriteLine("____________");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Ümit";
            calisan2.Soyad = "Çelik";
            calisan2.No = 23456789;
            calisan2.Departman = "HR";
            calisan2.CalisanBilgileri();
            Calisan calisan3 = new Calisan("Ahsen", "Ümit");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public Calisan() { }
        public Calisan(string ad, string soyad, int no, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            No = no;
            Departman = departman;
        }
        public Calisan(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı:{0}", Ad);
            Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışanın Numarası:{0}", No);
            Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
        }
    }

}