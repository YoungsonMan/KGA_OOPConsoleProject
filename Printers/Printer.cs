using KGA_OOPConsoleProject.Objects;
using System.Drawing;

namespace KGA_OOPConsoleProject.Printers
{
    public class Printer
    {
        public Point playerPos;
        public Point obstaclePost;

        public Game game;
        public Map map;
        public Player Player;

        public Obstacle Obstacle;
        public ObsFactory ObsFactory;

        public Shape[] Shape;
        public Obstacle[] obstaclesH;
        public ShapeBuilder ShapeBuilder;

        private RandomSpawn randomSpawn;

        public void PrintPlayer()
        {
            randomSpawn = new RandomSpawn();
            playerPos.X = randomSpawn.RandomX(2, 17); 
            playerPos.Y = randomSpawn.RandomY(2, 13); 
            Console.SetCursorPosition(playerPos.X, playerPos.Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("P");
            Console.ResetColor();
        }
        public void printObsV()
        {
            Obstacle[] obstaclesV = new Obstacle[10];
            obstaclesV[0] = ObsFactory.Instantiate<Obstacle>("1");
            obstaclesV[1] = ObsFactory.Instantiate<Obstacle>("2");
            obstaclesV[2] = ObsFactory.Instantiate<Obstacle>("3");
            obstaclesV[3] = ObsFactory.Instantiate<Obstacle>("4");
            obstaclesV[4] = ObsFactory.Instantiate<Obstacle>("5");
            obstaclesV[5] = ObsFactory.Instantiate<Obstacle>("6");
            obstaclesV[6] = ObsFactory.Instantiate<Obstacle>("7");
            obstaclesV[7] = ObsFactory.Instantiate<Obstacle>("8");
            obstaclesV[8] = ObsFactory.Instantiate<Obstacle>("9");
        }
        public void printObsH()
        {
            obstaclesH = new Obstacle[7];
            obstaclesH[0] = ObsFactory.Instantiate<Obstacle>("11");
            obstaclesH[1] = ObsFactory.Instantiate<Obstacle>("12");
            obstaclesH[2] = ObsFactory.Instantiate<Obstacle>("13");
            obstaclesH[3] = ObsFactory.Instantiate<Obstacle>("14");
            obstaclesH[4] = ObsFactory.Instantiate<Obstacle>("15");
            obstaclesH[5] = ObsFactory.Instantiate<Obstacle>("16");
            obstaclesH[6] = ObsFactory.Instantiate<Obstacle>("17");

        }

        public void printObstacleH()
        {
            for (int i = 0; i < obstaclesH.Length; i++)
            {
                Console.SetCursorPosition(obstaclesH[i].obsPos.X, obstaclesH[i].obsPos.Y);
                Console.ForegroundColor = obstaclesH[i].color;
                Console.WriteLine(obstaclesH[i].symbol);
                obstaclesH[i].obsMovement();
            }
        }


        public void createShape()
        {
            Shape = new Shape[4];
            ShapeBuilder spadeBuilder = new ShapeBuilder();
            ShapeBuilder heartBuilder = new ShapeBuilder();
            ShapeBuilder cloverBuilder = new ShapeBuilder();
            ShapeBuilder diamondBuilder = new ShapeBuilder();
            spadeBuilder.SetNumber(1);
            heartBuilder.SetNumber(2);
            cloverBuilder.SetNumber(3);
            diamondBuilder.SetNumber(4);
            spadeBuilder.SetColor(ConsoleColor.Blue).SetSymbol('♠');
            heartBuilder.SetColor(ConsoleColor.Red).SetSymbol('♥');
            cloverBuilder.SetColor(ConsoleColor.Green).SetSymbol('♣');
            diamondBuilder.SetColor(ConsoleColor.Yellow).SetSymbol('◆');
            Shape[0] = spadeBuilder.Build();
            Shape[1] = heartBuilder.Build();
            Shape[2] = cloverBuilder.Build();
            Shape[3] = diamondBuilder.Build();
        }


        public void printShapes()
        {
            for (int i = 0; i < Shape.Length; i++)
            {
                Console.SetCursorPosition(Shape[i].pos.X, Shape[i].pos.Y);
                Console.ForegroundColor = Shape[i].color;
                Console.Write(Shape[i].symbol);
            }

        }


    }
}
