using System;

namespace Recursion
{
    class Recursion
    {
        public static void Main()
        {
            int number = 5;
            Console.WriteLine(Factorial(number));
            Console.ReadLine();
        }

        public static int Factorial(int n)
        {
            if (n <= 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
