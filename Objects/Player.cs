using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KGA_OOPConsoleProject.Scenes;

namespace KGA_OOPConsoleProject.Objects
{
    public class Player
    {
        public Game game;
        public Scene scene;

        public ConsoleColor color;
        public Point pos;
        public char symbol;
        public bool removeWhenInteract;

        public Player(Game game)  
        {
            this.game = game; 
            this.scene = scene;
        }


    }
}
