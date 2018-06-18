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

        public bool InfOption { get; set; }

        public QueueGeneric()
        {
            this.sizeOfQueue = 10;
            last = -1;
            InfOption = false;
            _queue = new T[sizeOfQueue];
        }

        public QueueGeneric(int size)
        {
            sizeOfQueue = size;
            first = 0;
            length = 0;
            last = -1;
            InfOption = false;
            _queue = new T[sizeOfQueue];
        }

        public void AddItemF(T item)
        {
            if (IsFull(this))
            {
                Console.WriteLine("======== Queue Full ========\n");
                return;
            }
            else
            {
                last++;
                _queue[last] = item;
                length++;
            }
        }

        public void AddItem(T item)
        {
            if (IsFull(this))
            {
                IncreaseQueueSize();
            }

                last++;
                _queue[last] = item;
                length++;
            
        }

        private void IncreaseQueueSize()
        {
            sizeOfQueue= sizeOfQueue + 1;
            T[] _newQueue = new T[sizeOfQueue];
            _queue.CopyTo(_newQueue, 0);

            _queue = _newQueue;
        }

        public T RemoveItem()
        {

            if (IsEmpty(this))
            {
                Console.WriteLine("======== Queue Empty ========\n");
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
                Console.Write("======== Removed : " + data + " ========\n");
                return data;
            }
        }

        public void Iterate()
        {
            Console.WriteLine("\n======== Queue Data Begin ========\n");
            for (int i = first; i <= last; i++)
            {
                if (_queue[i] != null)
                    Console.WriteLine(_queue[i]);
            }
            Console.WriteLine("\n======== Queue Data End ========\n\n");
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
