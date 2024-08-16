using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KGA_OOPConsoleProject.Scenes
{
    public class Stage3 : Scene
    {
        public Stage3(Game game) : base(game)
        {

        }
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
            game.map.PrintMap();
        }
        public override void Input()
        {

        }
        public override void Update()
        {

        }
        public override void Interaction()
        {

        }
        public override void Exit()
        {

        }

    }
}
