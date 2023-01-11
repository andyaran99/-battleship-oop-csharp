﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfBattleship
{
    public class Player
    {
        protected List<Ship> ships;

        public Player(List<Ship> ships)
        {
            this.ships=ships;
        }

        public List<Ship> GetShips()
        {
            return ships;

        }
        protected bool isAlive { get; }

    }
}
