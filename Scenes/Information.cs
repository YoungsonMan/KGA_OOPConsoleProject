using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class Information : Scene
    {
        public Information(Game game) : base(game)
        {

        }
        public override void Enter()
        {

        }
        public override void Render()
        {
            Console.Clear();
            Console.WriteLine($"┏━━━━━━━━━━주어진  문양━━━━━━━━━━━┓");
            Console.WriteLine($"┃                                 ┃");
            Console.WriteLine($"┃                ♥                ┃");
            Console.WriteLine($"┃                                 ┃");
            Console.WriteLine($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"┏━━━━━━━━━━플레이  방법━━━━━━━━━━━┓");
            Console.WriteLine($"┃                                 ┃"); 
            Console.WriteLine($"┃  [방향키]                       ┃");
            Console.WriteLine($"┃     ↑                           ┃");
            Console.WriteLine($"┃   ←   →     :  이동             ┃");
            Console.WriteLine($"┃     ↓                           ┃");
            Console.WriteLine($"┃                                 ┃");
            Console.WriteLine($"┃ 굴러오는 방해물을 피해          ┃");
            Console.WriteLine($"┃ 주어진 문양을 먹고 탈출하세요   ┃");
            Console.WriteLine($"┃                                 ┃"); 
            Console.WriteLine($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.WriteLine();
        }
        public override void Input()
        {
            Console.ReadKey();
        }
        public override void Update()
        {
            game.ChangeScene(SceneType.Stage1);
        }
        public override void Interaction()
        {

        }
        public override void Exit()
        {

        }

    }
}
