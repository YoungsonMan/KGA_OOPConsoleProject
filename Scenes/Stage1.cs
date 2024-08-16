using KGA_OOPConsoleProject.Functions;
using KGA_OOPConsoleProject.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class Stage1 : Scene
    {
        public Point playerPos;
        // public Information info;
        private ConsoleKey input;
        public Stage1(Game game) : base(game)
        {
            playerPos = new Point();
        }

        private void PrintInfo()
        {
            game.info.infoOut();
        }
        public override void Enter()
        {

        }
        public override void Render()
        {

            Console.Clear();
            game.map.PrintMap();

            game.obstacle.PrintObstacle();
            game.printer.printObsH();

            game.printer.createShape();
            game.player.PrintPlayer();
            PrintInfo();

        }
        public override void Input()
        {
            input = Console.ReadKey().Key;
        }
        public override void Update()
        {
            game.movement.Moves(input);
           // game.ChangeScene(SceneType.Stage2);
        }
        public override void Interaction()
        {

        }
        public override void Exit()
        {

        }
    }
}
