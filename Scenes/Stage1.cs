using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class Stage1 : Scene
    {
        private bool[,] map;
        public Stage1(Game game) : base(game)
        {
            map = new bool[,]
            {
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false },
                { false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false },
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false },
                { false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false },
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false },
                { false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false },
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false },
                { false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false },
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false },
                { false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false },
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false },
                { false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false },
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false },
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
            };
        }
        private void PrintMap()
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x])
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("▒");
                    }
                }
                Console.WriteLine();
            }
        }
        private void PrintInfo()
        {

        }
        public override void Enter()
        {

        }
        public override void Render()
        {
            Console.Clear();
            PrintMap();
        }
        public override void Input()
        {

        }
        public override void Update()
        {
            game.ChangeScene(SceneType.Stage2);
        }
        public override void Interaction()
        {

        }
        public override void Exit()
        {

        }
    }
}
