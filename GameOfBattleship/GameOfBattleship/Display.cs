using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfBattleship
{
    public class Display
    {

        public void DisplayMainMenu(){}

        public void DisplayBoard(Board board)
        {
            Console.WriteLine(board);
            
        }


        public void DisplayGame(Board palyer1Board, Board player2Board)
        {
            Console.WriteLine(palyer1Board);
            Console.WriteLine(player2Board);
        }


        public void DisplayEndResults(Board boardWinner){
            Console.WriteLine(boardWinner);
        }

        public void DisplayNotValidDirection(){
            Console.WriteLine("Not a valid direction!");
            Console.WriteLine("Pls give a right direction!");
            DisplayDirectionOptions();
        }

        public void DisplayDirectionOptions()
        {
            Console.WriteLine("A valid direction is: ");
            Console.WriteLine("1. Down.");
            Console.WriteLine("2. Up.");
            Console.WriteLine("3. Left.");
            Console.WriteLine("1. Right.");

        }

        public void DisplayNotValidShipType() { }

    }
}
