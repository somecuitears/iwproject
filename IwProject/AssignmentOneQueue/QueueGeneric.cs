using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOneQueue
{
    class QueueGeneric<T>
    {

        private int length; //How many holding.
        private int sizeOfQueue;      //Size of Queue
        private int first;   //Beginning of queue
        private int last;    //Enging of queue;
        private T[] _queue;

        public QueueGeneric()
        {
            this.sizeOfQueue = 10;
            _queue = new T[sizeOfQueue];
        }

        public QueueGeneric(int size)
        {
            sizeOfQueue = size;
            first = 0;
            length = 0;
            last = -1;
            _queue = new T[sizeOfQueue];
        }

        public void AddItem(T item)
        {
            if (IsFull(this))
            {
                Console.WriteLine("Queue Full");
                return;
            }
            else
            {
                last++;
                _queue[last] = item;
                length++;
            }
        }

        public T RemoveItem()
        {

            if (IsEmpty(this))
            {
                Console.WriteLine("Queue Empty");
                return default(T);
            }
            else
            {

                T data = _queue[first];
                for (int i = first; i < last; i++)
                {
                    _queue[i] = _queue[i + 1];
                }
                length--;
                last--;
                Console.Write("Removed." + data);
                return data;
            }
        }

        public void Iterate()
        {
            for (int i = first; i <= last; i++)
            {
                if (_queue[i] != null)
                    Console.WriteLine(_queue[i]);
            }
        }

        public bool IsEmpty(QueueGeneric<T> queue)
        {
            if (queue.length == 0)
                return true;
            else
                return false;
        }

        public bool IsFull(QueueGeneric<T> queue)
        {
            if (queue.length == queue.sizeOfQueue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
