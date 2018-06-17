using System;

namespace AssignmentOneQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void Strn()
        {
            QueueGeneric<String> q = new QueueGeneric<String>(5);
            q.RemoveItem();
            q.AddItem("hello");
            q.AddItem("wgata ");
            q.AddItem("wgat b");
            q.AddItem("wgat c");
            q.AddItem("wgatn d");

            q.Iterate();
            Console.WriteLine("-------");
            q.RemoveItem();
            q.RemoveItem();
            q.Iterate();

            Console.WriteLine("-------");
            q.AddItem("nd");
            q.AddItem("rd");
            q.AddItem("dd");
            q.Iterate();
            Console.ReadKey();
        }

        private static void Inet()
        {
            QueueGeneric<int> q = new QueueGeneric<int>(5);
            q.RemoveItem();
            q.AddItem(1);
            q.AddItem(2);
            q.AddItem(3);
            q.AddItem(4);
            q.AddItem(5);

            q.Iterate();
            Console.WriteLine("-------");
            q.RemoveItem();
            q.RemoveItem();
            q.Iterate();

            Console.WriteLine("-------");
            q.AddItem(6);
            q.AddItem(7);
            q.AddItem(8);
            q.Iterate();
            Console.ReadKey();
        }
    }
}
