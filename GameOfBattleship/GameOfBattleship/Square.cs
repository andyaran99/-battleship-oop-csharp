using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfBattleship
{
    public class Square
    {
        private (int x, int y) position;
        protected SquareStatus squareStatus {get; set; }



        public Square((int x, int y) position,SquareStatus squareStatus)
        {
            this.position = position;
            this.squareStatus =squareStatus;
        }

        public string GetCharacter(Square square)
        {
            
            switch (square.squareStatus)
            {
                case SquareStatus.Empty:
                    return " ~ ";

                case SquareStatus.Hit:
                    return " H ";

                case SquareStatus.Miss:
                    return " M ";

                case SquareStatus.Ship:
                    return " S ";

                default:
                    return " ";
            }

        }


        public void ChangeStatus(Square square,SquareStatus squareStatusToChange)
        {
            square.squareStatus=squareStatusToChange;
        }

       public (int x, int y) GetSquarePosition()
       {
           return position;
       } 
    }
}
