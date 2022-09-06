using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison
{
    class Class3
    {

        public static void LineEquality()
        {
            Console.WriteLine("----------Compuatation for first line----------");
            int x1, y1, x2, y2;

            Console.WriteLine("Enter x1");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y1");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x2");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y2");
            y2 = Convert.ToInt32(Console.ReadLine());

            var line1 = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

            Console.WriteLine("line1 :" + line1);

            Console.WriteLine("--------Computation for second line---------");
            int x3, y3, x4, y4;

            Console.WriteLine("Enter x3");
            x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y3");
            y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x4");
            x4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter y4");
            y4 = Convert.ToInt32(Console.ReadLine());

            var line2 = Math.Sqrt((Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2)));

            Console.WriteLine("line2 :" + line2);

            Console.WriteLine("----------Line Comparison---------------");

            if (line1 == line2)
            {
                Console.WriteLine("Both lines are Equal");
            }
            else if (line2 > line1)
            {
                Console.WriteLine("Line2 is greater than Line1");
            }
            else if (line1 > line2)
            {
                Console.WriteLine("Line1 is greater than Line2");
            }
            else
            {
                Console.WriteLine("They are not Equal");
            }
        }
    }
}
