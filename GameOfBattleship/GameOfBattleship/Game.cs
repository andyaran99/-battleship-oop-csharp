



namespace GameOfBattleship
{

    public class Game
    {

        public void Start()
        {
            var display = new Display();
            var board = new Board(10); 
            
            display.DisplayBoard(board);
        }

    }
    
}
