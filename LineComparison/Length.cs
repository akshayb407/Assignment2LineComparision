using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Length
    {
        int x1 = 2, x2 = 3;
        int y1 = 1, y2 = 2;

        int x11 = 2, x12 = 3;
        int y11 = 1, y12 = 2;

        public void EqualityOfLines()
        {
            int x = (x2-x1) * (x2-x1);  
            int y = (y2-y1) * (y2-y1);
            int z = x + y;

            Console.WriteLine("Length of the Line is :" + Math.Sqrt(z));

            int u = (x11 - x12) * (x11 - x12);
            int v = (y11 - y12) * (y11 - y12);
            int w = u + v;
            Console.WriteLine("Length of the 2nd Line:" + Math.Sqrt(w));

            if (z == w)
            {
                Console.WriteLine("The Two Lines are equals");

            }
            else if (z > w)
            {
                Console.WriteLine("The Two Lines are not equal and 1st one is greater than the 2nd one");

            }
            else
            {
                Console.WriteLine("The Two Lines are not equal and 1st one is less than 2nd one");
            }
        }

    }
}
