using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfBattleship
{
    public class Ship
    {
        protected List<Square> squares;
        protected ShipType type { get; }

       
        public Ship(  ShipType shipType, (int x, int y) inputOfTheFirstSquareOfTheShip, string directionOfTheShip)
        {
            squares= new List<Square>();
            type = shipType;
            MakeSquaresOfShip(inputOfTheFirstSquareOfTheShip, directionOfTheShip);
            
        }
       

        private void MakeSquaresOfShip((int x, int y) inputOfTheFirstSquareOfTheShip, string directionOfTheShip)
        {
            int shipLenght = makeShipLength(type);
            Square square = new Square(inputOfTheFirstSquareOfTheShip, SquareStatus.Ship);
            squares.Add(square);
            addShipSquares(shipLenght, inputOfTheFirstSquareOfTheShip, directionOfTheShip, type);
            
        }



        public int makeShipLength(ShipType shipType)
        {
            switch (shipType)
            {
                case ShipType.Battleship:
                    return 2;
                case ShipType.Carrier:
                    return 1;
                case ShipType.Cruiser:
                    return 3;
                case ShipType.Destroyer:
                    return 4;
                case ShipType.Submarine:
                    return 5;
                default:
                    new Display().DisplayNotValidShipType();
                    return -1;
            }
        }

        public void addShipSquares(int shipLenght,
            (int x, int y) inputOfTheFirstSquareOfTheShip,
            string directionOfTheShip,
            ShipType shipType)

        {
            Square square;
            for (int i = 0; i < shipLenght - 1; i++)
            {
                switch (directionOfTheShip)
                {
                    case "down":
                        inputOfTheFirstSquareOfTheShip.x -= 1;
                        square = new Square(inputOfTheFirstSquareOfTheShip, SquareStatus.Ship);
                        squares.Add(square);
                        break;
                    case "up":
                        inputOfTheFirstSquareOfTheShip.x += 1;
                        square = new Square(inputOfTheFirstSquareOfTheShip, SquareStatus.Ship);
                        squares.Add(square);
                        break;
                    case "left":
                        inputOfTheFirstSquareOfTheShip.y -= 1;
                        square = new Square(inputOfTheFirstSquareOfTheShip, SquareStatus.Ship);
                        squares.Add(square);
                        break;
                    case "right":
                        inputOfTheFirstSquareOfTheShip.y += 1;
                        square = new Square(inputOfTheFirstSquareOfTheShip, SquareStatus.Ship);
                        squares.Add(square);
                        break;
                    default:
                        new Display().DisplayNotValidDirection();
                        break;
                }
            }

        }

        public List<Square> GetShipSquares()
        {
            return this.squares;
        }



    }
}
