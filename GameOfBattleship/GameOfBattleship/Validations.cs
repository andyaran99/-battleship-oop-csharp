using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace GameOfBattleship
{
    public class Validations
    {
        
        public int BoardSize(string inputToCheck)
        {
            var input = new Input();
            if (inputToCheck == "1")
            {
                return 10;
            }
            if (inputToCheck == "2")
            {
                return 20;
            }

            return input.AskBoardLength();
        }



        public (int x, int y) Coordonates(string inputCoordonates,Board board)
        {
            var input = new Input();
            var display = new Display();

            (int x, int y) outputCoord;
            var isRow = int.TryParse(inputCoordonates.Remove(0, 1), out var col) ;
            var row = char.ToUpper(inputCoordonates[0]) - 65;

            if (isRow && InRange(row,board) && InRange(col-1,board)&& IsAnotherShip(row,col-1,board)){
                outputCoord = (row, col-1);
                return outputCoord;
            }
            display.PrintErrorMessageForCoordonates();
            return input.AskForCoordonates(board);
        }

        public (int x, int y) CoordonatesShoot(string inputCoordonates, Board board)
        {
            var input = new Input();
            var display = new Display();

            (int x, int y) outputCoord;
            var isRow = int.TryParse(inputCoordonates.Remove(0, 1), out var col);
            var row = char.ToUpper(inputCoordonates[0]) - 65;

            if (isRow && InRange(row, board) && InRange(col - 1, board))
            {
                outputCoord = (row, col - 1);
                return outputCoord;
            }
            display.PrintErrorMessageForCoordonates();
            return input.AskForCoordonates(board);
        }


        public bool InRange(int coord,Board board)
        {
            int boardSize = board.GetBoardSquares(board).GetLength(0);

            if (coord >= 0 && coord <boardSize)
            {
                return true;
            }

            return false;
        }


        public bool IsAnotherShip(int row, int col, Board board)
        {
            Square[,] boardSquares = board.GetBoardSquares(board);
            if (boardSquares[row, col].GetStatus() == SquareStatus.Empty)
            {
                return true;
            }
            return false;
        }


        public int NumberOfShips(string inputNumberOfShips)
        {
            var input = new Input();
            var display = new Display();

            var isNumber = int.TryParse(inputNumberOfShips, out var numberOfShips);
            if (isNumber && numberOfShips <= 5)
            {
                return numberOfShips;
            }
            display.PrinErrorMessageForNumberOfShips();
            return input.AskForNumberOfShips();
        }

        public bool CheckIfCanBePlaced( (int row,int col)position, string direction, ShipType shipType,Board board)
        {
            Ship ship=new Ship();
            var shipLength=ship.makeShipLength(shipType);
            var squares = board.GetBoardSquares(board);
            while (shipLength > 0)
            {
                try
                {
                    if (direction == "up")
                    {
                        if (squares[(position.row - shipLength+1), position.col].GetStatus() != SquareStatus.Empty)
                        {
                            return false;
                        }
                    }
                    if (direction == "down")
                    {
                        if (squares[(position.row + shipLength), position.col].GetStatus() != SquareStatus.Empty)
                        {
                            return false;
                        }
                    }
                    if (direction == "left")
                    {
                        if (squares[position.row, (position.col-shipLength+1)].GetStatus() != SquareStatus.Empty)
                        {
                            return false;
                        }
                    }
                    if (direction == "right")
                    {
                        if (squares[position.row, (position.col+shipLength-1)].GetStatus() != SquareStatus.Empty)
                        {
                            return false;
                        }
                    }
                }
                catch
                {
                    return false;
                }
                shipLength -= 1;
            }

            return true;
        }

        public string Direction(string inputDirection)
        {
            var input = new Input();
            var display = new Display();
            var inputDirectionResponse = inputDirection.ToLower();
            switch (inputDirection)
            {

                case "up":
                    return inputDirectionResponse;
                case "down":
                    return inputDirectionResponse;
                case "right":
                    return inputDirectionResponse;
                case "left":
                    return inputDirectionResponse;
                default: 
                    display.DisplayNotValidDirection();
                    return input.AskForDirection();
            }
        }
        public ShipType MakeShipType(string inputShipType)
        {
            var input = new Input();
            var display = new Display();
            inputShipType= inputShipType.ToLower();
            
            switch (inputShipType)
            {

                case "1":
                    return ShipType.Battleship;
                case "2":
                    return ShipType.Cruiser;
                case "3":
                    return ShipType.Carrier;
                case "4":
                    return ShipType.Destroyer;
                case "5":
                    return ShipType.Submarine;
                default:
                    display.DisplayNotValidShipType();
                    return input.AskForShipType();
            }

        }

        public bool IsPlayerStillAlive(List<Ship>ships)
        {
            foreach (var ship in ships)
            {
                Console.WriteLine(ship.GetShipSquares()[0]);
                var squares = ship.GetShipSquares();
                foreach (var square in squares)
                {
                    if (square.GetStatus()== SquareStatus.Ship)
                    {
                        return true;
                    }
                }


            }
            
            return false;
        }

        public bool IsShipDead(Ship ship)
        {
            var squares = ship.GetShipSquares();
            foreach (var square in squares)
            {
                if (square.GetStatus() != SquareStatus.Hit)
                {
                    return false;
                }
            }
            return true;
        }


    }


}
