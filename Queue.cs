using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExampleJMC
{
    public interface Queue<E>
    {
        void Enqueue(E element);
        E Dequeue();

        E First();
        int Size();
        bool IsEmpty();
    }
}
