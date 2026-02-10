using System;
using System.Collections.Generic;
using System.Text;

namespace Patternprinting
{
    internal class rhombuspattern
    {
        public static void rhmptr()
        {
            Console.WriteLine("Program for rhombus pattern");

            Console.WriteLine("Enter Number :");
            int row = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i<=row; i++)
            {
                for(int k=0; k<i;k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <=row; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");  
                   
            }
            
        }
    }
}
