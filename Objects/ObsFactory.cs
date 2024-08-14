using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Objects
{
    public class ObsFactory
    {
        //public Game game;
        public Obstacle Obstacle;

        public static T Instantiate<T>(string name) where T : Obstacle
        {
            if (name == "1")
            {
                Obstacle obstacle = new Obstacle();
                obstacle.name = "○";
                static void PrintObstacle()
                {
                    Point point = new Point();
                    point.X = 1; point.Y = 1;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("○");
                    Console.ResetColor();
                }
                return obstacle as T;
            }
            else if (name == "2")
            {
                Obstacle obstacle = new Obstacle();
                obstacle.name = "○";
                static void PrintObstacle()
                {
                    Point point = new Point();
                    point.X = 3; point.Y = 1;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("○");
                    Console.ResetColor();
                }
                return obstacle as T;
            }
            else if (name == "3")
            {
                Obstacle obstacle = new Obstacle();
                obstacle.name = "○";
                static void PrintObstacle()
                {
                    Point point = new Point();
                    point.X = 5; point.Y = 1;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("○");
                    Console.ResetColor();
                }
                return obstacle as T;
            }
            else if (name == "4")
            {
                Obstacle obstacle = new Obstacle();
                obstacle.name = "○";
                static void PrintObstacle()
                {
                    Point point = new Point();
                    point.X = 7; point.Y = 1;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("○");
                    Console.ResetColor();
                }
                return obstacle as T;
            }
            else if (name == "5")
            {
                Obstacle obstacle = new Obstacle();
                obstacle.name = "○";
                static void PrintObstacle()
                {
                    Point point = new Point();
                    point.X = 9; point.Y = 1;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("○");
                    Console.ResetColor();
                }
                return obstacle as T;
            }
            else if (name == "6")
            {
                Obstacle obstacle = new Obstacle();
                obstacle.name = "○";
                static void PrintObstacle()
                {
                    Point point = new Point();
                    point.X = 11; point.Y = 1;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("○");
                    Console.ResetColor();
                }
                return obstacle as T;
            }
            else if (name == "7")
            {
                Obstacle obstacle = new Obstacle();
                obstacle.name = "○";
                static void PrintObstacle()
                {
                    Point point = new Point();
                    point.X = 13; point.Y = 1;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("○");
                    Console.ResetColor();
                }
                return obstacle as T;
            }
            else if (name == "8")
            {
                Obstacle obstacle = new Obstacle();
                obstacle.name = "○";
                static void PrintObstacle()
                {
                    Point point = new Point();
                    point.X = 15; point.Y = 1;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("○");
                    Console.ResetColor();
                }
                return obstacle as T;
            }
            else if (name == "9")
            {
                Obstacle obstacle = new Obstacle();
                obstacle.name = "○";
                static void PrintObstacle()
                {
                    Point point = new Point();
                    point.X = 17; point.Y = 1;
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("○");
                    Console.ResetColor();
                }
                return obstacle as T;
            }


            else
            {
                return null;
            }
        }
    }
}
