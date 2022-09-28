using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public static class Comparison
    {
        public static void ComparingLength()
        {
            Console.WriteLine("enter the co-ordinates");
            Console.Write("x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("a1: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("b1: ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("a2: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("b2: ");
            int b2 = Convert.ToInt32(Console.ReadLine());
            double Length1 = 0;
            double Length2 = 0;
            Console.WriteLine("first line points= " + (x1, y1) + "," + (x2, y2));
            Console.WriteLine("Second line points= " + (a1, b1) + "," + (a2, b2));

            Length1 = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Length2 = Math.Sqrt((Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2)));
            Console.WriteLine("Length of first line is " + Length1);
            Console.WriteLine("Length of second line is " + Length2);
            //UC2
            Console.WriteLine(Length1.Equals(Length2));
            //UC3
            int LineLength = Length1.CompareTo(Length2);
            if (LineLength == 0)
            {
                Console.WriteLine("Length of the two lines are equal");
            }
            else if (LineLength > 0)
            {
                Console.WriteLine("Length of line1 is " + Length1 + " is greater than  " + Length2 + " length of line2");
            }
            else
            {
                Console.WriteLine("Length of line1 " + Length1 + " is lesser than  " + Length2 + " length of line2");
            }


        }
    }
}
