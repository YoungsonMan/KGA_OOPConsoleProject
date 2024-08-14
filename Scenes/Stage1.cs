using KGA_OOPConsoleProject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class Stage1 : Scene
    {

        public Stage1(Game game) : base(game)
        {
           
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
