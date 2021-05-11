using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoeConroy_s000196433
{
    class Game
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public double MetacriticScore { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public double Price { get; set; }
        public string Game_Image { get; set; }

        public void DecreasePrice(double decrease)
        {
            Price *= (double)(1 + decrease);
        }


    }
}
