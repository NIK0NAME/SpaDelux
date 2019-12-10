using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Chante
{
    public partial class Form1 : Form
    {
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string mensaje);
        [DllImport("user32")]
        public static extern int PostMessage(IntPtr dest, int IdMensaje, IntPtr wparam, IntPtr lparam);

        int MSG_ENTRA, MSG_COGE_TOALLA, MSG_DEJA_TOALLA, MSG_DUCHA_IN, MSG_DUCHA_OUT;

        int timeo = 0;

        public Semaphore semaphor;
        public Mutex mutexUsuario;
        public Form1()
        {

            InitializeComponent();

            /*  Registramos los mensajes*/
            MSG_ENTRA = RegisterWindowMessage("MSG_ENTRA");
            MSG_COGE_TOALLA = RegisterWindowMessage("MSG_COGE_TOALLA");
            MSG_DEJA_TOALLA = RegisterWindowMessage("MSG_DEJA_TOALLA");
            MSG_DUCHA_IN = RegisterWindowMessage("MSG_DUCHA_IN");
            MSG_DUCHA_OUT = RegisterWindowMessage("MSG_DUCHA_OUT");

            

            /*  Inicializamos el mutex y el semaforo*/
            semaphor = Semaphore.OpenExisting("spa delux");
            mutexUsuario = Mutex.OpenExisting("mutex spa");

            /*  Obtenemos la ventana para lanzar el mensaje*/
            IntPtr h = Process.GetProcessesByName("UnSpaDelux")[0].MainWindowHandle;

            /*  Mandamos mensaje Entra en el spa un usuario*/
            PostMessage(h, MSG_ENTRA, IntPtr.Zero, IntPtr.Zero);

            /*  Espera a que este vacio el proceso para coger una toalla*/
            semaphor.WaitOne();

            /*  Mandamos mensaje Usuario coge toalla*/
            PostMessage(h, MSG_COGE_TOALLA, IntPtr.Zero, IntPtr.Zero);

            /*  Entra en la ducha y la bloquea*/
            mutexUsuario.WaitOne();

            /*  Mandamos mensaje Usuario entra ducha*/
            PostMessage(h, MSG_DUCHA_IN, IntPtr.Zero, IntPtr.Zero);

            /*  Una vez el usuario entra en la ducha el tiempo que esta dentro*/

            /*  Momento en el que entramos*/
            int actual = DateTime.Now.Millisecond;
            int quiere = new Random(actual).Next(1000, 4500);
            do
            {
                timeo++;
                Console.Write("Tro lo lo lololo lolo trolololo");
            } while (timeo % 45000 != 0/*(DateTime.Now.Millisecond - actual) < 1500*/);

            Console.Clear();
            Console.WriteLine("Fin de ducha");

            /*  Liberamos la ducha*/
            mutexUsuario.ReleaseMutex();

            /*  Mandamos mensaje Usuario sale ducha*/
            PostMessage(h, MSG_DUCHA_OUT, IntPtr.Zero, IntPtr.Zero);

            /*  Dejamos la toalla libre*/
            semaphor.Release();

            /*  Mandamos mensaje Usuario deja la toalla*/
            PostMessage(h, MSG_DEJA_TOALLA, IntPtr.Zero, IntPtr.Zero);

            //Console.ReadLine();
            Dispose();
        }
    }
}
