using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Pot
    {
        private int potsize = 0;
        public Pot(int i)
        {
            this.potsize = potsize + i;
        }

        public int Returnpotsize()
        {
            return potsize;
        }

        public void Addtopot(int bet)
        {
            potsize = potsize + bet;
        }
    }
}
