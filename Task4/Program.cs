// See https://aka.ms/new-console-template for more information
/// <summary>
/// Создать класс Article, содержащий следующие закрытые поля:
///• название товара;
///• название магазина, в котором продается товар;
///• стоимость товара в гривнах.
///Создать класс Store, содержащий закрытый массив элементов типа Article.
///Обеспечить следующие возможности:
///• вывод информации о товаре по номеру с помощью индекса;
///• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, выдать соответствующее сообщение;
///Написать программу, вывода на экран информацию о товаре.
/// </summary>
namespace Task4
{
    class Program
    {
        static void Main()
        {
            Article[] arts = new Article[3];
            arts[0]  = new Article();
            arts[1] = new Article();
            arts[2] = new Article();

            arts[0].name = "Носки";
            arts[1].name = "Варежки";
            arts[2].name = "Носки";
            arts[0].cost = 10;
            arts[1].cost = 20;
            arts[2].cost = 30;
            arts[0].nameShop = "Базар";
            arts[1].nameShop = "Базар";
            arts[2].nameShop = "Базар";

            Store store = new Store(arts);
            store.ShowInfo(1);
            Console.WriteLine("");
            store.ShowInfo("Носки");

            Console.ReadLine();
        }
    }
    class Article
    {
        public string name ="", nameShop="";
        public double cost;
    }
    class Store
    {
        private Article[] articles;
        public void ShowInfo(int id)
        {
            Article art = articles[id];
            Console.WriteLine($"Название {art.name}");
            Console.WriteLine($"Магазин {art.nameShop}");
            Console.WriteLine($"Стоимость {art.cost} гривен");
        }
        public void ShowInfo(string name)
        {
            Article[] arts = articles.Where(x => x.name == name).ToArray();
            foreach (Article art in arts)
            {
            Console.WriteLine($"Название {art.name}");
            Console.WriteLine($"Магащин {art.nameShop}");
            Console.WriteLine($"Стоимость {art.cost} гривен");
            }
        }
        public Store(Article[] articles)
        {
            this.articles = articles;
        }

    }
}