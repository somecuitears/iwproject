using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengesThree.Lib
{
    public class LISequence
    {
        Array array;
        int size;
        public void SetArraySize()
        {
            int.TryParse(Console.ReadLine(), out size);
            array = Array.CreateInstance(typeof(int), size);
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
            int counter = 1, temp = 0;
            Array trackingArray = Array.CreateInstance(typeof(int), size);
            for (int i = 0; i < array.Length; i++)
            {
                int remaining = array.Length - i;
                if (counter > remaining)
                    break;
                counter = 1;
                temp = (int)array.GetValue(i);
                for (int j = i + 1; j < array.Length; j++)
                {
                    int temp2 = (int)array.GetValue(j);
                    if (temp <= temp2)
                    {
                        counter++;
                        temp = (int)array.GetValue(j);
                    }
                }
                trackingArray.SetValue(counter, i);
            }
            Console.WriteLine();
            Array.Sort(trackingArray);
            int last = array.Length - 1;
            Console.WriteLine(trackingArray.GetValue(last));
            Console.ReadKey();
        }

        //From Internet...
        public void DisplayResultFixed()
        {
            int[] lis = new int[size];
            int i, j, max = 0;
            int[] arr = (int[])array;
            for (i = 0; i < size; i++)
                lis[i] = 1;

            for (i = 1; i < size; i++)
                for (j = 0; j < i; j++)
                    if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                        lis[i] = lis[j] + 1;

            for (i = 0; i < size; i++)
                if (max < lis[i])
                    max = lis[i];
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
