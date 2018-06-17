using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOneQueue
{
    class Queue
    {
        private int length; //How many holding.
        private int sizeOfQueue;      //Size of Queue
        private int first;   //Beginning of queue
        private int last;    //Enging of queue;
        private String[] _queue;

        public Queue()
        {
            this.sizeOfQueue = 10;
            _queue = new String[sizeOfQueue];
        }

        public Queue(int size)
        {
            sizeOfQueue = size;
            first = 0;
            length = 0;
            //last = sizeOfQueue - 1;
            last = -1;
            _queue = new String[sizeOfQueue];
        }

        public void AddItem(String item)
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

        public String RemoveItem()
        {

            if (IsEmpty(this))
            {
                Console.WriteLine("Queue Empty");
                //return _queue[first++];
                return String.Empty;
            }
            else
            {

                String data = _queue[first];
                for(int i = first; i < last; i++)
                {
                    _queue[i] = _queue[i + 1];
                }
                //first++; 
                length--;
                last--;
                return data;
            }
            //first++;
            //if(first == sizeOfQueue)
            //{
            //    first = 0;
            //}
        }

        public void Iterate()
        {
            for (int i = first; i <= last; i++)
            {
                if (_queue[i] != null)
                    Console.WriteLine(_queue[i]);
            }
        }

        public bool IsEmpty(Queue queue)
        {
            if (queue.length == 0)
                return true;
            else
                return false;
        }

        public bool IsFull(Queue queue)
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
