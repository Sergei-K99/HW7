namespace HW7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test1();

            GC.Collect();
            GC.WaitForFullGCApproach();
           

            Console.Read();


            Test2();


            void Test1()
            {
                Play play1 = new Play("Test", 2020, "TestUser", Genre.sci_fi);
                play1.ShowInfo();
                play1.StartPlay();

                using(Play play2 = new Play("Test2", 2022, "TestUser2", Genre.Action))
                {
                    play2.ShowInfo();

                }     
            }
            void Test2()
            {
                using (Shop shop = new Shop("ATB","street test", ShopType.product))
                {
                    shop.ShowMess();

                }
            }

        }
        
    }

    public enum Genre
    {
        Romance_comedy,
        sci_fi,
        Horror,
        Documentary,
        Animated_film,
        Action,
    }
    public enum ShopType { product  }
    public class Play : IDisposable
    {
        public string Name { get; set; }
        public int Date { get; set; }
        public string Author { get; set; }
        public Genre Genre_Play { get; set; }

        public Play(string Name, int Date, string Author, Genre Genre_Play)
        {
            this.Name = Name;
            this.Date = Date;
            this.Author = Author;
            this.Genre_Play = Genre_Play;
        }
        ~Play()
        {
            Console.Beep();
            Console.WriteLine("Деструктор отработал");
        }

        public void StartPlay()
        {
            Console.Beep(261, 500);
            Console.Beep(293, 500);
            Console.Beep(329, 500);
            Console.Beep(349, 500);
            Console.Beep(392, 500);
            Console.Beep(440, 500);
            Console.Beep(493, 500);
            Console.Beep(523, 500);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Автор: {Author}\nПьеса: {Name}\nЖанр:{Genre_Play}\nГод написания:{Date}");
        }

        public void Dispose()
        {
            Console.Beep();
            Console.WriteLine("Деструктор отработал2");
        }
    }

    public class Shop : IDisposable
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public ShopType type { get; set; }

        public Shop(string Name, string Street, ShopType type)
        {
            this.Name = Name;
            this.Street = Street;
            this.type = type;
        }

        public void Dispose()
        {
            Console.WriteLine("- Магазин удалён -");
        }


        public void ShowMess()
        {
            Console.WriteLine("Если честно, ничего не придумал что можно вписать");
        }
    }
}

