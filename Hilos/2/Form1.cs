using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Pelotita_Con_Threads.Pelotita pelota = new Pelotita_Con_Threads.Pelotita(this.pictureBox1);
            Thread nuevo_hilo = new Thread(pelota.DoWork);
            nuevo_hilo.Start();
            
        }
    }
}
