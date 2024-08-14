using System.Drawing;

namespace KGA_OOPConsoleProject.Functions
{
    public class Movement
    {
        private Point playerPos;
        private Point obstaclePost;
        private ConsoleKey input;

        public Game game;
        public Map map;

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
        //    if (map[next.X, next.Y])
        //    {
        //        playerPos = next;
        //    }

         //   if (map[next.X, next.Y])
         //   {
         //       playerPos = next;
         //   }

        }
    }
}
