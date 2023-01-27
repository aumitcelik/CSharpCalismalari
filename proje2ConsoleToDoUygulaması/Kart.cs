namespace proje2
{
    public class Kart
    {
        string baslik, icerik;
        Buyukluk buyukluk;
        int person;

        public string Baslik { get => baslik; set => baslik = value; }
        public string Icerik { get => icerik; set => icerik = value; }
        public int personData { get => person; set => person = value; }
        public Buyukluk buyuklukData { get => buyukluk; set => buyukluk = value; }

        public Kart(string baslik, string icerik, int person, Buyukluk buyukluk)
        {
            Baslik = baslik;
            Icerik = icerik;
            buyuklukData = buyukluk;
            personData = person;
        }
    }

    public enum Buyukluk
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}