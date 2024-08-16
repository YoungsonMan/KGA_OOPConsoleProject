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
            info[0] =  ($"\t\t\t\t\t ┏━━━━━━━━━━주어진  문양━━━━━━━━━━━┓");
            info[1] =  ($"\t\t\t\t\t ┃                                 ┃");
            info[2] =  ($"\t\t\t\t\t ┃               {printChar}                 ┃");
            info[3] =  ($"\t\t\t\t\t ┃                                 ┃");
            info[4] =  ($"\t\t\t\t\t ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            info[5] = "";            
            info[6] =  ($"\t\t\t\t\t ┏━━━━━━━━━━플레이  방법━━━━━━━━━━━┓");
            info[7] =  ($"\t\t\t\t\t ┃                                 ┃");
            info[8] =  ($"\t\t\t\t\t ┃  [방향키]                       ┃");
            info[9] =  ($"\t\t\t\t\t ┃     ↑                           ┃");
            info[10] = ($"\t\t\t\t\t ┃   ←   →     :  이동             ┃");
            info[11] = ($"\t\t\t\t\t ┃     ↓                           ┃");
            info[12] = ($"\t\t\t\t\t ┃                                 ┃");
            info[13] = ($"\t\t\t\t\t ┃ 굴러오는 장애물을 피해          ┃");
            info[14] = ($"\t\t\t\t\t ┃ 주어진 문양을 먹고 탈출하세요   ┃");
            info[15] = ($"\t\t\t\t\t ┃                                 ┃");
            info[16] = ($"\t\t\t\t\t ┃ S = 스페이드♠    H = 하트♥      ┃");
            info[17] = ($"\t\t\t\t\t ┃ C = 클로버♣      D = 다이아◆    ┃");
            info[18] = ($"\t\t\t\t\t ┃                                 ┃");
            info[19] = ($"\t\t\t\t\t ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            info[20] = "";

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
