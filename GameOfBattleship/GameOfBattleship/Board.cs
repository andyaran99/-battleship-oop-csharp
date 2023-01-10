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
            for (var i = 0; i < boardLength; i++)
            {
                for (var j = 0; j < boardLength; j++)
                {
                    ocean[i,j]=(new Square((i, j), SquareStatus.Empty)); 
                }
                
            }
        }

        public void AddShipToBoard(Board board, Ship ship)
        {
            var shipSquares = ship.GetShipSquares();
            

            foreach (var square in shipSquares)
            {
                ocean[square.GetSquarePosition().x,square.GetSquarePosition().y].ChangeStatus(square,SquareStatus.Ship);
            }
        }

        
        public bool IsPlacementOk()
        {
            return true;
        }
    }
}
