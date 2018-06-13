using System;
using System.Collections.Generic;

namespace ChallengesTwo.Lib
{
    public class Fibonacci
    {
        List<Decimal> fibList = new List<Decimal>();


        public List<Decimal> Generator(Decimal upTo)
        {
            int a = 0, b = 1;
            //Console.WriteLine(a);
            fibList.Add(a);
            for (int i = 0; i < upTo; i++)
            {
                //Console.WriteLine(b);
                fibList.Add(b);
                int temp = a;
                a = b;
                b = b + temp;

            }
            return fibList;
        }

        public Decimal Search(Decimal number)
        {
            Decimal a = fibList.IndexOf(number);

            //Console.WriteLine(a);
            return a;
        }
    }
}
