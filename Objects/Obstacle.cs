using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KGA_OOPConsoleProject.Scenes;

namespace KGA_OOPConsoleProject.Objects
{
    public abstract class Obstacle
    {
        public Game game;
        public Scene scene;

        public ConsoleColor color;
        public Point pos;

        public char symbol;

        public Obstacle(Game game)
        {
            this.game = game;
            this.scene = scene;
        }
    }
}
