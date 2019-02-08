using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class Store
    {

        int maxGames = 4; 


        List<Game> showcase = new List<Game>();

        public void AddGame(Game game)
        {
            if(showcase.Count < maxGames)
            showcase.Add(game);
        }


        public Store()
        {
            showcase.Add(new Game("Daddy Simulator", 15, "How to dad", "real-life"));
            showcase.Add(new Game("HalfLife 3", 15, "lose half your body", "not-real-life"));
            showcase.Add(new Game("Hat in Time", 20, "How to mom", "4D-Platformer"));
        }

        public void RemoveGame(Game game)
        {
            if(showcase.Contains(game))
            showcase.Remove(game); 
        }

        public void Sell(Game game, User user)
        {
            if (user.wallet >= game.price)
            {
                user.library.Add(game);
                user.wallet -= game.price;
                RemoveGame(game);
          
            }
            Console.WriteLine("Not enough money");
        }

        public string search;
        public string games;
        public string genre;
        private bool available;
        public string owned;
        Game Daddy = new Game("Daddy simulator", 10, "Simulate a daddy", "Fantasy");
        
    }
    
    class User
    {
        public float wallet;
        public List<Game> library = new List<Game>();

        public User(float walletFunds)
        {
            wallet = walletFunds;
        }
    }

    class Game
    {
       public string genre;
       public string name;
       public string description;
       public float price;

        public Game(string name, float price, string description, string genre)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.genre = genre;
        }
    }

    class DLC
    {

    }


}
