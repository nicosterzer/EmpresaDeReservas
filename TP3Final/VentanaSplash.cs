using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3Final
{
    public partial class VentanaSplash : Form
    {
        string[] info = new string[3];
        public VentanaSplash(int segundos)
        {
            InitializeComponent();
            timer1.Interval = segundos * 1000;
            timer1.Start();
            timer2.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 25)
            {
                progressBar1.Value += 5;
                label4.Text = "Abriendo base de datos...";
            }
            else if (progressBar1.Value < 50)
            {
                progressBar1.Value += 5;
                label4.Text = "Consultando Propiedades...";
            }
            else if (progressBar1.Value < 75)
            {
                progressBar1.Value += 5;
                label4.Text = "Configurando Sistema...";
            }
            else if (progressBar1.Value < 100)
            {
                progressBar1.Value += 5;
                label4.Text = "Recuperando Datos...";
            }
            else if (progressBar1.Value == 100)
            {
                timer2.Stop();
            }
        }

        private void VentanaSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
