﻿using System;
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
        public Player player;


        public ConsoleColor color;
        public Point pos;
        public char symbol;
        public bool removeWhenInteract;

        public Player()  
        {
            this.game = game; 
            this.scene = scene;
        }

        public void PrintPlayer()
        {
            pos.X = 1; pos.Y = 1;
            Console.SetCursorPosition(pos.X, pos.Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("P");
            Console.ResetColor();
        }
    }
}
