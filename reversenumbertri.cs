using System;
using System.Collections.Generic;
using System.Text;

namespace Patternprinting
{
    internal class reversenumbertri
    {
        public static void revnumtri()
        {
            Console.WriteLine("Program for Reverse number triangle pattern");

            Console.WriteLine("Enter Number: ");
            int row = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=row;i++)
            {
                for(int k=1;k<i;k++)
                {
                    Console.Write(" ");
                }
                for(int j=i; j<=row;j++)
                {
                    Console.Write(" "+j);
                }
                Console.WriteLine(" ");
            }
        }
    }
}