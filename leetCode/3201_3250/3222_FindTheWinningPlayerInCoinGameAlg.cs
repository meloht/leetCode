using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3201_3250
{
    public class _3222_FindTheWinningPlayerInCoinGameAlg
    {
        public string LosingPlayer(int x, int y)
        {
            return Math.Min(x, y / 4) % 2 != 0 ? "Alice" : "Bob";
        }
    }
}
