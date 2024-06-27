using System.Linq.Expressions;
using System.Reflection;

namespace C__12
{
    class Program
    {
        public delegate void DelegateChoice();

        public static void NewGame()
        {
            Console.WriteLine("Новая игра!");
        }

        public static void DownloadGame()
        {
            Console.WriteLine("Игра загружается!");
        }

        public static void Rules()
        {
            Console.WriteLine("Правила игры:");
        }

        public static void AboutTheAuthor()
        {
            Console.WriteLine("Об авторе:");
        }

        public static void Exit()
        {
            Console.WriteLine("Выход!");
        }


        static void Main(string[] args)
        {
            DelegateChoice choice = NewGame;
            choice += DownloadGame;
            choice += Rules;
            choice += AboutTheAuthor;
            choice += Exit;

            Console.WriteLine("Выберите пункт меню: ");
            Console.WriteLine("1 - новая игра");
            Console.WriteLine("2 - загрузить игру");
            Console.WriteLine("3 - правила");
            Console.WriteLine("4 - об авторе");
            Console.WriteLine("0 - выход");
            Console.WriteLine();
            Console.WriteLine("Ваш выбор: ");
            Console.WriteLine();
            int a = Convert.ToInt32(Console.ReadLine());

            Delegate d = choice.GetInvocationList()[a];

            //choice.GetInvocationList()[a];

        }
    }

}


