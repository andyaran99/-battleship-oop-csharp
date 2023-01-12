



using System.Security.Cryptography.X509Certificates;

namespace GameOfBattleship
{

    public class Game
    {

        public void Start()
        {
            var display = new Display();
            var input= new Input();

            var boardSize = input.AskBoardLength();
            var numberOfShips = input.AskForNumberOfShips();
            var board1 = new Board(boardSize);
            var board2 = new Board(boardSize);
            PlacementPhase(board1,display,input,numberOfShips);
            PlacementPhase(board2, display, input, numberOfShips);
        }


        public void PlacementPhase(Board boardInput,Display display,Input input,int numberOfShips)
        {
            List<Ship>ships=new List<Ship>();
            while (numberOfShips > 0)
            {
                var initialCoord = input.AskForCoordonates();
                var directionOfTheShip = input.AskForDirection();
                var shipType = input.AskForShipType();
                var ship = new Ship(initialCoord, directionOfTheShip, shipType);
                ships.Add(ship);
                numberOfShips -= 1;
            }
            var player=new Player(ships);
            var boardFactory=new BoardFactory();
            boardFactory.FillManualBoard(boardInput,ships);
            display.DisplayBoard(boardInput);
            

        }

        public void Round(Player player1,Board board1,Player player2,Board board2){}
    }
    
}
