using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfBattleship
{
    public class Square
    {
        public (int x, int y) position { get; private set; }
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

                case SquareStatus.Dead:
                    return " D ";

                default:
                    return " ";
            }

        }


        public void ChangeStatus(SquareStatus squareStatusToChange)
        {
            squareStatus=squareStatusToChange;
        }



       public void SetSquarePosition(int x, int y)
       {
            position=(x,y);
       }

       public SquareStatus GetStatus()
       {
          return this.squareStatus;
       }


    }
}
