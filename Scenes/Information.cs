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
            string[] info = new string[20];
            info[0] = ($"┏━━━━━━━━━━주어진  문양━━━━━━━━━━━┓");
            info[1] = ($"┃                                 ┃");
            info[2] = ($"┃                ♥                ┃");
            info[3] = ($"┃                                 ┃");
            info[4] = ($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            info[5] = "";
            info[6] = "";
            info[7] = ($"┏━━━━━━━━━━플레이  방법━━━━━━━━━━━┓");
            info[8] = ($"┃                                 ┃");
            info[9] = ($"┃  [방향키]                       ┃");
            info[10] = ($"┃     ↑                           ┃");
            info[11] = ($"┃   ←   →     :  이동             ┃");
            info[12] = ($"┃     ↓                           ┃");
            info[13] = ($"┃                                 ┃");
            info[14] = ($"┃ 굴러오는 방해물을 피해          ┃");
            info[15] = ($"┃ 주어진 문양을 먹고 탈출하세요   ┃");
            info[16] = ($"┃                                 ┃");
            info[17] = ($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            info[18] = "";

            foreach (string str in info)
            {
                Console.WriteLine(str);
            }

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
