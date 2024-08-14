using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class Stage2 : Scene
    {
        public Stage2(Game game) : base(game)
        {

        }

        public override void Enter()
        {
            Console.Clear();
            game.map.PrintMap();
        }
        public override void Render()
        {

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
