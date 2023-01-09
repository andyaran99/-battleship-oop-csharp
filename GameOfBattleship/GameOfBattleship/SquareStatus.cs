using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfBattleship
{
    public class SquareStatus
    {
        protected enum ShipType
        {
            empty,
            hit,
            miss,
            sunken
        }
    }
}
