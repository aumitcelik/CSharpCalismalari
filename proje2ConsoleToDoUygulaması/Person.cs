namespace proje2
{
    public class Person
    {
        int id;
        string ad;
        public int Id { get => id; set => id = value; }

        public string Ad { get => ad; set => ad = value; }
        public Person(int id, string ad)
        {
            Id = id;

            Ad = ad;
        }
    }
}