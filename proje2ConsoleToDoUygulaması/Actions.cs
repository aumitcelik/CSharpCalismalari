namespace proje2
{
    public class Actions
    {
        public void listingBoard(
            List<Kart> toDo,
            List<Kart> inProgress,
            List<Kart> done,
            List<Person> directory)
        {
            Console.WriteLine("To Do Line");
            listKart(toDo, directory);
            Console.WriteLine("In Progress Line");
            listKart(inProgress, directory);
            Console.WriteLine("Done Line");
            listKart(done, directory);

        }
        private void listKart(List<Kart> secilmis, List<Person> directory)
        {
            foreach (var item in secilmis)
            {
                Console.WriteLine("\nBaşlık : " + item.Baslik + "\nİçerik : " + item.Icerik);
                listPerson(directory, item.personData);
                Console.WriteLine("Büyüklük : " + item.buyuklukData + "\n");
            }
        }
        private void listPerson(
            List<Person> directory,
            int personId
        )
        {
            foreach (var item in directory)
            {
                if (personId == item.Id)
                {
                    Console.WriteLine("Atanan Kişi : " + item.Ad);
                }
            }
        }

        public void addToDo(
           ref List<Kart> toDo,
           List<Person> directory)
        {
            Console.WriteLine("Başlık Giriniz : ");
            string baslik = Convert.ToString(Console.ReadLine());

            Console.WriteLine("İçerik Giriniz : ");
            string icerik = Console.ReadLine();

            foreach (var item in directory)
            {
                Console.WriteLine("id: " + item.Id + " İsim: " + item.Ad);
            }
            Console.WriteLine("Kişi ıd değerini giriniz : ");
            int personId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) : ");
            int buyuklukId = Convert.ToInt32(Console.ReadLine());
            switch (buyuklukId)
            {
                case 1:
                    toDo.Add(new Kart(baslik, icerik, personId, Buyukluk.XS));
                    Console.WriteLine("Yeni Kart Eklendi." + baslik + icerik);
                    break;
                case 2:
                    toDo.Add(new Kart(baslik, icerik, personId, Buyukluk.S));
                    Console.WriteLine("Yeni Kart Eklendi." + baslik + icerik);
                    break;
                case 3:
                    toDo.Add(new Kart(baslik, icerik, personId, Buyukluk.M));
                    Console.WriteLine("Yeni Kart Eklendi." + baslik + icerik);
                    break;
                case 4:
                    toDo.Add(new Kart(baslik, icerik, personId, Buyukluk.L));
                    Console.WriteLine("Yeni Kart Eklendi." + baslik + icerik);

                    break;
                case 5:
                    toDo.Add(new Kart(baslik, icerik, personId, Buyukluk.XL));
                    Console.WriteLine("Yeni Kart Eklendi." + baslik + icerik);
                    break;
                default:
                    Console.WriteLine("Hatalı Büyüklük");
                    break;
            }
        }

        public void deleteKart(
        ref List<Kart> toDo,
        ref List<Kart> inProgress,
        ref List<Kart> done, List<Person> directory)
        {
            Menu actions = new Menu();
            Console.WriteLine(" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor. \nLütfen kart başlığını yazınız: ");
            string baslikIndex = Console.ReadLine();
            int counter = 0;
            deleteKartFunc(ref toDo, ref counter, baslikIndex);
            deleteKartFunc(ref inProgress, ref counter, baslikIndex);
            deleteKartFunc(ref done, ref counter, baslikIndex);
            if (counter == 0)
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı.\n Lütfen bir seçim yapınız.\n Silmeyi sonlandırmak için : (1)\n Yeniden denemek için : (2)");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        actions.Menu1(ref toDo, ref inProgress, ref done, directory);
                        break;
                    case 2:
                        deleteKart(ref toDo, ref inProgress, ref done, directory);
                        break;
                }
            }
        }
        public void deleteKartFunc(ref List<Kart> secilmis, ref int counter, string baslikIndex)
        {
            for (int i = 0; i < secilmis.Count; i++)
            {
                if (secilmis[i].Baslik == baslikIndex)
                {
                    secilmis.RemoveAt(secilmis.IndexOf(secilmis[i]));
                    counter++;
                }
            }
        }

        public void moveKart(
        ref List<Kart> toDo,
        ref List<Kart> inProgress,
        ref List<Kart> done,
        List<Person> directory)
        {
            Menu actions = new Menu();
            Console.WriteLine(" Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor. \nLütfen kart başlığını yazınız: ");
            string baslikIndex = Console.ReadLine();
            int counter = 0;
            int line = 0;
            moveKartFunc(ref toDo, ref counter, baslikIndex, directory, ref toDo, ref inProgress, ref done, ref line);
            moveKartFunc(ref inProgress, ref counter, baslikIndex, directory, ref toDo, ref inProgress, ref done, ref line);
            moveKartFunc(ref done, ref counter, baslikIndex, directory, ref toDo, ref inProgress, ref done, ref line);
            if (counter == 0)
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı.\n Lütfen bir seçim yapınız.\n Taşımayı sonlandırmak için : (1)\n Yeniden denemek için : (2)");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        actions.Menu1(ref toDo, ref inProgress, ref done, directory);
                        break;
                    case 2:
                        moveKart(ref toDo, ref inProgress, ref done, directory);
                        break;
                }
            }

        }
        private void moveKartFunc(
        ref List<Kart> secilmis,
        ref int counter,
        string baslikIndex,
        List<Person> directory,
        ref List<Kart> toDo,
        ref List<Kart> inProgress,
        ref List<Kart> done,
        ref int line
        )
        {
            line++;
            for (int i = 0; i < secilmis.Count; i++)
            {
                if (secilmis[i].Baslik == baslikIndex)
                {
                    counter++;
                    Console.WriteLine("Bulunan Kart Bilgileri: \n Başlık : " + secilmis[i].Baslik);
                    Console.WriteLine("İçerik : " + secilmis[i].Icerik);
                    listPerson(directory, secilmis[i].personData);
                    Console.WriteLine("Büyüklük :" + secilmis[i].buyuklukData);
                    switch (line)
                    {
                        case 1:
                            Console.WriteLine("Line : To Do");
                            break;
                        case 2:
                            Console.WriteLine("Line : In Progress");
                            break;
                        case 3:
                            Console.WriteLine("Line : Done");
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine(" Lütfen taşımak istediğiniz Line'ı seçiniz:\n(1) TODO\n(2) IN PROGRESS\n(3) DONE");
                    int sec = Convert.ToInt32(Console.ReadLine());
                    switch (sec)
                    {
                        case 1:
                            toDo.Add(new Kart(secilmis[i].Baslik, secilmis[i].Icerik, secilmis[i].personData, secilmis[i].buyuklukData));
                            secilmis.RemoveAt(secilmis.IndexOf(secilmis[i]));
                            break;
                        case 2:
                            inProgress.Add(new Kart(secilmis[i].Baslik, secilmis[i].Icerik, secilmis[i].personData, secilmis[i].buyuklukData));
                            secilmis.RemoveAt(secilmis.IndexOf(secilmis[i]));
                            break;
                        case 3:
                            done.Add(new Kart(secilmis[i].Baslik, secilmis[i].Icerik, secilmis[i].personData, secilmis[i].buyuklukData));
                            secilmis.RemoveAt(secilmis.IndexOf(secilmis[i]));
                            break;
                    }
                }
            }
        }

    }
}