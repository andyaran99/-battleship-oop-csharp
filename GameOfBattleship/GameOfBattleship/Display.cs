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
            Console.WriteLine("1 - For a game Player vs Player on a 10 spaces board.");
            Console.WriteLine("2 - For a game Player vs Player on a 20 spacesBoard.");
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


        public void DisplayGameResults(Board board1,Board board2)
        {
            Console.WriteLine("We have a winner");
            Console.WriteLine("\n");
            Console.WriteLine(board1);
            Console.WriteLine(board2);
        }

        public void DisplayNotValidDirection()
        {
            Console.WriteLine("Not a valid direction!");
            Console.WriteLine("Pls give a right direction!");
        }

        public void DisplayDirectionOptions()
        {
            Console.WriteLine("A valid direction is: ");
            Console.WriteLine(" Down.");
            Console.WriteLine(" Up.");
            Console.WriteLine(" Left.");
            Console.WriteLine(" Right.");
            
        }

        public void DisplayNotValidShipType()
        {
            Console.WriteLine("Not a valid ship type!");
            Console.WriteLine("Pls give a right ship type!");
            


        }
        public void DisplayShipTypeOptions()
        {
            Console.WriteLine("A valid ship type is: ");
            Console.WriteLine("1. Battleship.");
            Console.WriteLine("2. Cruiser.");
            Console.WriteLine("3. Carrier.");
            Console.WriteLine("4. Destroyer");
            Console.WriteLine("5. Submarine");
        }

       
        
        public void PrintMessageForCoordonates()
        {
            Console.WriteLine("Please give coordonates! ");
            Console.WriteLine("Valid coordonates are a letter from A-J followed by a number from 1-10");
        }

        public void PrintErrorMessageForCoordonates()
        {
            Console.WriteLine("Not valid cordonates ");
        }

        public void CheckMessageForCoordonates((int,int)coord)
        {
            Console.WriteLine(coord.Item1);
            Console.WriteLine(coord.Item2);
        }

        public void PrintMessageForNumberOfShips()
        {
            Console.WriteLine("Please give valid number of ships! ");
            Console.WriteLine("The ships can be up to 5 on a board! ");
        }

        public void PrinErrorMessageForNumberOfShips()
        {
            Console.WriteLine("Not a valid number! ");
        }

        public void PlayerPreparation(string a){
            Console.WriteLine($"Player {a} place your ships! ");
        }

        public void PlayerMove(string a)
        {
            Console.WriteLine($"Player {a} shoot at coordonates! ");
        }


    }
}
