using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            GameTitle();
        }

        public static void GameTitle()
        {
            Console.WriteLine("Добро пожаловать в мою игру. \nНажми 'Enter', чтобы начать.");
            Console.ReadLine();
            Console.Clear();
            First();
        }

        public static void First()
        {
            string choise;
            Console.WriteLine("Ты просыпаешься в классе со злым Стормом \nЧто ты будешь делать? \n1. Ударю\n2. Заплачу \n3. Описаюсь");
            Console.Write("Выбор: ");
            choise = Console.ReadLine().ToLower();
            Console.Clear();
            
            switch (choise)
            {
                case "1":
                case "Ударю":
                    {
                        Console.WriteLine("Твой кулак пробил лицо челику \nВсе студенты орут твоё имя \nЖена услышала и пришла проверить \nКогда она увидела мужа, который плакал в углу, она убила тебя своими лазерами \nНажми 'Enter', чтобы продолжить");
                        Console.ReadLine();
                        GameOver();
                        break;
                    }
                    case "2":
                case "Заплачу":
                    {
                        Console.WriteLine("Лицо сторма скривилось \nТы хочешь плакать? Делай это в коридоре! \nНажми 'Enter', чтобы продолжить");
                        Console.ReadLine();
                        Second();
                        break;
                    }
                    case"3":
                case "Пописаю":
                    {
                        Console.WriteLine("Все офигели \nВыметайся отсюда!");
                        Console.ReadLine();
                        Second();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Я не понимаю эту команду \nНажми Enter, чтобы попробовать ещё раз");
                        Console.ReadLine();
                        First();
                        break;
                    }
            }
        }
        public static void Second()
        {
            Random rnd = new Random();
            string[] SecOptions = { "В коридоре ты видишь, что военкомат пришёл с повестками", "В коридоре ты видишь, что завуч вышла из кабинета и почти заметила тебя", "В коридоре ты видишь, как кто-то случайно разбил окно" };
            int randomNumber = rnd.Next(0, 3);
            string SecText = SecOptions[randomNumber];

            string SecChoice;

            Console.WriteLine(SecText);
            Console.WriteLine("Попробуешь спрятаться в ванной? Да или нет?");
            Console.Write("Выбор: ");
            SecChoice = Console.ReadLine().ToLower();
            if (SecChoice == "yes" || SecChoice == "y")
            {
                Third();
            }
            else if (SecChoice == "no" || SecChoice == "n")
            {
                Console.WriteLine("Метеорит упал на школу прямо в этот момент и ты умер \nНажми 'Enter', чтобы продолжить");
                Console.ReadLine();
                GameOver();
            }
            else
            {
                Console.WriteLine("Я не понимаю эту команду \nНажми Enter, чтобы попробовать ещё раз");
                Console.ReadLine();
                Second();
            }
        }
        public static void Third()
        {
            int age;
            Console.WriteLine("Ты залез в ванную \nВсе твои друзья и родственники тоже тут.\nОни говорят СЮРПРИИИЗ \nТы вспоминаешь, что сегодня твой День Рождения \nСколько тебе исполнилось?");
            Console.Write("Сколько? ");
            int.TryParse(Console.ReadLine(), out age);

            while(age < 100)
            {
                Console.WriteLine("Серьёзно? Ты выглядишь старше \nСколько тебе на самом деле?");
                Console.Write("Сколько? ");
                int.TryParse(Console.ReadLine(), out age);
            }
            Console.WriteLine("Вау, ты старый. Много же ты повидал");
            Console.ReadLine();
            YouWin();
        }
        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("На твоих похоронах все пели песни о твоей храборости. \nПотом они вспомнили, чьи это похороны и забрали слова назад \nУдачи в следующий раз \nНажми 'Enter', чтобы попробовать снова");
            Console.ReadLine();
            Console.Clear();
            GameTitle();
        }
        public static void YouWin()
        {
            Console.Clear();
            Console.WriteLine("Твой день рождения это что-то с чем-то \nВсе получили суперсилы. \nВы все проживёте ещё 100 лет. \nНажми 'Enter', чтобы начать заново");
            Console.ReadLine();
            Console.Clear();
            GameTitle();
        }
    }
}
