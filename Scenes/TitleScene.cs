﻿namespace KGA_OOPConsoleProject.Scenes
{
    public class TitleScene : Scene
    {
        public TitleScene(Game game) : base(game)
        {

        }


        public override void Enter()
        {




        }
        public override void Render()
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

        }
        public override void Input()
        {
            Console.WriteLine("   계속하려면 아무키나 누르세요    ");
            Console.ReadKey();
        }
        public override void Update()
        {
            game.ChangeScene(SceneType.Information);
        }
        public override void Interaction()
        {

        }
        public override void Exit()
        {

        }

    }
}
