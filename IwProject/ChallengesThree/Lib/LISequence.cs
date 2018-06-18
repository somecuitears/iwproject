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
            Console.WriteLine("Size of Array: ");

            bool isValid = true;
            do
            {

                isValid = int.TryParse(Console.ReadLine(), out size);
                if (isValid)
                    array = Array.CreateInstance(typeof(int), size);
                else
                    Console.WriteLine("Enter Integer Value");


            } while (!isValid);



        }

        public void SetArrayElements()
        {
            Console.WriteLine("\nEnter Elements of the Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                bool check = true;
                do
                {
                    check = int.TryParse(Console.ReadLine(), out int intValue);

                    if (check)
                        array.SetValue(intValue, i);
                    else
                        Console.WriteLine("Enter Integer values only.");
                } while (!check);

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
    }
}
