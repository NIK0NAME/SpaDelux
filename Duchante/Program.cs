using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Duchante
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Semaphore semaphor = Semaphore.OpenExisting("spa delux");
            semaphor.WaitOne();
        }
    }
}
