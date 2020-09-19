using System;

namespace Factorial
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int startingNumber = 6;
            Console.Out.WriteLine(Factorial(startingNumber));
            Console.ReadLine();
        }

        public static int Factorial(int x)
        {
            Console.Out.WriteLine("x is {0}", x);
            if(x == 1)
            {
                return 1;
            } else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}
