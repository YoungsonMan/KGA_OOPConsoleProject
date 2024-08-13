using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class TitleScene : Scene
    {
        public TitleScene(Launcher launcher) : base(launcher) 
        {
        
        }

        public override void Start()
        {
            Console.Clear();
            Console.WriteLine($"┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓"); 
            Console.WriteLine($"┃ ♠ ♥ ♣ ◆ ♠ ♥ ♣ ◆ ♠ ♥ ♣ ◆ ♠ ♥ ♣ ◆ ┃");
            Console.WriteLine($"┃                                 ┃");
            Console.WriteLine($"┃      로스트아크 쿠크세이튼      ┃"); 
            Console.WriteLine($"┃           2관문 미로            ┃");
            Console.WriteLine($"┃                                 ┃");
            Console.WriteLine($"┃ ◆ ♣ ♥ ♠ ◆ ♣ ♥ ♠ ◆ ♣ ♥ ♠ ◆ ♣ ♥ ♠ ┃");
            Console.WriteLine($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.WriteLine();
            Console.WriteLine("    계속하려면 아무키나 누르세요    ");
            Console.ReadKey();

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
        public override void End()
        {

        }

    }
}
