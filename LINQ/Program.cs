namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ mmetodid");
            Console.WriteLine("1. Inimesed, kes elavad Tallinnas");
            Console.WriteLine("2. Toode hinnad kasvavalt");
            Console.WriteLine("3. projitseerimine");
            Console.WriteLine("4. Vahelejätmine");
            Console.WriteLine("5. Takewhile");
            Console.WriteLine("6. FirstOrDefault");
            Console.WriteLine("7. Statistika");
            Console.WriteLine("8. Kontroll");
            int choice = int.Parse(Console.ReadLine());
            //Sorteeri toode hinna järgi kasvavalt 

            switch (choice)
            {
                case 1:
                    Tallinn();
                    break;

                case 2:
                    Hinnad();
                    break;

                    case 3:
                    projitseerimine();
                    break;

                    case 4:
                    Vahelejätmine();
                        break;

                case 5:
                    Takewhile();
                    break;

                    case 6:
                    FirstOrDefault();
                    break;

                    case 7:
                    Statistika();
                    break;

                    case 8:
                        Kontroll();
                    break;

                default:
                    Console.WriteLine("Vale Valik");
                    break;
            }

        }

        public static void Tallinn()
        {
            Console.WriteLine("-------Tallinn-------");

            var thenByResult = ClientList.Clients.Where(x => x.City == "Tallinn");
            foreach (var client in thenByResult) 
            {
                Console.WriteLine(client.Name);
            }
        }

        public static void Hinnad() 
        {
            //kuvab esimese elemendi, mis järjestuses
            //vastab tingimustele
            var firstprice = ProductList.Product
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.Price);

            Console.WriteLine("The first price is '{2}'.", firstprice);
        }

        public static void projitseerimine()
        {
            Console.WriteLine("-------Kliendid-------");
            Console.Clear();
            //Väljastab ainult kliente
            var ProductPrice = ClientList.Clients.Select(x => new{x = x.Name});
            foreach (var product in ProductPrice)
            { 
                Console.WriteLine(product.x); 
            }
        }

        public static void Vahelejätmine()
        {
            Console.WriteLine("---------Vahelejätmine---------");
            //mis tähendab: => . See t'hendab lambda märki ja selle
            //abil saab kasutada pikema classi nimetuse asemel lühendit
            //koos sees oleva muutujaga, mis antud juhul on x. 
            var skipWhile = ProductList.Product.SkipWhile(x => x.Price < 20);

            foreach (var item in skipWhile)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Price);
            }
        }

        public static void Takewhile()
        {
            Console.WriteLine("---------TakeWhile---------");
            //mis tähendab: => . See t'hendab lambda märki ja selle
            //abil saab kasutada pikema classi nimetuse asemel lühendit
            //koos sees oleva muutujaga, mis antud juhul on x. 
            var skipWhile = ProductList.Product.TakeWhile(x => x.Price < 50);

            foreach (var item in skipWhile)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Price);
            }
        }

        public static void FirstOrDefault()
        {
            //kuvab esimese elemendi, mis järjestuses
            //vastab tingimustele
            string firstLongName = ClientList.Clients
                .FirstOrDefault(x => x.Id.Equals(3)).Name;

            Console.WriteLine(firstLongName);
        }

        public static void Statistika()
        {
            var minPrice = ProductList.Product
                .Min(x => x.Price);

            Console.WriteLine("Kõike väiksem hind on " + minPrice);
        
        var sumPrice = ProductList.Product.Sum(x => x.Price);
        Console.WriteLine("Koondsumma on " + sumPrice);

            Console.WriteLine("------------------------------");
            
        }

        public static void Kontroll()
        {
            bool result = ProductList.Product
                .Any(x => x.Amount > 0 );

            Console.WriteLine(result);
        }
    }
}
