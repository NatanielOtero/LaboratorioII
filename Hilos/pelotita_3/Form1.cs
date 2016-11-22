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

namespace pelotita_3
{
    public partial class Form1 : Form
    {
        List<Thread> _miHilo;
        public Form1()
        {
            InitializeComponent();
            this._miHilo = new List<Thread>();
            this.button1.Click += new EventHandler(this.PausarPelota);
            this.btnDestruir.Click += new EventHandler(this.destroy);
            this.btnReanudar.Click += new EventHandler(this.reanudar);

        }
        public void PausarPelota(object sender, EventArgs e)
        {
            try
            {
                this._miHilo[this._miHilo.Count - 1].Suspend();
            }
            catch (Exception)
            {
                
                MessageBox.Show("mañana tenemos parcial de estadistica");
            }
            //MessageBox.Show("mañana tenemos parcial de estadistica");
        }
        public void destroy(object sender, EventArgs e)
        {
            try
            {
                this._miHilo[this._miHilo.Count - 1].Abort();
                this._miHilo.RemoveAt(this._miHilo.Count - 1);

                Graphics g = this.pictureBox1.CreateGraphics();
                g.Clear(this.pictureBox1.BackColor);
            }
            catch (Exception ex)
            {

                MessageBox.Show("error");
            } 
        }
        private void reanudar(object sender, EventArgs e)
        {
            try
            {
                this._miHilo[this._miHilo.Count - 1].Resume();
                Graphics g = this.pictureBox1.CreateGraphics();
                g.Clear(this.pictureBox1.BackColor);
            }
            catch (Exception)
            {

               
            }
        }
        private void btnCrearPelotita_Click(object sender, EventArgs e)
        {
            Pelotita_Con_Threads.Pelotita pelota = new Pelotita_Con_Threads.Pelotita(this.pictureBox1);

            Thread hilo = new Thread(pelota.DoWork);
            hilo.Start();
            this._miHilo.Add(hilo);
            
            //this.btnCrearPelotita.Click -= new System.EventHandler(this.btnCrearPelotita_Click);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDestruir_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReanudar_Click(object sender, EventArgs e)
        {

        }

       
    }
}
