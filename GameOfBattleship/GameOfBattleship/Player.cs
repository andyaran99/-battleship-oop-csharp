using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfBattleship
{
    public class Player
    {
        protected List<Ship> ships;
        protected bool isAlive { get; }
        public Player(List<Ship> ships)
        {
            this.ships=ships;
            isAlive = GetPlayerState(ships);
        }

        public List<Ship> GetShips()
        {
            return ships;

        }
       
        public bool returnIsAlive(Player player)
        {
            return isAlive;
        }
        public bool GetPlayerState(List<Ship> playerShips)
        {
            var validation = new Validations();
            var result = validation.IsPlayerStillAlive(playerShips);
            return result;
        }

    }
}
