using KGA_OOPConsoleProject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Printers
{
    public class Printer
    {
       
        public Obstacle Obstacle;
        public ObsFactory ObsFactory;

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
            Obstacle[] obstaclesH = new Obstacle[10];
            obstaclesH[0] = ObsFactory.Instantiate<Obstacle>("11");
            obstaclesH[1] = ObsFactory.Instantiate<Obstacle>("12");
            obstaclesH[2] = ObsFactory.Instantiate<Obstacle>("13");
            obstaclesH[3] = ObsFactory.Instantiate<Obstacle>("14");
            obstaclesH[4] = ObsFactory.Instantiate<Obstacle>("15");
            obstaclesH[5] = ObsFactory.Instantiate<Obstacle>("16");
            obstaclesH[6] = ObsFactory.Instantiate<Obstacle>("17");
            obstaclesH[7] = ObsFactory.Instantiate<Obstacle>("18");
        }

    }
}
