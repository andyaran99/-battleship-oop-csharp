using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfBattleship
{
    public class Board
    {
        private Square[,] ocean;

        public Board(int boardLength)
        {
            ocean = new Square[boardLength,boardLength];
            for (var i = 0; i < boardLength; i++)
            {
                for (var j = 0; j < boardLength; j++)
                {
                    ocean[i,j]=new Square((i, j), SquareStatus.Empty); 
                }
                
            }
        }

        public void AddShipToBoard(Board board, Ship ship)
        {
            var shipSquares = ship.GetShipSquares();
            

            foreach (var square in shipSquares)
            {
                ocean[square.position.x,square.position.y].ChangeStatus(SquareStatus.Ship);
               
            }
        }


        public override string ToString()

        {
            StringBuilder sb = new StringBuilder();

            for (var i=0; i< ocean.GetLength(0);i++)
            {
                for (var j = 0; j < ocean.GetLength(1); j++)
                {
                    sb.Append("|");
                    sb.Append(ocean[i,j].GetCharacter(ocean[i,j]));
                }

                sb.Append("\n");

            }

            return sb.ToString();
        }


        

        public Square[,] GetBoardSquares(Board board)
        {
            return ocean;
        }
    }
}
