namespace proje2
{
    public class Menu
    {

        public void Menu1(ref List<Kart> toDo,
         ref List<Kart> inProgress,
         ref List<Kart> done,
         List<Person> directory)//0
        {

            Actions actions = new Actions();
            Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz :) \n");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            int action;
            action = Convert.ToInt32(Console.ReadLine());
            switch (action)
            {
                case 1:
                    Console.Clear();
                    actions.listingBoard(toDo, inProgress, done, directory);
                    Menu1(ref toDo, ref inProgress, ref done, directory);
                    break;
                case 2:
                    Console.Clear();
                    actions.addToDo(ref toDo, directory);
                    Menu1(ref toDo, ref inProgress, ref done, directory);
                    break;
                case 3:
                    Console.Clear();
                    actions.deleteKart(ref toDo, ref inProgress, ref done, directory);
                    Menu1(ref toDo, ref inProgress, ref done, directory);
                    break;
                case 4:
                    Console.Clear();
                    actions.moveKart(ref toDo, ref inProgress, ref done, directory);
                    Menu1(ref toDo, ref inProgress, ref done, directory);
                    break;
                default:
                    Menu1(ref toDo, ref inProgress, ref done, directory);
                    break;

            }
        }

    }
}