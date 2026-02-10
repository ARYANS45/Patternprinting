namespace Patternprinting
{
    public class Program
    {
        static void Main(string[] args)
        {
            ptrnprt();
            ptrnprt2();
            hollowtri();
            hollowtri2();

            reverseright.revpyramid();
            squarepattern.sqrptr();
            reverseleft.revpyramid();
            rhombuspattern.rhmptr();
            reversenumbertri.revnumtri();

            Console.ReadLine();
        }

        public static void ptrnprt()
        {
            Console.WriteLine("Program for pattern printing :");
            Console.WriteLine("Enter number :");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(" ");
            }
        }
        public static void ptrnprt2()
        {
            Console.WriteLine("Enter Number :");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int k = row - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    


        public static void hollowtri()
        {
            Console.WriteLine("Enter Number :");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int k = row - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (i > 2 && i < row)
                    {
                        if (j == 1 || j == i)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
             Console.WriteLine(" ");
                
            }
        }

        public static void hollowtri2()
        {
            Console.WriteLine("Enter Number :");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int k = row - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (i > 1 && i < row)
                    {
                        if (j == 1)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine(" ");
            }
        }
        
   }
}

 
