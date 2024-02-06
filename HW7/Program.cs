namespace HW7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Play play1 = new Play("Test", 2020, "TestUser", 1);
            play1.ShowInfo();
            play1.StartPlay();
            play1 = null;

            GC.Collect();
            GC.WaitForFullGCApproach();
            GC.Collect();

            Console.WriteLine("End");
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

    public class Play
    {
        public string Name { get; set; }
        public int Date { get; set; }
        public string Author { get; set; }
        public int Genre_Play { get; set; }

        public Play(string Name, int Date, string Author, int Genre_Play)
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
            Console.WriteLine($"Автор: {Author}\nПьеса: {Name}\nЖанр:{Enum.GetName(typeof(Genre), Genre_Play)}\nГод написания:{Date}");
        }


    }
}

