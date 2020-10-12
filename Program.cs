using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace QueueExampleJMC
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayQueue<string> strQ =
                new ArrayQueue<string>();
            try
            {
                strQ.Enqueue("letter a");
                strQ.Enqueue("letter b");
                strQ.Enqueue("letter c");
                strQ.Enqueue("letter d");
                strQ.Enqueue("letter e");
                strQ.Enqueue("letter f");
                Console.WriteLine(strQ.First());
                Console.WriteLine(strQ.Size());
                Console.WriteLine(strQ.IsEmpty());
            }
            catch(FullQueueException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
