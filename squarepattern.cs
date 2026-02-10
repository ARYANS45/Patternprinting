using System;
using System.Collections.Generic;
using System.Text;

namespace Patternprinting
{
    public class squarepattern
    {
         public static void sqrptr()
        {
            Console.WriteLine("Program for Square Fill Pattern");

            Console.WriteLine("Enter number :");
            int row = Convert.ToInt32(Console.ReadLine());
            for(int i =1;i<=row;i++)
            {
                for(int j=1; j<=row;j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
