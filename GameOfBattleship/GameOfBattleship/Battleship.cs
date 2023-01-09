using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfBattleship
{
    public class Battleship
    {
        public static void Main(string[] args)
        {
            Game g=new Game();
            g.Start();
        }



        protected Display _display { get; set; }
        protected Input _input { get; set; }

        protected BoardFactory _BoardFactory { get; set; }

        
        
    }
}
