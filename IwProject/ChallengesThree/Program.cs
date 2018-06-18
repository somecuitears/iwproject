using ChallengesThree.Lib;
using System;

namespace ChallengesThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LIS");
            LISequence iSeq = new LISequence();
            iSeq.SetArraySize();
            iSeq.SetArrayElements();
            iSeq.DisplayResult();
        }
    }
}
