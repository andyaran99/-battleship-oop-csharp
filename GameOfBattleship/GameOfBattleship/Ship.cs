using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfBattleship
{
    public class Ship
    {
        protected List<Square> squares;
        protected ShipType type { get; }
    }
}
