using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ZoeConroy_s000196433
{
   public class Game
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public double CriticScore { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public decimal Price { get; set; }
        public string GameImage { get; set; }

        public Game(string _Name, double _CriticScore, string _Description, string _Platform , decimal _Price ,string _GameImage = "")
        {
            Name = _Name;
            CriticScore = _CriticScore;
            Description = _Description;
            Platform = _Platform;
            Price = _Price;
            GameImage = _GameImage;
        }

        public Game()
        {
        }

        public override string ToString()
        {
            return Name;
        }

        public void DecreasePrice(double decrease)
        {
            Price *= (decimal)(1 - decrease);
        }


    }
    public class GameData : DbContext
    {
        public GameData() : base("GameInformation") { }

        public DbSet<Game> Games { get; set; }
    }
}
