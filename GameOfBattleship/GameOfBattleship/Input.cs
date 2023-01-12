using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfBattleship
{
    public class Input
    {
        public int AskBoardLength()
        {
            var display = new Display();
            var validations = new Validations();
            display.DisplayMainMenu();
            string input = Console.ReadLine();
            var boardSize = validations.BoardSize(input);
            return boardSize;
        }

        public int AskForNumberOfShips()
        {
            var display = new Display();
            var validations = new Validations();
            display.PrintMessageForNumberOfShips();
            string input = Console.ReadLine();
            var numberOfShips = validations.NumberOfShips(input);
            return numberOfShips;
        }

        public (int x,int y) AskForCoordonates(Board boardInput)
        {

            var display = new Display();
            var validations = new Validations();
            display.PrintMessageForCoordonates();
            string input = Console.ReadLine();
            var coordonates = validations.Coordonates(input,boardInput);
            return coordonates;
        }


        public (int x, int y) AskForCoordonatesShoot(Board boardInput)
        {

            var display = new Display();
            var validations = new Validations();
            display.PrintMessageForCoordonates();
            string input = Console.ReadLine();
            var coordonates = validations.CoordonatesShoot(input, boardInput);
            return coordonates;
        }
        public string AskForDirection()
        {
            var display = new Display();
            var validations = new Validations();
            display.DisplayDirectionOptions();
            string input = Console.ReadLine();
            var directions = validations.Direction(input);
            return directions;
        }

        public ShipType AskForShipType()
        {
            var display = new Display();
            var validations = new Validations();
            display.DisplayShipTypeOptions();
            string input = Console.ReadLine();
            var shipType = validations.MakeShipType(input);
            return shipType;
        }
    }
}
