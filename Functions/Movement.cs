using KGA_OOPConsoleProject.Objects;
using System.Drawing;
using KGA_OOPConsoleProject.Printers;


namespace KGA_OOPConsoleProject.Functions
{
    public class Movement
    {
        public Point playerPos;
        public Point obstaclePost;
        public ConsoleKey input;


        public Game game;
        public Map map;
        
        public Player player;
        public Printer printer;
        public void Moves()
        {

            
            Point next = player.playerPos;
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    next = new Point(game.player.playerPos.X, playerPos.Y - 1);
                    break;
                case ConsoleKey.DownArrow:
                    next = new Point(playerPos.X, playerPos.Y + 1);
                    break;
                case ConsoleKey.LeftArrow:
                    next = new Point(playerPos.X - 1, playerPos.Y);
                    break;
                case ConsoleKey.RightArrow:
                    next = new Point(playerPos.X + 1, playerPos.Y);
                    break;
            }
            if (game.map.map[next.Y, next.X])
            {
                playerPos = next;
            }
         
           
        }

    }
}
