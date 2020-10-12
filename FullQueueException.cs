using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExampleJMC
{
    public class FullQueueException : Exception
    {
        public FullQueueException(string msg) : base(msg)
        {
            
        }
    }
}
