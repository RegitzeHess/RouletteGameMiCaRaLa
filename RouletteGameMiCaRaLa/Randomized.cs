using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGameMiCaRaLa
{
    public class Randomized : IRandomized
    {
        private Random rnd = new Random();

        public void CreateRandom()
        {
            rnd.Next(0, 37);
        }
    }
}
