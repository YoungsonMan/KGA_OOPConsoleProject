using System.Drawing;

namespace KGA_OOPConsoleProject.Objects
{
    public class ObsFactory
    {
        //public Game game;
        public Obstacle Obstacle;
        public Point obsPos;


        public static T Instantiate<T>(string name) where T : Obstacle, IInteractable
        {
            Point obsPos = new Point();
            #region 위아래
            if (name == "1")
            {
                Obstacle obstacleV = new Obstacle();
                obstacleV.name = "○";

               
                obsPos.X = 1; obsPos.Y = 1;
                Console.SetCursorPosition(obsPos.X, obsPos.Y);
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
                obsPos.X = 3; obsPos.Y = 1;
                Console.SetCursorPosition(obsPos.X, obsPos.Y);
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
                obsPos.X = 5; obsPos.Y = 1;
                Console.SetCursorPosition(obsPos.X, obsPos.Y);
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
                obsPos.X = 7; obsPos.Y = 1;
                Console.SetCursorPosition(obsPos.X, obsPos.Y);
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
                obsPos.X = 9; obsPos.Y = 1;
                Console.SetCursorPosition(obsPos.X, obsPos.Y);
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
                obsPos.X = 11; obsPos.Y = 1;
                Console.SetCursorPosition(obsPos.X, obsPos.Y);
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
                obsPos.X = 13; obsPos.Y = 1;
                Console.SetCursorPosition(obsPos.X, obsPos.Y);
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
                obsPos.X = 15; obsPos.Y = 1;
                Console.SetCursorPosition(obsPos.X, obsPos.Y);
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
                obsPos.X = 17; obsPos.Y = 1;
                Console.SetCursorPosition(obsPos.X, obsPos.Y);
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
                obsPos.X = 1; obsPos.Y = 1;
                Console.SetCursorPosition(obsPos.X, obsPos.Y);
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
                obsPos.X = 1; obsPos.Y = 3;
                Console.SetCursorPosition(obsPos.X, obsPos.Y);
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
                obsPos.X = 1; obsPos.Y = 5;
                Console.SetCursorPosition(obsPos.X, obsPos.Y);
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
                obsPos.X = 1; obsPos.Y = 7;
                Console.SetCursorPosition(obsPos.X, obsPos.Y);
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
                obsPos.X = 1; obsPos.Y = 9;
                Console.SetCursorPosition(obsPos.X, obsPos.Y);
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
                obsPos.X = 1; obsPos.Y = 11;
                Console.SetCursorPosition(obsPos.X, obsPos.Y);
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
                obsPos.X = 1; obsPos.Y = 13;
                Console.SetCursorPosition(obsPos.X, obsPos.Y);
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
