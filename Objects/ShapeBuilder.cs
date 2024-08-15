﻿
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KGA_OOPConsoleProject.Printers;
using KGA_OOPConsoleProject.Scenes;

namespace KGA_OOPConsoleProject.Objects
{
    public class ShapeBuilder
    {
        public Point pos;
        public ConsoleColor color;
        public char symbol;
        public bool removeWhenInteract;

        private RandomSpawn randomSpawn;

        public ShapeBuilder()
        {
            randomSpawn = new RandomSpawn();
            this.pos.X = randomSpawn.RandomX(2, 17);
            this.pos.Y = randomSpawn.RandomY(2, 13);
            this.color = ConsoleColor.White;
            Console.SetCursorPosition(pos.X, pos.Y);
            this.symbol = '★';
            Console.ResetColor(); 
        }

        public ShapeBuilder SetColor(ConsoleColor color)
        {
            this.color = color;
            return this;
        }
        public ShapeBuilder SetSymbol(char symbol)
        {
            this.symbol = symbol;
            return this;
        }
        public Shape Build()
        {
            Shape shape = new Shape();
            shape.color = color;
            shape.symbol = symbol;
            shape.pos.X = randomSpawn.RandomX(2, 17);
            shape.pos.Y = randomSpawn.RandomY(2, 13);
            Console.WriteLine(symbol);
            return shape;
        }

    }
}
