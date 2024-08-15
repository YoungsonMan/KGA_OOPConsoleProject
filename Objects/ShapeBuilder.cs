
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KGA_OOPConsoleProject.Scenes;

namespace KGA_OOPConsoleProject.Objects
{
    public class ShapeBuilder
    {
        public Point pos;
        public ConsoleColor color;
        public char symbol;
        public bool removeWhenInteract;
        
        public ShapeBuilder()
        {
            this.pos.X = 7;
            this.pos.Y = 7;
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
            shape.pos.X = 3;
            shape.pos.Y = 3;
            return shape;
        }

    }
}
