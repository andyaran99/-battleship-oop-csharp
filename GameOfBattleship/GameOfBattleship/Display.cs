using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfBattleship
{
    public class Display
    {

        public void DisplayMainMenu()
        {
            Console.WriteLine("Pick a game rule: ");
            Thread.Sleep(1000);
            Console.WriteLine("1 - For a game Player vs Player on a 10 spaces board.");
            Thread.Sleep(1000);
            Console.WriteLine("2 - For a game Player vs Player on a 20 spacesBoard.");
            Thread.Sleep(1000);
        }

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
            Thread.Sleep(1000);
            Console.WriteLine("Pls give a right direction!");
            Thread.Sleep(1000);
            DisplayDirectionOptions();
            Thread.Sleep(1000);

        }

        public void DisplayDirectionOptions()
        {
            Console.WriteLine("A valid direction is: ");
            Thread.Sleep(1000);
            Console.WriteLine("1. Down.");
            Thread.Sleep(1000);
            Console.WriteLine("2. Up.");
            Thread.Sleep(1000);
            Console.WriteLine("3. Left.");
            Thread.Sleep(1000);
            Console.WriteLine("1. Right.");
            Thread.Sleep(1000);
        }

        public void DisplayNotValidShipType()
        {
            Console.WriteLine("Not a valid ship type!");
            Thread.Sleep(1000);
            Console.WriteLine("Pls give a right ship type!");
            Thread.Sleep(1000);
            DisplayShipTypeOptions();
            Thread.Sleep(1000);

        }
        public void DisplayShipTypeOptions()
        {
            Console.WriteLine("A valid ship type is: ");
            Thread.Sleep(1000);
            Console.WriteLine("1. Battleship.");
            Thread.Sleep(1000);
            Console.WriteLine("2. Cruiser.");
            Thread.Sleep(1000);
            Console.WriteLine("3. Carrier.");
            Thread.Sleep(1000);
            Console.WriteLine("4. Destroyer");
            Thread.Sleep(1000);
            Console.WriteLine("5. Submarine");
            Thread.Sleep(1000);

        }

       
        
        public void PrintMessageForCoordonates()
        {
            Console.WriteLine("Please give coordonates: ");
            Thread.Sleep(1000);
            Console.WriteLine("Valid coordonates are a letter from A-J followed by a number from 0-9");
            Thread.Sleep(1000);
        }
        public void CheckMessageForCoordonates((int,int)coord)
        {
            Console.WriteLine(coord.Item1);
            Console.WriteLine(coord.Item2);
            Thread.Sleep(1000);


        }
        public void PrintMessageForNumberOfShips()
        {
            Console.WriteLine("Please give coordonates: ");
            Thread.Sleep(1000);
            Console.WriteLine("Valid coordonates are a letter from A-J followed by a number from 0-9");
            Thread.Sleep(1000);
        }
    }
}
