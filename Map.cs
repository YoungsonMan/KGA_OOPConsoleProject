using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Map()
    {

        public bool[,] map = new bool[,]
        {      //  0      1      2      3      4      5      6       7     8       9     10     11     12     13     14     15    16      17     18
 /*  1 */     { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, 
 /*  2 */     { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false },
 /*  3 */     { false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false },
 /*  4 */     { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false },
 /*  5 */     { false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false },
 /*  6 */     { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false },
 /*  7 */     { false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false },
 /*  8 */     { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false },
 /*  9 */     { false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false },
 /* 10 */     { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false },
 /* 11 */     { false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false },
 /* 12 */     { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false },
 /* 13 */     { false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false,  true, false },
 /* 14 */     { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false },
 /* 15 */     { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
         };
        public void PrintMap()
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y,x])
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("▒");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
