using System;
using System.Collections.Generic;
using System.Text;

namespace Patternprinting
{
    internal class reverseright
    {
        public static void revpyramid()
        {
            Console.WriteLine("Program for Reverse Right Half Pyramid");
            Console.WriteLine("Enter Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i= 1;i<=n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
