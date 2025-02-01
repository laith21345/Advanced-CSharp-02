using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Q7
{
    internal class Queue
    {
        private object[] array;
        private int head;
        private int tail;
        private int capacity;

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (capacity < 0)
                    capacity = 0;
                else
                    capacity = value;
            }
        }


        public Queue(int capacity)
        {
            this.Capacity = capacity;
            array = new object[capacity];

            tail = head = capacity - 1;
        }

        public void Enqueue(object? obj)
        {
            if (tail < 0)
            {
                Console.WriteLine("the queue is full");
            }
            else
            {
                array[tail--] = obj;
            }
        }
    }
}
