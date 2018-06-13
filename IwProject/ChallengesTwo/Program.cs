using ChallengesTwo.Lib;
using System;
using System.Collections.Generic;

namespace ChallengesTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // OldImplementation();
            BetterImplementation();
        }

        private static void BetterImplementation()
        {
            Fibonacci fb = new Fibonacci();
            do
            {
                fb.FastFinder(Decimal.Parse(Console.ReadLine()));
            } while (true);
        }

        private static void OldImplementation()
        {
            Fibonacci fb = new Fibonacci();
            List<Decimal> myList = fb.Generator(100);
            Decimal index = fb.Search(Decimal.Parse(Console.ReadLine()));
            if (index == -1)
            {
                Console.WriteLine("IsNotFibo");
            }
            else
            {
                String vall = "IsFibo ";
                for (int i = (int)index - 1; i >= index - 2; i--)
                {
                    vall += myList[i] + ",";
                }
                Console.WriteLine(vall.Substring(0, vall.Length - 1));
            }
            Console.ReadKey();
        }
    }
}
