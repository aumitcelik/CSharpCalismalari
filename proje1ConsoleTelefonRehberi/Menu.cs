namespace proje1
{
    public class Menu
    {
        public void Menu1(ref List<Person> directory)//0
        {
            Actions actions = new Actions();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) \n");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            int action;
            action = Convert.ToInt32(Console.ReadLine());
            switch (action)
            {
                case 1:
                    Console.Clear();
                    actions.addPerson(ref directory);
                    Menu1(ref directory);
                    break;
                case 2:
                    Console.Clear();
                    actions.deletePerson(ref directory);
                    Menu1(ref directory);
                    break;
                case 3:
                    Console.Clear();
                    actions.updateNumber(ref directory);
                    Menu1(ref directory);
                    break;
                case 4:
                    Console.Clear();
                    actions.listingDirectory(ref directory);
                    Menu1(ref directory);
                    break;
                case 5:
                    Console.Clear();
                    actions.searchPerson(ref directory);
                    Menu1(ref directory);
                    break;
                default:
                    break;
            }
        }
       

    }

}
