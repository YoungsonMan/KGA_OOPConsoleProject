using KGA_OOPConsoleProject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class Information : Scene
    {
        public Player player;
        
        public Information(Game game) : base(game)
        {

        }
        private void PrintInfo()
        {
           
        }
        public override void Enter()
        {

        }
        public void infoOut()
        {
            int printNumber = game.player.shapeNumber;
            char printChar = ' ';
            if (printNumber == 1)
            {
                printChar = '♠';
            }
            else if (printNumber == 2)
            {
                printChar = '♥';
            }
            else if (printNumber == 3)
            {
                printChar = '♣';
            }
            else
            {
                printChar = '◆';
            }

            string[] info = new string[22];
            info[0] = ($"┏━━━━━━━━━━주어진  문양━━━━━━━━━━━┓");
            info[1] = ($"┃                                 ┃");
            info[2] = ($"┃               {printChar}               ┃");
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
            info[14] = ($"┃ 굴러오는 장애물을 피해          ┃");
            info[15] = ($"┃ 주어진 문양을 먹고 탈출하세요   ┃");
            info[16] = ($"┃                                 ┃");
            info[17] = ($"┃ S = 스페이드♠    H = 하트♥      ┃");
            info[18] = ($"┃ C = 클로버♣      D = 다이아◆    ┃");
            info[19] = ($"┃                                 ┃");
            info[20] = ($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            info[21] = "";

            foreach (string str in info)
            {
                Console.WriteLine(str);
            }
        }
        public override void Render()
        {

            Console.Clear();
            Console.WriteLine($"┏━━━━━━━━━━━━━━━━━━━━━━게임 소개━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃                                                     ┃");
            Console.WriteLine($"┃  본 게임은 로스트아크 군단장레이드 쿠크세이튼       ┃");
            Console.WriteLine($"┃  2관문 기믹중 하나인 카드미로를 모방한 게임 입니다. ┃");
            Console.WriteLine($"┃                                                     ┃"); 
            Console.WriteLine($"┃  방향키를 이용하여 플레이어를 움직이며              ┃");
            Console.WriteLine($"┃  다가오는 장애물을 피한후                           ┃");
            Console.WriteLine($"┃  주어진 문양을 3번 먹은후 나오는 탈출구를 찾아      ┃");
            Console.WriteLine($"┃  문양: ♠ ♥ ♣ ◆   탈출구: G                          ┃");
            Console.WriteLine($"┃  들어가 탈출을 하면 됩니다.                         ┃");
            Console.WriteLine($"┃                                                     ┃"); 
            Console.WriteLine($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
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
