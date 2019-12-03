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

namespace Chante
{
    public partial class Form1 : Form
    {
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string mensaje);
        [DllImport("user32")]
        public static extern int PostMessage(IntPtr dest, int IdMensaje, IntPtr wparam, IntPtr lparam);

        int MSG_ENTRA, MSG_COGE_TOALLA, MSG_DEJA_TOALLA, MSG_DUCHA_IN, MSG_DUCHA_OUT;

        public Semaphore semaphor;
        public Form1()
        {

            InitializeComponent();

            MSG_ENTRA = RegisterWindowMessage("MSG_ENTRA");
            MSG_COGE_TOALLA = RegisterWindowMessage("MSG_COGE_TOALLA");
            MSG_DEJA_TOALLA = RegisterWindowMessage("MSG_DEJA_TOALLA");
            MSG_DUCHA_IN = RegisterWindowMessage("MSG_DUCHA_IN");
            MSG_DUCHA_OUT = RegisterWindowMessage("MSG_DUCHA_OUT");

            semaphor = Semaphore.OpenExisting("spa delux");
            semaphor.WaitOne();
        }
    }
}
