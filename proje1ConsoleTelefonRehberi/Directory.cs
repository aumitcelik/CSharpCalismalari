namespace proje1
{
    public class Directorys
    {
        public static List<Person> directory = new List<Person>();
        public void Directory()
        {
            Menu actions = new Menu();
            directory.Add(new Person("George ", "Friedrich", "05555555555"));
            directory.Add(new Person("Zane", "Dowling", "04444444444"));
            directory.Add(new Person("Kontz", "Gyurka", "03333333333"));
            directory.Add(new Person("Leonard", "Caro", "02222222222"));
            directory.Add(new Person("Roy", "Ruben", "01111111111"));
            actions.Menu1(ref directory);
        }
    }
}
