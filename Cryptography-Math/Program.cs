using System;
using System.Numerics;

namespace Cryptography_Math
{
    class Program
    {
        public static void factor(string yn)
        {
            Console.WriteLine("enter a number");
            BigInteger respond = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("calculating...");
            for (BigInteger i = 1; i < respond + 1; i++)
            {
                if (respond % i == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
            Console.WriteLine("wanna continue? type (Y) yes or (N) no");
            yn = Console.ReadLine();

            if (yn.ToLower() == "y")
            {
                factor(yn);
            }

            else if (yn.ToLower() == "n")
            {
                Console.WriteLine("Ok thanks for using the factor machine! See you next time!");
            }

            else
            {
                Console.WriteLine("That is not a valid answer please try again");
            
                yn = Console.ReadLine();

                if (yn.ToLower() == "y")
                {
                    factor(yn);
                }

                else if (yn.ToLower() == "n")
                {
                    Console.WriteLine("Ok thanks for using the factor machine! See you next time!");
                }

                else
                {
                    Console.WriteLine("That is not a valid answer please try again");

                    yn = Console.ReadLine();

                    if (yn.ToLower() == "y")
                    {
                        factor(yn);
                    }

                    else if (yn.ToLower() == "n")
                    {
                        Console.WriteLine("Ok thanks for using the factor machine! See you next time!");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            string yn = "";

            factor(yn);
            
        }
    }
}
