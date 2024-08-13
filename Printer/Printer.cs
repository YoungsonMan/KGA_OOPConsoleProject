using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Printer
{
    public class Printer
    {
        Map map = new Map(18, 15);
        public Printer() 
        {
            
        }
        public void PrintMap()
        {
            for (int y = 0; y < 15; y++)
            {
                for (int x = 0; x < 18; x++)
                {
                    if (y.Equals(true) && x.Equals(true))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.WriteLine("▒");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
