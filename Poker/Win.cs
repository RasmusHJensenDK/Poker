using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Win
    {
        private int winnings;
        public Win(int winnings)
        {
            this.winnings = winnings;
        }

        public int GetWinnings()
        {
            return winnings;
        }
        public void Addtowinnings(int addtowin)
        {
            winnings = winnings + addtowin;
        }
    }
}
