using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Patternprinting
{
    public class reverseleft
    {
        public static void revpyramid()
        {
            Console.WriteLine("Program for Reverse left Half Pyramid");

            Console.WriteLine("Enter Number:");
            int n = Convert.ToInt32(Console.ReadLine());
                
            for(int i=n ;i>=1 ;i--)
            {
                for(int k=0 ; k < n-i ; k++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
