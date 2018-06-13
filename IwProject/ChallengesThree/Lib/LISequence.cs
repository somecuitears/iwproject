using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengesThree.Lib
{
    public class LISequence
    {
        Array array;
        public void SetArraySize()
        {
            int.TryParse(Console.ReadLine(), out int value);
            array = Array.CreateInstance(typeof(int), value);
        }

        public void SetArrayElements()
        {
            for (int i = 0; i < array.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out int intValue);
                array.SetValue(intValue, i);
            }
        }

        public void DisplayResult()
        {
            int counter = 0, temp = 0;
            foreach (int item in array)
            {
                if (temp < item)
                {
                    counter++;
                    temp = item;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}
