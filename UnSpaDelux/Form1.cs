using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace UnSpaDelux
{
    public partial class Form1 : Form
    {
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string mensaje);
        [DllImport("user32")]
        public static extern int PostMessage(IntPtr dest, int IdMensaje, IntPtr wparam, IntPtr lparam);

        //Mensajes para el sitema
        int MSG_ENTRA, MSG_COGE_TOALLA, MSG_DEJA_TOALLA, MSG_DUCHA_IN, MSG_DUCHA_OUT;

        public int usersNum;
        public Semaphore semaphor;
        public Mutex mutexUsuario;
        public Form1()
        {
            InitializeComponent();

            MSG_ENTRA = RegisterWindowMessage("MSG_ENTRA");
            MSG_COGE_TOALLA = RegisterWindowMessage("MSG_COGE_TOALLA");
            MSG_DEJA_TOALLA = RegisterWindowMessage("MSG_DEJA_TOALLA");
            MSG_DUCHA_IN = RegisterWindowMessage("MSG_DUCHA_IN");
            MSG_DUCHA_OUT = RegisterWindowMessage("MSG_DUCHA_OUT");

            listaToallas.Items.Add("Toalla");
            listaToallas.Items.Add("Toalla");
            listaToallas.Items.Add("Toalla");
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == MSG_ENTRA)
            {
                usersNum++;
                txtUsuarios.Text = usersNum.ToString();
                /*textBox1.Lines = log.ToArray();
                txtCuantos.Text = (int.Parse(txtCuantos.Text) - 1).ToString();*/
            }
            else if (m.Msg == MSG_COGE_TOALLA)
            {
                listaToallas.Items.RemoveAt(0);
            }
            else if(m.Msg == MSG_DEJA_TOALLA)
            {
                listaToallas.Items.Add("Toalla");
            }
            else if (m.Msg == MSG_DUCHA_IN)
            {
                checkOcupado.Checked = true;
            }
            else if (m.Msg == MSG_DUCHA_OUT)
            {
                usersNum--;
                txtUsuarios.Text = usersNum.ToString();
                checkOcupado.Checked = false;
            }
            else base.WndProc(ref m);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            semaphor = new Semaphore(3, 3, "spa delux");

            mutexUsuario = new Mutex(false, "mutex spa");


        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "..\\..\\..\\Chante\\bin\\Debug\\Chante.exe";
            //p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
        }
    }
}
