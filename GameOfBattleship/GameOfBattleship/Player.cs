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
        public Player(List<Ship> ships)
        {
            this.ships=ships;
           // isAlive = GetPlayerState(ships);
        }

        public List<Ship> GetShips()
        {
            return ships;

        }
       
        
        public bool GetPlayerState()
        {
            var validation = new Validations();
            var result = validation.IsPlayerStillAlive(ships);
            return result;
        }

    }
}
