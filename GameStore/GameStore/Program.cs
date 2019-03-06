using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Store store = new Store();
            User myuser = new User(100);
           

            while (true)
            {
                store.PrintShowcase();
                Console.WriteLine("Input command");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "buy":
                        {
                            Console.WriteLine("Which game?");

                            string buyInput = Console.ReadLine();

                            int gameN = int.Parse(buyInput);

                            if (store.IsValidGame(gameN))
                            {
                                store.Sell(gameN, myuser);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Game!");
                            }
                        }
                        break;
                    case "add":
                        Console.WriteLine("Game name?");
                        string name = Console.ReadLine();

                        Console.WriteLine("Game description?");
                        string descr = Console.ReadLine();

                        Console.WriteLine("Game price?");
                        string price = Console.ReadLine();
                        float pr = float.Parse(price);

                        Console.WriteLine("Game Genre?");
                        string genre = Console.ReadLine();

                        Game game = new Game(name, pr, descr, genre);
                        store.AddGame(game);

                        break;
                    case "quit":
                        return;
                    default:
                        Console.WriteLine("Invalid comment!");
                        break;
                }
            }
        }
    }
}
