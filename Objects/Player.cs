using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KGA_OOPConsoleProject.Functions;
using KGA_OOPConsoleProject.Scenes;

namespace KGA_OOPConsoleProject.Objects
{
    public class Player
    {
        public Game game;
        public Scene scene;
        public Player player;
        public Map map;
        public Movement movement;

        public ConsoleColor color;
        public Point playerPos;
        public char symbol;
        public bool removeWhenInteract;

        public Player()  
        {
            this.game = game; 
            this.scene = scene;
            this.map = map;
            this.movement = movement;
        }

        public void PrintPlayer()
        {
            playerPos.X = 1; playerPos.Y = 1;
            Console.SetCursorPosition(playerPos.X, playerPos.Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("P");
            Console.ResetColor();
        }
    }
}
