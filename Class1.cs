using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Class1
    {
        //Логарифмический (logN)
        public static int Rank(int key, int[] numbers)
        {
            int low = 0;
            int high = numbers.Length - 1;
            while (low <= high)
            {                
                int mid = low + (high - low) / 2;
                
                if (key < numbers[mid]) high = mid - 1;
                else if (key > numbers[mid]) low = mid + 1;
                else return mid;
            }
            return -1;
        }
    }
}
