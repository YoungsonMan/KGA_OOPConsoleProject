using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using KGA_OOPConsoleProject.Functions;
using KGA_OOPConsoleProject.Scenes;
using KGA_OOPConsoleProject.Printers;

namespace KGA_OOPConsoleProject.Objects
{
    public class Player
    {
        public Game game;
        public Scene scene;
        public Player player;
        public Map map;
        public Movement movement;
        public Obstacle obstacle;
        public Shape shape;
        public Random random;

        public ConsoleColor color;
        public Point playerPos;
        public char symbol;
        public bool removeWhenInteract;
        public int shapeNumber;
        public Player()  
        {
         //   this.game = game; 
         //   this.scene = scene;
         //   this.map = map;
         //   this.movement = movement;
         //   this.symbol = new char();
            random = new Random();
            this.shapeNumber = random.Next(1,4);
            if (shapeNumber == 1)
            {
                symbol = 'S';
            }
            else if (shapeNumber == 2)
            {
                symbol = 'H';
            }
            else if(shapeNumber == 3)
            {
                symbol = 'C';
            }
            else
            {
                symbol = 'D';
            }
            playerPos.X = 9; playerPos.Y = 7;
        }

        public void PrintPlayer()
        {
            
            Console.SetCursorPosition(playerPos.X, playerPos.Y);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{symbol}");
            Console.ResetColor();
            Console.SetCursorPosition(1, 1);
        }

    }
}
