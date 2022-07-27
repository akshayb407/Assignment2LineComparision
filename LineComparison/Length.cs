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

        public void length()
        {
            int x = (x2-x1) * (x2-x1);  
            int y = (y2-y1) * (y2-y1);
            int z = x + y;

            Console.WriteLine("Length of the Line is :" + Math.Sqrt(z));
        }

    }
}
