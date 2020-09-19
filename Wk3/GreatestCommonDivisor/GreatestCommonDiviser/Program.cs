using System;

namespace GreatestCommonDivisor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number1 = 800;
            int number2 = 85;
            int answer = gcd(number1, number2);
            Console.Out.WriteLine("The gcd of {0} and {1} is {2}", number1, number2, answer);
            Console.ReadLine();
        }

        public static int gcd(int n1, int n2)
        {
            if(n2 == 0)
            {
                return n1;
            } else
            {
                Console.Out.WriteLine("Not yet. Remainder is {0}", n1 % n2);
                return gcd(n2, n1 % n2);
            }
        }
    }
}
