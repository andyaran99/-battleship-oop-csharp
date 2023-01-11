



using System.Security.Cryptography.X509Certificates;

namespace GameOfBattleship
{

    public class Game
    {

        public void Start()
        {
            var display = new Display();
            var board = new Board(10); //to do an input for board length from keyboard and validate it
            display.DisplayBoard(board);
            var initialCoord1 = (1, 6);
            var initialCoord2 = (1, 8);
            var initialCoord3 = (7, 8);
            var direction1 = "down";
            var direction2 = "left";
            var shipType1 = ShipType.Battleship;
            var shipType2 = ShipType.Cruiser;//to do input for initialCoord,direction and shipType and validate it
            List<Ship>ships= new List<Ship>();
            
            
            

            var ship1 = new Ship(shipType1,initialCoord1,direction1 );
            var ship2 = new Ship(shipType1,initialCoord2,direction1);
            var ship3 =new Ship( shipType2,initialCoord3,direction2);
            ships.Add(ship1);
            ships.Add(ship2);
            ships.Add(ship3);
            var player1 = new Player(ships);
            var boardFactory = new BoardFactory();
            boardFactory.FillManualBoard(board,player1.GetShips());
            display.DisplayBoard(board);


        }

    }
    
}
