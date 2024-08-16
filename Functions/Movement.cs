using KGA_OOPConsoleProject.Objects;
using KGA_OOPConsoleProject.Printers;
using System.Drawing;


namespace KGA_OOPConsoleProject.Functions
{
    public class Movement
    {
        public Point playerPos;
        public Point obstaclePost;
        public ConsoleKey input;


        public Game game;

        public Player player;
        public Printer printer;
        public Obstacle obstacle;
        public ObsFactory obsFactory;

        public Movement(Game game)
        {
            this.game = game;
        }
        public void Moves(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    if (game.map.map[game.player.playerPos.Y - 1, game.player.playerPos.X])
                        game.player.playerPos = new Point(game.player.playerPos.X, game.player.playerPos.Y - 1);
                    break;
                case ConsoleKey.DownArrow:
                    if (game.map.map[game.player.playerPos.Y + 1, game.player.playerPos.X])
                        game.player.playerPos = new Point(game.player.playerPos.X, game.player.playerPos.Y + 1);
                    break;
                case ConsoleKey.LeftArrow:
                    if (game.map.map[game.player.playerPos.Y, game.player.playerPos.X - 1])
                        game.player.playerPos = new Point(game.player.playerPos.X - 1, game.player.playerPos.Y);
                    break;
                case ConsoleKey.RightArrow:
                    if (game.map.map[game.player.playerPos.Y, game.player.playerPos.X + 1])
                        game.player.playerPos = new Point(game.player.playerPos.X + 1, game.player.playerPos.Y);
                    break;
            }
        }

        // 장애물 움직임
        /*
         * 어떤키를 입력받든 ---> 오른쪽으로 이동
        public void ObsMovesH(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    // if (game.map.map[game.obsFactory.Obstacle.pos.Y - 1, game.obsFactory.Obstacle.pos.X])
                    game.obsFactory.Obstacle.obsPos = new Point(game.obsFactory.Obstacle.obsPos.X + 1, game.obsFactory.Obstacle.obsPos.Y);
                    break;
                case ConsoleKey.DownArrow:
                    //if (game.map.map[game.obsFactory.Obstacle.pos.Y + 1, game.obsFactory.Obstacle.pos.X])
                    game.obsFactory.Obstacle.obsPos = new Point(game.obsFactory.Obstacle.obsPos.X + 1, game.obsFactory.Obstacle.obsPos.Y);
                    break;
                case ConsoleKey.LeftArrow:
                    //if (game.map.map[game.obsFactory.Obstacle.pos.Y, game.obsFactory.Obstacle.pos.X - 1])
                    game.obsFactory.Obstacle.obsPos = new Point(game.obsFactory.Obstacle.obsPos.X + 1, game.obsFactory.Obstacle.obsPos.Y);
                    break;
                case ConsoleKey.RightArrow:
                    //if (game.map.map[game.obsFactory.Obstacle.pos.Y, game.obsFactory.Obstacle.pos.X + 1])
                    game.obsFactory.Obstacle.obsPos = new Point(game.obsFactory.Obstacle.obsPos.X + 1, game.obsFactory.Obstacle.obsPos.Y);
                    break;
            }
        }
        */
    }
}
