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
        
        public Player Player;
        public Printer printer;
        public void Moves()
        {
            map = new Map();
            
            Point next = playerPos;
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    next = new Point(playerPos.X, playerPos.Y - 1);
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
          //  if (map[next.Y, next.X])
          //  {
          //      playerPos = next;
          //  }
         
           
        }
    //    public void MoveUP()
    //    {
    //        Point next = new Point() { X = playerPos.X, Y = playerPos.Y - 1};
    //        if (map[next.Y, next.X])
    //        {
    //            playerPos = next;   
    //        }
    //    }
    }
}
