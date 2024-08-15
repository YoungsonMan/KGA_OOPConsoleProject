using System.Drawing;

namespace KGA_OOPConsoleProject.Objects
{
    public class ObsFactory
    {
        //public Game game;
        public Obstacle Obstacle;

        public static T Instantiate<T>(string name) where T : Obstacle
        {
            #region 위아래
            if (name == "1")
            {
                Obstacle obstacleV = new Obstacle();
                obstacleV.name = "○";

                Point point = new Point();
                point.X = 1; point.Y = 1;
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("○");
                Console.ResetColor();

                return obstacleV as T;
            }
            else if (name == "2")
            {
                Obstacle obstacleV = new Obstacle();
                obstacleV.name = "○";

                Point point = new Point();
                point.X = 3; point.Y = 1;
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("○");
                Console.ResetColor();

                return obstacleV as T;
            }
            else if (name == "3")
            {
                Obstacle obstacleV = new Obstacle();
                obstacleV.name = "○";

                Point point = new Point();
                point.X = 5; point.Y = 1;
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("○");
                Console.ResetColor();

                return obstacleV as T;
            }
            else if (name == "4")
            {
                Obstacle obstacleV = new Obstacle();
                obstacleV.name = "○";

                Point point = new Point();
                point.X = 7; point.Y = 1;
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("○");
                Console.ResetColor();

                return obstacleV as T;
            }
            else if (name == "5")
            {
                Obstacle obstacleV = new Obstacle();
                obstacleV.name = "○";

                Point point = new Point();
                point.X = 9; point.Y = 1;
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("○");
                Console.ResetColor();

                return obstacleV as T;
            }
            else if (name == "6")
            {
                Obstacle obstacleV = new Obstacle();
                obstacleV.name = "○";

                Point point = new Point();
                point.X = 11; point.Y = 1;
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("○");
                Console.ResetColor();

                return obstacleV as T;
            }
            else if (name == "7")
            {
                Obstacle obstacleV = new Obstacle();
                obstacleV.name = "○";

                Point point = new Point();
                point.X = 13; point.Y = 1;
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("○");
                Console.ResetColor();

                return obstacleV as T;
            }
            else if (name == "8")
            {
                Obstacle obstacleV = new Obstacle();
                obstacleV.name = "○";

                Point point = new Point();
                point.X = 15; point.Y = 1;
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("○");
                Console.ResetColor();

                return obstacleV as T;
            }
            else if (name == "9")
            {
                Obstacle obstacleV = new Obstacle();
                obstacleV.name = "○";

                Point point = new Point();
                point.X = 17; point.Y = 1;
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("○");
                Console.ResetColor();

                return obstacleV as T;
            }
            #endregion

            #region 좌우
            if (name == "11")
            {
                Obstacle obstacleH = new Obstacle();
                obstacleH.name = "○";

                Point point = new Point();
                point.X = 1; point.Y = 1;
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("○");
                Console.ResetColor();

                return obstacleH as T;
            }
            else if (name == "12")
            {
                Obstacle obstacleH = new Obstacle();
                obstacleH.name = "○";

                Point point = new Point();
                point.X = 1; point.Y = 3;
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("○");
                Console.ResetColor();

                return obstacleH as T;
            }
            else if (name == "13")
            {
                Obstacle obstacleH = new Obstacle();
                obstacleH.name = "○";

                Point point = new Point();
                point.X = 1; point.Y = 5;
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("○");
                Console.ResetColor();

                return obstacleH as T;
            }
            else if (name == "14")
            {
                Obstacle obstacleH = new Obstacle();
                obstacleH.name = "○";

                Point point = new Point();
                point.X = 1; point.Y = 7;
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("○");
                Console.ResetColor();

                return obstacleH as T;
            }
            else if (name == "15")
            {
                Obstacle obstacleH = new Obstacle();
                obstacleH.name = "○";

                Point point = new Point();
                point.X = 1; point.Y = 9;
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("○");
                Console.ResetColor();

                return obstacleH as T;
            }
            else if (name == "16")
            {
                Obstacle obstacleH = new Obstacle();
                obstacleH.name = "○";

                Point point = new Point();
                point.X = 1; point.Y = 11;
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("○");
                Console.ResetColor();

                return obstacleH as T;
            }
            else if (name == "17")
            {
                Obstacle obstacleH = new Obstacle();
                obstacleH.name = "○";

                Point point = new Point();
                point.X = 1; point.Y = 13;
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("○");
                Console.ResetColor();

                return obstacleH as T;
            }
            else if (name == "18")
            {
                Obstacle obstacleH = new Obstacle();
                obstacleH.name = "○";

                Point point = new Point();
                point.X = 15; point.Y = 1;
                Console.SetCursorPosition(point.X, point.Y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("○");
                Console.ResetColor();

                return obstacleH as T;
            }
            #endregion

            else
            {
                return null;
            }
        }
    }
}
