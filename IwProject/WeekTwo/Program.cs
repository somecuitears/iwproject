using System;
using System.Collections;

namespace WeekTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SortedList sortedList = new SortedList();
            sortedList.Add("01", "val1");
            sortedList.Add("02", "val2");
            Console.WriteLine(sortedList.GetKey(1).GetHashCode());
            Console.WriteLine(sortedList.GetKey(0).GetHashCode());
       

           
            Console.ReadKey();
            Console.ReadKey();
        }

        private static void HashTableDemo()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("1", "hello");
            hashtable.Add("2", "hello a");
            hashtable.Add("3", "hello b");
            hashtable.Add(4, "hello c");

            if (hashtable.ContainsKey(4))
            {
                Console.WriteLine("Yooo");
            }

            Console.WriteLine(hashtable.Count);
            hashtable.Remove(4);
            Console.WriteLine(hashtable.Count);
        }

        public static void ArrayListDemo()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add("string");
            arrayList.Add(4);
            arrayList.Add(5.4F);
            arrayList.Add("new String");

            Console.WriteLine("========");
            foreach (var k in arrayList)
            {
                Console.WriteLine(k);
                Console.WriteLine(k.GetType());
            }
            Console.WriteLine("========");
            Console.WriteLine("========");
            Console.WriteLine(arrayList.Capacity);
            Console.WriteLine(arrayList.Count);
            Console.WriteLine(arrayList.IsFixedSize);
            Console.WriteLine(arrayList.IsReadOnly);
            Console.WriteLine(arrayList.IsSynchronized);
            Console.WriteLine(arrayList.SyncRoot);
            Console.WriteLine("========");
            Console.WriteLine("========");
            Console.WriteLine("========");
            Console.WriteLine();
            arrayList.Remove("string");
            Console.WriteLine(arrayList.Capacity);
            Console.WriteLine(arrayList.Count);
            Console.WriteLine("========");
            Console.WriteLine("========");
            Console.WriteLine("========");
            Console.WriteLine("========");
            arrayList.TrimToSize();
            Console.WriteLine(arrayList.Capacity);
            Console.WriteLine(arrayList.Count);
            Console.WriteLine("========");
            Console.WriteLine("========");
            Console.WriteLine("========");
            Console.WriteLine("========");
            Console.WriteLine("========");
            foreach (var k in arrayList)
            {
                Console.WriteLine(k);
                Console.WriteLine(k.GetType());
            }

        }
    }
}
