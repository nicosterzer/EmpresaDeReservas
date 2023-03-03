using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3Final
{
    public partial class VentanaReservacion : Form
    {
        public VentanaReservacion()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int cant = Convert.ToInt32(tbCant.Text);
            List<Cliente> agregados = new List<Cliente>();
            VentanaCliente aClient;

            for (int i = 0; i < cant;)
            {
                aClient = new VentanaCliente();
                if (aClient.ShowDialog() == DialogResult.OK)
                {
                    int dni = Convert.ToInt32(aClient.tbDNI.Text);
                    string nom = aClient.tbNombre.Text;
                    string fN = aClient.tBEdad.Text;
                    Cliente c = new Cliente(dni, nom, fN);
                    agregados.Add(c);
                    listBox2.Items.Add(c);
                    i++;
                }
                aClient.Dispose();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
