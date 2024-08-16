using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Printers
{
    public class RandomSpawn
    {
        // 플레이어 & 문양 생성할때 벽에 안만들어지게 필요한 랜덤좌표 생성기
        public RandomSpawn() 
        {

        }
        public int RandomX(int min, int max)
        {
            int randNum1;
            Random rand = new Random();
            randNum1 = rand.Next(min, max);
            // 짝수에 벽이 있으니 홀수는 피하기
            while (randNum1 % 2 != 0)
            {
                randNum1 = rand.Next(min, max);
            }
            return randNum1;
        }
        public int RandomY(int min, int max)
        {
            int randNum2;
            Random rand = new Random();
            randNum2 = rand.Next(min, max);
            // 짝수에 벽이 있으니 홀수는 피하기
            while (randNum2 % 2 == 0)
            {
                randNum2 = rand.Next(min, max);
            }
            return randNum2;
        }

    //    public int randomShape() 
    //    {// 1-Spade, 2-Heart, 3-Clover, 4-Diamond
    //        Random rand = new Random();
    //        rand.Next(1, 4);
    //        return rand.Next();
    //    }

    }
}
