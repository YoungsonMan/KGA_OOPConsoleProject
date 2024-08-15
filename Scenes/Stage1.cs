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
        private Point playerPos;

        public Stage1(Game game) : base(game)
        {
            playerPos = new Point(1, 1);
        }
        private void PrintMap()
        {

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
            game.map.PrintMap();
            game.obstacle.PrintObstacle();
            game.printer.printObsH();
            //playerPos = new Point(1,1);
            game.player.PrintPlayer();
            
        }
        public override void Input()
        {

        }
        public override void Update()
        {
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
