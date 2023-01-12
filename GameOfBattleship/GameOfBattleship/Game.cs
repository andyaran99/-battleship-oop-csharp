



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

            var board1 = new Board(boardSize);
            var board2 = new Board(boardSize);
            display.DisplayBoard(board1);

            display.PlayerPreparation("1");
            var player1=PlacementPhase(board1,display,input);
            display.DisplayBoard(board1);


            display.PlayerPreparation("2");
            var player2=PlacementPhase(board2, display, input);
            display.DisplayBoard(board2);

            Round(player1,board1,player2,board2);

            
        }


        public Player PlacementPhase(Board boardInput,Display display,Input input)
        {
            var numberOfShips = input.AskForNumberOfShips();
            var valid = new Validations();
            List<Ship>ships=new List<Ship>();

            while (numberOfShips > 0)
            {
                var shipType = input.AskForShipType();
                var initialCoord = input.AskForCoordonates(boardInput);
                var directionOfTheShip =input.AskForDirection();
                if (valid.CheckIfCanBePlaced(initialCoord, directionOfTheShip, shipType, boardInput))
                {
                    var ship = new Ship(initialCoord, directionOfTheShip, shipType);
                    ships.Add(ship);
                    boardInput.AddShipToBoard(boardInput, ship);
                    numberOfShips -= 1;
                }
            }
            var player=new Player(ships);
            return player;
        }

        public void Round(Player player1, Board board1, Player player2, Board board2)
        {
            var display = new Display();
            
            while (player1.GetPlayerState(player1.GetShips()) && player2.GetPlayerState(player2.GetShips()))
            {
                display.PlayerMove("1");
                makeMove(board2, player1);
                display.PlayerMove("2");
                makeMove(board1, player2);
                display.DisplayGame(board1,board2);
            }
            
            display.DisplayGameResults(board1,board2);
        }

        public void makeMove(Board board,Player player)
        {
            var input = new Input();
            var validation = new Validations();
            var coordMove = input.AskForCoordonatesShoot(board);
            var ships = player.GetShips();
            Shoot(coordMove,board);
            foreach (var ship in ships)
            {
                if (validation.IsShipDead(ship))
                {
                    MakeShipDead(ship);
                }
            }
        }

        public void Shoot((int row, int col) coord, Board board)
        {
            var squares = board.GetBoardSquares(board);
            if (squares[coord.row, coord.col].GetStatus() == SquareStatus.Empty)
            {
                squares[coord.row, coord.col].ChangeStatus(SquareStatus.Miss);
            }
            if (squares[coord.row, coord.col].GetStatus() == SquareStatus.Ship)
            {
                squares[coord.row, coord.col].ChangeStatus(SquareStatus.Hit);
            }
        }

        public void MakeShipDead(Ship ship)
        {
            var squares = ship.GetShipSquares();
            foreach (var square in squares)
            {
                square.ChangeStatus(SquareStatus.Dead);
            }
        }

    }
    
}
