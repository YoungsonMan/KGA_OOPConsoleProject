using KGA_OOPConsoleProject.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using KGA_OOPConsoleProject.Objects;


namespace KGA_OOPConsoleProject.Functions
{
    public class Interaction
    {
        public Player player;
        private Point playerPos;

        public Game game;
        public Obstacle obstacle;
        public ObsFactory obsFactory;

        public List<Obstacle> obstacles;
        public Interaction(Game game)
        {
            this.game = game;
            
        }
        public void Interacts()
        {
            foreach(Obstacle obstacle in obstacles)
            {
                if (game.player.playerPos.X == game.obstacle.obsPos.X && game.player.playerPos.Y == game.obstacle.obsPos.Y)
                {
                   // game.Reset();
                }
            }
        }
    }
}
