using System;
using System.Collections.Generic;
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

        public (int x, int y) Coordonates(string inputCoordonates)
        {
            var input = new Input();
            var display = new Display();

            (int x, int y) outputCoord;
            var isRow = int.TryParse(inputCoordonates.Remove(0, 1), out var row) ;
            var col = char.ToUpper(inputCoordonates[0]) - 65;

            if (isRow && InRange(row-1) && InRange(col)){
                outputCoord = (row - 1, col);
                display.CheckMessageForCoordonates(outputCoord);
                return outputCoord;
            }
            return input.AskForCoordonates();
        }

        public bool InRange(int coord)
        {
            if (coord >= 0 && coord < 10)
            {
                return true;
            }

            return false;
            ;
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

            return input.AskForNumberOfShips();
        }
    }
}
