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
        private Point playerPos;
       // public Information info;
        public Stage1(Game game) : base(game)
        {
            playerPos = new Point(1, 1);
        }
    //    private void PrintMap()    맵을 따로 빼서 렌더에 넣었기 떄문에 필요 없을거 같다.
    //    {
    //
    //    }
        private void PrintInfo()
        {
            info.infoOut();
        }
        public override void Enter()
        {

        }
        public override void Render()
        {

            Console.Clear();
            //info.infoOut();
            game.map.PrintMap();
            game.obstacle.PrintObstacle();
            game.printer.printObsH();
            game.printer.createShape();
            //playerPos = new Point(1,1);
            game.player.PrintPlayer();
            game.printer.PrintPlayer();
            
        }
        public override void Input()
        {
            ConsoleKey input = Console.ReadKey().Key;
        }
        public override void Update()
        {
            game.movement.Moves();
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
