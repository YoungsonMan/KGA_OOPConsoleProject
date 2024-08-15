using KGA_OOPConsoleProject.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace KGA_OOPConsoleProject.Functions
{
    public class Interaction
    {
        public Player player;
        private Point playerPos;

        public Game game;
        


        public List<GameObject> gameObjects;
        public Interaction()
        {


            
        }
        public void Interacts()
        {
            foreach(GameObject gameObject in gameObjects)
            {
                if (playerPos.X == gameObject.pos.X && playerPos.Y == gameObject.pos.Y)
                {
                    gameObject.Interaction(game.player);
                    if (gameObject.removeWhenInteract)
                    {
                        gameObjects.Remove(gameObject);
                    }
                    return;
                }
            }
        }
    }
}
