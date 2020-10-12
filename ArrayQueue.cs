using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExampleJMC
{
    public class ArrayQueue<E> : Queue<E>
    {
        private E[] element;
        private int front = 0;
        private int size = 0;

        public ArrayQueue() : this(5)
        {

        }

        public ArrayQueue(int capacity)
        {
            element = new E[capacity];
        }

        public E Dequeue()
        {
            if(IsEmpty())
            {
                return default;
            }

            E temp = element[front];
            element[front] = default;
            front = (front + 1) % element.Length;
            size--;
            return temp;
        }

        public void Enqueue(E element)
        {
            if(size == this.element.Length)
            {
                throw new FullQueueException("Queue is full.");
            }

            int avail = (front + size) % this.element.Length;
            this.element[avail] = element;
            size++;
        }

        public E First()
        {
            if(IsEmpty())
            {
                return default;
            }
            return element[front];
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int Size()
        {
            return size;
        }
    }
}
