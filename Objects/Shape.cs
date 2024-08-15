using KGA_OOPConsoleProject.Scenes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KGA_OOPConsoleProject.Scenes;

namespace KGA_OOPConsoleProject.Objects
{
    public class Shape
    {
        public Game game;
        public Scene scene;
        public Player player;

        public Point pos;
        public ConsoleColor color;
        public char symbol;
        public bool removeWhenInteract;

        public Shape()
        {

        }

        public void PrintShape()
        {
            pos.X = 1; pos.Y = 1;
            Console.SetCursorPosition(pos.X, pos.Y);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
