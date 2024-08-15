using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KGA_OOPConsoleProject.Scenes;
using KGA_OOPConsoleProject.Functions;
using System.Drawing;

namespace KGA_OOPConsoleProject.Objects
{
    public abstract class GameObject : IInteractable
    {
        public Game game;
        public Scene scene;

        public ConsoleColor color;
        public Point pos;
        public char symbol;
        public bool removeWhenInteract;

        public GameObject(Scene scene)
        {
            this.game = scene.game;
            this.scene = scene;
        }
        public abstract void Interaction(Player player);
    }
}
