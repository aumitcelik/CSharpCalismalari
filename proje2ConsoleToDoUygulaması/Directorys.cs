namespace proje2
{
    public class Directorys
    {
        public static List<Person> directory = new List<Person>();
        public static List<Kart> toDo = new List<Kart>();
        public static List<Kart> inProgress = new List<Kart>();
        public static List<Kart> done = new List<Kart>();
        public void Directory()
        {
            Menu actions = new Menu();
            directory.Add(new Person(0, "George Friedrich"));
            directory.Add(new Person(1, "Zane Dowling"));
            directory.Add(new Person(2, "Kontz Gyurka"));
            toDo.Add(new Kart("FrontEnd","Create Team",0,Buyukluk.XS));
            toDo.Add(new Kart("Backend","Create Team",1,Buyukluk.S));
            toDo.Add(new Kart("Database","Create Team",2,Buyukluk.L));
            actions.Menu1(ref toDo,ref inProgress, ref done, directory);

        }
    }
}