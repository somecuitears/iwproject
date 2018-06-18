using ChallengesOne.Lib;
using System;

namespace ChallengesOne
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Handler iO = new Handler();
                iO.Execute();
                
            } while (true);
        }
    }
}
