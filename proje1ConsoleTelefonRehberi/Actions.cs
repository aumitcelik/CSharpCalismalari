namespace proje1
{
    public class Actions
    {
        public void addPerson(ref List<Person> directory)//1
        {

            Console.WriteLine("Lütfen İsim Giriniz :");
            string Ad = Console.ReadLine();
            Console.WriteLine("Lütfen Soyisim Giriniz :");
            string Soyad = Console.ReadLine();
            Console.WriteLine("Lütfen Numara Giriniz :");
            string Numara = Console.ReadLine();
            directory.Add(new Person(Ad, Soyad, Numara));

            Console.WriteLine("Ekleme İşlemi Gerçekleştirildi ");
        }
        public void deletePerson(ref List<Person> directory)//2
        {
            string nameOrSurname;
            int loop = 1;
            int counter = 0;

            while (loop == 1)
            {
                Console.WriteLine("  Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                nameOrSurname = Console.ReadLine();

                foreach (var item in directory)
                {

                    if (item.Ad != nameOrSurname && item.Soyad != nameOrSurname)
                    {
                        counter++;
                        if (counter == directory.Count)
                        {
                            int i = 2;
                            while (i == 2)
                            {
                                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                                Console.WriteLine("Yeniden denemek için: (2)");
                                string basim = Console.ReadLine();
                                if (basim == "2")
                                {
                                    i = 1;
                                    loop = 1;
                                }
                                else if (basim == "1")
                                {
                                    i = 1;
                                    loop = 2;
                                }
                                else
                                {
                                    Console.WriteLine("Geçerli bir parametre girilmedi");
                                }
                            }
                        }
                    }
                    else if (item.Ad == nameOrSurname || item.Soyad == nameOrSurname)
                    {
                        Console.WriteLine(item.Ad + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                        string chose = Console.ReadLine();
                        if (chose == "y")
                        {
                            directory.RemoveAt(directory.IndexOf(item));
                            Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.Numara + " Silindi");
                            loop = 2;
                            break;
                        }
                        else if (chose == "n")
                        {
                            Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.Numara + " İçin silme işlemi iptal edildi");
                            loop = 2;
                            break;
                        }
                    }
                }
                counter = 0;
            }
        }
        public void updateNumber(ref List<Person> directory)//3
        {

            string nameOrSurname;
            int loop = 1;
            int counter = 0;

            while (loop == 1)
            {
                Console.WriteLine("  Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                nameOrSurname = Console.ReadLine();

                foreach (var item in directory)
                {

                    if (item.Ad != nameOrSurname && item.Soyad != nameOrSurname)
                    {
                        counter++;
                        if (counter == directory.Count)
                        {
                            int i = 2;
                            while (i == 2)
                            {
                                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
                                Console.WriteLine("Yeniden denemek için: (2)");
                                string basim = Console.ReadLine();
                                if (basim == "2")
                                {
                                    i = 1;
                                    loop = 1;
                                }
                                else if (basim == "1")
                                {
                                    i = 1;
                                    loop = 2;
                                }
                                else
                                {
                                    Console.WriteLine("Geçerli bir parametre girilmedi");
                                }
                            }
                        }
                    }
                    else if (item.Ad == nameOrSurname || item.Soyad == nameOrSurname)
                    {
                        Console.WriteLine(item.Ad + " " + item.Soyad + " isimli kişinin yeni numarasını giriniz: ");
                        string newNumber = Console.ReadLine();
                        Console.WriteLine(item.Ad + " isimli kişi numarası " + newNumber + " olarak güncellenmek üzere, onaylıyor musunuz ?(y/n)");
                        string chose = Console.ReadLine();
                        if (chose == "y")
                        {
                            item.Numara = newNumber;
                            Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.Numara + " güncellendi");
                            loop = 2;
                            break;
                        }
                        else if (chose == "n")
                        {
                            Console.WriteLine(item.Ad + " " + item.Soyad + " " + newNumber + " İçin güncelleme işlemi iptal edildi");
                            loop = 2;
                            break;
                        }
                    }
                }
                counter = 0;
            }
        }
        public void listingDirectory(ref List<Person> directory)//4
        {
            Console.WriteLine("Telefon Rehberi\n");
            foreach (var item in directory)
            {
                Console.WriteLine("İsim: " + item.Ad + "\n" + "Soyisim: " + item.Soyad + "\n" + "Telefon Numarası: " + item.Numara + "\n");
            }
        }

        public void searchPerson(ref List<Person> directory)//5
        {
            List<Person> searchList = new List<Person>();
            Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz. \n İsim veya soyisime göre arama yapmak için: (1)\n Telefon numarasına göre arama yapmak için: (2)\n");
            char selection = Convert.ToChar(Console.ReadLine());
            if (selection == '1')
            {

                Console.Clear();
                Console.Write("İsim veya soyisim giriniz : ");
                string name = Console.ReadLine();
                foreach (var item in directory)
                {
                    if (item.Ad == name || item.Soyad == name)
                    {
                        searchList.Add(new Person(item.Ad, item.Soyad, item.Numara));
                    }
                }

            }
            else if (selection == '2')
            {
                Console.Clear();
                Console.WriteLine("Telefon numarası giriniz.");
                string telefonNo = Console.ReadLine();
                foreach (var item in directory)
                {
                    if (item.Numara == telefonNo)
                    {
                        searchList.Add(new Person(item.Ad, item.Soyad, item.Numara));
                    }
                }
            }

            if (searchList.Count != 0)
            {
                foreach (var item in searchList)
                {
                    Console.WriteLine("İsim: " + item.Ad + "\n" + "Soyisim: " + item.Soyad + "\n" + "Telefon Numarası: " + item.Numara + "\n");
                }
            }

        }

    }
}
