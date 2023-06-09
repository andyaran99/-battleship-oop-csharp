﻿



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
            
            while (player1.GetPlayerState() && player2.GetPlayerState())
            {
                Console.WriteLine(player1.GetPlayerState());
                Console.WriteLine(player2.GetPlayerState());
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
            Shoot(coordMove,board,ships);
            foreach (var ship in ships)
            {
                if (validation.IsShipDead(ship))
                {

                    ship.MakeShipDead();
                }
            }
        }

        public void Shoot((int row, int col) coord, Board board,List<Ship> ships)
        {
            var squares = board.GetBoardSquares(board);
            if (squares[coord.row, coord.col].GetStatus() == SquareStatus.Empty)
            {
                squares[coord.row, coord.col].ChangeStatus(SquareStatus.Miss);
            }
            if (squares[coord.row, coord.col].GetStatus() == SquareStatus.Ship)
            {
                            Console.WriteLine("test1");
                squares[coord.row, coord.col].ChangeStatus(SquareStatus.Hit);
                            Console.WriteLine("test2");
                foreach (var ship in ships)
                {
                            Console.WriteLine("test3");
                    foreach (var square in ship.GetShipSquares())
                    {
                        Console.WriteLine("test4");

                        if (square.position == coord)
                        {
                            Console.WriteLine("sq tst1 " +square.GetStatus());
                            square.ChangeStatus(SquareStatus.Hit);
                            Console.WriteLine("sq tst1 " + square.GetStatus());

                        }
                    }
                }
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
