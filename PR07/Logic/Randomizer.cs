using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR07.Logic
{
    public class Randomizer
    {
        private Random rand;

        public Randomizer() {
            rand = new Random();
        }
        
        public int MyRandom()
        {
            return rand.Next();
        }
    }
}
