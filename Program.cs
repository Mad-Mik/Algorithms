using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Константный(1)
            int x = 10;
            if (x > 10)
            {
                x--;
                Console.WriteLine(x);
            }
            else
            {
                x++;
                Console.WriteLine(x);
                Console.ReadLine();
            }
        }
    }
}
