using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Limpieza
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean result;
            /*  Creamos el mutex de limpieza*/
            Mutex mutexLimpieza;
            int timeo = 1;
            do
            {
                mutexLimpieza = new Mutex(false, "mutexDuchante", out result);
                mutexLimpieza.Dispose();
            } while (!result);

            mutexLimpieza = new Mutex(false, "mutexLimpieza", out result);
            mutexLimpieza.WaitOne();

            DateTime actual = DateTime.Now;
            while(timeo % 15000 != 0)
            {
                timeo++;
                Console.WriteLine("Limpiando");
            }

            mutexLimpieza.ReleaseMutex();
            mutexLimpieza.Dispose();
        }
    }
}
