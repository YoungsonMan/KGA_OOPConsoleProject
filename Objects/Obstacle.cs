using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KGA_OOPConsoleProject.Scenes;

namespace KGA_OOPConsoleProject.Objects
{
    public class Obstacle : IInteractable
    {
        public Game game;
        public Scene scene;
        public Obstacle obstacle;

        public ConsoleColor color;
        public Point pos;
        public char symbol;
        public bool removeWhenInteract;

        public string name;

        public Obstacle() 
        {
        }
        // 장애물을 대량생산 하려고하는데 밑에 Obstacle(Game game)
        // CS7036: 'Obstacle.Obstacle(Game)의 필수 매개변수 'game'에 해당하는 인수가 없습니다.
        // IDE0090: 'new'식을 단순화 할 수 있습니다. 에러 떠서 전구 표시에서 누르다가 위에처럼 생성되고
        // 일단 빨간밑줄 없어지고 돌아가긴해서 내비둠.

        public Obstacle(Game game)
        {
            this.game = game;
            this.scene = scene;
        }
        public void PrintObstacle()
        {
            pos.X = 3; pos.Y = 3;
            Console.SetCursorPosition(pos.X, pos.Y);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("○");
            Console.ResetColor();
        }
        public void Interaction(Player player)
        {
            game.Reset(this);
        }

        
    }
}
